using System;
using System.ComponentModel.DataAnnotations;

namespace conectabairro.Services
{
    public class RequiredOnCreateAttribute : RequiredAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var idProperty = validationContext.ObjectType.GetProperty("UsuarioId");

            if (idProperty != null)
            {
                var idValue = idProperty.GetValue(validationContext.ObjectInstance);

                if (idValue is int id && id == 0)
                {
                    return base.IsValid(value, validationContext);
                }
                else
                {
                    return ValidationResult.Success;
                }
            }

            return base.IsValid(value, validationContext);
        }
    }
}
