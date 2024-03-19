using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity) //Valide sınıfının interface ine ulaşarak ne gibi değişkenler istediğine baktık
        {
            var context = new ValidationContext<object>(entity); //Bu kullanım bize yapının generic olduğunu gösteriyor.
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
