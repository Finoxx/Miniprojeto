namespace miniprojeto
{
    partial class frmminiprojeto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbostatus = new System.Windows.Forms.ComboBox();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.lblOBS = new System.Windows.Forms.Label();
            this.txtmcpf = new System.Windows.Forms.MaskedTextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.lblogin = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btocadastro = new System.Windows.Forms.Button();
            this.btoAlterar = new System.Windows.Forms.Button();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.btoexcluir = new System.Windows.Forms.Button();
            this.btoSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Controls.Add(this.lblcodigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(129, 46);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(29, 23);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(9, 46);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(114, 23);
            this.txtcodigo.TabIndex = 1;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(13, 20);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(49, 15);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Codigo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbostatus);
            this.groupBox2.Controls.Add(this.txtobs);
            this.groupBox2.Controls.Add(this.lblOBS);
            this.groupBox2.Controls.Add(this.txtmcpf);
            this.groupBox2.Controls.Add(this.txtsenha);
            this.groupBox2.Controls.Add(this.txtlogin);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.lblCPF);
            this.groupBox2.Controls.Add(this.lblsenha);
            this.groupBox2.Controls.Add(this.lblogin);
            this.groupBox2.Controls.Add(this.txtnome);
            this.groupBox2.Controls.Add(this.lblnome);
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 241);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // cbostatus
            // 
            this.cbostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbostatus.FormattingEnabled = true;
            this.cbostatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbostatus.Location = new System.Drawing.Point(370, 119);
            this.cbostatus.Name = "cbostatus";
            this.cbostatus.Size = new System.Drawing.Size(121, 23);
            this.cbostatus.TabIndex = 4;
            // 
            // txtobs
            // 
            this.txtobs.Location = new System.Drawing.Point(0, 198);
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(493, 23);
            this.txtobs.TabIndex = 5;
            // 
            // lblOBS
            // 
            this.lblOBS.AutoSize = true;
            this.lblOBS.Location = new System.Drawing.Point(13, 180);
            this.lblOBS.Name = "lblOBS";
            this.lblOBS.Size = new System.Drawing.Size(31, 15);
            this.lblOBS.TabIndex = 5;
            this.lblOBS.Text = "Obs:";
            // 
            // txtmcpf
            // 
            this.txtmcpf.Location = new System.Drawing.Point(216, 119);
            this.txtmcpf.Mask = "###,###,###-##";
            this.txtmcpf.Name = "txtmcpf";
            this.txtmcpf.Size = new System.Drawing.Size(98, 23);
            this.txtmcpf.TabIndex = 3;
            this.txtmcpf.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(102, 119);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(95, 23);
            this.txtsenha.TabIndex = 2;
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(0, 119);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(86, 23);
            this.txtlogin.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(370, 92);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 15);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(216, 92);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(31, 15);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF:";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(102, 92);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(42, 15);
            this.lblsenha.TabIndex = 2;
            this.lblsenha.Text = "Senha:";
            // 
            // lblogin
            // 
            this.lblogin.AutoSize = true;
            this.lblogin.Location = new System.Drawing.Point(13, 92);
            this.lblogin.Name = "lblogin";
            this.lblogin.Size = new System.Drawing.Size(40, 15);
            this.lblogin.TabIndex = 2;
            this.lblogin.Text = "Login:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(0, 51);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(491, 23);
            this.txtnome.TabIndex = 0;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(13, 19);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(43, 15);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btocadastro);
            this.groupBox3.Controls.Add(this.btoAlterar);
            this.groupBox3.Controls.Add(this.btoLimpar);
            this.groupBox3.Controls.Add(this.btoexcluir);
            this.groupBox3.Controls.Add(this.btoSair);
            this.groupBox3.Location = new System.Drawing.Point(12, 374);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 67);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btocadastro
            // 
            this.btocadastro.Location = new System.Drawing.Point(102, 38);
            this.btocadastro.Name = "btocadastro";
            this.btocadastro.Size = new System.Drawing.Size(75, 23);
            this.btocadastro.TabIndex = 0;
            this.btocadastro.Text = "Cadastrar";
            this.btocadastro.UseVisualStyleBackColor = true;
            this.btocadastro.Click += new System.EventHandler(this.btocadastro_Click);
            // 
            // btoAlterar
            // 
            this.btoAlterar.Location = new System.Drawing.Point(175, 38);
            this.btoAlterar.Name = "btoAlterar";
            this.btoAlterar.Size = new System.Drawing.Size(75, 23);
            this.btoAlterar.TabIndex = 0;
            this.btoAlterar.Text = "ALterar";
            this.btoAlterar.UseVisualStyleBackColor = true;
            // 
            // btoLimpar
            // 
            this.btoLimpar.Location = new System.Drawing.Point(256, 38);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(75, 23);
            this.btoLimpar.TabIndex = 0;
            this.btoLimpar.Text = "Limpar";
            this.btoLimpar.UseVisualStyleBackColor = true;
            this.btoLimpar.Click += new System.EventHandler(this.btoLimpar_Click);
            // 
            // btoexcluir
            // 
            this.btoexcluir.Location = new System.Drawing.Point(337, 38);
            this.btoexcluir.Name = "btoexcluir";
            this.btoexcluir.Size = new System.Drawing.Size(75, 23);
            this.btoexcluir.TabIndex = 0;
            this.btoexcluir.Text = "Excluir";
            this.btoexcluir.UseVisualStyleBackColor = true;
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(423, 38);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(75, 23);
            this.btoSair.TabIndex = 0;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // frmminiprojeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmminiprojeto";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmminiprojeto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private MaskedTextBox maskedTextBox1;
        private TextBox txtcodigo;
        private Label lblcodigo;
        private GroupBox groupBox2;
        private ComboBox cbostatus;
        private TextBox txtobs;
        private Label lblOBS;
        private MaskedTextBox txtmcpf;
        private TextBox txtsenha;
        private TextBox txtlogin;
        private Label lblStatus;
        private Label lblCPF;
        private Label lblsenha;
        private Label lblogin;
        private TextBox txtnome;
        private Label lblnome;
        private GroupBox groupBox3;
        private Button btocadastro;
        private Button btoAlterar;
        private Button btoLimpar;
        private Button btoexcluir;
        private Button btoSair;
    }
}