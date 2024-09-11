namespace BasicCreatNoteWinForm
{
    partial class login
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
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            buttonLogin = new Button();
            buttonReset = new Button();
            labelPassword = new Label();
            labelLogin = new Label();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPassword.Location = new Point(317, 299);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(430, 50);
            textBoxPassword.TabIndex = 0;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxLogin.Location = new Point(317, 165);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(430, 50);
            textBoxLogin.TabIndex = 1;
            textBoxLogin.TextChanged += textBoxLogin_TextChanged;
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonLogin.Location = new Point(317, 414);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(181, 66);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonReset.Location = new Point(566, 414);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(181, 66);
            buttonReset.TabIndex = 3;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPassword.Location = new Point(167, 312);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(111, 32);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLogin.Location = new Point(167, 178);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(73, 32);
            labelLogin.TabIndex = 5;
            labelLogin.Text = "Login";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1073, 655);
            Controls.Add(labelLogin);
            Controls.Add(labelPassword);
            Controls.Add(buttonReset);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxPassword);
            Name = "login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private Button buttonLogin;
        private Button buttonReset;
        private Label labelPassword;
        private Label labelLogin;
    }
}