using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPhotoOps.Models.ViewModels
{
    public class EventIndexViewModel
    {

        #region Fields

        private List<Event> _events;
            
        #endregion

        public EventIndexViewModel(List<Event> events)
        {
            _events = events;
        }

        public List<Event> Events
        {
            get { return _events; }
            set { _events = value; }
        }

    }
}
