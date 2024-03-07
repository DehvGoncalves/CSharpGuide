using System;


namespace CursoCSharp.MetodosEFuncoes {
    public class UsandoDelegate {

        //Dois delegates qualquer
        delegate double Soma(double a, double b); //Deletgate Soma, com retorno parâmetros  Double
        delegate void ImprimirSoma(double a, double b); //Delegate sem retorno, com parametros double  (


        //Funções sem ligação com Delegate
        static double MinhaSoma(double x, double y) {  //Método comum com retorno
            return x + y;
        }

        static void MeuImprimorSoma(double a, double b) {
            Console.WriteLine(a + b);
        }
        public static void Executar() {//Vc pode pegar funções pré existentes e associar a delegates, só precisa ter uma compatibilidade entre as assinaturas, tipo, qtd de parametros e ordem

            // Associando um método a um delegate chamado Soma
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2, 5));

            // Associando um método a um delegate chamado ImprimirSoma
            ImprimirSoma op2 = MeuImprimorSoma;
            op2(5.3, 8);

            // Criando um delegate Func<double, double, double> e associando a um método MinhaSoma
            // Func<double, double, double> representa um método que recebe dois parâmetros do tipo double e retorna um double
            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(2.4, 45.3));

            // Criando um delegate Action<double, double> e associando a um método MeuImprimorSoma
            // Action<double, double> representa um método que recebe dois parâmetros do tipo double e não retorna nada (void)
            Action<double, double> op4 = MeuImprimorSoma;
            op4(7.7, 34.4);
        }
    }
}
