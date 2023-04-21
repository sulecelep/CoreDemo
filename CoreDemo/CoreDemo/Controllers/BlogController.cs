using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;

namespace CoreDemo.Controllers
{
	[AllowAnonymous]
    public class BlogController : Controller
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
		Context c= new Context();	
        public IActionResult Index()
		{
			var values = bm.GetBlogListWithCategory();
			return View(values);
		}
		public IActionResult BlogReadAll(int id)
		{

			ViewBag.i = id;
			var values = bm.GetBlogByID(id);
			return View(values);
		}
		public IActionResult BlogListByWriter()
		{
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(x => x.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = bm.GetCategoryListByWriterBm(writerID);
			return View(values);
		}

		[HttpGet]
		public IActionResult BlogAdd()
		{
			List<SelectListItem> categoryvalues = (from x in cm.GetList()
												   select new SelectListItem
												   {
													   Text = x.CategoryName,
													   Value = x.CategoryID.ToString()
												   }).ToList();
			ViewBag.cv = categoryvalues;
			//BlogAdd sayfasında burdan gelecek değerleri gösterebilmek için ViewBag kullandık cv kısaltmasını biz yazdık 
			return View();
		}
		[HttpPost]
		public IActionResult BlogAdd(Blog p)
		{
			var username = User.Identity.Name;
			var usermail = c.Users.Where(x => x.UserName == username).Select(x => x.Email).FirstOrDefault();
			var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
			BlogValidator bv = new BlogValidator();
			ValidationResult results = bv.Validate(p);
			if (results.IsValid)
			{
				p.BlogStatus = true;
				p.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
				p.WriterID = writerID; //bunu session ekleyince elimizle yazmıcaz
				bm.TAdd(p);
				return RedirectToAction("BlogListByWriter", "Blog");
			}
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}
		public IActionResult DeleteBlog(int id)
		{
			var blogvalue=bm.TGetById(id);
			bm.TDelete(blogvalue);
			return RedirectToAction("BlogListByWriter");	
		}
		[HttpGet]
		public IActionResult EditBlog(int id)
		{
            List<SelectListItem> categoryvalues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryvalues;
            var blogvalue = bm.TGetById(id);
            return View(blogvalue);	
		}
        [HttpPost]
        public IActionResult EditBlog(Blog p)
        {
			var username = User.Identity.Name;
			var usermail = c.Users.Where(x => x.UserName == username).Select(x => x.Email).FirstOrDefault();
			var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
			p.WriterID = writerID;
            var blogValue = bm.TGetById(p.BlogID);
            p.CreateDate = DateTime.Parse(blogValue.CreateDate.ToShortDateString());
            p.BlogStatus = true;
			bm.TUpdate(p);
            return RedirectToAction("BlogListByWriter");
        }
    }
}
