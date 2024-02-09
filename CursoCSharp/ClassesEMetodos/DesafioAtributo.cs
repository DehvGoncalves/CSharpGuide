using System;

/*Faça o desafio:
 *     public class DesafioAtributo
    {
        int a = 10;
        public static void Executar()
        {
            //Acessar variável 'a' dentro do método Executar!
            var desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);
        }
*/
namespace CursoCSharp.ClassesEMetodos
{
    public class DesafioAtributo
    {
        int a = 10;
        public static void Executar()
        {
            //Acessar variável 'a' dentro do método Executar!
            var desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);
        }

    }
}//R: O atributo 'a' é um atributo de instancia e o meétodo executar é um metodo que pertence a classe. O metodo que pertence a classe não consegue acessar um atributo de instancia
//Eu poderia mudar o atributo p/ static para transformálo em um atributo de classe e assim o método executar conseguiria acessá-lo.
//Porém a resposta correta, é você criar uma instancia, atribuir isso a uma variável e acessar o atributo 'a' através dessa variável(instancia), usando a notação ponto.
