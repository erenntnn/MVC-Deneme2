using Deneme4.Resopsi;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Deneme4.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Deneme4.Controllers
{

    public class StudentController : Controller
    {
        Context c = new Context();
        StudentResopsi studentResopsi = new StudentResopsi();
        public IActionResult Index()
        {

            return View(studentResopsi.TList());
        }

        [HttpGet]
        public IActionResult Register()
        {
            using (var db = new Context())
            {
                List<Computer> ComputerModel = new List<Computer>();
                ComputerModel = db.computers.ToList();

                var Ram = ComputerModel.Select(x => x.Ram).Distinct().ToList();
                ViewBag.STRam = Ram;


                var Graphicscard = ComputerModel.Select(x => x.Graphicscard).Distinct().ToList();
                ViewBag.STGraphicscard = Graphicscard;

                var Mainboard = ComputerModel.Select(x => x.Mainboard).Distinct().ToList();
                ViewBag.STMainboard = Mainboard;

                var Monitor = ComputerModel.Select(x => x.Monitor).Distinct().ToList();
                ViewBag.STMonitor = Monitor;
            }

          

            return View();
        }

        [HttpPost]
        public IActionResult Register(Student p)
        {
            List<SelectListItem> values = (from x in c.computers.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Ram,

                                               Value = x.Pcid.ToString()
                                           }).ToList();

            p.STRam = values[Convert.ToInt32(p.STRam)].Text;
 
            studentResopsi.Tadd(p);


            List<SelectListItem> values2 = (from x in c.computers.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Graphicscard,

                                               Value = x.Pcid.ToString()
                                           }).ToList();

            p.STGraphicscard = values2[Convert.ToInt32(p.STGraphicscard)].Text;

            studentResopsi.Tadd(p);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            studentResopsi.TRemove(new Student { id = id });
            return RedirectToAction("Index");
        }





        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(Student d)
        {
            var data = c.students.Where(x => x.id == d.id).FirstOrDefault();
            if (data != null)
            {


                data.name = d.name;
                data.surname = d.surname;
                data.email = d.email;
                data.telefon = d.telefon;
                c.SaveChanges();
            }

            return RedirectToAction("Index");

        }



    }
}

