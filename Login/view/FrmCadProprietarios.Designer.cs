namespace Login.view
{
    partial class FrmCadProprietarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadProprietarios));
            this.btNovo = new System.Windows.Forms.Button();
            this.btProximo = new System.Windows.Forms.Button();
            this.btAnterior = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.txtnCOD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnMunicipio = new System.Windows.Forms.TextBox();
            this.txtnNumero = new System.Windows.Forms.TextBox();
            this.txtnEndereco = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.txtnNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCadastrarCodômino = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnRG = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txtnFone1 = new System.Windows.Forms.MaskedTextBox();
            this.txtnFone = new System.Windows.Forms.MaskedTextBox();
            this.txtnEmail = new System.Windows.Forms.TextBox();
            this.txtnCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtnBairro = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbCondominio = new System.Windows.Forms.ComboBox();
            this.clbMorador = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtnCPF = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(152, 88);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(52, 23);
            this.btNovo.TabIndex = 59;
            this.btNovo.Text = "&Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            // 
            // btProximo
            // 
            this.btProximo.Location = new System.Drawing.Point(116, 56);
            this.btProximo.Name = "btProximo";
            this.btProximo.Size = new System.Drawing.Size(41, 23);
            this.btProximo.TabIndex = 58;
            this.btProximo.Text = ">>";
            this.btProximo.UseVisualStyleBackColor = true;
            this.btProximo.Click += new System.EventHandler(this.btProximo_Click);
            // 
            // btAnterior
            // 
            this.btAnterior.Location = new System.Drawing.Point(64, 56);
            this.btAnterior.Name = "btAnterior";
            this.btAnterior.Size = new System.Drawing.Size(41, 23);
            this.btAnterior.TabIndex = 57;
            this.btAnterior.Text = "<<";
            this.btAnterior.UseVisualStyleBackColor = true;
            this.btAnterior.Click += new System.EventHandler(this.btAnterior_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(599, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 18);
            this.label12.TabIndex = 56;
            this.label12.Text = "UF";
            // 
            // cbUF
            // 
            this.cbUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbUF.Location = new System.Drawing.Point(629, 213);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(53, 24);
            this.cbUF.TabIndex = 12;
            this.cbUF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbUF_KeyDown);
            // 
            // txtnCOD
            // 
            this.txtnCOD.Enabled = false;
            this.txtnCOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnCOD.Location = new System.Drawing.Point(73, 89);
            this.txtnCOD.Name = "txtnCOD";
            this.txtnCOD.Size = new System.Drawing.Size(71, 22);
            this.txtnCOD.TabIndex = 1;
            this.txtnCOD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnCOD_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 52;
            this.label8.Text = "Cod";
            // 
            // txtnMunicipio
            // 
            this.txtnMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnMunicipio.Location = new System.Drawing.Point(281, 211);
            this.txtnMunicipio.Name = "txtnMunicipio";
            this.txtnMunicipio.Size = new System.Drawing.Size(298, 22);
            this.txtnMunicipio.TabIndex = 11;
            this.txtnMunicipio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnMunicipio_KeyDown);
            // 
            // txtnNumero
            // 
            this.txtnNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnNumero.Location = new System.Drawing.Point(564, 250);
            this.txtnNumero.Name = "txtnNumero";
            this.txtnNumero.Size = new System.Drawing.Size(84, 22);
            this.txtnNumero.TabIndex = 14;
            this.txtnNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnNumero_KeyDown);
            // 
            // txtnEndereco
            // 
            this.txtnEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnEndereco.Location = new System.Drawing.Point(105, 249);
            this.txtnEndereco.Name = "txtnEndereco";
            this.txtnEndereco.Size = new System.Drawing.Size(376, 22);
            this.txtnEndereco.TabIndex = 13;
            this.txtnEndereco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnEndereco_KeyDown);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(679, 19);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(80, 30);
            this.btCancelar.TabIndex = 21;
            this.btCancelar.Text = "Sai&r";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // txtnNome
            // 
            this.txtnNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnNome.Location = new System.Drawing.Point(266, 89);
            this.txtnNome.Name = "txtnNome";
            this.txtnNome.Size = new System.Drawing.Size(426, 22);
            this.txtnNome.TabIndex = 2;
            this.txtnNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnNome_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "CEP";
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(544, 19);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(80, 30);
            this.btExcluir.TabIndex = 20;
            this.btExcluir.Text = "&Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(201, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Município";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Endereço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(497, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Número";
            // 
            // btSalvar
            // 
            this.btSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSalvar.Location = new System.Drawing.Point(402, 19);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(80, 30);
            this.btSalvar.TabIndex = 19;
            this.btSalvar.Text = "&Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            this.btSalvar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btSalvar_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nome";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btCadastrarCodômino);
            this.groupBox1.Controls.Add(this.btConsultar);
            this.groupBox1.Controls.Add(this.btExcluir);
            this.groupBox1.Controls.Add(this.btCancelar);
            this.groupBox1.Controls.Add(this.btSalvar);
            this.groupBox1.Location = new System.Drawing.Point(12, 389);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 65);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // btCadastrarCodômino
            // 
            this.btCadastrarCodômino.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastrarCodômino.Location = new System.Drawing.Point(138, 14);
            this.btCadastrarCodômino.Name = "btCadastrarCodômino";
            this.btCadastrarCodômino.Size = new System.Drawing.Size(87, 40);
            this.btCadastrarCodômino.TabIndex = 23;
            this.btCadastrarCodômino.Text = "C&adastrar Condômino";
            this.btCadastrarCodômino.UseVisualStyleBackColor = true;
            this.btCadastrarCodômino.Click += new System.EventHandler(this.button1_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConsultar.Location = new System.Drawing.Point(25, 19);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(80, 30);
            this.btConsultar.TabIndex = 22;
            this.btConsultar.Text = "&Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 31);
            this.label1.TabIndex = 33;
            this.label1.Text = "Cadastro de Propritário";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "CPF";
            // 
            // txtnRG
            // 
            this.txtnRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnRG.Location = new System.Drawing.Point(251, 128);
            this.txtnRG.Name = "txtnRG";
            this.txtnRG.Size = new System.Drawing.Size(124, 22);
            this.txtnRG.TabIndex = 4;
            this.txtnRG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnRG_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(215, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 20);
            this.label10.TabIndex = 62;
            this.label10.Text = "RG";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(389, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 20);
            this.label11.TabIndex = 64;
            this.label11.Text = "Fone";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(598, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 20);
            this.label13.TabIndex = 66;
            this.label13.Text = "Fone";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(27, 174);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 20);
            this.label14.TabIndex = 68;
            this.label14.Text = "E-mail";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(573, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 20);
            this.label15.TabIndex = 70;
            this.label15.Text = "Estado civil";
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.Items.AddRange(new object[] {
            "SOLTEIRA",
            "CASADO (A)",
            "VIUVO (A)",
            "DIVORCIADO (A)"});
            this.cbEstadoCivil.Location = new System.Drawing.Point(663, 130);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(129, 24);
            this.cbEstadoCivil.TabIndex = 6;
            this.cbEstadoCivil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbEstadoCivil_KeyDown);
            // 
            // txtnFone1
            // 
            this.txtnFone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnFone1.Location = new System.Drawing.Point(438, 172);
            this.txtnFone1.Mask = "(99) 00000-0000";
            this.txtnFone1.Name = "txtnFone1";
            this.txtnFone1.Size = new System.Drawing.Size(154, 22);
            this.txtnFone1.TabIndex = 8;
            this.txtnFone1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnFone1_KeyDown);
            // 
            // txtnFone
            // 
            this.txtnFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnFone.Location = new System.Drawing.Point(646, 173);
            this.txtnFone.Mask = "(99) 00000-0000";
            this.txtnFone.Name = "txtnFone";
            this.txtnFone.Size = new System.Drawing.Size(146, 22);
            this.txtnFone.TabIndex = 9;
            this.txtnFone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnFone_KeyDown);
            // 
            // txtnEmail
            // 
            this.txtnEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnEmail.Location = new System.Drawing.Point(91, 172);
            this.txtnEmail.Name = "txtnEmail";
            this.txtnEmail.Size = new System.Drawing.Size(288, 22);
            this.txtnEmail.TabIndex = 7;
            this.txtnEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnEmail_KeyDown);
            // 
            // txtnCEP
            // 
            this.txtnCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnCEP.Location = new System.Drawing.Point(74, 211);
            this.txtnCEP.Mask = "00000-000";
            this.txtnCEP.Name = "txtnCEP";
            this.txtnCEP.Size = new System.Drawing.Size(121, 22);
            this.txtnCEP.TabIndex = 10;
            this.txtnCEP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnCEP_KeyDown);
            // 
            // txtnBairro
            // 
            this.txtnBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnBairro.Location = new System.Drawing.Point(105, 288);
            this.txtnBairro.Name = "txtnBairro";
            this.txtnBairro.Size = new System.Drawing.Size(260, 22);
            this.txtnBairro.TabIndex = 15;
            this.txtnBairro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnBairro_KeyDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(27, 288);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 20);
            this.label16.TabIndex = 74;
            this.label16.Text = "Bairro";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(391, 289);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 20);
            this.label17.TabIndex = 76;
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
            this.cbCondominio.Location = new System.Drawing.Point(501, 287);
            this.cbCondominio.Name = "cbCondominio";
            this.cbCondominio.Size = new System.Drawing.Size(291, 24);
            this.cbCondominio.TabIndex = 16;
            this.cbCondominio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbCondominio_KeyDown);
            // 
            // clbMorador
            // 
            this.clbMorador.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clbMorador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbMorador.FormattingEnabled = true;
            this.clbMorador.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.clbMorador.Location = new System.Drawing.Point(131, 327);
            this.clbMorador.Name = "clbMorador";
            this.clbMorador.Size = new System.Drawing.Size(122, 46);
            this.clbMorador.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 78;
            this.label9.Text = "Condômino?";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(501, 327);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(291, 24);
            this.comboBox1.TabIndex = 18;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(391, 331);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 20);
            this.label19.TabIndex = 123;
            this.label19.Text = "Unidade";
            // 
            // cbSexo
            // 
            this.cbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "FEMININO",
            "MASCULINO"});
            this.cbSexo.Location = new System.Drawing.Point(445, 129);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(125, 24);
            this.cbSexo.TabIndex = 5;
            this.cbSexo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbSexo_KeyDown);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(381, 129);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 20);
            this.label18.TabIndex = 127;
            this.label18.Text = "Sexo";
            // 
            // txtnCPF
            // 
            this.txtnCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnCPF.Location = new System.Drawing.Point(91, 127);
            this.txtnCPF.Mask = "000-000-000-00";
            this.txtnCPF.Name = "txtnCPF";
            this.txtnCPF.Size = new System.Drawing.Size(115, 22);
            this.txtnCPF.TabIndex = 3;
            this.txtnCPF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnCPF_KeyDown);
            // 
            // FrmCadProprietarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 462);
            this.Controls.Add(this.txtnCPF);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.clbMorador);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbCondominio);
            this.Controls.Add(this.txtnBairro);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtnCEP);
            this.Controls.Add(this.txtnFone);
            this.Controls.Add(this.txtnFone1);
            this.Controls.Add(this.cbEstadoCivil);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtnEmail);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtnRG);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btProximo);
            this.Controls.Add(this.btAnterior);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbUF);
            this.Controls.Add(this.txtnCOD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnMunicipio);
            this.Controls.Add(this.txtnNumero);
            this.Controls.Add(this.txtnEndereco);
            this.Controls.Add(this.txtnNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadProprietarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadProprietarios";
            this.Load += new System.EventHandler(this.FrmCadProprietarios_Load);
            this.Click += new System.EventHandler(this.CadProprietarios_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CadProprietarios_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btProximo;
        private System.Windows.Forms.Button btAnterior;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.TextBox txtnCOD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnMunicipio;
        private System.Windows.Forms.TextBox txtnNumero;
        private System.Windows.Forms.TextBox txtnEndereco;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox txtnNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnRG;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbEstadoCivil;
        private System.Windows.Forms.MaskedTextBox txtnFone1;
        private System.Windows.Forms.MaskedTextBox txtnFone;
        private System.Windows.Forms.TextBox txtnEmail;
        private System.Windows.Forms.MaskedTextBox txtnCEP;
        private System.Windows.Forms.TextBox txtnBairro;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbCondominio;
        private System.Windows.Forms.CheckedListBox clbMorador;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btCadastrarCodômino;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox txtnCPF;
    }
}