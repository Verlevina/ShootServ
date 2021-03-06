﻿using System.Web.Mvc;
using BO;
using ShootingCompetitionsRequests.Models;
using ShootServ.Models.Registration;

namespace ShootServ.Controllers
{
    public class RegistrationController : BaseController
    {
        private readonly RegPageModelParams _modelLogic;

        public RegistrationController()
        {
            _modelLogic = new RegPageModelParams();
        }

        public ActionResult Index(int idUser = -1)
        {
            var model = new RegPageModelParams();

            if (idUser == -1)
            {
                model.IsEditMode = false;
                model.RolesList = StandartClassifierModelLogic.GetRolesList();

                var queryCountries = StandartClassifierModelLogic.GetCountryList();
                if (queryCountries.Result.IsOk)
                {
                    model.CountriesList = queryCountries.Data;
                    model.SexList = StandartClassifierModelLogic.GetSexList();
                    model.WeaponTypes = StandartClassifierModelLogic.GetWeaponTypeList();
                    model.Categories = _modelLogic.GetCategoies();
                }
                else model.Error = new ErrorModelParams(queryCountries.Result);
            }
            else 
            {
                if (CurrentUser != null && CurrentUser.Id == idUser)
                {
                    model = RegPageModelParams.GetModelByExistUser(idUser);
                }
                else 
                {
                    return Redirect(Url.Action("Login", "Home", new { Area = ""} ));
                }
            }

            return View("Index", model);
        }

        [HttpGet]
        public ActionResult AddUser(RegPageModelParams model)
        {
            var res = _modelLogic.AddUser(model);

            if (res.Result.IsOk)
            {
                // Регистрация прошла успешно, сразу пишем юзера в сессию
                var user = _modelLogic.GetUser(res.Data);
                if (user != null)
                {
                    Session["user"] = user;
                }
            }

            return new JsonResult { Data = new { IsOk = res.Result.IsOk, Message = res.Result.ErrorMessage }, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        /// <summary>
        /// Получить список стрелковых клубов по региону
        /// </summary>
        /// <param name="idRegion">ид. региона</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetShootingClubsByRegion(int idRegion)
        {
            var clubs = _modelLogic.GetShooterClubsByRegion(-1, idRegion); /// TODO: Здесь временный костыль с -1
            var model = new DropDownListModel
            {
                Name = "IdClub",
                Items = clubs
            };
            return PartialView("DropDownListModel", model);
        }

        [HttpGet]
        public ActionResult UpdateUser(int idExistingUser, bool needUpdatePassword, RegPageModelParams model)
        {
            var res = new ResultInfo { IsOk = false };
            if (((UserParams)Session["user"]).Id == idExistingUser)
            {
                res = _modelLogic.UpdateUser(idExistingUser, model, needUpdatePassword);
            }

            if (res.IsOk)
            {
                var updatingUser = _modelLogic.GetUser(idExistingUser);
                Session["user"] = updatingUser;
            }

            return new JsonResult { Data = new { IsOk = res.IsOk, Message = res.ErrorMessage }, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

    }
}
