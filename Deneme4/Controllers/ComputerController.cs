using System;
using Deneme4.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Deneme4.Resopsi;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Deneme4.Controllers
{
    public class ComputerController : Controller
    {
        Context c = new Context();
        ComputerReposi computerReposi = new ComputerReposi();
        public IActionResult CpIndex()
        {
            var data = c.computers.ToList();
            ViewBag.Model = data;
            return View();

        }




        [HttpGet]
        public IActionResult CpRegister()
        {
            List<SelectListItem> values = (from x in c.computers.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Ram,

                                               Value = x.Pcid.ToString()
                                           }).ToList();
            ViewBag.v1 = values;

            List<SelectListItem> values2 = (from x in c.computers.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Monitor,

                                               Value = x.Pcid.ToString()
                                           }).ToList();
            ViewBag.v2 = values2;

            return View();

            var data = c.computers.ToList();
            ViewBag.Model = data;
            return View();
           
        }



        [HttpPost]
        public IActionResult CpRegister(Computer cp)
        {

            computerReposi.Tadd(cp);
            return RedirectToAction("CpIndex");
        }
        public IActionResult CpDelete(int id)
        {
            computerReposi.TRemove(new Computer { Pcid = id });
            return RedirectToAction("CpIndex");
        }
    }
}


