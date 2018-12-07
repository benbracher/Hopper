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
    [Authorize]
    public class RideController : Controller
    {
        // GET: Ride
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new RideService(userId);
            var model = service.GetRide();

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RideCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new RideService(userId);

            service.CreateRide(model);

            return RedirectToAction("Index");
        }
    }
}