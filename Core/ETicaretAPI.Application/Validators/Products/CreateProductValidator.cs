using ETicaretAPI.Application.ViewModels.Products;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("Please fill the Name field")
                .MinimumLength(3).MaximumLength(150).WithMessage("Please enter the Name field between 5 and 150 characters");

            RuleFor(p => p.Stock)
                .NotEmpty().WithMessage("Please fill the Stock field")
                .Must(s => s >= 0).WithMessage("Stock field cannot be negative number");

            RuleFor(p => p.Price)
                .NotEmpty().WithMessage("Please fill the Price field")
                .Must(p => p >= 0).WithMessage("Price field cannot be negative number");
        }
    }
}
