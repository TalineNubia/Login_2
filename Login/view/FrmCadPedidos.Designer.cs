namespace Login.view
{
    partial class FrmCadPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadPedidos));
            this.txtnNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnResposta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnCOD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbUnidade = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbCondominio = new System.Windows.Forms.ComboBox();
            this.cbPrioridade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtnPedido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnFone = new System.Windows.Forms.MaskedTextBox();
            this.txtnDataPedido = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btProximo = new System.Windows.Forms.Button();
            this.btAnterior = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnNome
            // 
            this.txtnNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnNome.Location = new System.Drawing.Point(302, 71);
            this.txtnNome.Name = "txtnNome";
            this.txtnNome.Size = new System.Drawing.Size(334, 22);
            this.txtnNome.TabIndex = 2;
            this.txtnNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnNome_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 188;
            this.label2.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtnResposta);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(783, 104);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resposta";
            // 
            // txtnResposta
            // 
            this.txtnResposta.Location = new System.Drawing.Point(12, 15);
            this.txtnResposta.Multiline = true;
            this.txtnResposta.Name = "txtnResposta";
            this.txtnResposta.Size = new System.Drawing.Size(758, 82);
            this.txtnResposta.TabIndex = 9;
            this.txtnResposta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnResposta_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btConsultar);
            this.groupBox1.Controls.Add(this.btExcluir);
            this.groupBox1.Controls.Add(this.btCancelar);
            this.groupBox1.Controls.Add(this.btSalvar);
            this.groupBox1.Location = new System.Drawing.Point(11, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 65);
            this.groupBox1.TabIndex = 201;
            this.groupBox1.TabStop = false;
            // 
            // btConsultar
            // 
            this.btConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConsultar.Location = new System.Drawing.Point(25, 19);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(80, 30);
            this.btConsultar.TabIndex = 13;
            this.btConsultar.Text = "&Consultar ";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(544, 19);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(80, 30);
            this.btExcluir.TabIndex = 11;
            this.btExcluir.Text = "&Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(679, 19);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(80, 30);
            this.btCancelar.TabIndex = 12;
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
            this.btSalvar.TabIndex = 10;
            this.btSalvar.Text = "&Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            this.btSalvar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btSalvar_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 31);
            this.label1.TabIndex = 202;
            this.label1.Text = "Lançar Pedidos / Ocorrências";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtnCOD
            // 
            this.txtnCOD.Enabled = false;
            this.txtnCOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnCOD.Location = new System.Drawing.Point(148, 71);
            this.txtnCOD.Name = "txtnCOD";
            this.txtnCOD.Size = new System.Drawing.Size(71, 22);
            this.txtnCOD.TabIndex = 1;
            this.txtnCOD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnCOD_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 204;
            this.label8.Text = "Cod do pedido";
            // 
            // cbUnidade
            // 
            this.cbUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnidade.FormattingEnabled = true;
            this.cbUnidade.Items.AddRange(new object[] {
            "Apart. 01",
            "Apart. 02",
            "Apart. 03",
            "Apart. 04",
            "Apart. 05",
            "Apart. 06",
            "Apart. 07",
            "Apart. 08",
            "Apart. 09",
            "Apart. 10",
            "Apart. 11",
            "Apart. 12",
            "Apart. 13",
            "Apart. 14",
            "Apart. 15",
            "Apart. 16",
            "Apart. 17",
            "Apart. 18",
            "Apart. 19",
            "Apart. 20"});
            this.cbUnidade.Location = new System.Drawing.Point(522, 109);
            this.cbUnidade.Name = "cbUnidade";
            this.cbUnidade.Size = new System.Drawing.Size(252, 24);
            this.cbUnidade.TabIndex = 5;
            this.cbUnidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbUnidade_KeyDown);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(444, 110);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 20);
            this.label19.TabIndex = 207;
            this.label19.Text = "Unidade";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(37, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 20);
            this.label17.TabIndex = 206;
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
            this.cbCondominio.Location = new System.Drawing.Point(147, 106);
            this.cbCondominio.Name = "cbCondominio";
            this.cbCondominio.Size = new System.Drawing.Size(291, 24);
            this.cbCondominio.TabIndex = 4;
            this.cbCondominio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbCondominio_KeyDown);
            // 
            // cbPrioridade
            // 
            this.cbPrioridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrioridade.FormattingEnabled = true;
            this.cbPrioridade.Items.AddRange(new object[] {
            "Baixa",
            "Normal",
            "Alta",
            "Altíssima"});
            this.cbPrioridade.Location = new System.Drawing.Point(146, 143);
            this.cbPrioridade.Name = "cbPrioridade";
            this.cbPrioridade.Size = new System.Drawing.Size(252, 24);
            this.cbPrioridade.TabIndex = 6;
            this.cbPrioridade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbPrioridade_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 209;
            this.label3.Text = "Prioridade";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtnPedido);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(783, 104);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pedido";
            // 
            // txtnPedido
            // 
            this.txtnPedido.Location = new System.Drawing.Point(12, 15);
            this.txtnPedido.Multiline = true;
            this.txtnPedido.Name = "txtnPedido";
            this.txtnPedido.Size = new System.Drawing.Size(758, 82);
            this.txtnPedido.TabIndex = 8;
            this.txtnPedido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnPedido_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(446, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 212;
            this.label4.Text = "Fone";
            // 
            // txtnFone
            // 
            this.txtnFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnFone.Location = new System.Drawing.Point(519, 145);
            this.txtnFone.Mask = "(99) 00000-0000";
            this.txtnFone.Name = "txtnFone";
            this.txtnFone.Size = new System.Drawing.Size(156, 22);
            this.txtnFone.TabIndex = 7;
            this.txtnFone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnFone_KeyDown);
            // 
            // txtnDataPedido
            // 
            this.txtnDataPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnDataPedido.Location = new System.Drawing.Point(692, 69);
            this.txtnDataPedido.Mask = "00/00/0000";
            this.txtnDataPedido.Name = "txtnDataPedido";
            this.txtnDataPedido.Size = new System.Drawing.Size(81, 22);
            this.txtnDataPedido.TabIndex = 3;
            this.txtnDataPedido.ValidatingType = typeof(System.DateTime);
            this.txtnDataPedido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnDataPedido_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(642, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 224;
            this.label11.Text = "Data";
            // 
            // btProximo
            // 
            this.btProximo.Location = new System.Drawing.Point(188, 42);
            this.btProximo.Name = "btProximo";
            this.btProximo.Size = new System.Drawing.Size(41, 23);
            this.btProximo.TabIndex = 226;
            this.btProximo.Text = ">>";
            this.btProximo.UseVisualStyleBackColor = true;
            this.btProximo.Click += new System.EventHandler(this.btProximo_Click);
            // 
            // btAnterior
            // 
            this.btAnterior.Location = new System.Drawing.Point(136, 42);
            this.btAnterior.Name = "btAnterior";
            this.btAnterior.Size = new System.Drawing.Size(41, 23);
            this.btAnterior.TabIndex = 225;
            this.btAnterior.Text = "<<";
            this.btAnterior.UseVisualStyleBackColor = true;
            this.btAnterior.Click += new System.EventHandler(this.btAnterior_Click);
            // 
            // FrmCadPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 462);
            this.Controls.Add(this.btProximo);
            this.Controls.Add(this.btAnterior);
            this.Controls.Add(this.txtnDataPedido);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtnFone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cbPrioridade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbUnidade);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbCondominio);
            this.Controls.Add(this.txtnCOD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtnNome);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadPedidos";
            this.Load += new System.EventHandler(this.FrmCadPedidos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CadPedidos_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtnNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtnResposta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnCOD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbUnidade;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbCondominio;
        private System.Windows.Forms.ComboBox cbPrioridade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtnFone;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.MaskedTextBox txtnDataPedido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btProximo;
        private System.Windows.Forms.Button btAnterior;
        private System.Windows.Forms.TextBox txtnPedido;
    }
}