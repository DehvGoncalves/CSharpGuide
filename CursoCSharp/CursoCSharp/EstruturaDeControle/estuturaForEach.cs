using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class estuturaForEach
    {
        public static void Executar()
        {
            var palavra = "Opa!";

            foreach (var letra in palavra) { //ele vai percorrer toda palavra e cada repetição, uma letra será atribuída pra essa variável letra
                Console.WriteLine(letra); //ele vai repetir enquanto tiver letra.

            }

            //o forEach tm pode ser usado em outros contextos
            var alunos = new String[] { "Ana", "Bia", "Carlos" };
            foreach (string aluno in alunos) {
                Console.WriteLine(aluno);

                //É simples, ele corre do primeio ao ultimo sem necessidade de criar laços e incrementar algo
            }
        }
    }
}
