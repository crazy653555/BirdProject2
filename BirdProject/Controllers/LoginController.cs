using BirdProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BirdProject.Controllers
{
    public class LoginController : Controller
    {
        BirdEntities db = new BirdEntities();


        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel data)
        {
            if (ModelState.IsValid)
            {
                if (CheckLogin(data.Email,data.Password))
                {
                    FormsAuthentication.RedirectFromLoginPage(data.Email, false);
                    return RedirectToAction("Index","Bird");

                }

            }

            return View(data);
        }

        private bool CheckLogin(string Email, string password)
        {
            B鳥奴 dUser = db.B鳥奴.Where(x => x.Email == Email).FirstOrDefault();
            if (dUser.Password.Equals(password))
            {
                return true;
            }
            ModelState.AddModelError("", "帳號或密碼錯誤");
            return false;
        }

        public ActionResult Registered()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registered(RegisteredViewModel data)
        {

            if (ModelState.IsValid)
            {
                if (db.B鳥奴.Where(x => x.Email == data.Email).Any())
                {
                    ModelState.AddModelError("", "此帳號已被註冊");
                    return View(data);
                }

                B鳥奴 bUser = new B鳥奴()
                {
                    Email = data.Email,
                    UserName = data.UserName,
                    Password = data.Password,
                    Tel = data.Tel
                };

                db.B鳥奴.Add(bUser);
                db.SaveChanges();
                return RedirectToAction("Index", "Bird");
            }

            return View(data);

        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Bird");
        }
    }
}