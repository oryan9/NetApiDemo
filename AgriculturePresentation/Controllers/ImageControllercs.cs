using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ImageControllercs : Controller
    {
        private readonly IImageService _ımageService;

        public ImageControllercs(IImageService ımageService)
        {
            _ımageService = ımageService;
        }

        public IActionResult Index()
        {
            var values = _ımageService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddImage()
        {
            return View();
        }


        [HttpPost]

        public IActionResult AddImage(Image ımage)
        {
            _ımageService.Insert(ımage);
            return RedirectToAction("Index");
        }

        [HttpDelete]
        public IActionResult DeleteImage(int id)
        {
            var values = _ımageService.GetById(id);
            _ımageService.Delete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult EditImage(int id)
        {
            var values = _ımageService.GetById(id);
            return View(values);

        }

        [HttpPost]

        public IActionResult EditImage(Image ımage)
        {
            _ımageService.Update(ımage);
            return RedirectToAction("Index");
        }
    }
}
