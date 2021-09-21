using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar soyadını boş geçemezsiniz");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Ünvan kısmını boş geçemezsiniz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında kısmını boş geçemezsiniz");
            RuleFor(x => x.WriterAbout).Must(AboutValid).WithMessage("A harfini içermelidir");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az üç karakter girişi yapın");
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("Lütfen 50 karakterden fazla değer girişi yapmayın");
        }

        private bool AboutValid(string arg)
        {
            Regex regex = new Regex(@"a");
            return regex.IsMatch(arg);
        }
    }
}

