using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminMessage")]
    [AllowAnonymous]
    public class AdminMessageController : Controller
    {
        Message2Manager mm = new Message2Manager(new EfMessage2Repository());
        Context c = new Context();
        [Route("")]
        [Route("Inbox")]
        public IActionResult Inbox()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(x => x.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = mm.GetInboxListByWriter(writerID);
            ViewBag.gelen = mm.GetInboxListByWriter(writerID).Count();
            ViewBag.giden = mm.GetSendboxListByWriter(writerID).Count();
            return View(values);
        }
        [Route("")]
        [Route("Sendbox")]
        public IActionResult Sendbox()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(x => x.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = mm.GetSendboxListByWriter(writerID);
            ViewBag.gelen = mm.GetInboxListByWriter(writerID).Count();
            ViewBag.giden = mm.GetSendboxListByWriter(writerID).Count();
            return View(values);
        }

        [Route("ComposeMessage")]
        [HttpGet]
        public IActionResult ComposeMessage()
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
        [Route("ComposeMessage")]
        [HttpPost]
        public IActionResult ComposeMessage(Message2 p)
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            p.SenderID=writerID;
            p.MessageDate=Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.MessageStatus = true;
            ViewBag.gelen= mm.GetInboxListByWriter(writerID).Count();
            ViewBag.giden= mm.GetSendboxListByWriter(writerID).Count();
            mm.TAdd(p); 
            return RedirectToAction("Sendbox");
        }
    }
}
