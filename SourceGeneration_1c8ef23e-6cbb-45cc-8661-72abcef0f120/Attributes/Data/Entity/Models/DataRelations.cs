namespace SourceGeneration.Attributes.Data.Entity.Models
{
    public enum RelationType
    {
        OneToMany,
        OneToOne,
        ManyToMany
    }
    public class DataRelation
    {
        public Entity RelatingEntity;
        public Entity To;
        public RelationType RelationType;
        public Member NavigationPropertyOfRelating;
        public Member NavigationPropertyOfRelated;
        public string ForeignKeyProperty;
    }
}