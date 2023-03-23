using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator:AbstractValidator<Writer>
	{
		public WriterValidator()
		{
			RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Ad Soyad kısmı boş geçilemez.");
			RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail kısmı boş geçilemez.");
			RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre kısmı boş geçilemez.");

			RuleFor(x => x.WriterPassword).Matches("[A-Z]").WithMessage("Şifrenizde en az 1 büyük harf olmalıdır.");
			RuleFor(x => x.WriterPassword).Matches("[a-z]").WithMessage("Şifrenizde en az 1 küçük harf olmalıdır.");
			RuleFor(x => x.WriterPassword).Matches("[0-9]").WithMessage("Şifrenizde en az 1 sayı olmalıdır.");
			RuleFor(x => x.WriterPassword).Matches("[^a-zA-Z0-9]").WithMessage("Şifrenizde en az 1 özel karakter kullanmalısınız.");
			RuleFor(x => x.WriterPassword).MinimumLength(8).WithMessage("Lütfen en az 8 karakterlik veri girişi yapın.");

			RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakterlik veri girişi yapın.");
			RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en az 50 karakterlik veri girişi yapın.");
		}

	}
}
