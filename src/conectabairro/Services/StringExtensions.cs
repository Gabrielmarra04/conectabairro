using System.Linq;
namespace conectabairro.Services
{
    public static class StringExtensions
    {
        public static string ToUserInitials(this string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
            {
                return "?"; // Retorna um valor padrão para nomes nulos/vazios
            }

            var parts = fullName.Trim().Split(' ');
            string initials = "";

            // Primeira inicial
            if (parts.Length > 0 && !string.IsNullOrWhiteSpace(parts[0]))
            {
                initials += parts[0][0];
            }

            // Inicial do último nome (se houver mais de um nome)
            if (parts.Length > 1)
            {
                // Encontra o último elemento não vazio
                var lastPart = parts.LastOrDefault(p => !string.IsNullOrWhiteSpace(p));

                // Garante que o último nome não seja o mesmo que o primeiro (em casos de nome único)
                if (lastPart != null && lastPart != parts[0] && initials.Length < 2)
                {
                    initials += lastPart[0];
                }
            }

            return initials.ToUpper();
        }
    }
}