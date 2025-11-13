using System;

namespace MapaDeTroco {

    public class Moeda {

        public Decimal Valor { get; set; }

        public Int32 Quantidade { get; set; }

        public Moeda(Decimal valor, Int32 quantidade) {
            Valor = valor;
            Quantidade = quantidade;
        }

    }

}