using System;

namespace Exemplos.POO
{
    public class StaticExemp
    {
        private static int contador = 0;

        public static void Saudacao()
        {
            Console.WriteLine("Greetings my friend!");
        }

        public static void Converter(string numero)
        {
            int convert = Convert.ToInt32(numero);

            Console.WriteLine($"Número convertido: {convert}");

            contador++;
            Console.WriteLine($"Contador: {contador}");
        }
    }
}