using MisOfertas.Web.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MisOfertas.Web.Controllers
{
    [AuthorizeConsumer]
    public class ConsumerController : Controller
    {
        // GET: Consumer
        public ActionResult Index()
        {
            return View();
        }
    }
}