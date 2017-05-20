namespace Login.view
{
    partial class FrmCadBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadBanco));
            this.txtnIe = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btNovo = new System.Windows.Forms.Button();
            this.btProximo = new System.Windows.Forms.Button();
            this.btAnterior = new System.Windows.Forms.Button();
            this.txtnCOD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnAgencia = new System.Windows.Forms.TextBox();
            this.txtnBanco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnRazãoSocial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.cbCondominio = new System.Windows.Forms.ComboBox();
            this.txtnConta = new System.Windows.Forms.TextBox();
            this.txtnNossoNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbEmiteBoleto = new System.Windows.Forms.ComboBox();
            this.txtnCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtnLançaRemessa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtnRecuperaRemessa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.clbAtivoInativo = new System.Windows.Forms.CheckedListBox();
            this.txtnOperacao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnIe
            // 
            this.txtnIe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnIe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnIe.Location = new System.Drawing.Point(419, 167);
            this.txtnIe.Name = "txtnIe";
            this.txtnIe.Size = new System.Drawing.Size(178, 22);
            this.txtnIe.TabIndex = 5;
            this.txtnIe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnIe_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(474, 213);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 20);
            this.label15.TabIndex = 89;
            this.label15.Text = "Conta";
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(210, 81);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(52, 23);
            this.btNovo.TabIndex = 88;
            this.btNovo.TabStop = false;
            this.btNovo.Text = "&Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            // 
            // btProximo
            // 
            this.btProximo.Location = new System.Drawing.Point(179, 50);
            this.btProximo.Name = "btProximo";
            this.btProximo.Size = new System.Drawing.Size(41, 23);
            this.btProximo.TabIndex = 87;
            this.btProximo.Text = ">>";
            this.btProximo.UseVisualStyleBackColor = true;
            this.btProximo.Click += new System.EventHandler(this.btProximo_Click);
            // 
            // btAnterior
            // 
            this.btAnterior.Location = new System.Drawing.Point(127, 50);
            this.btAnterior.Name = "btAnterior";
            this.btAnterior.Size = new System.Drawing.Size(41, 23);
            this.btAnterior.TabIndex = 86;
            this.btAnterior.Text = "<<";
            this.btAnterior.UseVisualStyleBackColor = true;
            this.btAnterior.Click += new System.EventHandler(this.btAnterior_Click);
            // 
            // txtnCOD
            // 
            this.txtnCOD.Enabled = false;
            this.txtnCOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnCOD.Location = new System.Drawing.Point(139, 82);
            this.txtnCOD.Name = "txtnCOD";
            this.txtnCOD.Size = new System.Drawing.Size(63, 22);
            this.txtnCOD.TabIndex = 1;
            this.txtnCOD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnCOD_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 85;
            this.label8.Text = "Cod Banco";
            // 
            // txtnAgencia
            // 
            this.txtnAgencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnAgencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnAgencia.Location = new System.Drawing.Point(386, 211);
            this.txtnAgencia.Name = "txtnAgencia";
            this.txtnAgencia.Size = new System.Drawing.Size(85, 22);
            this.txtnAgencia.TabIndex = 7;
            this.txtnAgencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnAgencia_KeyDown);
            // 
            // txtnBanco
            // 
            this.txtnBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnBanco.Location = new System.Drawing.Point(139, 212);
            this.txtnBanco.Name = "txtnBanco";
            this.txtnBanco.Size = new System.Drawing.Size(170, 22);
            this.txtnBanco.TabIndex = 6;
            this.txtnBanco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnBanco_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 84;
            this.label3.Text = "Agencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 81;
            this.label2.Text = "Banco";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 31);
            this.label1.TabIndex = 90;
            this.label1.Text = "Cadastro de Banco";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtnRazãoSocial
            // 
            this.txtnRazãoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnRazãoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnRazãoSocial.Location = new System.Drawing.Point(372, 82);
            this.txtnRazãoSocial.Name = "txtnRazãoSocial";
            this.txtnRazãoSocial.Size = new System.Drawing.Size(423, 22);
            this.txtnRazãoSocial.TabIndex = 2;
            this.txtnRazãoSocial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnRazãoSocial_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(265, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 92;
            this.label4.Text = "Razão Social";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 94;
            this.label5.Text = "CNPJ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(372, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 96;
            this.label6.Text = "I.E";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btConsultar);
            this.groupBox1.Controls.Add(this.btExcluir);
            this.groupBox1.Controls.Add(this.btCancelar);
            this.groupBox1.Controls.Add(this.btSalvar);
            this.groupBox1.Location = new System.Drawing.Point(12, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 65);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            // 
            // btConsultar
            // 
            this.btConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConsultar.Location = new System.Drawing.Point(22, 19);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(80, 30);
            this.btConsultar.TabIndex = 17;
            this.btConsultar.Text = "&Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(544, 19);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(80, 30);
            this.btExcluir.TabIndex = 15;
            this.btExcluir.Text = "&Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(679, 19);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(80, 30);
            this.btCancelar.TabIndex = 16;
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
            this.btSalvar.TabIndex = 14;
            this.btSalvar.Text = "&Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(45, 126);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 20);
            this.label17.TabIndex = 119;
            this.label17.Text = "Condominio";
            // 
            // cbCondominio
            // 
            this.cbCondominio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCondominio.FormattingEnabled = true;
            this.cbCondominio.Items.AddRange(new object[] {
            "CONDOMINIO BELA VISTA",
            "CONDOMINIO VITTA",
            "CONDOMINIO VILA SEIXAS",
            "TODOS"});
            this.cbCondominio.Location = new System.Drawing.Point(140, 124);
            this.cbCondominio.Name = "cbCondominio";
            this.cbCondominio.Size = new System.Drawing.Size(273, 24);
            this.cbCondominio.TabIndex = 3;
            this.cbCondominio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbCondominio_KeyDown);
            // 
            // txtnConta
            // 
            this.txtnConta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnConta.Location = new System.Drawing.Point(533, 213);
            this.txtnConta.Name = "txtnConta";
            this.txtnConta.Size = new System.Drawing.Size(101, 22);
            this.txtnConta.TabIndex = 8;
            this.txtnConta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnConta_KeyDown);
            // 
            // txtnNossoNumero
            // 
            this.txtnNossoNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnNossoNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnNossoNumero.Location = new System.Drawing.Point(419, 256);
            this.txtnNossoNumero.Name = "txtnNossoNumero";
            this.txtnNossoNumero.Size = new System.Drawing.Size(192, 22);
            this.txtnNossoNumero.TabIndex = 10;
            this.txtnNossoNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnNossoNumero_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(339, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 121;
            this.label7.Text = "Nosso N°";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 123;
            this.label9.Text = "Emite Boleto";
            // 
            // cbEmiteBoleto
            // 
            this.cbEmiteBoleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmiteBoleto.FormattingEnabled = true;
            this.cbEmiteBoleto.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.cbEmiteBoleto.Location = new System.Drawing.Point(180, 253);
            this.cbEmiteBoleto.Name = "cbEmiteBoleto";
            this.cbEmiteBoleto.Size = new System.Drawing.Size(117, 24);
            this.cbEmiteBoleto.TabIndex = 9;
            this.cbEmiteBoleto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbEmiteBoleto_KeyDown);
            // 
            // txtnCNPJ
            // 
            this.txtnCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnCNPJ.Location = new System.Drawing.Point(140, 167);
            this.txtnCNPJ.Mask = "00.000.000.0000-00";
            this.txtnCNPJ.Name = "txtnCNPJ";
            this.txtnCNPJ.Size = new System.Drawing.Size(188, 22);
            this.txtnCNPJ.TabIndex = 4;
            this.txtnCNPJ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnCNPJ_KeyDown_1);
            // 
            // txtnLançaRemessa
            // 
            this.txtnLançaRemessa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnLançaRemessa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnLançaRemessa.Location = new System.Drawing.Point(161, 19);
            this.txtnLançaRemessa.Name = "txtnLançaRemessa";
            this.txtnLançaRemessa.Size = new System.Drawing.Size(295, 22);
            this.txtnLançaRemessa.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 20);
            this.label11.TabIndex = 128;
            this.label11.Text = "Lança Remessa";
            // 
            // txtnRecuperaRemessa
            // 
            this.txtnRecuperaRemessa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnRecuperaRemessa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnRecuperaRemessa.Location = new System.Drawing.Point(163, 50);
            this.txtnRecuperaRemessa.Name = "txtnRecuperaRemessa";
            this.txtnRecuperaRemessa.Size = new System.Drawing.Size(293, 22);
            this.txtnRecuperaRemessa.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 20);
            this.label12.TabIndex = 130;
            this.label12.Text = "Recupera Remessa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtnRecuperaRemessa);
            this.groupBox2.Controls.Add(this.txtnLançaRemessa);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(49, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 88);
            this.groupBox2.TabIndex = 131;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuração de Diretorio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(695, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 133;
            this.label13.Text = "Cadastro";
            // 
            // clbAtivoInativo
            // 
            this.clbAtivoInativo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clbAtivoInativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbAtivoInativo.FormattingEnabled = true;
            this.clbAtivoInativo.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.clbAtivoInativo.Location = new System.Drawing.Point(675, 138);
            this.clbAtivoInativo.Name = "clbAtivoInativo";
            this.clbAtivoInativo.Size = new System.Drawing.Size(120, 46);
            this.clbAtivoInativo.TabIndex = 132;
            // 
            // txtnOperacao
            // 
            this.txtnOperacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnOperacao.Location = new System.Drawing.Point(724, 213);
            this.txtnOperacao.Name = "txtnOperacao";
            this.txtnOperacao.Size = new System.Drawing.Size(63, 22);
            this.txtnOperacao.TabIndex = 134;
            this.txtnOperacao.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(637, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 135;
            this.label10.Text = "Operação";
            // 
            // FrmCadBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 462);
            this.Controls.Add(this.txtnOperacao);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.clbAtivoInativo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtnCNPJ);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbEmiteBoleto);
            this.Controls.Add(this.txtnNossoNumero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtnConta);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbCondominio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnRazãoSocial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnIe);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btProximo);
            this.Controls.Add(this.btAnterior);
            this.Controls.Add(this.txtnCOD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnAgencia);
            this.Controls.Add(this.txtnBanco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadBanco";
            this.Load += new System.EventHandler(this.FrmCadBanco_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CadBanco_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnIe;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btProximo;
        private System.Windows.Forms.Button btAnterior;
        private System.Windows.Forms.TextBox txtnCOD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnAgencia;
        private System.Windows.Forms.TextBox txtnBanco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnRazãoSocial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbCondominio;
        private System.Windows.Forms.TextBox txtnConta;
        private System.Windows.Forms.TextBox txtnNossoNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbEmiteBoleto;
        private System.Windows.Forms.MaskedTextBox txtnCNPJ;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.TextBox txtnLançaRemessa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtnRecuperaRemessa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckedListBox clbAtivoInativo;
        private System.Windows.Forms.TextBox txtnOperacao;
        private System.Windows.Forms.Label label10;
    }
}