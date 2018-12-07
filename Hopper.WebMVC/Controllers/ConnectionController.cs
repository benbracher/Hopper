using Hopper.Models;
using Hopper.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hopper.WebMVC.Controllers
{
    public class ConnectionController : Controller
    {
        // GET: Connection
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(ConnectionDetailsItem model)
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new RideService(userId);

        }
    }
}