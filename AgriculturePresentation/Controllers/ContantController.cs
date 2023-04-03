using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ContantController : Controller
    {
        public readonly IContantService _contantService;

        public ContantController(IContantService contantService)
        {
            _contantService = contantService;
        }

        public IActionResult Index()
        {
            var values = _contantService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddContant()
        {
            return View();
        }

        [HttpPost]

        public IActionResult AddContant(Contant contant)
        {
            _contantService.Insert(contant);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteContant(int id)
        {
            var values = _contantService.GetById(id);
            _contantService.Delete(values);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult EditContant(int id)
        {
            var values = _contantService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditContant(Contant contant)
        {
            _contantService.Update(contant);
            return RedirectToAction("Index");
        }
    }
}
