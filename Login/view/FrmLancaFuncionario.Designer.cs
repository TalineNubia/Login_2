namespace Login.view
{
    partial class FrmLancaFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLancaFuncionario));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtnObs = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.txtnValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnFuncionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnData = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbCondominio = new System.Windows.Forms.ComboBox();
            this.txtnCOD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDespesas = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtnVencimento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCodvd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnData2 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtnObs);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(340, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 156);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Observação";
            // 
            // txtnObs
            // 
            this.txtnObs.Location = new System.Drawing.Point(6, 21);
            this.txtnObs.Multiline = true;
            this.txtnObs.Name = "txtnObs";
            this.txtnObs.Size = new System.Drawing.Size(425, 129);
            this.txtnObs.TabIndex = 10;
            this.txtnObs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnObs_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btConsultar);
            this.groupBox1.Controls.Add(this.btExcluir);
            this.groupBox1.Controls.Add(this.btCancelar);
            this.groupBox1.Controls.Add(this.btSalvar);
            this.groupBox1.Location = new System.Drawing.Point(12, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 65);
            this.groupBox1.TabIndex = 254;
            this.groupBox1.TabStop = false;
            // 
            // btConsultar
            // 
            this.btConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConsultar.Location = new System.Drawing.Point(26, 20);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(97, 29);
            this.btConsultar.TabIndex = 14;
            this.btConsultar.Text = "&Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(544, 19);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(80, 30);
            this.btExcluir.TabIndex = 12;
            this.btExcluir.Text = "&Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(679, 19);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(80, 30);
            this.btCancelar.TabIndex = 13;
            this.btCancelar.Text = "Sai&r";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSalvar.Location = new System.Drawing.Point(402, 19);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(80, 30);
            this.btSalvar.TabIndex = 11;
            this.btSalvar.Text = "&Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // txtnValor
            // 
            this.txtnValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnValor.Location = new System.Drawing.Point(133, 249);
            this.txtnValor.Name = "txtnValor";
            this.txtnValor.Size = new System.Drawing.Size(113, 22);
            this.txtnValor.TabIndex = 9;
            this.txtnValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnValor_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 251;
            this.label3.Text = "Valor";
            // 
            // txtnFuncionario
            // 
            this.txtnFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnFuncionario.Location = new System.Drawing.Point(302, 81);
            this.txtnFuncionario.Name = "txtnFuncionario";
            this.txtnFuncionario.Size = new System.Drawing.Size(475, 22);
            this.txtnFuncionario.TabIndex = 2;
            this.txtnFuncionario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnFuncionario_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 249;
            this.label2.Text = "Funcionário";
            // 
            // txtnData
            // 
            this.txtnData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnData.Location = new System.Drawing.Point(478, 169);
            this.txtnData.Mask = "00/00/0000";
            this.txtnData.Name = "txtnData";
            this.txtnData.Size = new System.Drawing.Size(109, 22);
            this.txtnData.TabIndex = 6;
            this.txtnData.ValidatingType = typeof(System.DateTime);
            this.txtnData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnData_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(336, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 20);
            this.label11.TabIndex = 247;
            this.label11.Text = "Referente ao mês";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(410, 127);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 20);
            this.label17.TabIndex = 241;
            this.label17.Text = "Condominio";
            // 
            // cbCondominio
            // 
            this.cbCondominio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCondominio.FormattingEnabled = true;
            this.cbCondominio.Items.AddRange(new object[] {
            "CONDOMINIO BELA VISTA",
            "CONDOMINIO VITTA",
            "CONDOMINIO VILA SEIXAS"});
            this.cbCondominio.Location = new System.Drawing.Point(514, 125);
            this.cbCondominio.Name = "cbCondominio";
            this.cbCondominio.Size = new System.Drawing.Size(264, 24);
            this.cbCondominio.TabIndex = 4;
            this.cbCondominio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbCondominio_KeyDown);
            // 
            // txtnCOD
            // 
            this.txtnCOD.Enabled = false;
            this.txtnCOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnCOD.Location = new System.Drawing.Point(123, 81);
            this.txtnCOD.Name = "txtnCOD";
            this.txtnCOD.Size = new System.Drawing.Size(71, 22);
            this.txtnCOD.TabIndex = 1;
            this.txtnCOD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnCOD_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 239;
            this.label8.Text = "Sequencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 31);
            this.label1.TabIndex = 260;
            this.label1.Text = "Lançamento Funcionários";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbDespesas
            // 
            this.cbDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDespesas.FormattingEnabled = true;
            this.cbDespesas.Items.AddRange(new object[] {
            "Água",
            "Eletricidade",
            "Elevadores",
            "Funcionario",
            "Exitintores",
            "Jardinagem",
            "Limpeza",
            "Multa",
            "Seguro"});
            this.cbDespesas.Location = new System.Drawing.Point(123, 123);
            this.cbDespesas.Name = "cbDespesas";
            this.cbDespesas.Size = new System.Drawing.Size(265, 24);
            this.cbDespesas.TabIndex = 3;
            this.cbDespesas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbDespesas_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(34, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 262;
            this.label13.Text = "Despesa";
            // 
            // txtnVencimento
            // 
            this.txtnVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnVencimento.Location = new System.Drawing.Point(133, 214);
            this.txtnVencimento.Mask = "00/00/0000";
            this.txtnVencimento.Name = "txtnVencimento";
            this.txtnVencimento.Size = new System.Drawing.Size(113, 22);
            this.txtnVencimento.TabIndex = 8;
            this.txtnVencimento.ValidatingType = typeof(System.DateTime);
            this.txtnVencimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnVencimento_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 264;
            this.label4.Text = "Vencimento";
            // 
            // cbCodvd
            // 
            this.cbCodvd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodvd.FormattingEnabled = true;
            this.cbCodvd.Items.AddRange(new object[] {
            "Salario Semanal",
            "Salario Mensal",
            "Vale",
            "13° Salario",
            "Ferias",
            "Vale Transporte"});
            this.cbCodvd.Location = new System.Drawing.Point(124, 167);
            this.cbCodvd.Name = "cbCodvd";
            this.cbCodvd.Size = new System.Drawing.Size(180, 24);
            this.cbCodvd.TabIndex = 5;
            this.cbCodvd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbCodvd_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 266;
            this.label5.Text = "Cod V/D";
            // 
            // txtnData2
            // 
            this.txtnData2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnData2.Location = new System.Drawing.Point(620, 169);
            this.txtnData2.Mask = "00/00/0000";
            this.txtnData2.Name = "txtnData2";
            this.txtnData2.Size = new System.Drawing.Size(109, 22);
            this.txtnData2.TabIndex = 7;
            this.txtnData2.ValidatingType = typeof(System.DateTime);
            this.txtnData2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnData2_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(593, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 268;
            this.label6.Text = "á";
            // 
            // FrmLancaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 462);
            this.Controls.Add(this.txtnData2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCodvd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnVencimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDespesas);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtnValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnFuncionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnData);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbCondominio);
            this.Controls.Add(this.txtnCOD);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLancaFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLancaFuncionario";
            this.Load += new System.EventHandler(this.FrmLancaFuncionario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLancaFuncionario_KeyDown);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtnObs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.TextBox txtnValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtnData;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbCondominio;
        private System.Windows.Forms.TextBox txtnCOD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDespesas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtnVencimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCodvd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtnData2;
        private System.Windows.Forms.Label label6;
    }
}