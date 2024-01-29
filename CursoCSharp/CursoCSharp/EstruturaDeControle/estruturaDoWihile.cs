using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class estruturaDoWihile //Minha classe
    {
        public static void Executar()//metodo
        {
            string entrada;

            do //sempre executa p/ depois analisar
            {
                Console.WriteLine("Qual seu nome?");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem vindo! {0}", entrada);
                Console.WriteLine("Deseja continuar? (S/N)");
                entrada = (Console.ReadLine());
            }while (entrada.ToLower() == "s" ); //Se for verdadeiro vai continr repetindo até o usuário colocar n e drr negativo., só vai testar o final
        }
    }
}
