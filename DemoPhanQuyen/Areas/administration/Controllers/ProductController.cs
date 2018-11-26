using DemoPhanQuyen.Areas.administration.Help;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoPhanQuyen.Areas.administration.Controllers
{
    [AuthorizeController]
    public class ProductController : Controller
    {
        // GET: administration/Product
        public ActionResult Index()
        {
            return View();
        }

        // GET: administration/Product/Details/5
        public ActionResult Details()
        {
            return View();
        }

        // GET: administration/Product/Create
        public ActionResult Create()
        {
            return View();
        }

       
    }
}
