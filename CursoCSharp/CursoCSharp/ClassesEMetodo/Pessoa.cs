using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodo
{
    class Pessoa
    {
        //atributos
        public string Nome; //publico para que o atributo fique visivel pra fora da classe
        public int Idade;

        public string Apresentar() //Metodo pra apresentar a pessoa
        {
            return string.Format($"Olá, me chamo {Nome} e tenho {Idade} anos");//usando método pra formatar o texto
        }
        public void ApresentarNoConsole()//Método que não retorna, será usado para chamar o método apresentar
        {
            Console.WriteLine(Apresentar());
        }

        public void Zerar() //Metodo que não retorna nada mas Zero os dados de uma pessoa
        {
            Nome = "";
            Idade = 0;
        }
        public string ValidarDados()
        {
            if (Idade == 0)
            {
                // Dados em branco, retorna um valor indicativo de erro.
                return string.Format( "Os dados estão em branco");
            }
            else
            {
                // Dados válidos, realiza a ação desejada e retorna apropriado, se necessário.
                ApresentarNoConsole();
                return Apresentar();
            }
        }

    }
}

