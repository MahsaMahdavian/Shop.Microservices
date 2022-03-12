using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Application.Behaviours
{
    public class ValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : MediatR.IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;
        public ValidationBehaviour(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators?? throw new ArgumentNullException(nameof(validators)); 
        }
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            var context = new ValidationContext<TRequest>(request); 
            var vlaidationResults=await Task.WhenAll(_validators.Select( v =>v.ValidateAsync(context)));
            var failures = vlaidationResults.SelectMany(r => r.Errors).Where(f => f != null).ToList();
            if (failures.Count!=0)
            {
                throw new ValidationException(failures);
            }
            return await next();
        }
    }
   
}
