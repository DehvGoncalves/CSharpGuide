using System;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento; //Usado quando vc quer setar o valor no momento da criação do objeto e não quer que ele seja alterado.
        public Cliente(string nome, DateTime nascimento)//Constructor
        {
            Nome = nome;
            Nascimento = nascimento;
        }
        public string GetDataDeNascimento()//Método criado para formatar a data de nascimento no formato dd/mm/aaaa.
        {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }
    public class Readonly
    {
        public static void Executar()
        {
            var novoCliente = new Cliente("Ana Silva", 
                new DateTime(1992, 5, 21));
            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());
        }
    }


}