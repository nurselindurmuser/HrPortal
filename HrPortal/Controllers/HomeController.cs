﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HrPortal.Models;
using HrPortal.Data;
using HrPortal.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HrPortal.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<Setting> settingRepository;
        private IRepository<Resume> resumeRepository;
        private IRepository<Feedback> feedbackRepository;
        private IRepository<Job> jobRepository;
        private IRepository<Location> locationRepository;

        public HomeController(IRepository<Resume> resumeRepository, IRepository<Feedback> feedbackRepository, IRepository<Job> jobRepository, IRepository<Location> locationRepository, IRepository<Setting> settingRepository)
        {
            this.settingRepository = settingRepository;
            this.resumeRepository = resumeRepository;
            this.feedbackRepository = feedbackRepository;
            this.jobRepository = jobRepository;
            this.locationRepository = locationRepository;
            

        }
        
        public IActionResult Index()
        {
            ViewBag.ResumeCount = resumeRepository.Count();
            ViewBag.jobCount = jobRepository.Count();
            ViewBag.jobs = jobRepository.GetMany(s=>s.PublishDate <= DateTime.Now && DateTime.Now <= s.EndDate && s.IsActive == true, "Company","JobLocations","JobLocations.Location");
            ViewBag.resumes = resumeRepository.GetMany(s=>s.IsActive == true && s.IsApproved  == true, "EducationInfos");
            ViewBag.Locations = locationRepository.GetAll().OrderBy(s=>s.Name);
            return View();
        }

        [Route("hakkimizda")]
        public IActionResult About()
        {
            var setting = settingRepository.GetAll().FirstOrDefault();

            return View(setting);
        }

        [Route("nasil-calisiyoruz")]
        public IActionResult HowItWorks()
        {
            var setting = settingRepository.GetAll().FirstOrDefault();

            return View(setting);
        }

        [Route("yardim")]
        public IActionResult Help()
        {
            var setting = settingRepository.GetAll().FirstOrDefault();

            return View(setting);
        }

        [Route("gizlilik-politikasi")]
        public IActionResult PrivacyPolicy()
        {
            var setting = settingRepository.GetAll().FirstOrDefault();

            return View(setting);
        }

        [Route("iletisim")]
        public IActionResult Contact()
        {
            
            var setting = settingRepository.GetAll().FirstOrDefault();
            
            return View(setting);
        }

        
        [HttpPost]
        public IActionResult Contact(Feedback feedback)
        {
            if (ModelState.IsValid) { 
            feedbackRepository.Insert(feedback);
            }
            ViewBag.Result = "Mesajınız başarıyla iletilmiştir.";
            var setting = settingRepository.GetAll().FirstOrDefault();

            return View(setting);
        }

        [Route("hata")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
