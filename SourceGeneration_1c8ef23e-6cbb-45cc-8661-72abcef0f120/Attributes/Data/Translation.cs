using System;
using System.Collections.Generic;
using System.Text;

namespace SourceGeneration.Attributes.Data
{
    public class Translation
    {
        const string _noTranslationFor = "!!!No translation!!!";

        public const string LanguagesFolder = "SourceGeneration_1c8ef23e-6cbb-45cc-8661-72abcef0f120/Attributes/Data/Languages";
        private string _currentLanguage;
        public static readonly string[] SupportedLanguages = { "RU, ENG" };

        public Func<string, string> GetFunction() => s => Translate(s);

        public void SelectLanguage(string language)
        {
            _currentLanguage = language;
            if (!Languages.ContainsKey(language))
            {
                Languages.Add(language, new Dictionary<string, Dictionary<string, string>>());
            }
        }
        public void LoadLanguages(Dictionary<string, Dictionary<string, Dictionary<string, string>>> languages)
        {
            Languages = languages;
        }

        private string _currentContext;
        public Dictionary<string, Dictionary<string, Dictionary<string, string>>> Languages { get; private set; } = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();
        private Dictionary<string, Dictionary<string, string>> Translations 
        { get 
            {
                if (!Languages.ContainsKey(_currentLanguage))
                {
                    Languages.Add(_currentLanguage, new Dictionary<string, Dictionary<string, string>>());
                }
                return Languages[_currentLanguage]; 
            } 
        }
        public void SetContext(string context)
        {
            _currentContext = context;
            if (!Translations.ContainsKey(context))
            {
                Translations.Add(context, new Dictionary<string, string>());
            }
        }

        public string Translate(string phrase)
        {
            if (_currentContext == null)
            {
                throw new Exception("Context not set.");
            }

            if (!Translations.ContainsKey(_currentContext))
            {
                SetContext(_currentContext);
                //throw new InvalidOperationException($"Context {_currentContext} not added to translation in language {_currentLanguage}.");
            }

            if (!Translations[_currentContext].ContainsKey(phrase))
            {
                var result = phrase;
                Translations[_currentContext].Add(phrase, result);
                return result;
            }
            return Translations[_currentContext][phrase];
        }
    }
}
