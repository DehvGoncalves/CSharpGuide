using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Interpolacao
    {
        public static void Executar() //função
        {
            String nome = "Notbook gamer";
            String marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("O "+ nome + " da marca "
                   + marca + " custa " + preco + "."); //concatenação comum

            Console.WriteLine("O {0} da marca {1} custa {2}.", 
                nome, marca, preco);

            Console.WriteLine($"A marca {marca} é legal!");  
            
            Console.WriteLine($"{1 + 1}!");
        }
    }
}
