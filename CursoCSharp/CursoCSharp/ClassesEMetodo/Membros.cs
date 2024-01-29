using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodo
{
    internal class Membros
    {
        public static void Executar()
        {
          
            //Pessoa sicrano = new Pessoa(); //Tipo pessoa, o nome da variável sicrano, recebe NEW e ai eu chamo Pessoa, nesse caso Pessoa() é um construtor vamos vê isso mais pra frente, tem os parenteses pq é um metodo que estapa sendo executado pra criar 
            //sicrano.Nome = "Renato";
            //sicrano.Idade = 21;

            ////Console.WriteLine($" {sicrano.Nome} tem {sicrano.Idade} anos");
            
            //sicrano.ApresentarNoConsole(); //Usando o método ApresentarNoConsole da classe Pessoa
            //sicrano.Zerar();
            //sicrano.ApresentarNoConsole();


            //var fulano = new Pessoa();
            //fulano.Nome = "Beto";
            //fulano.Idade = 21;

            //fulano.ApresentarNoConsole(); //Usando o control e o clique do mouse, vc consegue navegar entre a função


            //Pessoa Debora = new Pessoa();
            //Debora.Nome = "Debora";
            //Debora.Idade = 31;
            //Debora.ValidarDados();

            Pessoa Branco = new Pessoa();
            Branco.Nome = "";
            Branco.Idade = 0;
            Branco.ValidarDados();
        }
    }
}
