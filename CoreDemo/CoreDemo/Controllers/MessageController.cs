﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        Message2Manager mm = new Message2Manager(new EfMessage2Repository());
        Context c= new Context();   
        public IActionResult InBox()
        {
			var username = User.Identity.Name;
			var usermail = c.Users.Where(x => x.UserName == username).Select(x => x.Email).FirstOrDefault();
			var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
			var values = mm.GetInboxListByWriter(writerID);
            ViewBag.v1 = values.Count();
            return View(values);
        }
        public IActionResult SendBox()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(x => x.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = mm.GetSendboxListByWriter(writerID);
            ViewBag.v1 = values.Count();
            return View(values);
        }
        public IActionResult MessageDetails(int id)
        {
           
            var value = mm.TGetById(id);
            return View(value);
        }
        [HttpGet]
        public IActionResult SendMessage()
        {
			UserManager um = new UserManager(new EfUserRepository());
			List<SelectListItem> receiverUsers = (from x in um.GetList()
											   select new SelectListItem
											   {
												   Text = x.Email,
												   Value = x.Id.ToString()
											   }).ToList();
			ViewBag.v1 = receiverUsers;
			return View();
        }
        [HttpPost]
        public IActionResult SendMessage(Message2 p)
        {
			var username = User.Identity.Name;
			var usermail = c.Users.Where(x => x.UserName == username).Select(x => x.Email).FirstOrDefault();
			var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            p.SenderID=writerID;
            //p.ReceiverID = 2;
            p.MessageStatus = true;
            p.MessageDate=Convert.ToDateTime(DateTime.Now.ToShortDateString());
            mm.TAdd(p);
			return RedirectToAction("InBox");
        }


    }
}