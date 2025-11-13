using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MapaDeTroco {

  public partial class FormPricipal : Form {

    private readonly List<Moeda> moedas;

    public FormPricipal() {
      InitializeComponent();
      moedas = new List<Moeda>();
      cbCedulasMoedas.Items.Add("Poucas Unidades");
      cbCedulasMoedas.Items.Add("Muitas Unidades");
    }

    private void CriaModedasEAddNaLista() {
      List<GroupBox> groupBoxes = Controls.OfType<GroupBox>().
        Where(gb => gb.Tag != null && gb.Tag.Equals("CbValoresEQuantidades")).ToList();
      moedas.Clear();
      foreach (GroupBox control in groupBoxes) {
          List<TextBox> textBoxes = control.Controls.OfType<TextBox>().ToList();
          foreach (TextBox textBox in textBoxes) {
            moedas.Add(new Moeda(Convert.ToDecimal(textBox.Tag), Convert.ToInt32(textBox.Text)));
          }
      }
    }

    private void Calcular() {
      lvTroco.Items.Clear();
      CriaModedasEAddNaLista();
      if (tbTroco.Text.Trim().Equals("")) {
        MessageBox.Show(@"Informe o valor do troco!");
        return;
      }
      Decimal valorTroco = Convert.ToDecimal(tbTroco.Text.Trim());
      Int32 idx = cbCedulasMoedas.SelectedIndex;

      List<Moeda> troco = idx == 0 ? CalculaTroco.CalculaTrocoMaisUnidades(valorTroco, moedas) : CalculaTroco.CalculaTrocoMenosUnidades(valorTroco, moedas);
      if (troco == null) {
        MessageBox.Show(@"Não há dinheiro suficiente no caixa para interar o troco");
        return;
      }
      foreach (Moeda valor in troco) {
        lvTroco.Items.Add(new ListViewItem(new[] { valor.Valor.ToString(), valor.Quantidade.ToString() }));
      }
    }

    private void btnCalcular_Click(object sender, EventArgs e) {
      Calcular();
    }
  }

}