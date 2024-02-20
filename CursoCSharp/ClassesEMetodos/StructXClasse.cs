using System;

namespace CursoCSharp.ClassesEMetodos {
    public struct StructExemplo {
        public int X;
        public int Y;
    }
    public class ClasseExemplo {
        public int X;
        public int Y;
    }
    public class StructXClasse {
        public static void Executar() {
            StructExemplo objetoStruct = new StructExemplo { X = 5, Y = 15 };//Instanciando objeto do tipo Struct
            StructExemplo copiaObjetoStruct = objetoStruct;//Instanciando objeto do tipo Struct que será uma cópia do objetoStruct
            objetoStruct.X = 31;
            objetoStruct.Y = 32;

            Console.WriteLine("STRUCT");
            //Após a atribuição, esses valores são iguais ou diferentes?Apontam para o mesmo espaço de memoria? Uma vez que eu fiz objetoStruct.X = 31 ele altera tando no objetoStruct.X quando na cópiaObjetoStruct.X?
            //Ou são valores independentes? A resposta é NÃO. Uma cópia é atribuída e uma vez que vc mexe, não gera efeito colateral no outro. Uma struct a passagem é sempre feita por valor e não por referência.
            Console.WriteLine("O objetoStruct X é {0}, Y {1} ", objetoStruct.X, objetoStruct.Y);
            Console.WriteLine("O copiaObjetoStruct X é {0}, Y {1} ", copiaObjetoStruct.X, copiaObjetoStruct.Y);

            Console.WriteLine("*********************************************************************************************");

            Console.WriteLine("CLASSE");//A unica coisa que mudou foi a palavra Struct para Classe
            //No caso da classe a passagem é por referência, ou seja, se eu alterar o objetoClasse.X, o copiaObjetoClasse.X também será alterado.
            ClasseExemplo objetoClasse = new ClasseExemplo { X = 5, Y = 15 };//Instanciando objeto do tipo Classe
            ClasseExemplo copiaObjetoClasse = objetoClasse;//Instanciando objeto do tipo Classe que será uma cópia do objetoClasse
            Console.WriteLine("O objetoClasse X é {0}, Y {1} ", objetoClasse.X, objetoClasse.Y);
            Console.WriteLine("O copiaObjetoClasse X é {0}, Y {1} ", copiaObjetoClasse.X, copiaObjetoClasse.Y);

        }
    }
}
