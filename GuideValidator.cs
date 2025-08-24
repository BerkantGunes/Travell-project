using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please Enter the Guide Name and Surname!");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Please Enter the Guide Description!");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Please Upload Image for Guide!");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Please enter a name of less than 30 characters");
            RuleFor(x => x.Name).MinimumLength(6).WithMessage("Please enter a name of more than 6 characters");
        }
    }
}
