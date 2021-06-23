using System;

namespace EstruturaDoPrograma { /*deve ser o nome da pasta onde ele esta*/

    public class Pilha {

        Posicao primeiro;

        public void Empilha(object item) { /*metodo passa um objeto */

            primeiro = new Posicao(primeiro, item); /*toda ver que passa o objeto, instancia*/
        }

        public object Desempilha() {

            if (primeiro == null) {

                throw new InvalidOperationException("A pilha está vazia!"); /*qualquer falha que acontecer vai disparar um erro*/
            }

            object resultado = primeiro.item;
            primeiro = primeiro.proximo;
            return resultado;
        }

        class Posicao {

            public Posicao proximo;

            public object item;

            public Posicao(Posicao proximo, object item) {

                this.proximo = proximo;
                this.item = item;
            }
        }


    }
}