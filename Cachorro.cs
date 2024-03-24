using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos.POO
{
   public class Cachorro : Animal, ICachorro
    {
        public virtual void Latir()
        {
            Console.WriteLine("Au Au!");
        }

        public virtual void Lamber()
        {
            Console.WriteLine("O cachorro está lambendo");
        }

        public void Correr()
        {
            Console.WriteLine("O cachorro está corredno");
        }

        public override void FazerBarulho()
        {
            Console.WriteLine("O Cachorro está fazendo um baruloh");
        }
    }
}
