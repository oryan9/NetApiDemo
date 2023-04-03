using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _annoumcementService;

        public AnnouncementController(IAnnouncementService annoumcementService)
        {
            _annoumcementService = annoumcementService;
        }

        public IActionResult Index()
        {
            var values = _annoumcementService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(Announcement announcement)
        {
            announcement.Date = DateTime.Parse(DateTime.Now.ToShortTimeString());
            announcement.Status = false;
            _annoumcementService.Insert(announcement);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAnnouncement(int id)
        {
            var values = _annoumcementService.GetById(id);
            _annoumcementService.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditAnnouncement(int id)
        {
            var values = _annoumcementService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditAnnoumcement(Announcement annoumcement)
        {
            _annoumcementService.Update(annoumcement);
            return RedirectToAction("Index");
        }
    }
}
