using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StadiumManagementSys.Data;
using StadiumManagementSys.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StadiumManagementSys.Controllers
{
    public class AudienceController : Controller
    {
        // GET: /<controller>/

        private DataContext _Context;
        public AudienceController(DataContext context)
        {
            _Context = context;

        }

        public IActionResult List( Audience audience)
        {
            var test = _Context.Audience.ToList();
            var model = new List<Audience>();
            foreach (var i in test)
            {
                var s = new Audience();
                {
                  
                    s.Date = i.Date;
                    s.Name = i.Name;
                    s.Phone = i.Phone;
                    s.Type = i.Type;
                    s.SeatNo = i.SeatNo;
                    s.Gameno = i.Gameno;
                    model.Add(s);
                }
            }
            return View(model);
        }

        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Add(Audience audience)
        {
            _Context.Audience.Add(audience);
            _Context.SaveChanges();

            return RedirectToAction("List");

        }


        public IActionResult Edit(DateTime date)
        {

            var data = _Context.Audience.Where(u => u.Date == date).FirstOrDefault();

            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(Audience audience)
        {

            var data = _Context.Audience.Where(u => u.Date == audience.Date).FirstOrDefault();

            data.Date = audience.Date;
            data.Name = audience.Name;
            data.Phone = audience.Phone;
            data.Type = audience.Type;
            data.SeatNo = audience.SeatNo;
            data.Gameno = audience.Gameno;



            _Context.SaveChanges();
            return RedirectToAction("List");
        }

    }
}
