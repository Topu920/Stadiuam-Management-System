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
    public class EmployeeController : Controller
    {
        // GET: /<controller>/

        private DataContext _Context;
        public EmployeeController(DataContext context)
        {
            _Context = context;

        }

        public IActionResult List()
        {
            var test = _Context.Employee.ToList();
            var model = new List<Employee>();
            foreach (var i in test)
            {
                var s = new Employee();
                {
                    s.EmployeeId = i.EmployeeId;
                    s.Name = i.Name;
                    s.Email = i.Email;
                    s.Phone = i.Phone;
                    s.Designation = i.Designation;
                    s.JoiningDate = i.JoiningDate;
                    s.Salary = i.Salary;
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
        public IActionResult Add(Employee employee)
        {
            var s = new Login()
            {
                Email = employee.Email,
                Password = employee.Phone,
                Actor= "Employee"

            };
            _Context.Login.Add(s);
            _Context.Employee.Add(employee);
            _Context.SaveChanges();



            return RedirectToAction("List");

        }


        public IActionResult Edit(int Id)
        {

            var data = _Context.Employee.Where(u => u.EmployeeId == Id).FirstOrDefault();

            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {

            var data = _Context.Employee.Where(u => u.EmployeeId == employee.EmployeeId).FirstOrDefault();

            data.EmployeeId = employee.EmployeeId;
            data.Name = employee.Name;
            data.Email = employee.Email;
            data.Phone = employee.Phone;
            data.Designation = employee.Designation;
            data.JoiningDate = employee.JoiningDate;
            data.Salary = employee.Salary;

            _Context.SaveChanges();
            return RedirectToAction("List");
        }

      
        public IActionResult Delect(Employee employee)
        {
            var data = _Context.Employee.Where(u => u.EmployeeId == employee.EmployeeId).FirstOrDefault();

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
