using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Application.Categories.Command.Update
{
    public class UpdateCategoryCommandValidator:AbstractValidator<UpdateCategoryCommand>
    {
        public UpdateCategoryCommandValidator()
        {
            RuleFor(C => C.Title)
              .NotEmpty().WithMessage("{Title} is Required")
              .NotNull()
              .MaximumLength(200).WithMessage("{Title} must not exceed 10 characters");
            RuleFor(C => C.Description)
                .NotEmpty().WithMessage("{Description} is Required")
                .NotNull()
                .MaximumLength(5000).WithMessage("{Description} must not exceed 10 characters");

         

            
        }
    }
}
