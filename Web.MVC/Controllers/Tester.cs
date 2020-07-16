using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.MVC.Controllers
{
    public class Tester : Controller
    {
        // GET: Tester
        public ActionResult Index()
        {
            return View();
        }

        // GET: Tester/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tester/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tester/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Tester/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tester/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Tester/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tester/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
