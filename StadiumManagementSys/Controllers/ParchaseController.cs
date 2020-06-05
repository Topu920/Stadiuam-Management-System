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
    public class ParchaseController : Controller
    {
        private DataContext _Context;
        public ParchaseController(DataContext context)
        {
            _Context = context;

        }

        public IActionResult List()
        {
            var test = _Context.Account.ToList();
            var model = new List<Account>();
            foreach (var i in test)
            {
                var s = new Account();
                {
                    s.TransactionNumber = i.TransactionNumber;
                    s.TransactionDate = i.TransactionDate;
                    s.TransactionType = i.TransactionType;
                    s.ClientName = i.ClientName;
                    s.Phone = i.Phone;
                    s.Email = i.Email;
                    s.Categories = i.Categories;
                    s.Quantity = i.Quantity;
                    s.Amount = i.Amount;
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
        public IActionResult Add(Account account,Audience audience)
        {
            if(account.Categories=="25000")
            {
                account.Categories = "VIP";
            }
            else
            {
                account.Categories = "General";
            }

            audience.Gameno = account.Gameno;
            audience.Name = account.ClientName;
            audience.Phone = account.Phone;
            audience.Type = account.Categories;
            audience.Date = account.TransactionDate;


            _Context.Account.Add(account);
            _Context.Audience.Add(audience);
            _Context.SaveChanges();
            return RedirectToAction("List");
        }

        public IActionResult Edit(int no)
        {

            var data = _Context.Account.Where(u => u.No == no).FirstOrDefault();

            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(Account account)
        {

            var data = _Context.Account.Where(u => u.No == account.No).FirstOrDefault();

            data.TransactionNumber = account.TransactionNumber;
            data.TransactionDate = account.TransactionDate;
            data.Email = account.Email;
            data.Phone = account.Phone;
            data.ClientName = account.ClientName;
            data.TransactionType = account.TransactionType;
            data.Categories = account.Categories;
            data.Quantity = account.Quantity;
            data.Amount = account.Amount;

            _Context.SaveChanges();
            return RedirectToAction("List");
        }

        public IActionResult Delect(Account account)
        {
            var data = _Context.Account.Where(u => u.No == account.No).FirstOrDefault();

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
