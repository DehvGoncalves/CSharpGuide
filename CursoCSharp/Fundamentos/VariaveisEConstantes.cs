using System;
using System.Drawing;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            /*Em C#, temos várias formas de declarar variáveis. A escolha depende do contexto e da preferência do desenvolvedor.*/

            /*Var (Inferência de Tipo):
            Permite que o compilador determine automaticamente o tipo da variável com base no valor atribuído.*/
            var idadeInferida = 25;
            var salarioInferido = 3000.50;
            var nomeInferido = "João";

            // Declaração Simples:
            int idade;
            double salario;

            // Declaração e Inicialização em uma Linha:
            int idadeInicial = 25;
            string nomeInicial = "João";

            // Declaração de Múltiplas Variáveis:
            int x, y, z;

            // Atribuição de Valor Padrão:
            int idadePadrao = default;
            double salarioPadrao = default;

            //Tipos internos:
            bool estaChovendo = true;
            bool estaComSol = false;

            //Tipos numericos:
            sbyte saldoDeGols = sbyte.MinValue; //Vai até 8 bits, vai de -128 a 127, menor valor 
            byte idadeUm = 45; //Tem capacidade pra um unico Byte que é 8 bits, vai de 0 a 255
            short idadeDois = 9834; //Vai até 16 bits, e assim por diante, vai de 0 a 65535
            int idadeNumerica = 35;//Tem capacidade pra 32 bits, vai de 0 a 4.294.967.295

            /*Constantes:
            Declaração de uma constante cujo valor NÃO pode ser alterado após a inicialização.*/
            const double Pi = 3.14; // O valor não pode ser alterado
            double raio = 4.5; // O valor pode ser alterado
            double area;
            area = Pi * raio * raio;


            // Exibição do resultado
            Console.WriteLine($"Para um raio de {raio}, a área é {area}");

            // Exemplo de variável do tipo string
            string mensagem = "Curso de C#"; // Pode ser alterada
            Console.WriteLine($"Bem-vindo ao {mensagem}");
        }
    }
}
