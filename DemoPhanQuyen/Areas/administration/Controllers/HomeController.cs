using DemoPhanQuyen.Areas.administration.Help;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoPhanQuyen.Areas.administration.Controllers
{
    public class HomeController : Controller
    {
        // GET: administration/Home
        public ActionResult Index()
        {
            List<Type> lstControlller = ReflectionController.GetControllers("DemoPhanQuyen.Areas.administration.Controllers");

            string htmlLstAction = "<ul>";
            foreach (Type x in lstControlller)
            {
                htmlLstAction += "<li><lable><input type='checkbox' id='All_"+ x.Name + "' value='"+x.Name+"' /> " + x.Name + "<lable><ul>";
                foreach (string y in ReflectionController.GetActions(x))
                {
                    htmlLstAction += "<li><lable><input type='checkbox' class='"+x.Name+"' value='" + y + "' />" + y + "</lable></li>";

                }
                htmlLstAction += "</ul></li>";

            }
            htmlLstAction += "</ul>";
            ViewBag.menu = htmlLstAction;
            return View();
        }

        // GET: administration/Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: administration/Home/Create

        public ActionResult Create()
        {
            return View();
        }

        // POST: administration/Home/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: administration/Home/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: administration/Home/Edit/5
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

        // GET: administration/Home/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: administration/Home/Delete/5
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

        public ActionResult Notification()
        {
            return View();
        }
    }
}
