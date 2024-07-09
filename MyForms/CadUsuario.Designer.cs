namespace MyForms
{
    partial class CadUsuario
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            label5 = new Label();
            bttCadastrar = new Button();
            bttCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 39);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 80);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 118);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Login";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 161);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Senha";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(105, 36);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 4;
            txtNome.KeyDown += textBox1_KeyDown;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(105, 77);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 5;
            txtEmail.KeyDown += txtEmail_KeyDown;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(105, 115);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(100, 23);
            txtLogin.TabIndex = 6;
            txtLogin.KeyDown += txtLogin_KeyDown;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(105, 158);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 7;
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 9);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 8;
            label5.Text = "Cadastro de Usuário";
            // 
            // bttCadastrar
            // 
            bttCadastrar.Location = new Point(156, 198);
            bttCadastrar.Name = "bttCadastrar";
            bttCadastrar.Size = new Size(75, 23);
            bttCadastrar.TabIndex = 9;
            bttCadastrar.Text = "Cadastrar";
            bttCadastrar.UseVisualStyleBackColor = true;
            bttCadastrar.Click += bttCadastrar_Click;
            // 
            // bttCancel
            // 
            bttCancel.Location = new Point(24, 198);
            bttCancel.Name = "bttCancel";
            bttCancel.Size = new Size(76, 23);
            bttCancel.TabIndex = 10;
            bttCancel.Text = "Cancelar";
            bttCancel.UseVisualStyleBackColor = true;
            bttCancel.Click += bttCancel_Click;
            // 
            // CadUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 237);
            Controls.Add(bttCancel);
            Controls.Add(bttCadastrar);
            Controls.Add(label5);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadUsuario";
            Text = "CadUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label label5;
        private Button bttCadastrar;
        private Button bttCancel;
    }
}