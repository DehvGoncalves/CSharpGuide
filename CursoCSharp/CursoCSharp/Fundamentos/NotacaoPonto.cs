using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "Olá".ToUpper();
            Console.WriteLine(saudacao);
            

            var saudacoes2 = "Olá World! ".ToUpper().Insert(4, " World! ").Replace(" World! ", "Mundo ");
            Console.WriteLine(saudacoes2); //metodos terminam com()

            //ToUpper deixa tudo maiúsculo
            //Insert insere o texto na posição indicada
            //Replace repete tudo denovo

            Console.WriteLine("Teste".Length); //qtd de caracteres, não termina com () pois é valor o outro é metodo

            //A notação ponto, se a variável for vazia, vc deve usar o ? pra que o valor só seja acessado se tiver um valor definido.
            //Isso é chamado de navegação segura, quando vc tem um valor qualquer que não esteja definido você pode colocar o ? pra que seu código
            //Fique mais seguro.
            String valorImportante = null;
            Console.WriteLine(valorImportante?.Length);

            int idade = 31;
            int idade2 = 31;


        }
    }
}
