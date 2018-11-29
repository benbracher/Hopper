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
    public class TransportController : Controller
    {
        // GET: Transport
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new TransportService(userId);
            var model = service.GetTransports();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransportCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateTransportService();

            if (service.CreateTransport(model))
            {
                return RedirectToAction("Index");
            }

            return View(model);
        }

        private TransportService CreateTransportService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new TransportService(userId);
            return service;
        }
    }
}