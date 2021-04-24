using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer.Concrete;

namespace MvcProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager c = new CategoryManager();
        public ActionResult Index()
        {

            return View(c.ListAllBl()) ;
        }
    }
}