using System;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        // Método da Classe (static)
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        // Método da Instância (não static)
        public int Subtrair(int a, int b)
        {
            return a - b;
        }
    }

    public class MetodosEstaticos
    {
        public static void Executar()
        {
            // Usando método estático diretamente pela classe
            var resultado = CalculadoraEstatica.Somar(2, 2);
            Console.WriteLine(resultado); // Saída: 4

            // Criando uma instância da classe para usar método não estático
            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Subtrair(5, 2)); // Saída: 3
        }
    }
}
