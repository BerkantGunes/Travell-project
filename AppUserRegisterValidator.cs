using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDTO>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name field can not be blank");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname field can not be blank");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Email field can not be blank");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Username field can not be blank");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password field can not be blank");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("ConfirmPassword field can not be blank");

            RuleFor(x => x.UserName).MinimumLength(5).WithMessage("Username must be at least 5 characters");
            RuleFor(x => x.UserName).MaximumLength(30).WithMessage("Username must be maximum 30 characters");

            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Password and ConfirmPassword must be matched");
        }
        
    }
}
