using MisOfertas.CapaDatos;
using MisOfertas.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MisOfertas.Web.Controllers
{
    
    public class UserController : Controller
    {
        public UserController()
        {
           
        }

        public ActionResult Index()
        {
            var context = LocalDataContext.GetInstance();
            return View(context.Users.ToList());
        }
        // GET: User
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {

            if (ModelState.IsValid)
            {
                LocalDataContext.GetInstance().Users.Add(user);
                LocalDataContext.GetInstance().SaveChanges();

                ModelState.Clear();

                ViewBag.Message = user.Email + " Registered";
            }
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            var context = LocalDataContext.GetInstance();
            var userHelper = context.Users.Single(u=> u.Email == user.Email && u.Password == user.Password);
            if (userHelper != null)
            {
                Session["IdUser"] = userHelper.IdUser.ToString();
                Session["Email"] = userHelper.Email.ToString();
                return RedirectToAction("LoggedIn");
            }
            else
            {
                ModelState.AddModelError("","Username or password are incorrect");
            }

            return View();
        }


        public ActionResult LoggedIn()
        {
            if (Session["IdUser"] != null)
            {
                return View();

            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        
    }
}