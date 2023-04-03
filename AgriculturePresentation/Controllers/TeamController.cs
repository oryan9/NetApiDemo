using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AgriculturePresentation.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }


        public IActionResult Index()
        {
            var values = _teamService.GetListAll();
            return View(values);
        }


        [HttpGet]
        public IActionResult AddTeam()
        {
            return View();
        }

        //Insert

        [HttpPost]
        public IActionResult AddTeam(Team team)
        {
            TeamValidatör validationRules = new TeamValidatör();
            ValidationResult result = validationRules.Validate(team);

            if (result.IsValid)
            {
                _teamService.Insert(team);
                return RedirectToAction("Index");
                 
            }

            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }
            return View();

        }

        //delete
        public IActionResult DeleteTeam(int id)
        {
            var values = _teamService.GetById(id);
            _teamService.Delete(values);
            return RedirectToAction("Index");
        }


        //update
        [HttpGet]
        public IActionResult EditTeam(int id)
        {
            var values = _teamService.GetById(id);
            return View(values);
        }


        [HttpPost]

        public IActionResult EditTeam(Team team)
        {
            TeamValidatör validationRules = new TeamValidatör();
            ValidationResult result = validationRules.Validate(team);

            if (result.IsValid)
            {
                _teamService.Update(team);
                return RedirectToAction("Index");

            }

            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }
            return View();
        }
    }
}
