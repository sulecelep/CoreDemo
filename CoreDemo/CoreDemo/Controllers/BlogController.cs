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

namespace CoreDemo.Controllers
{
	[AllowAnonymous]
	public class BlogController : Controller
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());
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
			var values = bm.GetCategoryListByWriterBm(1);
			return View(values);
		}

		[HttpGet]
		public IActionResult BlogAdd()
		{
			CategoryManager cm = new CategoryManager(new EfCategoryRepository());
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
			BlogValidator bv = new BlogValidator();
			ValidationResult results = bv.Validate(p);
			if (results.IsValid)
			{
				p.BlogStatus = true;
				p.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
				p.WriterID = 1; //bunu session ekleyince elimizle yazmıcaz
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
	}
}
