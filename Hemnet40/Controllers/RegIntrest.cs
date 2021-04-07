using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hemnet40.Controllers
{
    public class RegIntrest : Controller
    {
        // GET: RegIntrest
        public ActionResult Index()
        {
            return View();
        }

        // GET: RegIntrest/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RegIntrest/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegIntrest/Create
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

        // GET: RegIntrest/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegIntrest/Edit/5
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

        // GET: RegIntrest/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegIntrest/Delete/5
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
