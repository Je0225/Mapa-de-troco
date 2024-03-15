using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MapaDeTroco {

    public partial class FormPricipal: Form {

        private readonly List<Moeda> und;
        private List<TextBox> tbs;

        public FormPricipal() {
            InitializeComponent();
            und = new List<Moeda>();
            cbCedulasMoedas.Items.Add("Poucas Unidades");
            cbCedulasMoedas.Items.Add("Muitas Unidades");
            tbs = new List<TextBox>();
        }

        private void btnCalcular_Click(object sender, EventArgs e) {
            und.Clear();
            lvTroco.Items.Clear();

            und.Add(new Moeda(Convert.ToDecimal(lbl0025C.Text), Convert.ToInt32(tb0025C.Text)));
            und.Add(new Moeda(Convert.ToDecimal(lbl0050C.Text), Convert.ToInt32(tb0050C.Text)));
            und.Add(new Moeda(Convert.ToDecimal(lbl1C.Text), Convert.ToInt32(tb1C.Text)));
            und.Add(new Moeda(Convert.ToDecimal(lbl0010C.Text), Convert.ToInt32(tb0010C.Text)));
            und.Add(new Moeda(Convert.ToDecimal(lbl1R.Text), Convert.ToInt32(tb1R.Text)));
            und.Add(new Moeda(Convert.ToDecimal(lbl100R.Text), Convert.ToInt32(tb100R.Text)));
            und.Add(new Moeda(Convert.ToDecimal(lbl005C.Text), Convert.ToInt32(tb005C.Text)));

            und.Add(new Moeda(Convert.ToDecimal(lbl50R.Text), Convert.ToInt32(tb50R.Text)));
            und.Add(new Moeda(Convert.ToDecimal(lbl200R.Text), Convert.ToInt32(tb200R.Text)));
            und.Add(new Moeda(Convert.ToDecimal(lbl2R.Text), Convert.ToInt32(tb2R.Text)));
            und.Add(new Moeda(Convert.ToDecimal(lbl5R.Text), Convert.ToInt32(tb5R.Text)));
            und.Add(new Moeda(Convert.ToDecimal(lbl10R.Text), Convert.ToInt32(tb10R.Text)));
            und.Add(new Moeda(Convert.ToDecimal(lbl20R.Text), Convert.ToInt32(tb20R.Text)));

            List<Moeda> caixa = und.OrderByDescending(Moeda => Moeda.Valor).ToList();
            List<Moeda> troco = new List<Moeda>();

            // usando a maior quantidade de cedulas/moedas possiveis para troco
             Decimal valorTroco = Convert.ToDecimal(tbTroco.Text);
            Decimal valor = 0;
            Decimal diferenca = valorTroco;
            Int32 qtd = 0;
            Int32 idx = cbCedulasMoedas.SelectedIndex;

            if (idx == 0) {
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
                    MessageBox.Show("Não há dinheiro suficiente no caixa para interar o troco");
                } else {
                    AddItemsListView(troco);
                }
            }

            // usando a maior quantidade de cedulas/moedas possivel para troco
            if (idx == 1) {
                for (int i = caixa.Count - 1; i >= 0; i--) {
                    qtd = 0;
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
                if (valor != valorTroco) {
                    MessageBox.Show("Não há dinheiro suficiente no caixa para interar o troco");
                } else {
                    AddItemsListView(troco);
                }
            }
        }

        private void AddItemsListView(List<Moeda> undds) {
            foreach (Moeda m in undds) {
                lvTroco.Items.Add(new ListViewItem(new[] { m.Valor.ToString(), m.Quantidade.ToString() }));
            }
        }

    }

}