namespace Login.view
{
    partial class FrmDadosFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDadosFuncionario));
            this.label1 = new System.Windows.Forms.Label();
            this.txtnNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnObs = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.txtnDataAdmissao = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnPeriodo = new System.Windows.Forms.MaskedTextBox();
            this.txtnPeriodo2 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnDataDemissao = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnSalarioMensal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbOperaSistema = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnSenha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtnContato = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 31);
            this.label1.TabIndex = 195;
            this.label1.Text = "Dados Funcionários";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtnNome
            // 
            this.txtnNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnNome.Location = new System.Drawing.Point(162, 79);
            this.txtnNome.Name = "txtnNome";
            this.txtnNome.Size = new System.Drawing.Size(608, 22);
            this.txtnNome.TabIndex = 1;
            this.txtnNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnNome_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 180;
            this.label2.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtnObs);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(302, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 113);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Observações";
            // 
            // txtnObs
            // 
            this.txtnObs.Location = new System.Drawing.Point(8, 19);
            this.txtnObs.Multiline = true;
            this.txtnObs.Name = "txtnObs";
            this.txtnObs.Size = new System.Drawing.Size(467, 82);
            this.txtnObs.TabIndex = 11;
            this.txtnObs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnObs_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btCancelar);
            this.groupBox1.Controls.Add(this.btSalvar);
            this.groupBox1.Location = new System.Drawing.Point(11, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 65);
            this.groupBox1.TabIndex = 198;
            this.groupBox1.TabStop = false;
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
            this.btSalvar.Location = new System.Drawing.Point(547, 19);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(80, 30);
            this.btSalvar.TabIndex = 12;
            this.btSalvar.Text = "&Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            this.btSalvar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btSalvar_KeyDown);
            // 
            // txtnDataAdmissao
            // 
            this.txtnDataAdmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnDataAdmissao.Location = new System.Drawing.Point(162, 174);
            this.txtnDataAdmissao.Mask = "00/00/0000";
            this.txtnDataAdmissao.Name = "txtnDataAdmissao";
            this.txtnDataAdmissao.Size = new System.Drawing.Size(101, 22);
            this.txtnDataAdmissao.TabIndex = 5;
            this.txtnDataAdmissao.ValidatingType = typeof(System.DateTime);
            this.txtnDataAdmissao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnDataAdmissao_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 20);
            this.label11.TabIndex = 155;
            this.label11.Text = "Data Admissão";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 201;
            this.label3.Text = "Periodo";
            // 
            // txtnPeriodo
            // 
            this.txtnPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnPeriodo.Location = new System.Drawing.Point(346, 176);
            this.txtnPeriodo.Mask = "00:00";
            this.txtnPeriodo.Name = "txtnPeriodo";
            this.txtnPeriodo.Size = new System.Drawing.Size(51, 22);
            this.txtnPeriodo.TabIndex = 6;
            this.txtnPeriodo.ValidatingType = typeof(System.DateTime);
            this.txtnPeriodo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnPeriodo_KeyDown);
            // 
            // txtnPeriodo2
            // 
            this.txtnPeriodo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnPeriodo2.Location = new System.Drawing.Point(441, 176);
            this.txtnPeriodo2.Mask = "00:00";
            this.txtnPeriodo2.Name = "txtnPeriodo2";
            this.txtnPeriodo2.Size = new System.Drawing.Size(51, 22);
            this.txtnPeriodo2.TabIndex = 7;
            this.txtnPeriodo2.ValidatingType = typeof(System.DateTime);
            this.txtnPeriodo2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnPeriodo2_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(403, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 204;
            this.label4.Text = "ás";
            // 
            // cbCargo
            // 
            this.cbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Administrador",
            "Auxiliar Administrativo",
            "Gerente",
            "Porteiro",
            "Serviços gerais"});
            this.cbCargo.Location = new System.Drawing.Point(564, 127);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(213, 24);
            this.cbCargo.TabIndex = 4;
            this.cbCargo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbCargo_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(500, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 206;
            this.label9.Text = "Cargo";
            // 
            // txtnDataDemissao
            // 
            this.txtnDataDemissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnDataDemissao.Location = new System.Drawing.Point(640, 176);
            this.txtnDataDemissao.Mask = "00/00/0000";
            this.txtnDataDemissao.Name = "txtnDataDemissao";
            this.txtnDataDemissao.Size = new System.Drawing.Size(90, 22);
            this.txtnDataDemissao.TabIndex = 8;
            this.txtnDataDemissao.ValidatingType = typeof(System.DateTime);
            this.txtnDataDemissao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnDataDemissao_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(512, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 208;
            this.label5.Text = "Data Demissao";
            // 
            // txtnSalarioMensal
            // 
            this.txtnSalarioMensal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnSalarioMensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnSalarioMensal.Location = new System.Drawing.Point(165, 220);
            this.txtnSalarioMensal.Name = "txtnSalarioMensal";
            this.txtnSalarioMensal.Size = new System.Drawing.Size(100, 22);
            this.txtnSalarioMensal.TabIndex = 9;
            this.txtnSalarioMensal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnSalarioMensal_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 210;
            this.label6.Text = "Salario Mensal";
            // 
            // cbOperaSistema
            // 
            this.cbOperaSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperaSistema.FormattingEnabled = true;
            this.cbOperaSistema.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbOperaSistema.Location = new System.Drawing.Point(165, 127);
            this.cbOperaSistema.Name = "cbOperaSistema";
            this.cbOperaSistema.Size = new System.Drawing.Size(77, 24);
            this.cbOperaSistema.TabIndex = 2;
            this.cbOperaSistema.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbOperaSistema_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 212;
            this.label7.Text = "Opera Sistema?";
            // 
            // txtnSenha
            // 
            this.txtnSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnSenha.Location = new System.Drawing.Point(302, 127);
            this.txtnSenha.Name = "txtnSenha";
            this.txtnSenha.Size = new System.Drawing.Size(192, 22);
            this.txtnSenha.TabIndex = 3;
            this.txtnSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnSenha_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(246, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 214;
            this.label10.Text = "Senha";
            // 
            // txtnContato
            // 
            this.txtnContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnContato.Location = new System.Drawing.Point(348, 218);
            this.txtnContato.Name = "txtnContato";
            this.txtnContato.Size = new System.Drawing.Size(330, 22);
            this.txtnContato.TabIndex = 10;
            this.txtnContato.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnContato_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(277, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 218;
            this.label13.Text = "Contato";
            // 
            // FrmDadosFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 462);
            this.Controls.Add(this.txtnContato);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtnSenha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbOperaSistema);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtnSalarioMensal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnDataDemissao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnPeriodo2);
            this.Controls.Add(this.txtnPeriodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnDataAdmissao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnNome);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDadosFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDadosFuncionario";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DadosFuncionario_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtnObs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.MaskedTextBox txtnDataAdmissao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtnPeriodo;
        private System.Windows.Forms.MaskedTextBox txtnPeriodo2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtnDataDemissao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnSalarioMensal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbOperaSistema;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnSenha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtnContato;
        private System.Windows.Forms.Label label13;
    }
}