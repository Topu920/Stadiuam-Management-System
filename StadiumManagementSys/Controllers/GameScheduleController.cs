﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StadiumManagementSys.Data;
using StadiumManagementSys.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StadiumManagementSys.Controllers
{
    public class GameScheduleController : Controller
    {
        // GET: /<controller>/

        private DataContext _Context;
        public GameScheduleController(DataContext context)
        {
            _Context = context;

        }

        public IActionResult Games(Account account)
        {
            //List<Guid> iamgeIds = _Context.Image.Select(m => m.Id).ToList();
            //return View(iamgeIds);
            var test = _Context.GameSchedule.ToList();
            
            var model = new List<GameSchedule>();
            foreach (var i in test)
            {
                var s = new GameSchedule();
                {
                    s.Tournament = i.Tournament;
                    s.TourGameNo = i.TourGameNo;
                    s.GameTime = i.GameTime;
                    s.FirstTeam = i.FirstTeam;
                    s.SecondTeam = i.SecondTeam;

                    

                    model.Add(s);
                }
            }
            return View(model);
        }

        public IActionResult SetSChedule(Account account)
        {
            var test = _Context.GameSchedule.ToList();
            var model = new List<GameSchedule>();
            foreach (var i in test)
            {
                var s = new GameSchedule();
                {
                    s.GameNo = i.GameNo;
                    s.Tournament = i.Tournament;
                    s.TourGameNo = i.TourGameNo;
                    s.GameTime = i.GameTime;
                    s.FirstTeam = i.FirstTeam;
                    s.SecondTeam = i.SecondTeam;
                    
                    model.Add(s);
                }
            }
            return View(model);
        }

       

        public IActionResult NewGame()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewGame( GameSchedule gameSchedule)
        {
            _Context.GameSchedule.Add(gameSchedule);
            _Context.SaveChanges();

            return RedirectToAction("Games");

        }


        //[HttpPost]
        //public IActionResult NewGame(IList<IFormFile> files, GameSchedule gameSchedule)
        //{
        //    IFormFile uploadedImage = files.FirstOrDefault();
        //    if (uploadedImage == null || uploadedImage.ContentType.ToLower().StartsWith("image/"))
        //    {

        //        MemoryStream ms = new MemoryStream();
        //        uploadedImage.OpenReadStream().CopyTo(ms);

        //        System.Drawing.Image image = System.Drawing.Image.FromStream(ms);

        //        Models.Image imageEntity = new Models.Image()
        //        {
        //            Id = Guid.NewGuid(),
        //            Name = uploadedImage.Name,
        //            Data = ms.ToArray(),
        //            Width = image.Width,
        //            Height = image.Height,
        //            ContentType = uploadedImage.ContentType
        //        };
        //        _Context.Image.Add(imageEntity);
        //        _Context.SaveChanges();



        //    }
        //    return RedirectToAction("Games");
        //}

        public IActionResult Delete(GameSchedule gameSchedule)
        {
            var data = _Context.GameSchedule.Where(u => u.GameNo == gameSchedule.GameNo).FirstOrDefault();
            var model = _Context.GameSchedule.ToList();
            //var dateAsString = DateTime.Now;
            //foreach (var x in model)
            //{
            //    int result = DateTime.Compare(dateAsString, x.GameTime);
            //    if(result>0)
            //    {
            //        _Context.GameSchedule.Remove(x);
            //        _Context.SaveChanges();
            //    }
            //}
            _Context.Remove(data);
            _Context.SaveChanges();


            return RedirectToAction("SetSChedule");
        }



        [HttpGet]
        public IActionResult ViewImage(string Name)
        {

            Models.Image image = _Context.Image.FirstOrDefault(m => m.Name == Name);

            MemoryStream ms = new MemoryStream(image.Data);

            return new FileStreamResult(ms, image.ContentType);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
