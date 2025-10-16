using System;
using System.ComponentModel.DataAnnotations;

namespace conectabairro.Services
{
    public class RequiredOnCreateAttribute : RequiredAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // Verifica se o objeto tem uma propriedade chamada "UsuarioId"
            var idProperty = validationContext.ObjectType.GetProperty("UsuarioId");

            if (idProperty != null)
            {
                var idValue = idProperty.GetValue(validationContext.ObjectInstance);

                // Se o ID for 0, significa que é um novo cadastro
                if (idValue is int id && id == 0)
                {
                    // Exige a senha no cadastro
                    return base.IsValid(value, validationContext);
                }
                else
                {
                    // Edição — senha opcional
                    return ValidationResult.Success;
                }
            }

            return base.IsValid(value, validationContext);
        }
    }
}
