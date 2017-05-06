namespace Login.view
{
    partial class FrmHelp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHelp2));
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Items.AddRange(new object[] {
            "Manual Basico para operação sistema:",
            "",
            "Cadastrar Condômino - Na tela de cadastro do PROPRIETARIO o sistema da opção de c" +
                "adastrar o condômino ( morador ) que reside no local",
            "aperta a tela de atalho (F6) preencha os dados necessarios clique em salvar;",
            "Observação ( No cadastro do condômino tem a opção de incluir todos os moradores q" +
                "ue moram no imovel );",
            "",
            "Cadastro Fornecedor -  Aperte a tecla de Atalho (F) o sistema te levará para a te" +
                "la de cadastro de fornecedor nessa tela preencha os dados necessarios e clique e" +
                "m salvar;",
            "",
            "Cadastro de Funcionario - Aperte a tecla de atalho (N) o sistema te levará para a" +
                " tela de cadastro de funcionario - nessa preencha os dados necessarios e clique " +
                "em salvar;",
            "Nessa mesma tela  de cadastro de funcionario aperte a tecla F3- dados Adicionais " +
                "do funcionario preencha os campos conforme necessario e clique em salvar;",
            "",
            "Cadastro de Banco - Aperte a tecla de atalho (A) o sistema te levará para a tela " +
                "de cadastro de banco, nessa tela preencha os dados do seu banco e  clique em sal" +
                "var;",
            "Observação ( Caso prefirá a impressão de boleto pelo sistema é obrigatorio o pree" +
                "nchimento de todos os campos;",
            "",
            "Cadastro Despesa - Aperte a tecla de atalho (D) e o sistema te levará para a tecl" +
                "a de cadastro de despesa, preencha todos os campos necessarios e clique em salva" +
                "r;",
            resources.GetString("listBox2.Items"),
            "2° passo lançamentos do sistema;",
            "",
            "Lançamento das mensalidade dos imoveis - Aperte a tecla de atalho (M)  o sistema " +
                "te levará para a tela onde voce precisará informar o condômino já cadastrado no " +
                "sistema",
            "qual o condominio do mesmo e o banco que irá imprimir o boleto - nessa tela o sis" +
                "tema informará a despesa do mês e a fração ideal, atraves dessas informações o u" +
                "suario",
            "saberá qual o valor da mensalidade aplicar naquele boleto;",
            "",
            "Lançamento de Contas á pagar - Aperte a tecla de atalho (T) - Sistema te levará p" +
                "ara a tela de lançamento onde você irá informará o fornecedor e despesas",
            "que deveram estar ja cadastrados,  preencha todos os campos e clique em salvar;",
            "",
            "Balancete - Aperte a tecla de atalho (B) - sistema te levará para uma tela de apu" +
                "ração mensal, o sistema faz o levantamento de receitas e despesas",
            "de cada condominio para uma visão geral do negocio;",
            "Observação ( Ao processo de lançamento o usuario deverá informar qual o condomini" +
                "o pertencente a despesa)",
            "",
            "Lançamento de Ocorrencias - Aperte a tecla de atalho O o sistema te levará para a" +
                " tela onde poderá ser preenchido ocorrencias feitas por moradores ",
            "ou pelo responsavel pelo condominio preencha todos os dados e clique me salvar;"});
            this.listBox2.Location = new System.Drawing.Point(51, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(1233, 642);
            this.listBox2.TabIndex = 2;
            // 
            // btVoltar
            // 
            this.btVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVoltar.Location = new System.Drawing.Point(51, 652);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(80, 30);
            this.btVoltar.TabIndex = 10;
            this.btVoltar.Text = "&Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // FrmHelp2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(989, 743);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.listBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmHelp2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHelp2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmHelp2_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btVoltar;
    }
}