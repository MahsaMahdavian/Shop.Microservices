using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace products.Application.Categories.Command.Create
{
    public class AddCategoryCommandValidator :AbstractValidator<AddCategoryCommand>
    {
        public AddCategoryCommandValidator()
        {
            RuleFor(p => p.Title)
               .NotEmpty().WithMessage("{Title} is Required")
               .NotNull()
               .MaximumLength(10).WithMessage("{Title} must not exceed 10 characters");
            RuleFor(p => p.Description)
                .NotEmpty().WithMessage("{Description} is Required")
                .NotNull()
                .MaximumLength(5000).WithMessage("{Description} must not exceed 5000 characters");

        

            
        }
    }
}
