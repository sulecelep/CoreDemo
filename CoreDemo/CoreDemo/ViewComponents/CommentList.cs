using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents
{
	public class CommentList:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserCommentViewModel>
			{
				new UserCommentViewModel
				{
					ID= 1,
					Username="Şule"
				},
				new UserCommentViewModel
				{
					ID= 2,
					Username="Zeynep"
				},
				new UserCommentViewModel
				{
					ID= 3,
					Username="Efrun"
				}

			};
			return View(commentvalues);
		}
	}
}
