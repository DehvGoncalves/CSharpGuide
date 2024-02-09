using System;

namespace CursoCSharp.ClassesEMetodos
{
    public class ParamsParametrosVariaveis
    {
        public static void Recepcionar(params string[] pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("Olá {0}", pessoa);
            }
        }
        public static void Executar()
        {
            Recepcionar("João", "Lucas", "Ana", "Bia", "Maria");
        }
    }
}
