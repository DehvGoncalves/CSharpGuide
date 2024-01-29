using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado); //Conversão implicita

            double nota = 9.5;
            int notaTruncada = (int)nota; //Conversão explicita, necessário repertir o tipo pra que o compilador entenda que vc realmente quer fazer a conversão mesmo ciênte das percas.
            Console.WriteLine("Nota truncada: {0}", notaTruncada);


            Console.WriteLine("Digite sua idade ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString); //Recendo a idade em String;
            Console.WriteLine("Idade inserida é {0} ", idadeInteiro); //Convertendo pra inteiro

            idadeInteiro = Convert.ToInt32(idadeString); //Convertendo usando o ToInt32, outra forma de converter
            Console.WriteLine("Idade inserida: {0} ", idadeInteiro);


            //Outra forma segura
            Console.WriteLine("Digite um número");
            string palavra = Console.ReadLine();
            int.TryParse(palavra, out int numero); //O TryParse vai pegar oque vc digitou em palavra e converter p/ número. Se ele não conseguir ele vai passar o valor 0
            Console.WriteLine("Resultado: {0}", numero);

            //Jeito simplificado
            Console.WriteLine("Digite o segundo número");
            int.TryParse(Console.ReadLine(), out int numero2); //O TryParse vai pegar oque vc digitou vai ser conveetido p/ inteiro
            Console.WriteLine("Resultado: {0}", numero2);

        }
    }
}
