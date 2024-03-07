using System;
using System.Collections.Generic;


namespace CursoCSharp.OO {
    //quando vc tem o conceito abstrato que vc não quer que tenha possibilidade de haver uma instanciação de uma determinada classe, vc pode marcar ela como abstrara.
    //Objetivos de ter uma classe abstrata:
    //Você só tem uma classe abstrata quando vc tem alguma classe que herde dessa classe e ai sim, essa classe que herda é do tipo concreto e você pode usar o polimorfismo pra celular = iphone, celular recebe motorola e etc 
    //Uma classe abstrata pode ou não ter métodos abstratos, que não tem corpo
    public abstract class Celular {
        public abstract string Assistente();//Se alguma classe herdar de celular e essa classe for concreta, obrigatóriamente esse método precisa estar implementado

        public string Tocar() {//Método concreto
            return "Trim trim trim";
        }
    }
    public class Samsung : Celular {
        public override string Assistente() {//como Sansung é classe concreta, precisei implementar de forma obrigatória o método abstrato
            return "Olá! Meuno nome é Buxby";
        }
    }
    public class Iphone : Celular {
        public override string Assistente() {
            return "Olá! Meu nome é Siri";
        }
    }
    public class Abstract {
        public static void Executar() {
            //Celular c = new Celular(); //Consigo instanciar assim caso a classe do tipo, não seja abstrata, a partir do momento que vc instancia, está dando vida a uma classe
            //instanciando objeto daquele tipo. Você só consegue instanciar objetos em classes concretas

            var Celulares = new List<Celular> {
                new Iphone(),
                new Samsung()
        };
            foreach (var celular in Celulares) {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
