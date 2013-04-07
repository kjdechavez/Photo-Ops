using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcPhotoOps.Models;
using MvcPhotoOps.Models.ViewModel;

namespace MvcPhotoOps.Controllers
{
    public class EventController : Controller
    {
        //
        // GET: /Event/

        public ActionResult Index()
        {
            // Add all static value on collection
            List<Event> events = new List<Event> { new Event { EventId=1, Date=DateTime.Now, Name="Event name 1" },
                                                   new Event { EventId=2, Date=DateTime.Now, Name="Event name 2" }};

            // Assign to ViewModel
            EventIndexViewModel viewModel = new EventIndexViewModel(events);
            

            return View(viewModel);
        }

    }
}
