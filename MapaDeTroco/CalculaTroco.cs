using System;
using System.Collections.Generic;
using System.Linq;

namespace MapaDeTroco {

    public static class CalculaTroco {

        public static List<Moeda> CalculaTrocoMaisUnidades(Decimal valorTroco, List<Moeda> caixa) {
            caixa = caixa.OrderByDescending(moeda => moeda.Valor).ToList();
            List<Moeda> troco = new List<Moeda>();
            Decimal valor = 0;
            Decimal diferenca = valorTroco;
            Int32 qtd = 0;

            for (int i = 0; i < caixa.Count && diferenca != 0; i++) {
                while (caixa[i].Valor <= diferenca && caixa[i].Quantidade > 0) {
                    valor += caixa[i].Valor;
                    qtd++;
                    caixa[i].Quantidade = caixa[i].Quantidade - 1;
                    diferenca = valorTroco - valor;
                }
                if (qtd > 0) {
                    troco.Add(new Moeda(caixa[i].Valor, qtd));
                    qtd = 0;
                }
            }
            if (valorTroco != valor) {
                return null;
            }
            return troco;
        } 

        public static List<Moeda> CalculaTrocoMenosUnidades(Decimal valorTroco, List<Moeda> caixa) {
            caixa = caixa.OrderByDescending(Moeda => Moeda.Valor).ToList();
            List<Moeda> troco = new List<Moeda>();
            Decimal valor = 0;
            Decimal diferenca = valorTroco;
            
            for (int i = caixa.Count - 1; i >= 0; i--) {
                Int32 qtd = 0;
                while ((caixa[i].Valor <= diferenca) && caixa[i].Quantidade > 0) {
                    valor += caixa[i].Valor;
                    qtd++;
                    diferenca = valorTroco - valor;
                    caixa[i].Quantidade -= 1;
                }
                if (qtd > 0) {
                    troco.Add(new Moeda(caixa[i].Valor, qtd));
                }
                if (diferenca != 0 && caixa[i].Valor > diferenca && caixa[i].Quantidade > 0) {
                    if (troco[troco.Count - 1].Valor == caixa[i].Valor) {
                        troco.RemoveAt(troco.Count - 1);
                    }
                    qtd++;
                    troco.Add(new Moeda(caixa[i].Valor, qtd));
                    valor += caixa[i].Valor;
                    diferenca = valor - valorTroco;
                    caixa[i].Quantidade -= 1;
                    break;
                }
            }
            if (valor > valorTroco) {
                for (int i = troco.Count - 1; i >= 0 && diferenca != 0; i--) {
                    while (troco[i].Valor <= diferenca && troco[i].Quantidade > 0) {
                        diferenca -= troco[i].Valor;
                        valor -= troco[i].Valor;
                        troco[i].Quantidade -= 1;
                        if (troco[i].Quantidade == 0) {
                            troco.RemoveAt(i);
                        }
                    }
                }
            }
            return valor != valorTroco ? null : troco;
        }

    }

}