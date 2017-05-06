namespace Login.view
{
    partial class FrmCadCondômino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadCondômino));
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbCondominio = new System.Windows.Forms.ComboBox();
            this.txtnFone = new System.Windows.Forms.MaskedTextBox();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtnEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btNovo = new System.Windows.Forms.Button();
            this.txtnCOD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUnidade = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btMaismoradores = new System.Windows.Forms.Button();
            this.txtnFoneConjugue = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnNomeConjugue = new System.Windows.Forms.TextBox();
            this.txtnCpfConjugue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.clbAtivoInativo = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtnCPF = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(465, 247);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 20);
            this.label18.TabIndex = 119;
            this.label18.Text = "Unidade";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(26, 245);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 20);
            this.label17.TabIndex = 117;
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
            this.cbCondominio.Location = new System.Drawing.Point(121, 243);
            this.cbCondominio.Name = "cbCondominio";
            this.cbCondominio.Size = new System.Drawing.Size(314, 24);
            this.cbCondominio.TabIndex = 9;
            this.cbCondominio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbCondominio_KeyDown);
            // 
            // txtnFone
            // 
            this.txtnFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnFone.Location = new System.Drawing.Point(296, 129);
            this.txtnFone.Mask = "(99) 00000-0000";
            this.txtnFone.Name = "txtnFone";
            this.txtnFone.Size = new System.Drawing.Size(146, 22);
            this.txtnFone.TabIndex = 4;
            this.txtnFone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnFone_KeyDown);
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
            this.cbEstadoCivil.Location = new System.Drawing.Point(588, 205);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(146, 24);
            this.cbEstadoCivil.TabIndex = 8;
            this.cbEstadoCivil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbEstadoCivil_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(465, 208);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 20);
            this.label15.TabIndex = 115;
            this.label15.Text = "Estado civil";
            // 
            // txtnEmail
            // 
            this.txtnEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnEmail.Location = new System.Drawing.Point(90, 206);
            this.txtnEmail.Name = "txtnEmail";
            this.txtnEmail.Size = new System.Drawing.Size(345, 22);
            this.txtnEmail.TabIndex = 7;
            this.txtnEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnEmail_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(26, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 20);
            this.label14.TabIndex = 114;
            this.label14.Text = "E-mail";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(248, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 20);
            this.label13.TabIndex = 113;
            this.label13.Text = "Fone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 110;
            this.label3.Text = "CPF";
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(158, 89);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(47, 21);
            this.btNovo.TabIndex = 109;
            this.btNovo.Text = "&Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            // 
            // txtnCOD
            // 
            this.txtnCOD.Enabled = false;
            this.txtnCOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnCOD.Location = new System.Drawing.Point(87, 88);
            this.txtnCOD.Name = "txtnCOD";
            this.txtnCOD.Size = new System.Drawing.Size(65, 22);
            this.txtnCOD.TabIndex = 1;
            this.txtnCOD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnCOD_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 105;
            this.label8.Text = "Cod";
            // 
            // txtnNome
            // 
            this.txtnNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnNome.Location = new System.Drawing.Point(260, 89);
            this.txtnNome.Name = "txtnNome";
            this.txtnNome.Size = new System.Drawing.Size(540, 22);
            this.txtnNome.TabIndex = 2;
            this.txtnNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnNome_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 100;
            this.label2.Text = "Nome";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btConsultar);
            this.groupBox1.Controls.Add(this.btExcluir);
            this.groupBox1.Controls.Add(this.btCancelar);
            this.groupBox1.Controls.Add(this.btSalvar);
            this.groupBox1.Location = new System.Drawing.Point(11, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 65);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            // 
            // btConsultar
            // 
            this.btConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConsultar.Location = new System.Drawing.Point(25, 19);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(80, 30);
            this.btConsultar.TabIndex = 16;
            this.btConsultar.Text = "&Consultar ";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(544, 19);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(80, 30);
            this.btExcluir.TabIndex = 17;
            this.btExcluir.Text = "&Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(679, 19);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(80, 30);
            this.btCancelar.TabIndex = 18;
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
            this.btSalvar.TabIndex = 15;
            this.btSalvar.Text = "&Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 31);
            this.label1.TabIndex = 98;
            this.label1.Text = "Cadastro do Condômino";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbUnidade
            // 
            this.cbUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnidade.FormattingEnabled = true;
            this.cbUnidade.Items.AddRange(new object[] {
            "Todos",
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
            this.cbUnidade.Location = new System.Drawing.Point(588, 245);
            this.cbUnidade.Name = "cbUnidade";
            this.cbUnidade.Size = new System.Drawing.Size(146, 24);
            this.cbUnidade.TabIndex = 10;
            this.cbUnidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbUnidade_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btMaismoradores);
            this.groupBox2.Controls.Add(this.txtnFoneConjugue);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtnNomeConjugue);
            this.groupBox2.Controls.Add(this.txtnCpfConjugue);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(789, 102);
            this.groupBox2.TabIndex = 123;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cônjugue";
            // 
            // btMaismoradores
            // 
            this.btMaismoradores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMaismoradores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMaismoradores.Location = new System.Drawing.Point(642, 25);
            this.btMaismoradores.Name = "btMaismoradores";
            this.btMaismoradores.Size = new System.Drawing.Size(105, 62);
            this.btMaismoradores.TabIndex = 14;
            this.btMaismoradores.Text = "+ &Moradores ";
            this.btMaismoradores.UseVisualStyleBackColor = true;
            this.btMaismoradores.Click += new System.EventHandler(this.btMaismoradores_Click);
            // 
            // txtnFoneConjugue
            // 
            this.txtnFoneConjugue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnFoneConjugue.Location = new System.Drawing.Point(265, 66);
            this.txtnFoneConjugue.Mask = "(99) 00000-0000";
            this.txtnFoneConjugue.Name = "txtnFoneConjugue";
            this.txtnFoneConjugue.Size = new System.Drawing.Size(146, 22);
            this.txtnFoneConjugue.TabIndex = 13;
            this.txtnFoneConjugue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnFoneConjugue_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 127;
            this.label7.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 129;
            this.label5.Text = "Fone";
            // 
            // txtnNomeConjugue
            // 
            this.txtnNomeConjugue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnNomeConjugue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnNomeConjugue.Location = new System.Drawing.Point(67, 29);
            this.txtnNomeConjugue.Name = "txtnNomeConjugue";
            this.txtnNomeConjugue.Size = new System.Drawing.Size(517, 22);
            this.txtnNomeConjugue.TabIndex = 11;
            this.txtnNomeConjugue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnNomeConjugue_KeyDown);
            // 
            // txtnCpfConjugue
            // 
            this.txtnCpfConjugue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnCpfConjugue.Location = new System.Drawing.Point(68, 65);
            this.txtnCpfConjugue.Name = "txtnCpfConjugue";
            this.txtnCpfConjugue.Size = new System.Drawing.Size(136, 22);
            this.txtnCpfConjugue.TabIndex = 12;
            this.txtnCpfConjugue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnCpfConjugue_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 128;
            this.label6.Text = "CPF";
            // 
            // cbSexo
            // 
            this.cbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "FEMININO",
            "MASCULINO"});
            this.cbSexo.Location = new System.Drawing.Point(90, 167);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(146, 24);
            this.cbSexo.TabIndex = 6;
            this.cbSexo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbSexo_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 125;
            this.label9.Text = "Sexo";
            // 
            // clbAtivoInativo
            // 
            this.clbAtivoInativo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clbAtivoInativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbAtivoInativo.FormattingEnabled = true;
            this.clbAtivoInativo.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.clbAtivoInativo.Location = new System.Drawing.Point(658, 124);
            this.clbAtivoInativo.Name = "clbAtivoInativo";
            this.clbAtivoInativo.Size = new System.Drawing.Size(120, 46);
            this.clbAtivoInativo.TabIndex = 5;
            this.clbAtivoInativo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clbAtivoInativo_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(572, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 127;
            this.label10.Text = "Cadastro";
            // 
            // txtnCPF
            // 
            this.txtnCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnCPF.Location = new System.Drawing.Point(90, 128);
            this.txtnCPF.Mask = "000-000-000-00";
            this.txtnCPF.Name = "txtnCPF";
            this.txtnCPF.Size = new System.Drawing.Size(146, 22);
            this.txtnCPF.TabIndex = 3;
            this.txtnCPF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnCPF_KeyDown);
            // 
            // FrmCadCondômino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 462);
            this.Controls.Add(this.txtnCPF);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.clbAtivoInativo);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbUnidade);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbCondominio);
            this.Controls.Add(this.txtnFone);
            this.Controls.Add(this.cbEstadoCivil);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtnEmail);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnCOD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadCondômino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadCondômino";
            this.Load += new System.EventHandler(this.FrmCadCondômino_Load);
            this.Click += new System.EventHandler(this.CadCondômino_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CadCondômino_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbCondominio;
        private System.Windows.Forms.MaskedTextBox txtnFone;
        private System.Windows.Forms.ComboBox cbEstadoCivil;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtnEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.TextBox txtnCOD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUnidade;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtnFoneConjugue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnNomeConjugue;
        private System.Windows.Forms.TextBox txtnCpfConjugue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckedListBox clbAtivoInativo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btMaismoradores;
        private System.Windows.Forms.MaskedTextBox txtnCPF;
    }
}