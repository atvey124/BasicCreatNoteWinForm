namespace BasicCreatNoteWinForm
{
    partial class FormMain
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
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            textBoxRepeatPassword = new TextBox();
            labelLogin = new Label();
            labelPassword = new Label();
            labelRepeatPassword = new Label();
            buttonRegister = new Button();
            buttonReset = new Button();
            labelredirectLogin = new Label();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = SystemColors.ButtonHighlight;
            textBoxLogin.Cursor = Cursors.IBeam;
            textBoxLogin.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxLogin.Location = new Point(454, 163);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(492, 57);
            textBoxLogin.TabIndex = 0;
            textBoxLogin.TextChanged += textBoxLogin_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Cursor = Cursors.IBeam;
            textBoxPassword.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxPassword.Location = new Point(454, 289);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(492, 57);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // textBoxRepeatPassword
            // 
            textBoxRepeatPassword.Cursor = Cursors.IBeam;
            textBoxRepeatPassword.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxRepeatPassword.Location = new Point(454, 420);
            textBoxRepeatPassword.Name = "textBoxRepeatPassword";
            textBoxRepeatPassword.Size = new Size(492, 57);
            textBoxRepeatPassword.TabIndex = 2;
            textBoxRepeatPassword.TextChanged += textBoxRepeatPassword_TextChanged;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLogin.Location = new Point(147, 170);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(176, 45);
            labelLogin.TabIndex = 3;
            labelLogin.Text = "Input login";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPassword.Location = new Point(147, 296);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(239, 45);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Input password";
            // 
            // labelRepeatPassword
            // 
            labelRepeatPassword.AutoSize = true;
            labelRepeatPassword.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelRepeatPassword.Location = new Point(147, 427);
            labelRepeatPassword.Name = "labelRepeatPassword";
            labelRepeatPassword.Size = new Size(262, 45);
            labelRepeatPassword.TabIndex = 5;
            labelRepeatPassword.Text = "Repeat password";
            // 
            // buttonRegister
            // 
            buttonRegister.Cursor = Cursors.Hand;
            buttonRegister.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRegister.Location = new Point(454, 540);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(203, 63);
            buttonRegister.TabIndex = 6;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // buttonReset
            // 
            buttonReset.Cursor = Cursors.Hand;
            buttonReset.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonReset.Location = new Point(743, 540);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(203, 63);
            buttonReset.TabIndex = 7;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // labelredirectLogin
            // 
            labelredirectLogin.AutoSize = true;
            labelredirectLogin.Cursor = Cursors.Hand;
            labelredirectLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelredirectLogin.ForeColor = SystemColors.Highlight;
            labelredirectLogin.Location = new Point(680, 636);
            labelredirectLogin.Name = "labelredirectLogin";
            labelredirectLogin.Size = new Size(59, 25);
            labelredirectLogin.TabIndex = 8;
            labelredirectLogin.Text = "Login";
            labelredirectLogin.Click += labelredirectLogin_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1359, 809);
            Controls.Add(labelredirectLogin);
            Controls.Add(buttonReset);
            Controls.Add(buttonRegister);
            Controls.Add(labelRepeatPassword);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(textBoxRepeatPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private TextBox textBoxRepeatPassword;
        private Label labelLogin;
        private Label labelPassword;
        private Label labelRepeatPassword;
        private Button buttonRegister;
        private Button buttonReset;
        private Label labelredirectLogin;
    }
}
