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
                TempData["SaveResult"] = "Your transport was created.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Transport could not be created");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = CreateTransportService();
            var model = svc.GetTransportById(id);

            return View(model);
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateTransportService();
            var model = svc.GetTransportById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateTransportService();

            service.DeleteTransport(id);

            TempData["SaveResult"] = "Your transport was deleted";

            return RedirectToAction("Index");
        }

        private TransportService CreateTransportService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new TransportService(userId);
            return service;
        }
    }
}