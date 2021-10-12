using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Client.Services.UI
{
    public class GlobalClicksCatcher
    {
        public EventHandler<MouseEventArgs> OnGlobalMouseClick { get; set; } = (m,e) => { };

        public EventHandler<KeyboardEventArgs> OnKeyClick { get; set; } = (m, e) => { };

        public void DropHandlers()
        {
            OnGlobalMouseClick = (m, e) => { };
            OnKeyClick = (m, e) => { };
        }
    }
}
