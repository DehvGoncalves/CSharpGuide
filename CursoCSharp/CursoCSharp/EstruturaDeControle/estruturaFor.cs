using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class estruturaFor
    {
        public static void Executar()
        {
            double somatorio = 0;
            string entrada;

            Console.WriteLine("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++)
            {
                Console.WriteLine("Informe a nota do aluno {0} ",i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual; //acrescentando

                double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma: 0; //Operador ternárop ? só vai executar a media se o tamanho da turma for > 0
                Console.WriteLine("Media da turma {0}: ",media);
            }

        }
    }
}
