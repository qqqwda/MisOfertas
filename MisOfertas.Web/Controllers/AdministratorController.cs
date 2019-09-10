using MisOfertas.Web.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MisOfertas.Web.Controllers
{
    [AuthorizeAdmin]
    public class AdministratorController : Controller
    {


        public AdministratorController()
        {
            
        }
        // GET: Administrator
        public ActionResult Index()
        {
            return View();
        }
    }
}