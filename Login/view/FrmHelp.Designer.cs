namespace Login.view
{
    partial class FrmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHelp));
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btMais = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Items.AddRange(new object[] {
            "\t\t\t\t\t\t\t\tSistema Lefel Solutions",
            "",
            "Manual Basico para operação sistema: Para começar a usar o sistema 1° passos  são" +
                " os cadastro  :",
            "",
            "Cadastrar o Condominio - Aperte a tecla de atalho (C) o sistema te levará para a " +
                "tela de cadastro - nessa tela preencha os dados necessarios do condominio que vo" +
                "cê administra,",
            "clique em salvar;",
            "",
            "Cadastrar Residencias - Após ter cadastrado o condominio que administra na mesma " +
                "tela a opção (F3) permite cadastrar os ( apartamentos , resisdencias ),",
            "pertencente ao condominio já cadastrado;",
            "FRAÇÃO IDEAL - Para o calculo da fração idela é preciso informar Area construida " +
                "e Area total do terreno, sistema irá calcular AreaContruida / AreaTotal do terre" +
                "no informando",
            "assim a fração ideal daqueles imoveis;",
            "",
            "Cadastro de proprietario - Aperte a tecla de atalho (P) o sistema te levará para " +
                "a tela de cadastro de proprietario do imove",
            "preencha os dados necessarios para o cadastro e clique em salvar;",
            "Observação (Sistema da opção de cadastrar condômino caso o proprietario não seja " +
                "o morador do imovel o cadastro do condômino",
            "ficará vinculado com o proprietario)"});
            this.listBox2.Location = new System.Drawing.Point(47, 316);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(1288, 342);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // btMais
            // 
            this.btMais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMais.Location = new System.Drawing.Point(47, 665);
            this.btMais.Name = "btMais";
            this.btMais.Size = new System.Drawing.Size(80, 30);
            this.btMais.TabIndex = 7;
            this.btMais.Text = "&Mais...";
            this.btMais.UseVisualStyleBackColor = true;
            this.btMais.Click += new System.EventHandler(this.btMais_Click);
            // 
            // btSair
            // 
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(139, 665);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(80, 30);
            this.btSair.TabIndex = 8;
            this.btSair.Text = "Sai&r";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "\t\t\t\t\t\t\t\tTECLAS DE ATALHOS",
            "\t\t\tTodas as telas do sistema possuem teclas de atalho para visualiza-las pression" +
                "e ALT e para usa-las pressione ALT+ Tecla (letra) desejada",
            "",
            "\tBanco - Cadastrar  O / Consultar - F9\t\t\t\t\tProprietario - Cadastrar P / Consultar" +
                " - F3",
            "",
            "\tDespesa - Cadastrar D / Consultar - F10\t\t\t\t\t Ocorrencia/Pedido - Cadastrar O / C" +
                "onsultar - F4",
            "",
            "\tMensalidade - Lançar M / Consultar - F11           \t\t\t\tFornecedor - Cadastrar F " +
                "/ Consultar - F5                           ",
            "",
            "\tUtilitarios U\t\t\t\t\t\t\tContas á Pagar - Lançar T / Consultar - F6",
            "",
            "\tCondominio - Cadastrar C / Consultar - F1\t\t\t\tBalancete - Consultar B",
            "",
            "\tResidencia - Consultar - F2\t\t\t\t\t\tFuncionario - Cadastrar N / Consultar - F7 / La" +
                "nçar - F8",
            "\tBackup - K \t\t\t\t\t\t\tSair - F12\t"});
            this.listBox1.Location = new System.Drawing.Point(47, 10);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1288, 302);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(566, 688);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "TELEFONE SUPORTE - (16) 3235-2338";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(637, 670);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lefel Solutions";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.Online_Customer_Support_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(850, 664);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FrmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(989, 750);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btMais);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHelp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHelp_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmHelp_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btMais;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}