using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodo
{
    class CalculadoraComum//Classe
    {
        public int Somar(int a, int b) //Metodo com os parâmetros de entrada, nome do médoto
        {
            return a + b; //Tipo de retorno int
        }
        public int subtrair(int a, int b) //Metodo com os parâmetros de entrada, nome do médoto
        {
            return a - b; //Tipo de retorno int
        }
        public int multiplicar(int a, int b) //Metodo com os parâmetros de entrada, nome do médoto
        {
            return a * b; //Tipo de retorno int
        }
        public int dividir(int a, int b) //Metodo com os parâmetros de entrada, nome do médoto
        {
            return a / b; //Tipo de retorno int
        }

    }
    internal class MetodosComRetorno
    {
        public static void Executar()
        {
            //Acima criei os metodos, um cada tipo de operação, e dentro de executar, vou instanciar um objeto do tipo CalculadoraComum, vou armazenar usando o 
            //new CalculadoraComum, armazenar isso em uma variável e através dessa variável eu consigo chamar o metodo somar, subtrair e multiplicar
            var CalculadoraComum = new CalculadoraComum();
            var resultado = CalculadoraComum.Somar(5, 5);
            Console.WriteLine(resultado);

            Console.WriteLine(CalculadoraComum.subtrair(5,5)); //Usando o método subtrair
            Console.WriteLine(CalculadoraComum.dividir(5,5)); //Usando o método dividir
            Console.WriteLine(CalculadoraComum.multiplicar(5,5));  //Usando o método multiplicar

        }
    }
}
