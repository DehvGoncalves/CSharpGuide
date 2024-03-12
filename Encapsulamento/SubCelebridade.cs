using System;
using System.Collections.Generic;

namespace Encapsulamento {
    public class SubCelebridade {
        //A VISIBILIDADE TBM VALE PARA MÉTODOS
        
        // todos
        public String InfoPublica = "Tenho um Instagram!";

        // herança
        protected string CorDoOlho = "Verde";

        // Mesmo Projeto (assenbly), projeto = assenbly. Ulong não tem sinal
        internal ulong NumeroCelular = 5511999999999;

        // herança ou no mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        // mesma class ou herança no mesmo projeto (a partir da versão 7.2)
        private protected string SegredoFamilia = "Bla bla";

        //private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos() {
            Console.WriteLine("[SubCelebridade] *-* pode acessar todos os seus próprios atributos, independente da visibilidade. Pois pertencem a ele mesmi");
            Console.WriteLine("São eles: ");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }

    }
}
