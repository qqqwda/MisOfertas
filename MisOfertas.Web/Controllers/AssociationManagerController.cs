using MisOfertas.Web.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MisOfertas.Web.Controllers
{
    [AuthorizeAssociationManager]
    public class AssociationManagerController : Controller
    {
        // GET: AssociationManager
        public ActionResult Index()
        {
            return View();
        }
    }
}