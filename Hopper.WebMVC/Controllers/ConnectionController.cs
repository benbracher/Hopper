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
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new ConnectionService(userId);
            //var model = service.GetConnectionById();

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create(ConnectionDetailsItem model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var rideService = CreateRideService();
            var transportService = CreateTransportService();

            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new RideService(userId);

            

            return RedirectToAction("Index");
        }

        private ConnectionService CreateConnectionService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new ConnectionService(userId);
            return service;
        }

        private RideService CreateRideService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new RideService(userId);
            return service;
        }

        private TransportService CreateTransportService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new TransportService(userId);
            return service;
        }
    }
}