using System;
using System.Security.Cryptography.X509Certificates;

namespace CursoCSharp
{
    internal class Atalhos
    {
        public static void ConfigurarAtalhos()
        {
            Console.WriteLine("CONFIGURANDO ATALHOS no Visual Estudio");
            Console.WriteLine("Ferramentas>Opções>Ambiente>Teclado");
        }

        public static void AtalhosComentarios()
        {
            Console.WriteLine("ATALHO  PARA COMENTÁRIOS: Selecionar as linhas, Ctrl K + C para COMENTAR");
            Console.WriteLine("                          Selecionar as linhas, Ctrl K + U para DESCOMENTAR");
        }
        public static void AtalhoFormatarCodigo()
        {
            Console.WriteLine("ATALHO PARA FORMARAR CÓDIGO: Ctrl + K + D");
        }
      public static void Executar(){//Metodo retornado na classe Program.cs
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("Parece que você está em busca de atalhos, né? 😜");
            Console.WriteLine("Fique à vontade para pegar o que precisar, como se estivesse em uma cafeteria. ☕");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine();
            ConfigurarAtalhos();
            Console.WriteLine();
            AtalhosComentarios();
            Console.WriteLine();
            AtalhoFormatarCodigo();

        }
    }
}
