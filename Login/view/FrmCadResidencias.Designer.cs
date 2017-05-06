namespace Login.view
{
    partial class FrmCadResidencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadResidencias));
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btNovoCadastro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnAreaTotalConstruida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnBloco1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipo1 = new System.Windows.Forms.ComboBox();
            this.txtnNomeResidencia1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnAreaTotalTerreno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnFraçãoIdeal = new System.Windows.Forms.TextBox();
            this.txtnNomeResidencia2 = new System.Windows.Forms.TextBox();
            this.txtnBloco2 = new System.Windows.Forms.TextBox();
            this.cbTipo2 = new System.Windows.Forms.ComboBox();
            this.txtnNomeResidencia3 = new System.Windows.Forms.TextBox();
            this.txtnBloco3 = new System.Windows.Forms.TextBox();
            this.cbTipo3 = new System.Windows.Forms.ComboBox();
            this.txtnCod3 = new System.Windows.Forms.TextBox();
            this.txtnCod2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnCod1 = new System.Windows.Forms.TextBox();
            this.cbCondominio = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(55, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 20);
            this.label17.TabIndex = 145;
            this.label17.Text = "Condominio";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btConsultar);
            this.groupBox1.Controls.Add(this.btExcluir);
            this.groupBox1.Controls.Add(this.btCancelar);
            this.groupBox1.Controls.Add(this.btSalvar);
            this.groupBox1.Controls.Add(this.btNovoCadastro);
            this.groupBox1.Location = new System.Drawing.Point(11, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 65);
            this.groupBox1.TabIndex = 136;
            this.groupBox1.TabStop = false;
            // 
            // btConsultar
            // 
            this.btConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConsultar.Location = new System.Drawing.Point(25, 19);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(80, 30);
            this.btConsultar.TabIndex = 21;
            this.btConsultar.Text = "&Consultar ";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            this.btConsultar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btConsultar_KeyDown);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(544, 19);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(80, 30);
            this.btExcluir.TabIndex = 19;
            this.btExcluir.Text = "&Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(679, 19);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(80, 30);
            this.btCancelar.TabIndex = 20;
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
            this.btSalvar.TabIndex = 18;
            this.btSalvar.Text = "&Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            this.btSalvar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btSalvar_KeyDown);
            // 
            // btNovoCadastro
            // 
            this.btNovoCadastro.Location = new System.Drawing.Point(135, 17);
            this.btNovoCadastro.Name = "btNovoCadastro";
            this.btNovoCadastro.Size = new System.Drawing.Size(75, 36);
            this.btNovoCadastro.TabIndex = 22;
            this.btNovoCadastro.Text = "&Novo cadastro";
            this.btNovoCadastro.UseVisualStyleBackColor = true;
            this.btNovoCadastro.Click += new System.EventHandler(this.btNovoCadastro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 31);
            this.label1.TabIndex = 135;
            this.label1.Text = "Cadastro lote residencial";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtnAreaTotalConstruida
            // 
            this.txtnAreaTotalConstruida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnAreaTotalConstruida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnAreaTotalConstruida.Location = new System.Drawing.Point(697, 69);
            this.txtnAreaTotalConstruida.Name = "txtnAreaTotalConstruida";
            this.txtnAreaTotalConstruida.Size = new System.Drawing.Size(87, 22);
            this.txtnAreaTotalConstruida.TabIndex = 3;
            this.txtnAreaTotalConstruida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnAreaTotalConstruida_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(462, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 158;
            this.label3.Text = "Bloco";
            // 
            // txtnBloco1
            // 
            this.txtnBloco1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnBloco1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnBloco1.Location = new System.Drawing.Point(441, 157);
            this.txtnBloco1.Name = "txtnBloco1";
            this.txtnBloco1.Size = new System.Drawing.Size(83, 22);
            this.txtnBloco1.TabIndex = 6;
            this.txtnBloco1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnBloco1_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(593, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 160;
            this.label4.Text = "Tipo";
            // 
            // cbTipo1
            // 
            this.cbTipo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo1.FormattingEnabled = true;
            this.cbTipo1.Items.AddRange(new object[] {
            "Comercio",
            "Garagem",
            "Habitação",
            "Parqueamento"});
            this.cbTipo1.Location = new System.Drawing.Point(589, 157);
            this.cbTipo1.Name = "cbTipo1";
            this.cbTipo1.Size = new System.Drawing.Size(180, 24);
            this.cbTipo1.TabIndex = 7;
            this.cbTipo1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbTipo1_KeyDown);
            // 
            // txtnNomeResidencia1
            // 
            this.txtnNomeResidencia1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnNomeResidencia1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnNomeResidencia1.Location = new System.Drawing.Point(169, 155);
            this.txtnNomeResidencia1.Name = "txtnNomeResidencia1";
            this.txtnNomeResidencia1.Size = new System.Drawing.Size(212, 22);
            this.txtnNomeResidencia1.TabIndex = 5;
            this.txtnNomeResidencia1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtnNomeResidencia1_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 156;
            this.label2.Text = "Nome da residencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(570, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 191;
            this.label5.Text = "Área Construida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(311, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 196;
            this.label6.Text = "Área total terreno";
            // 
            // txtnAreaTotalTerreno
            // 
            this.txtnAreaTotalTerreno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnAreaTotalTerreno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnAreaTotalTerreno.Location = new System.Drawing.Point(450, 70);
            this.txtnAreaTotalTerreno.Name = "txtnAreaTotalTerreno";
            this.txtnAreaTotalTerreno.Size = new System.Drawing.Size(103, 22);
            this.txtnAreaTotalTerreno.TabIndex = 2;
            this.txtnAreaTotalTerreno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnAreaTotalTerreno_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(540, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 198;
            this.label8.Text = "Fração ideial";
            // 
            // txtnFraçãoIdeal
            // 
            this.txtnFraçãoIdeal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnFraçãoIdeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnFraçãoIdeal.Location = new System.Drawing.Point(645, 335);
            this.txtnFraçãoIdeal.Name = "txtnFraçãoIdeal";
            this.txtnFraçãoIdeal.Size = new System.Drawing.Size(124, 22);
            this.txtnFraçãoIdeal.TabIndex = 29;
            this.txtnFraçãoIdeal.TextChanged += new System.EventHandler(this.txtnFraçãoIdeal_TextChanged);
            // 
            // txtnNomeResidencia2
            // 
            this.txtnNomeResidencia2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnNomeResidencia2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnNomeResidencia2.Location = new System.Drawing.Point(169, 202);
            this.txtnNomeResidencia2.Name = "txtnNomeResidencia2";
            this.txtnNomeResidencia2.Size = new System.Drawing.Size(213, 22);
            this.txtnNomeResidencia2.TabIndex = 10;
            this.txtnNomeResidencia2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnNomeResidencia2_KeyDown);
            // 
            // txtnBloco2
            // 
            this.txtnBloco2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnBloco2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnBloco2.Location = new System.Drawing.Point(442, 204);
            this.txtnBloco2.Name = "txtnBloco2";
            this.txtnBloco2.Size = new System.Drawing.Size(83, 22);
            this.txtnBloco2.TabIndex = 11;
            this.txtnBloco2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnBloco2_KeyDown);
            // 
            // cbTipo2
            // 
            this.cbTipo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo2.FormattingEnabled = true;
            this.cbTipo2.Items.AddRange(new object[] {
            "Comercio",
            "Garagem",
            "Habitação",
            "Parqueamento"});
            this.cbTipo2.Location = new System.Drawing.Point(590, 204);
            this.cbTipo2.Name = "cbTipo2";
            this.cbTipo2.Size = new System.Drawing.Size(180, 24);
            this.cbTipo2.TabIndex = 12;
            this.cbTipo2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbTipo2_KeyDown);
            // 
            // txtnNomeResidencia3
            // 
            this.txtnNomeResidencia3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnNomeResidencia3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnNomeResidencia3.Location = new System.Drawing.Point(169, 246);
            this.txtnNomeResidencia3.Name = "txtnNomeResidencia3";
            this.txtnNomeResidencia3.Size = new System.Drawing.Size(213, 22);
            this.txtnNomeResidencia3.TabIndex = 15;
            this.txtnNomeResidencia3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnNomeResidencia3_KeyDown);
            // 
            // txtnBloco3
            // 
            this.txtnBloco3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnBloco3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnBloco3.Location = new System.Drawing.Point(442, 248);
            this.txtnBloco3.Name = "txtnBloco3";
            this.txtnBloco3.Size = new System.Drawing.Size(83, 22);
            this.txtnBloco3.TabIndex = 16;
            this.txtnBloco3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnBloco3_KeyDown);
            // 
            // cbTipo3
            // 
            this.cbTipo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo3.FormattingEnabled = true;
            this.cbTipo3.Items.AddRange(new object[] {
            "Comercio",
            "Garagem",
            "Habitação",
            "Parqueamento"});
            this.cbTipo3.Location = new System.Drawing.Point(590, 248);
            this.cbTipo3.Name = "cbTipo3";
            this.cbTipo3.Size = new System.Drawing.Size(180, 24);
            this.cbTipo3.TabIndex = 17;
            this.cbTipo3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbTipo3_KeyDown);
            // 
            // txtnCod3
            // 
            this.txtnCod3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnCod3.Enabled = false;
            this.txtnCod3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnCod3.Location = new System.Drawing.Point(80, 243);
            this.txtnCod3.Name = "txtnCod3";
            this.txtnCod3.Size = new System.Drawing.Size(47, 22);
            this.txtnCod3.TabIndex = 14;
            this.txtnCod3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnCod3_KeyDown);
            // 
            // txtnCod2
            // 
            this.txtnCod2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnCod2.Enabled = false;
            this.txtnCod2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnCod2.Location = new System.Drawing.Point(80, 199);
            this.txtnCod2.Name = "txtnCod2";
            this.txtnCod2.Size = new System.Drawing.Size(47, 22);
            this.txtnCod2.TabIndex = 9;
            this.txtnCod2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnCod2_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(83, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 20);
            this.label9.TabIndex = 204;
            this.label9.Text = "Cod";
            // 
            // txtnCod1
            // 
            this.txtnCod1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnCod1.Enabled = false;
            this.txtnCod1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnCod1.Location = new System.Drawing.Point(79, 152);
            this.txtnCod1.Name = "txtnCod1";
            this.txtnCod1.Size = new System.Drawing.Size(47, 22);
            this.txtnCod1.TabIndex = 4;
            this.txtnCod1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnCod1_KeyDown);
            // 
            // cbCondominio
            // 
            this.cbCondominio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbCondominio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCondominio.Location = new System.Drawing.Point(146, 71);
            this.cbCondominio.Name = "cbCondominio";
            this.cbCondominio.Size = new System.Drawing.Size(159, 22);
            this.cbCondominio.TabIndex = 1;
            // 
            // FrmCadResidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 462);
            this.Controls.Add(this.cbCondominio);
            this.Controls.Add(this.txtnCod3);
            this.Controls.Add(this.txtnCod2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtnCod1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnFraçãoIdeal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnAreaTotalTerreno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTipo3);
            this.Controls.Add(this.txtnBloco3);
            this.Controls.Add(this.txtnNomeResidencia3);
            this.Controls.Add(this.cbTipo2);
            this.Controls.Add(this.txtnBloco2);
            this.Controls.Add(this.txtnNomeResidencia2);
            this.Controls.Add(this.cbTipo1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnBloco1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnNomeResidencia1);
            this.Controls.Add(this.txtnAreaTotalConstruida);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadResidencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadResidencias";
            this.Load += new System.EventHandler(this.FrmCadResidencias_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CadResidencias_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btNovoCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnAreaTotalConstruida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnBloco1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipo1;
        private System.Windows.Forms.TextBox txtnNomeResidencia1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnAreaTotalTerreno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnFraçãoIdeal;
        private System.Windows.Forms.TextBox txtnNomeResidencia2;
        private System.Windows.Forms.TextBox txtnBloco2;
        private System.Windows.Forms.ComboBox cbTipo2;
        private System.Windows.Forms.TextBox txtnNomeResidencia3;
        private System.Windows.Forms.TextBox txtnBloco3;
        private System.Windows.Forms.ComboBox cbTipo3;
        private System.Windows.Forms.TextBox txtnCod3;
        private System.Windows.Forms.TextBox txtnCod2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtnCod1;
        private System.Windows.Forms.TextBox cbCondominio;
    }
}