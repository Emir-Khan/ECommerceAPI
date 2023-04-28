using ECommerceAPI.Application.Features.Commands.AppUser.UpdatePassword;
using FluentValidation;

namespace ECommerceAPI.Application.Validators.AppUsers
{
    public class UpdatePassword : AbstractValidator<UpdatePasswordCommandRequest>
    {
        public UpdatePassword()
        {
            RuleFor(up => up.Password).Equal(up => up.PasswordConfirm).WithMessage("Passwords Do Not Match");
        }
    }
}