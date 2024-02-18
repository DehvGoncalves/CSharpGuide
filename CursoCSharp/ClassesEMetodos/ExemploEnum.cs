using System;

namespace CursoCSharp.ClassesEMetodos
{
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia }; //importante não usar acentos ou caracteres especiais, boas práticas.
    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;//Genedo é do tipo Genero(Enum)
        public class ExemploEnum
        {
            public static void Executar()
            {
                int id = (int)Genero.Animacao;//Casting(Conversão) para cnverter o Enum para int.
                Console.WriteLine(id);

                var filmeParaFamilia = new Filme();
                filmeParaFamilia.Titulo = "Sharknado 17";
                filmeParaFamilia.GeneroDoFilme = Genero.Comedia;//setando o tipo através do enum.

                int id2 = (int)filmeParaFamilia.GeneroDoFilme;
                Console.WriteLine("{0} é {1}!", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);
            }
        }
    }
}
