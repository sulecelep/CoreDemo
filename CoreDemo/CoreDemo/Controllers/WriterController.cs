﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace CoreDemo.Controllers
{
	public class WriterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult WriterProfile()
		{
			return View();
		}
		public IActionResult WriterMail()
		{
			return View();
		}
		[AllowAnonymous]
		public IActionResult Test()
		{
			return View();
		}
        [AllowAnonymous]
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }
        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
        [AllowAnonymous]
		[HttpGet]
        public IActionResult WriterEditProfile()
        {
			var writervalues = wm.TGetById(1);
            return View(writervalues);
        }
        [AllowAnonymous]    
        [HttpPost]
        public IActionResult WriterEditProfile(Writer p)
        {
            var pas1 = Request.Form["pass1"];
            var pas2 = Request.Form["pass2"];
            if (pas1 == pas2)
            {
                p.WriterPassword = pas2;

                WriterValidator wl = new WriterValidator();
                ValidationResult results = wl.Validate(p);
                if (results.IsValid)
                {
                    p.WriterStatus = true;

                    wm.TUpdate(p);
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    foreach (var item in results.Errors)
                    {
                        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    }
                }
            }
            else
            {
                ViewBag.hata = "Girdiğiniz Parolalar Uyuşmuyor!";
            }
            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer w = new Writer();
            if(p.WriterImage!=null)
            {
                var extension = Path.GetExtension(p.WriterImage.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location=Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/writerimage/", newimagename);
                var stream=new FileStream(location, FileMode.Create);
                p.WriterImage.CopyTo(stream);
                w.WriterImage = "/writerimage/"+newimagename;
            }
            w.WriterMail = p.WriterMail;
            w.WriterName=p.WriterName;
            w.WriterPassword = p.WriterPassword;
            w.WriterStatus = true;
            w.WriterAbout = p.WriterAbout;
            wm.TAdd(w);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
