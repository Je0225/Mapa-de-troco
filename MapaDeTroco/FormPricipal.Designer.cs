namespace MapaDeTroco
{
    partial class FormPricipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.gbCedulas = new System.Windows.Forms.GroupBox();
      this.tb200R = new System.Windows.Forms.TextBox();
      this.tb100R = new System.Windows.Forms.TextBox();
      this.tb50R = new System.Windows.Forms.TextBox();
      this.tb20R = new System.Windows.Forms.TextBox();
      this.tb10R = new System.Windows.Forms.TextBox();
      this.tb5R = new System.Windows.Forms.TextBox();
      this.tb2R = new System.Windows.Forms.TextBox();
      this.lbl2R = new System.Windows.Forms.Label();
      this.lbl200R = new System.Windows.Forms.Label();
      this.lbl20R = new System.Windows.Forms.Label();
      this.lbl10R = new System.Windows.Forms.Label();
      this.lbl50R = new System.Windows.Forms.Label();
      this.lbl5R = new System.Windows.Forms.Label();
      this.lbl100R = new System.Windows.Forms.Label();
      this.gbTroco = new System.Windows.Forms.GroupBox();
      this.lblCedulasMoedas = new System.Windows.Forms.Label();
      this.cbCedulasMoedas = new System.Windows.Forms.ComboBox();
      this.lvTroco = new System.Windows.Forms.ListView();
      this.clmCedulaMoeda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.clmQuantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.btnCalcular = new System.Windows.Forms.Button();
      this.tbTroco = new System.Windows.Forms.TextBox();
      this.lblValor = new System.Windows.Forms.Label();
      this.gbMoedas = new System.Windows.Forms.GroupBox();
      this.lbl1R = new System.Windows.Forms.Label();
      this.tb1R = new System.Windows.Forms.TextBox();
      this.tb1C = new System.Windows.Forms.TextBox();
      this.lbl1C = new System.Windows.Forms.Label();
      this.lbl0025C = new System.Windows.Forms.Label();
      this.tb0050C = new System.Windows.Forms.TextBox();
      this.tb0025C = new System.Windows.Forms.TextBox();
      this.tb0010C = new System.Windows.Forms.TextBox();
      this.tb005C = new System.Windows.Forms.TextBox();
      this.lbl005C = new System.Windows.Forms.Label();
      this.lbl0050C = new System.Windows.Forms.Label();
      this.lbl0010C = new System.Windows.Forms.Label();
      this.gbCedulas.SuspendLayout();
      this.gbTroco.SuspendLayout();
      this.gbMoedas.SuspendLayout();
      this.SuspendLayout();
      // 
      // gbCedulas
      // 
      this.gbCedulas.Controls.Add(this.tb200R);
      this.gbCedulas.Controls.Add(this.tb100R);
      this.gbCedulas.Controls.Add(this.tb50R);
      this.gbCedulas.Controls.Add(this.tb20R);
      this.gbCedulas.Controls.Add(this.tb10R);
      this.gbCedulas.Controls.Add(this.tb5R);
      this.gbCedulas.Controls.Add(this.tb2R);
      this.gbCedulas.Controls.Add(this.lbl2R);
      this.gbCedulas.Controls.Add(this.lbl200R);
      this.gbCedulas.Controls.Add(this.lbl20R);
      this.gbCedulas.Controls.Add(this.lbl10R);
      this.gbCedulas.Controls.Add(this.lbl50R);
      this.gbCedulas.Controls.Add(this.lbl5R);
      this.gbCedulas.Controls.Add(this.lbl100R);
      this.gbCedulas.Location = new System.Drawing.Point(15, 7);
      this.gbCedulas.Name = "gbCedulas";
      this.gbCedulas.Size = new System.Drawing.Size(376, 106);
      this.gbCedulas.TabIndex = 0;
      this.gbCedulas.TabStop = false;
      this.gbCedulas.Tag = "CbValoresEQuantidades";
      this.gbCedulas.Text = "Cédulas";
      // 
      // tb200R
      // 
      this.tb200R.Location = new System.Drawing.Point(53, 71);
      this.tb200R.Name = "tb200R";
      this.tb200R.Size = new System.Drawing.Size(76, 20);
      this.tb200R.TabIndex = 6;
      this.tb200R.Tag = "200,00";
      this.tb200R.Text = "0";
      this.tb200R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // tb100R
      // 
      this.tb100R.Location = new System.Drawing.Point(289, 45);
      this.tb100R.Name = "tb100R";
      this.tb100R.Size = new System.Drawing.Size(76, 20);
      this.tb100R.TabIndex = 5;
      this.tb100R.Tag = "100,00";
      this.tb100R.Text = "0";
      this.tb100R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // tb50R
      // 
      this.tb50R.Location = new System.Drawing.Point(169, 45);
      this.tb50R.Name = "tb50R";
      this.tb50R.Size = new System.Drawing.Size(76, 20);
      this.tb50R.TabIndex = 4;
      this.tb50R.Tag = "50,00";
      this.tb50R.Text = "0";
      this.tb50R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // tb20R
      // 
      this.tb20R.Location = new System.Drawing.Point(53, 45);
      this.tb20R.Name = "tb20R";
      this.tb20R.Size = new System.Drawing.Size(76, 20);
      this.tb20R.TabIndex = 3;
      this.tb20R.Tag = "20,00";
      this.tb20R.Text = "0";
      this.tb20R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // tb10R
      // 
      this.tb10R.Location = new System.Drawing.Point(289, 19);
      this.tb10R.Name = "tb10R";
      this.tb10R.Size = new System.Drawing.Size(76, 20);
      this.tb10R.TabIndex = 2;
      this.tb10R.Tag = "10,00";
      this.tb10R.Text = "0";
      this.tb10R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // tb5R
      // 
      this.tb5R.Location = new System.Drawing.Point(169, 19);
      this.tb5R.Name = "tb5R";
      this.tb5R.Size = new System.Drawing.Size(76, 20);
      this.tb5R.TabIndex = 1;
      this.tb5R.Tag = "5,00";
      this.tb5R.Text = "0";
      this.tb5R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // tb2R
      // 
      this.tb2R.Location = new System.Drawing.Point(53, 19);
      this.tb2R.Name = "tb2R";
      this.tb2R.Size = new System.Drawing.Size(76, 20);
      this.tb2R.TabIndex = 0;
      this.tb2R.Tag = "2,00";
      this.tb2R.Text = "0";
      this.tb2R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // lbl2R
      // 
      this.lbl2R.Location = new System.Drawing.Point(14, 22);
      this.lbl2R.Name = "lbl2R";
      this.lbl2R.Size = new System.Drawing.Size(35, 13);
      this.lbl2R.TabIndex = 8;
      this.lbl2R.Tag = "";
      this.lbl2R.Text = "2,00";
      this.lbl2R.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lbl200R
      // 
      this.lbl200R.Location = new System.Drawing.Point(5, 74);
      this.lbl200R.Name = "lbl200R";
      this.lbl200R.Size = new System.Drawing.Size(44, 13);
      this.lbl200R.TabIndex = 7;
      this.lbl200R.Tag = "";
      this.lbl200R.Text = "200,00";
      this.lbl200R.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lbl20R
      // 
      this.lbl20R.Location = new System.Drawing.Point(14, 48);
      this.lbl20R.Name = "lbl20R";
      this.lbl20R.Size = new System.Drawing.Size(35, 13);
      this.lbl20R.TabIndex = 6;
      this.lbl20R.Tag = "";
      this.lbl20R.Text = "20,00";
      this.lbl20R.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lbl10R
      // 
      this.lbl10R.Location = new System.Drawing.Point(251, 22);
      this.lbl10R.Name = "lbl10R";
      this.lbl10R.Size = new System.Drawing.Size(35, 13);
      this.lbl10R.TabIndex = 5;
      this.lbl10R.Tag = "";
      this.lbl10R.Text = "10,00";
      this.lbl10R.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lbl50R
      // 
      this.lbl50R.Location = new System.Drawing.Point(132, 48);
      this.lbl50R.Name = "lbl50R";
      this.lbl50R.Size = new System.Drawing.Size(35, 13);
      this.lbl50R.TabIndex = 4;
      this.lbl50R.Tag = "";
      this.lbl50R.Text = "50,00";
      this.lbl50R.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lbl5R
      // 
      this.lbl5R.Location = new System.Drawing.Point(132, 22);
      this.lbl5R.Name = "lbl5R";
      this.lbl5R.Size = new System.Drawing.Size(35, 13);
      this.lbl5R.TabIndex = 3;
      this.lbl5R.Tag = "";
      this.lbl5R.Text = "5,00";
      this.lbl5R.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lbl100R
      // 
      this.lbl100R.Location = new System.Drawing.Point(245, 48);
      this.lbl100R.Name = "lbl100R";
      this.lbl100R.Size = new System.Drawing.Size(41, 13);
      this.lbl100R.TabIndex = 2;
      this.lbl100R.Tag = "";
      this.lbl100R.Text = "100,00";
      this.lbl100R.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // gbTroco
      // 
      this.gbTroco.Controls.Add(this.lblCedulasMoedas);
      this.gbTroco.Controls.Add(this.cbCedulasMoedas);
      this.gbTroco.Controls.Add(this.lvTroco);
      this.gbTroco.Controls.Add(this.btnCalcular);
      this.gbTroco.Controls.Add(this.tbTroco);
      this.gbTroco.Controls.Add(this.lblValor);
      this.gbTroco.Location = new System.Drawing.Point(15, 195);
      this.gbTroco.Name = "gbTroco";
      this.gbTroco.Size = new System.Drawing.Size(376, 251);
      this.gbTroco.TabIndex = 1;
      this.gbTroco.TabStop = false;
      this.gbTroco.Text = "Troco";
      // 
      // lblCedulasMoedas
      // 
      this.lblCedulasMoedas.Location = new System.Drawing.Point(165, 23);
      this.lblCedulasMoedas.Name = "lblCedulasMoedas";
      this.lblCedulasMoedas.Size = new System.Drawing.Size(88, 13);
      this.lblCedulasMoedas.TabIndex = 31;
      this.lblCedulasMoedas.Text = "Cédulas/Moedas";
      this.lblCedulasMoedas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // cbCedulasMoedas
      // 
      this.cbCedulasMoedas.FormattingEnabled = true;
      this.cbCedulasMoedas.Location = new System.Drawing.Point(253, 19);
      this.cbCedulasMoedas.Name = "cbCedulasMoedas";
      this.cbCedulasMoedas.Size = new System.Drawing.Size(112, 21);
      this.cbCedulasMoedas.TabIndex = 30;
      // 
      // lvTroco
      // 
      this.lvTroco.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmCedulaMoeda,
            this.clmQuantidade});
      this.lvTroco.HideSelection = false;
      this.lvTroco.Location = new System.Drawing.Point(19, 49);
      this.lvTroco.Name = "lvTroco";
      this.lvTroco.Size = new System.Drawing.Size(267, 190);
      this.lvTroco.TabIndex = 29;
      this.lvTroco.UseCompatibleStateImageBehavior = false;
      this.lvTroco.View = System.Windows.Forms.View.Details;
      // 
      // clmCedulaMoeda
      // 
      this.clmCedulaMoeda.Text = "Cédula/Moeda";
      this.clmCedulaMoeda.Width = 107;
      // 
      // clmQuantidade
      // 
      this.clmQuantidade.Text = "Quantidade";
      this.clmQuantidade.Width = 125;
      // 
      // btnCalcular
      // 
      this.btnCalcular.Location = new System.Drawing.Point(292, 48);
      this.btnCalcular.Name = "btnCalcular";
      this.btnCalcular.Size = new System.Drawing.Size(73, 23);
      this.btnCalcular.TabIndex = 1;
      this.btnCalcular.Text = "Calcular";
      this.btnCalcular.UseVisualStyleBackColor = true;
      this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
      // 
      // tbTroco
      // 
      this.tbTroco.Location = new System.Drawing.Point(53, 20);
      this.tbTroco.Name = "tbTroco";
      this.tbTroco.Size = new System.Drawing.Size(104, 20);
      this.tbTroco.TabIndex = 0;
      this.tbTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // lblValor
      // 
      this.lblValor.Location = new System.Drawing.Point(16, 23);
      this.lblValor.Name = "lblValor";
      this.lblValor.Size = new System.Drawing.Size(35, 13);
      this.lblValor.TabIndex = 26;
      this.lblValor.Text = "Valor";
      this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // gbMoedas
      // 
      this.gbMoedas.Controls.Add(this.lbl1R);
      this.gbMoedas.Controls.Add(this.tb1R);
      this.gbMoedas.Controls.Add(this.tb1C);
      this.gbMoedas.Controls.Add(this.lbl1C);
      this.gbMoedas.Controls.Add(this.lbl0025C);
      this.gbMoedas.Controls.Add(this.tb0050C);
      this.gbMoedas.Controls.Add(this.tb0025C);
      this.gbMoedas.Controls.Add(this.tb0010C);
      this.gbMoedas.Controls.Add(this.tb005C);
      this.gbMoedas.Controls.Add(this.lbl005C);
      this.gbMoedas.Controls.Add(this.lbl0050C);
      this.gbMoedas.Controls.Add(this.lbl0010C);
      this.gbMoedas.Location = new System.Drawing.Point(15, 115);
      this.gbMoedas.Name = "gbMoedas";
      this.gbMoedas.Size = new System.Drawing.Size(376, 77);
      this.gbMoedas.TabIndex = 1;
      this.gbMoedas.TabStop = false;
      this.gbMoedas.Tag = "CbValoresEQuantidades";
      this.gbMoedas.Text = "Moedas";
      // 
      // lbl1R
      // 
      this.lbl1R.Location = new System.Drawing.Point(252, 47);
      this.lbl1R.Name = "lbl1R";
      this.lbl1R.Size = new System.Drawing.Size(35, 13);
      this.lbl1R.TabIndex = 26;
      this.lbl1R.Tag = "";
      this.lbl1R.Text = "1,00";
      this.lbl1R.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // tb1R
      // 
      this.tb1R.Location = new System.Drawing.Point(289, 44);
      this.tb1R.Name = "tb1R";
      this.tb1R.Size = new System.Drawing.Size(76, 20);
      this.tb1R.TabIndex = 5;
      this.tb1R.Tag = "1,00";
      this.tb1R.Text = "0";
      this.tb1R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // tb1C
      // 
      this.tb1C.Location = new System.Drawing.Point(53, 18);
      this.tb1C.Name = "tb1C";
      this.tb1C.Size = new System.Drawing.Size(76, 20);
      this.tb1C.TabIndex = 0;
      this.tb1C.Tag = "00,01";
      this.tb1C.Text = "0";
      this.tb1C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // lbl1C
      // 
      this.lbl1C.Location = new System.Drawing.Point(16, 21);
      this.lbl1C.Name = "lbl1C";
      this.lbl1C.Size = new System.Drawing.Size(35, 13);
      this.lbl1C.TabIndex = 24;
      this.lbl1C.Tag = "";
      this.lbl1C.Text = "0,01";
      this.lbl1C.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lbl0025C
      // 
      this.lbl0025C.Location = new System.Drawing.Point(16, 47);
      this.lbl0025C.Name = "lbl0025C";
      this.lbl0025C.Size = new System.Drawing.Size(35, 13);
      this.lbl0025C.TabIndex = 18;
      this.lbl0025C.Tag = "";
      this.lbl0025C.Text = "0,25";
      this.lbl0025C.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // tb0050C
      // 
      this.tb0050C.Location = new System.Drawing.Point(169, 44);
      this.tb0050C.Name = "tb0050C";
      this.tb0050C.Size = new System.Drawing.Size(76, 20);
      this.tb0050C.TabIndex = 4;
      this.tb0050C.Tag = "00,50";
      this.tb0050C.Text = "0";
      this.tb0050C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // tb0025C
      // 
      this.tb0025C.Location = new System.Drawing.Point(53, 44);
      this.tb0025C.Name = "tb0025C";
      this.tb0025C.Size = new System.Drawing.Size(76, 20);
      this.tb0025C.TabIndex = 3;
      this.tb0025C.Tag = "00,25";
      this.tb0025C.Text = "0";
      this.tb0025C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // tb0010C
      // 
      this.tb0010C.Location = new System.Drawing.Point(289, 18);
      this.tb0010C.Name = "tb0010C";
      this.tb0010C.Size = new System.Drawing.Size(76, 20);
      this.tb0010C.TabIndex = 2;
      this.tb0010C.Tag = "00,10";
      this.tb0010C.Text = "0";
      this.tb0010C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // tb005C
      // 
      this.tb005C.Location = new System.Drawing.Point(169, 18);
      this.tb005C.Name = "tb005C";
      this.tb005C.Size = new System.Drawing.Size(76, 20);
      this.tb005C.TabIndex = 1;
      this.tb005C.Tag = "00,05";
      this.tb005C.Text = "0";
      this.tb005C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // lbl005C
      // 
      this.lbl005C.Location = new System.Drawing.Point(132, 22);
      this.lbl005C.Name = "lbl005C";
      this.lbl005C.Size = new System.Drawing.Size(35, 13);
      this.lbl005C.TabIndex = 20;
      this.lbl005C.Tag = "";
      this.lbl005C.Text = "0,05";
      this.lbl005C.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lbl0050C
      // 
      this.lbl0050C.Location = new System.Drawing.Point(132, 47);
      this.lbl0050C.Name = "lbl0050C";
      this.lbl0050C.Size = new System.Drawing.Size(35, 13);
      this.lbl0050C.TabIndex = 19;
      this.lbl0050C.Tag = "";
      this.lbl0050C.Text = "0,50";
      this.lbl0050C.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lbl0010C
      // 
      this.lbl0010C.Location = new System.Drawing.Point(252, 22);
      this.lbl0010C.Name = "lbl0010C";
      this.lbl0010C.Size = new System.Drawing.Size(35, 13);
      this.lbl0010C.TabIndex = 16;
      this.lbl0010C.Tag = "";
      this.lbl0010C.Text = "0,10";
      this.lbl0010C.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // FormPricipal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(405, 455);
      this.Controls.Add(this.gbMoedas);
      this.Controls.Add(this.gbTroco);
      this.Controls.Add(this.gbCedulas);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormPricipal";
      this.Text = "Mapa de Troco";
      this.gbCedulas.ResumeLayout(false);
      this.gbCedulas.PerformLayout();
      this.gbTroco.ResumeLayout(false);
      this.gbTroco.PerformLayout();
      this.gbMoedas.ResumeLayout(false);
      this.gbMoedas.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCedulas;
        private System.Windows.Forms.GroupBox gbTroco;
        private System.Windows.Forms.GroupBox gbMoedas;
        private System.Windows.Forms.TextBox tb2R;
        private System.Windows.Forms.TextBox tb200R;
        private System.Windows.Forms.TextBox tb100R;
        private System.Windows.Forms.TextBox tb50R;
        private System.Windows.Forms.TextBox tb20R;
        private System.Windows.Forms.TextBox tb10R;
        private System.Windows.Forms.TextBox tb5R;
        private System.Windows.Forms.Label lbl2R;
        private System.Windows.Forms.Label lbl200R;
        private System.Windows.Forms.Label lbl20R;
        private System.Windows.Forms.Label lbl10R;
        private System.Windows.Forms.Label lbl50R;
        private System.Windows.Forms.Label lbl5R;
        private System.Windows.Forms.Label lbl100R;
        private System.Windows.Forms.TextBox tb0050C;
        private System.Windows.Forms.TextBox tb0025C;
        private System.Windows.Forms.TextBox tb0010C;
        private System.Windows.Forms.TextBox tb005C;
        private System.Windows.Forms.Label lbl005C;
        private System.Windows.Forms.Label lbl0050C;
        private System.Windows.Forms.Label lbl0025C;
        private System.Windows.Forms.Label lbl0010C;
        private System.Windows.Forms.ListView lvTroco;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox tbTroco;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ColumnHeader clmCedulaMoeda;
        private System.Windows.Forms.ColumnHeader clmQuantidade;
        private System.Windows.Forms.TextBox tb1C;
        private System.Windows.Forms.Label lbl1C;
        private System.Windows.Forms.Label lbl1R;
        private System.Windows.Forms.TextBox tb1R;
        private System.Windows.Forms.Label lblCedulasMoedas;
        private System.Windows.Forms.ComboBox cbCedulasMoedas;
    }
}

