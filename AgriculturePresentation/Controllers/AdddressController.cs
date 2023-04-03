﻿using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class AdddressController : Controller
    {
        private readonly IAddressService _addressService;

        public AdddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public IActionResult Index()
        {
            var values = _addressService.GetListAll();
            return View(values);
        }

        [HttpGet]

        public IActionResult AddAddress()
        {
            return View();
        }

        [HttpPost]

        public IActionResult AddAddress(Address address)
        {
            _addressService.Insert(address);
            return RedirectToAction("Index");
        }

        [HttpDelete]
        public IActionResult DeleteAddress(int id)
        {
            var values = _addressService.GetById(id);
            _addressService.Delete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditAddress(int id)
        {
            var values = _addressService.GetById(id);
            return View(values);
        }

        [HttpPost]

        public IActionResult EditAddress(Address address)
        {
            _addressService.Update(address);
            return RedirectToAction("Index");
        }







    }
}
