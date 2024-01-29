using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAritmeticos
    {
        public static void Executar()
        {
            //Preco Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto); //Por ordem de precedência o * é executado primeiro
            Console.WriteLine($"O preço final é {totalComDesconto}");

            //IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / (altura * altura); //nesse caso será o peso dividido pela altura ao quadrado
            Console.WriteLine("Imc double imc = peso / (altura * altura) é {0}", imc);

            double imc2 = peso / Math.Pow(altura, 2); //Dá pra usar o Math.Pow pra fazer um número elevado a potência que é a msm coisa, porem usando um metodo pra implificar. primeiro a base (alura) depois o expoente qu no caso é o 2 
            Console.WriteLine("usando o Pow(altura {0} ", imc2);

            //Numero PAR/impar
            int par = 24;
            int impar = 25;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2); //Que fica 24/2 tem resto (Que é o resultado do numero par dividido por dois
            Console.WriteLine("{0}/2 Tem resto {1}", impar, impar %2);//O valor impar dividido por 2 tem o resto x

         
            Console.WriteLine("Em qua ano estamos ?");
            int anoAtual = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual seu ano de nascimento? ");
            int anoNacimento = int.Parse(Console.ReadLine());
            int idade = anoAtual - anoNacimento;
            Console.WriteLine($"De acordo com os dados informados, você tem {idade} anos de idade");

        }

    }
}
