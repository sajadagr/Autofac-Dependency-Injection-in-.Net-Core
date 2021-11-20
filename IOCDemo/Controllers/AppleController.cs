using Business;
using DataAccess;
using DataAccess.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOCDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppleController : Controller
    {
        IAppleService _appleService;
        public AppleController(IAppleService appleService)
        {
            _appleService = appleService;
        }

        //
        // GET: /Customer/
        [HttpGet]
        public IEnumerable<Apple> Index()
        {
            IEnumerable<Apple> model = (IEnumerable<Apple>)_appleService.GetAll();
            return model;
        }

        //[HttpPost]
        //public ActionResult Insert(Apple obj)
        //{
        //    _appleRepo.Insert(obj);
        //    _appleRepo.Save();
        //    return View();
        //}

        //[HttpPut]
        //public ActionResult Edit(string id)
        //{
        //    Apple existing = _appleRepo.SelectByID(id);
        //    return View(existing);
        //}


        //public ActionResult ConfirmDelete(string id)
        //{
        //    Apple existing = _appleRepo.SelectByID(id);
        //    return View(existing);
        //}

        //public ActionResult Delete(string id)
        //{
        //    _appleRepo.Delete(id);
        //    _appleRepo.Save();
        //    return View();
        //}

    }
}
