using System;
using System.Linq;

namespace CompaniaAutos
{
    public static class ValidationHelper
    {
        public static string LeerTexto()
        {
            string input = Console.ReadLine();
            if (!EsTexto(input))
            {
                throw new FormatException("Solo se permiten letras.");
            }
            return input;
        }

        public static string LeerTextoAlfanumerico()
        {
            string input = Console.ReadLine();
            if (!EsAlfanumerico(input))
            {
                throw new FormatException("Solo se permiten valores alfanuméricos.");
            }
            return input;
        }

        public static bool EsTexto(string input)
        {
            return input.All(c => char.IsLetter(c));
        }

        public static bool EsNumero(string input)
        {
            return input.All(c => char.IsDigit(c));
        }

        public static string LeerDNI()
        {
            string input = Console.ReadLine();
            if (!EsNumero(input) || input.Length > 10)
            {
                throw new FormatException("El DNI debe contener solo números y tener hasta 10 dígitos.");
            }
            return input;
        }

        public static bool EsAlfanumerico(string input)
        {
            return input.All(c => char.IsLetterOrDigit(c));
        }

        public static int LeerNumeroEntero()
        {
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int numero))
            {
                throw new FormatException("Debe ingresar un número entero válido.");
            }
            return numero;
        }

        public static decimal LeerNumeroDecimal()
        {
            string input = Console.ReadLine();
            if (!decimal.TryParse(input, out decimal numero))
            {
                throw new FormatException("Debe ingresar un valor decimal válido.");
            }
            return numero;
        }
    }
}
