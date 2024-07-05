namespace MyForms
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtPassword = new TextBox();
            bttLogin = new Button();
            bttLogon = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 16);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 93);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtName
            // 
            txtName.Location = new Point(76, 34);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            txtName.KeyDown += txtName_KeyDown;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(76, 111);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 3;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // bttLogin
            // 
            bttLogin.Location = new Point(158, 159);
            bttLogin.Name = "bttLogin";
            bttLogin.Size = new Size(75, 23);
            bttLogin.TabIndex = 4;
            bttLogin.Text = "Log in";
            bttLogin.UseVisualStyleBackColor = true;
            bttLogin.Click += bttLogin_Click;
            // 
            // bttLogon
            // 
            bttLogon.Location = new Point(22, 159);
            bttLogon.Name = "bttLogon";
            bttLogon.Size = new Size(75, 23);
            bttLogon.TabIndex = 5;
            bttLogon.Text = "Log on";
            bttLogon.UseVisualStyleBackColor = true;
            bttLogon.Click += bttLogon_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 203);
            Controls.Add(bttLogon);
            Controls.Add(bttLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtPassword;
        private Button bttLogin;
        private Button bttLogon;
    }
}
