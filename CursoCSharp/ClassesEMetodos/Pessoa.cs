using System;

namespace CursoCSharp.ClassesEMetodos
{
    public class Pessoa //A partir de uma classe você consegue criar/instanciar os objetos, tem dois atributos e dois comportamentos
    {
        //TODOS OS ATRIBUTOS/MEMBROS DE UMA CLASSE SÃO INICIADOS COM VALOR PADRÃO, NULL
        public String Nome;
        public int Idade;

        public string Apresentar() //Método sem entrada de parâmetros e com retorno de string
        {
            //Nesse caso não preciso passar parametros pra esse metodo, pois quem é dono dos atributos é a própria classe e dentro do Metodo eu consigo acessar os atributos da classe.
            return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos de idade.");

            //Metodo Format, retorna uma string formatada, onde eu passo o formato e os valores que eu quero formatar.
        }
        public void ApresentarNoConsole() //Método sem retorno, mas com saída no console
        {
            Console.WriteLine(Apresentar()); //Chamando um método dentro de outro método, o resultado do método Apresentar() é passado como argumento para o método WriteLine()
        }
        public void Zerar() //Método sem retorno e sem entrada de parâmetros
        {
            Nome = "";
            Idade = 0;
        }
    }

}
