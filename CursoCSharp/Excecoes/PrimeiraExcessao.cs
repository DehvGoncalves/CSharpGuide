using System;

namespace CursoCSharp.Excecoes {
    public class Conta {
        double Saldo;

        public Conta(double saldo) {
            Saldo = saldo;
        }

        public void Sacar(double valor) {
            if (valor > Saldo) {
                throw new ArgumentException("Saldo insuficiente"); //argumento não foi conforme o esperado, lanço excessão e retorna p/ método que chamou
                                                                   //vc não pode simplesmente criar uma exceção, usando apenas o new, vc precisa lançar a exceção criada. No exemplo criei a nova excessão, passe uma msg associada ao erro. E importante que vc passe a mensagem p/ usuário
            }
            Saldo -= valor;
        }

    }
    public class PrimeiraExcessao {


        public static void Executar() {
            var conta = new Conta(1_234.45); // O metodo sacar é um método que pode causar um erro, sempre que o metodo pode gerar erro vc pode usar o try dizendo que tem que fazer isso se der erro chama o catch

            try {
                conta.Sacar(40000000000000000);
                Console.WriteLine("Retirada com Sucesso!");
            }
            catch (Exception ex) { //O exception trata o erro de forma genérica
                Console.WriteLine(ex.Message);
            }
            finally {// Executado em qualquer situação se o try dá sucesso, ele vai executar o finally seguida, e se der erro ele vai executar o catch e depois pular pra finally
                     //sempre será executado independente de erro ou sucesso
                Console.WriteLine("Obrigado!");
            }


            var conta2 = new Conta(4890); // O metodo sacar é um método que pode causar um erro, sempre que o metodo pode gerar erro vc pode usar o try dizendo que tem que fazer isso se der erro chama o catch

            try {
                //int.Parse("Abc");//forçando erro pra formatar o valor de int pra string
                conta.Sacar(345466);
                Console.WriteLine("Retirada com Sucesso!");
            }
            catch (ArgumentException ex) { // Argumetation é um retorno mais especifico, ele herda de Exception
                Console.WriteLine(ex.GetType().Name);//opcional, retornando o nome da classe
                Console.WriteLine(ex.Message);
            }
            finally {// Executado em qualquer situação se o try dá sucesso, ele vai executar o finally seguida, e se der erro ele vai executar o catch e depois pular pra finally
                     //sempre será executado independente de erro ou sucesso
                Console.WriteLine("Obrigado!");
            }

            //Resumo:
            //Catch tem que estar associado a um try
            //tryé um bloco que pode acontecer um erro.
            //se vc tiver fazendo uma conexão com o banco de dados e pode dar um erro, coloca dentro do try, usa lá o cacth pra tratar de fato o erro ou tentar novamente se for o caso
            //E associado a um try, vc pode ou não colocar um  que será executado em quaquer circunstancia
        }

    }

}

