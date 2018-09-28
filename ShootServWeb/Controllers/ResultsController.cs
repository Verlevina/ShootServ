﻿using System.Web.Mvc;
using BL;

namespace ShootServ.Controllers
{
    public class ResultsController : Controller
    {
        private readonly ResultLogic _resultsLogic;

        public ResultsController()
        {
            _resultsLogic = new ResultLogic();
        }
        
        public ActionResult Index()
        {
            return View();
        }
    }
}
