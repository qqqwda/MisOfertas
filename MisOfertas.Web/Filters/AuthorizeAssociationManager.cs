﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MisOfertas.Web.Filters
{
    public class AuthorizeAssociationManager : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["IdUser"].ToString() != "2")
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary
                {
                    {"Controller", "Home"},
                    {"Action","Index" }

                });
            }
            base.OnActionExecuting(filterContext);
        }
    }
}