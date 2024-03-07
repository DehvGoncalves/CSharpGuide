using System;
using System.Collections.Generic;


namespace CursoCSharp.OO {
    public sealed class SemFilho {
        public double ValorDaFortuna() {
            return 1_407_033.65;
        }
    }
    //class SouFilho : SemFilho {

    //}
    public class Avo {
        public virtual bool HonrarNomeFamilia() {
            return true;
        }
    }
    public class Pai : Avo {//Vamos supor que o pai é mais durão e fala que os filhos não tem escolha eles obrigatoriamente precisam honrar a familia.
        //Então ele pega o método que foi marcado como virtual e que pode ser sobrescrito, lembrando que só faz sentido usar o sealed quando método é marcado como
        //virtual, pq vc está fazendo justamente o contrário do virtual, o virtual permite a sobrescrita e o sealed não permite.
        //Overriade sealed que significa que vc está selando esse método pra que ele não seja mudado em hipotese alguma, e com isso obrigatóriamente todo mundo
        //tem que colocar o valor como true, ou seja todos que estão abaixo do pai, vai herdar esse método e a implementação será essa.
        public sealed override bool HonrarNomeFamilia() {
            return true;
        }

    }
    public class FilhoRebelde : Pai {
        //public sealed override bool HonrarNomeFamilia() {//tentando substituir o valor selado na classe pai, o código não permite pois foi selado na linha 24, obrigatoriamente deve ser true
        //    
        //    return false;
        //}
        //uma forma de burlar que não vai sobrescrever mas vai ocultar o outro método e vc chamar um novo new, não é possivel sobrescrever

    }
    public class Sealed {
        public static void Executar() {
            SemFilho semFilho1 = new SemFilho();
            Console.WriteLine(semFilho1.ValorDaFortuna());

            FilhoRebelde filhorebelde1 = new FilhoRebelde();
            Console.WriteLine(filhorebelde1.HonrarNomeFamilia());

        }
    }
}
