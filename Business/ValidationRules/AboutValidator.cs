using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(z=>z.Description).NotEmpty().WithMessage("Aciklama Kismini bos gecemezsiniz");
            RuleFor(z => z.Image).NotEmpty().WithMessage("Lutfen gorsel seciniz..!");
            RuleFor(z => z.Description).MinimumLength(50).WithMessage("Lutfen en az 50 karakterlik aciklama bilgisi giriniz");
            RuleFor(z => z.Description).MaximumLength(1500).WithMessage("Lutfen aciklamayi kisaltin..!");
        }
    }
}
