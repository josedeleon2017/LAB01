using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using LAB0_0.Helpers;
using LAB0_0.Models;


namespace LAB0_0.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View(Storage.Instance.personList);
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var person = new PersonModel
                {
                    Name = collection["Name"],
                    LastName = collection["LastName"],
                    Phone = int.Parse(collection["Phone"]),
                    Description = collection["Description"],
                };

                if (person.Save())
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(person);
                }
       
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
