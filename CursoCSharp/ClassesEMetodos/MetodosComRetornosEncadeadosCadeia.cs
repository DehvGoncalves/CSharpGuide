namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraCadeia
    {
        int memoria;

        /* Este método Somar, recebe um número inteiro 'a' e o adiciona à variável 'memoria' (definida na classe).
         Em seguida, ele retorna a instância atual da classe (this), Isso permite encadear chamadas de método, ou seja, chamar outro método diretamente após este, na mesma linha de código.
        */
        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }

        // Este método subtrai o número inteiro 'a' da variável 'memoria'.
        // Retorna a instância atual da classe (this), permitindo chamadas encadeadas de métodos.
        public CalculadoraCadeia Subtrair(int a)
        {
            memoria -= a;
            return this;
        }

        // Este método multiplica a variável 'memoria' pelo número inteiro 'a'.
        // Retorna a instância atual da classe (this), permitindo chamadas encadeadas de métodos.
        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        // Este método divide a variável 'memoria' pelo número inteiro 'a'.
        // Retorna a instância atual da classe (this), permitindo chamadas encadeadas de métodos.
        public CalculadoraCadeia Dividir(int a)
        {
            memoria /= a;
            return this;
        }

        // Este método redefine a variável 'memoria' para 0.
        // Retorna a instância atual da classe (this), permitindo chamadas encadeadas de métodos.
        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        // Este método imprime o valor atual da variável 'memoria'.
        // Retorna a instância atual da classe (this), permitindo chamadas encadeadas de métodos.
        public CalculadoraCadeia Imprimir()
        {
            System.Console.WriteLine(memoria);
            return this;
        }

        // Este método retorna o valor atual da variável 'memoria'.
        public int Resultado()
        {
            return memoria;
        }

        // Este método estático é usado para demonstrar a funcionalidade da classe.
        // Ele cria uma instância da classe, encadeia algumas chamadas de método e imprime o resultado.
        public static void Executar()
        {
            var calculadora = new CalculadoraCadeia();
            //calculadora.Somar(2).Multiplicar(5).Dividir(2).Imprimir().Limpar().Imprimir();
            calculadora.Somar(4);
            calculadora.Imprimir();
            Console.WriteLine("*****");

            calculadora.Subtrair(2);
            calculadora.Imprimir();
            Console.WriteLine("Limpando os dados salvos");
            calculadora.Limpar().Imprimir();
            Console.WriteLine("Agora, estou passando Somar como 5 e subtrair como 4");

            calculadora.Somar(5).Subtrair(4).Imprimir();
            Console.WriteLine("*****");

            calculadora.Somar(4).Multiplicar(5).Dividir(2).Imprimir().Limpar().Imprimir();

        }
    }
}
