using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class BlogValidator : AbstractValidator<Blog>
	{
		public BlogValidator()
		{
			RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığını boş geçemezsiniz.");
			RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog başlığını boş geçemezsiniz.");
			RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog başlığını boş geçemezsiniz.");
			RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Başlık 150 karakteri geçmemelidir.");
			RuleFor(x => x.BlogTitle).MinimumLength(4).WithMessage("Başlık 4 karakterden az olmamalıdır.");
			RuleFor(x => x.BlogContent).MinimumLength(4).WithMessage("İçerik 4 karakterden az olmamalıdır.");
		}
	}
}
