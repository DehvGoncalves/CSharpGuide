using System;

namespace CursoCSharp.ExplicandoConceitos
{
    /*Em C#, trabalhamos com o conceito de classes e objetos. 
    * As classes servem como moldes ou modelos que definem as características (atributos) e comportamentos (métodos) de um objeto. 
    * Pode-se dizer que uma classe é um tipo de dado. 
    * Os atributos e Metodos são conhecidos como membros da classe. 
   */
    public class ClassesEObjetos //Classe ClassesEObjetos
    {
        /*Dentro de uma classe, podemos ter atributos, (Dados da classe) e os métodos (Funcionalidade, o algoritmo que vai fazer o tratamento, manipular os dados,
         *retornar dados, receber dados como entrada, fazer processamentos. Tem mais haver com AÇÃO).
         */
    }

    public class Pessoa //Classe Pessoa
    {
        public string Nome; //Atributo Nome da classe Pessoa
        public int Idade; //Atributo Idade da classe Pessoa
    }

    //************************************************************************************************************************************************************************************
    public class Data // Classe Data
    {
        // Atributos da classe Data
        public int Dia; // Tornado público para permitir acesso externo
        public int Mes; // Tornado público para permitir acesso externo
        public int Ano; // Tornado público para permitir acesso externo

        // Construtor padrão
        public Data() { }

        // Construtor que aceita um valor inicial para o atributo Dia
        public Data(int dia, int mes, int ano)
        {
            Dia = dia;
            Mes = mes;
            Ano = ano;
        }

        // Método que imprime a data
        public static void ImprimeData(Data d)
        {
            Console.WriteLine("{0}/{1}/{2}", d.Dia, d.Mes, d.Ano);
        }

        public static void Executar()
        {
            // Instanciando um objeto da classe Data
            Data d1 = new Data(1, 1, 2020);

            // Chamando o método ImprimeData diretamente na instância d1
            ImprimeData(d1);
        }
    }
}