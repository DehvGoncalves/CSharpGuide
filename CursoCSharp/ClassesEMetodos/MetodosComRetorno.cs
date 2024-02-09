using System;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraComum
    {
        public int Somar(int a, int b) //Assinatura do método é o nome do método e os parâmetros que ele recebe (tipo e quantidade)
        {
            return a + b;
        }
        public int Subtrair(int a, int b) //Assinatura do método é o nome do método e os parâmetros que ele recebe (tipo e quantidade)
        {
            return a - b;
        }
        public int Multiplicar(int a, int b) //Assinatura do método é o nome do método e os parâmetros que ele recebe (tipo e quantidade)
        {
            return a * b;
        }
        public int Dividir(int a, int b) //Assinatura do método é o nome do método e os parâmetros que ele recebe (tipo e quantidade)
        {
            return a / b;
        }


    }
    public class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();//Variável do tipo CalculadoraComum que recebe uma nova instância de CalculadoraComum através do operador new chamando o construtor padrão
            var resultado = calculadoraComum.Somar(5, 5);
            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(2, 7));
            Console.WriteLine(calculadoraComum.Multiplicar(4, 4));
            Console.WriteLine(calculadoraComum.Dividir(30, 3));

        }
    }

}
