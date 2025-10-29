namespace Tugas_Pak_Selamet
{
    partial class Form1
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
            txtUsername = new Label();
            txtPassword = new Label();
            tb_username = new TextBox();
            tb_password = new TextBox();
            btn_confirm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(162, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 37);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += btnKonfirmasi_Click;
            // 
            // txtUsername
            // 
            txtUsername.AutoSize = true;
            txtUsername.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(10, 90);
            txtUsername.Margin = new Padding(2, 0, 2, 0);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(123, 28);
            txtUsername.TabIndex = 1;
            txtUsername.Text = "Username :";
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(10, 150);
            txtPassword.Margin = new Padding(2, 0, 2, 0);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(120, 28);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "Password :";
            // 
            // tb_username
            // 
            tb_username.BorderStyle = BorderStyle.FixedSingle;
            tb_username.Location = new Point(128, 92);
            tb_username.Margin = new Padding(2);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(120, 27);
            tb_username.TabIndex = 3;
            // 
            // tb_password
            // 
            tb_password.BorderStyle = BorderStyle.FixedSingle;
            tb_password.Location = new Point(128, 153);
            tb_password.Margin = new Padding(2);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(120, 27);
            tb_password.TabIndex = 4;
            // 
            // btn_confirm
            // 
            btn_confirm.Location = new Point(74, 249);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(222, 45);
            btn_confirm.TabIndex = 5;
            btn_confirm.Text = "Confirm";
            btn_confirm.UseVisualStyleBackColor = true;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 384);
            Controls.Add(btn_confirm);
            Controls.Add(tb_password);
            Controls.Add(tb_username);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "S";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label txtUsername;
        private Label txtPassword;
        private TextBox tb_username;
        private TextBox tb_password;
        private Button btnKonfirmasi;
        private Button btn_confirm;
    }
}
