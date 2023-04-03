using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidatör : AbstractValidator<Team>
    {
        public TeamValidatör()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Personel adı boş geçilmez.");
            RuleFor(x => x.PersonName).MaximumLength(50).WithMessage("Personel adı Max 50 karakter olabilir.");
            RuleFor(x => x.PersonName).MinimumLength(3).WithMessage("Personel adı Min 3 karakter olabilir.");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Personel görevi boş geçilmez.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Personel görseli boş geçilmez.");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Personel görev adı Max 50 karakter olabilir.");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Personel görev adı Min 3 karakter olabilir.");
        }
    }
}
