namespace Login.view
{
    partial class FrmBaixarContasAPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaixarContasAPagar));
            this.label17 = new System.Windows.Forms.Label();
            this.cbCondominio = new System.Windows.Forms.ComboBox();
            this.txtnCOD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnData = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtnFornecedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btBaixar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBanco = new System.Windows.Forms.ComboBox();
            this.txtnSeqMovimento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtnObs = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(310, 126);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 20);
            this.label17.TabIndex = 214;
            this.label17.Text = "Condominio";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // cbCondominio
            // 
            this.cbCondominio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCondominio.FormattingEnabled = true;
            this.cbCondominio.Items.AddRange(new object[] {
            "CONDOMINIO BELA VISTA",
            "CONDOMINIO VITTA",
            "CONDOMINIO VILA SEIXAS"});
            this.cbCondominio.Location = new System.Drawing.Point(422, 124);
            this.cbCondominio.Name = "cbCondominio";
            this.cbCondominio.Size = new System.Drawing.Size(289, 24);
            this.cbCondominio.TabIndex = 4;
            this.cbCondominio.SelectedIndexChanged += new System.EventHandler(this.cbCondominio_SelectedIndexChanged);
            this.cbCondominio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbCondominio_KeyDown);
            // 
            // txtnCOD
            // 
            this.txtnCOD.Enabled = false;
            this.txtnCOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnCOD.Location = new System.Drawing.Point(149, 81);
            this.txtnCOD.Name = "txtnCOD";
            this.txtnCOD.Size = new System.Drawing.Size(61, 22);
            this.txtnCOD.TabIndex = 1;
            this.txtnCOD.TextChanged += new System.EventHandler(this.txtnCOD_TextChanged);
            this.txtnCOD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnCOD_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 212;
            this.label8.Text = "Sequencia";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 31);
            this.label1.TabIndex = 210;
            this.label1.Text = "Baixar Parcela do Contas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtnData
            // 
            this.txtnData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnData.Location = new System.Drawing.Point(186, 124);
            this.txtnData.Mask = "00/00/0000";
            this.txtnData.Name = "txtnData";
            this.txtnData.Size = new System.Drawing.Size(109, 22);
            this.txtnData.TabIndex = 3;
            this.txtnData.ValidatingType = typeof(System.DateTime);
            this.txtnData.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox4_MaskInputRejected);
            this.txtnData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnData_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(48, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 20);
            this.label11.TabIndex = 224;
            this.label11.Text = "Data Pagamento";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtnFornecedor
            // 
            this.txtnFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnFornecedor.Location = new System.Drawing.Point(326, 81);
            this.txtnFornecedor.Name = "txtnFornecedor";
            this.txtnFornecedor.Size = new System.Drawing.Size(419, 22);
            this.txtnFornecedor.TabIndex = 2;
            this.txtnFornecedor.Click += new System.EventHandler(this.txtnFornecedor_Click);
            this.txtnFornecedor.TextChanged += new System.EventHandler(this.txtnNome_TextChanged);
            this.txtnFornecedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnFornecedor_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 226;
            this.label2.Text = "Fornecedor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtnValor
            // 
            this.txtnValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnValor.Location = new System.Drawing.Point(107, 172);
            this.txtnValor.Name = "txtnValor";
            this.txtnValor.Size = new System.Drawing.Size(102, 22);
            this.txtnValor.TabIndex = 5;
            this.txtnValor.TextChanged += new System.EventHandler(this.txtnValorDespesa_TextChanged);
            this.txtnValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnValor_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 228;
            this.label3.Text = "Valor";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btCancelar);
            this.groupBox1.Controls.Add(this.btBaixar);
            this.groupBox1.Location = new System.Drawing.Point(11, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 65);
            this.groupBox1.TabIndex = 231;
            this.groupBox1.TabStop = false;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(679, 19);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(80, 30);
            this.btCancelar.TabIndex = 10;
            this.btCancelar.Text = "Sai&r";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btBaixar
            // 
            this.btBaixar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBaixar.Location = new System.Drawing.Point(543, 19);
            this.btBaixar.Name = "btBaixar";
            this.btBaixar.Size = new System.Drawing.Size(80, 30);
            this.btBaixar.TabIndex = 9;
            this.btBaixar.Text = "&Baixar";
            this.btBaixar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(548, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 233;
            this.label5.Text = "Banco";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbBanco
            // 
            this.cbBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBanco.FormattingEnabled = true;
            this.cbBanco.Items.AddRange(new object[] {
            "Brasil",
            "Bradesco",
            "Itau",
            "Santander",
            "Sicoob"});
            this.cbBanco.Location = new System.Drawing.Point(612, 173);
            this.cbBanco.Name = "cbBanco";
            this.cbBanco.Size = new System.Drawing.Size(134, 24);
            this.cbBanco.TabIndex = 7;
            this.cbBanco.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.cbBanco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbBanco_KeyDown);
            // 
            // txtnSeqMovimento
            // 
            this.txtnSeqMovimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnSeqMovimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnSeqMovimento.Location = new System.Drawing.Point(422, 173);
            this.txtnSeqMovimento.Name = "txtnSeqMovimento";
            this.txtnSeqMovimento.Size = new System.Drawing.Size(114, 22);
            this.txtnSeqMovimento.TabIndex = 6;
            this.txtnSeqMovimento.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtnSeqMovimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnSeqMovimento_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(227, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 20);
            this.label6.TabIndex = 236;
            this.label6.Text = "Seq. movimento/ Cheque";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtnObs);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(22, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(748, 141);
            this.groupBox3.TabIndex = 237;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Observação do pagamento";
            // 
            // txtnObs
            // 
            this.txtnObs.Location = new System.Drawing.Point(9, 21);
            this.txtnObs.Multiline = true;
            this.txtnObs.Name = "txtnObs";
            this.txtnObs.Size = new System.Drawing.Size(733, 108);
            this.txtnObs.TabIndex = 8;
            this.txtnObs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnObs_KeyDown);
            // 
            // FrmBaixarContasAPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 462);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtnSeqMovimento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbBanco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtnValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnFornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnData);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbCondominio);
            this.Controls.Add(this.txtnCOD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBaixarContasAPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBaixarContasAPagar";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLancaDespesa_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbCondominio;
        private System.Windows.Forms.TextBox txtnCOD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtnData;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtnFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btBaixar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBanco;
        private System.Windows.Forms.TextBox txtnSeqMovimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtnObs;
    }
}