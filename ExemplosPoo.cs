using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos.POO
{
    public class ExemplosPoo : Cachorro
    {
        static void Main(string[] args)
        {
            StaticExemp.Saudacao();
            StaticExemp.Converter("1222211");

            List<string> lista = new List<string>();

            lista.Add("Cachorro");
            lista.Add("Gato");
            lista.Add("Cavalo");

            Console.WriteLine("Elementos da lista:");
            foreach (string name in lista)
            {
                Console.WriteLine(name);
            }

            string primeiroNome = lista[0];
            Console.WriteLine($"O primeiro nome da lista é: {primeiroNome}");


            int[] cep = new int[3];

            cep[0] = 08738340;
            cep[1] = 08416660;
            cep[2] = 98735666;

            Console.WriteLine("\nElementos do array:");
            foreach (int num in cep)
            {
                Console.WriteLine(num);
            }

            Cachorro cachorro = new Cachorro();
            cachorro.FazerBarulho();
            cachorro.Correr();
            cachorro.Lamber();
        }

        public override void Lamber()
        {
            Console.WriteLine(" O cachorro está lambendo muito rápido");
        }

        public override void Latir()
        {
            Console.WriteLine("O cachorro parou de latir");
        }
    }
}
