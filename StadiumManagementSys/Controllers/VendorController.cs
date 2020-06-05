using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StadiumManagementSys.Data;
using StadiumManagementSys.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StadiumManagementSys.Controllers
{
    public class VendorController : Controller
    {
        // GET: /<controller>/
        private DataContext _Context;
        public VendorController(DataContext context)
        {
            _Context = context;

        }

        public IActionResult List()
        {
            var test = _Context.Vendor.ToList();
            var model = new List<Vendor>();
            foreach (var i in test)
            {
                var s = new Vendor();
                {
                    s.RegistrationNo = i.RegistrationNo;
                    s.OrganizationName = i.OrganizationName;
                    s.OrganizationEmail = i.OrganizationEmail;
                    s.Phone = i.Phone;
                    s.OrganizationRegNO = i.OrganizationRegNO;
                    s.ContactDuration = i.ContactDuration;
                    s.ServiceType = i.ServiceType;
                    s.ServiceComment = i.ServiceComment;
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
        public IActionResult Add(Vendor vendor)
        {
            _Context.Vendor.Add(vendor);
            _Context.SaveChanges();



            return RedirectToAction("List");

        }


        public IActionResult Edit(string Id)
        {

            var data = _Context.Vendor.Where(u => u.RegistrationNo == Id).FirstOrDefault();

            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(Vendor vendor)
        {

            var data = _Context.Vendor.Where(u => u.RegistrationNo == vendor.RegistrationNo).FirstOrDefault();

            data.RegistrationNo = vendor.RegistrationNo;
            data.OrganizationName = vendor.OrganizationName;
            data.OrganizationEmail = vendor.OrganizationEmail;
            data.Phone = vendor.Phone;
            data.OrganizationRegNO = vendor.OrganizationRegNO;
            data.ContactDuration = vendor.ContactDuration;
            data.ServiceType = vendor.ServiceType;
            data.ServiceComment = vendor.ServiceComment;

            _Context.SaveChanges();
            return RedirectToAction("List");
        }


        public IActionResult Delect(Vendor vendor)
        {
            var data = _Context.Vendor.Where(u => u.RegistrationNo == vendor.RegistrationNo).FirstOrDefault();

            _Context.Remove(data);
            _Context.SaveChanges();


            return RedirectToAction("List");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}

