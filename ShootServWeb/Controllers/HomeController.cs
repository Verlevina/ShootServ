﻿using System.Web.Mvc;
using BO;
using ShootingCompetitionsRequests.App_Start;

namespace ShootServ.Controllers
{
    public class HomeController : BaseController
    {     
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message">сообщение, которое будет выводиться при загрузге Index страницы</param>
        /// <returns></returns>
        public ActionResult Index(string message = "")
        {
            if (!string.IsNullOrEmpty(message))
            {
                ViewBag.Message = message;
            }

            return View();
        }

        public ActionResult GetUserInfo()
        {
            var user = new UserParams();
            if (CurrentUser != null)
            {
                user = CurrentUser;
            }

            return PartialView("UserInfo", user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Страница описания приложения.";
            return View();
        }

        [CustomAuthorize]
        public ActionResult Logout()
        {
            Session.Abandon();

            return Redirect(Url.Action("Login", "Account"));
        }
    }
}
