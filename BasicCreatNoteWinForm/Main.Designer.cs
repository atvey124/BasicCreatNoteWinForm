namespace BasicCreatNoteWinForm
{
    partial class Main
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
            buttonProfile = new Button();
            textBoxNote = new RichTextBox();
            textBoxCreatNote = new RichTextBox();
            labelCreatNote = new Label();
            labelNextNote = new Label();
            labelBackNote = new Label();
            labelUniqueNumber = new Label();
            labelDateTime = new Label();
            labelGeolocation = new Label();
            labelLoginUser = new Label();
            textBoxSearch = new TextBox();
            labelSearch = new Label();
            labelEnjoy = new Label();
            labelUnenjoy = new Label();
            labelIsUserNote = new Label();
            SuspendLayout();
            // 
            // buttonProfile
            // 
            buttonProfile.BackColor = SystemColors.ActiveBorder;
            buttonProfile.Cursor = Cursors.Hand;
            buttonProfile.FlatStyle = FlatStyle.Popup;
            buttonProfile.Location = new Point(970, 0);
            buttonProfile.Name = "buttonProfile";
            buttonProfile.Size = new Size(150, 65);
            buttonProfile.TabIndex = 0;
            buttonProfile.Text = "Profile";
            buttonProfile.UseVisualStyleBackColor = false;
            buttonProfile.Click += buttonProfile_Click;
            // 
            // textBoxNote
            // 
            textBoxNote.Cursor = Cursors.IBeam;
            textBoxNote.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNote.Location = new Point(295, 130);
            textBoxNote.Name = "textBoxNote";
            textBoxNote.ReadOnly = true;
            textBoxNote.Size = new Size(593, 371);
            textBoxNote.TabIndex = 1;
            textBoxNote.Text = "";
            textBoxNote.TextChanged += textBoxNote_TextChanged;
            // 
            // textBoxCreatNote
            // 
            textBoxCreatNote.BackColor = SystemColors.Info;
            textBoxCreatNote.Cursor = Cursors.IBeam;
            textBoxCreatNote.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxCreatNote.Location = new Point(295, 507);
            textBoxCreatNote.Name = "textBoxCreatNote";
            textBoxCreatNote.Size = new Size(593, 96);
            textBoxCreatNote.TabIndex = 2;
            textBoxCreatNote.Text = "";
            textBoxCreatNote.TextChanged += textBoxCreatNote_TextChanged;
            // 
            // labelCreatNote
            // 
            labelCreatNote.AutoSize = true;
            labelCreatNote.Cursor = Cursors.Hand;
            labelCreatNote.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCreatNote.Location = new Point(923, 540);
            labelCreatNote.Name = "labelCreatNote";
            labelCreatNote.Size = new Size(123, 32);
            labelCreatNote.TabIndex = 3;
            labelCreatNote.Text = "CreatNote";
            labelCreatNote.Click += labelCreatNote_Click;
            // 
            // labelNextNote
            // 
            labelNextNote.AutoSize = true;
            labelNextNote.Cursor = Cursors.Hand;
            labelNextNote.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNextNote.Location = new Point(833, 62);
            labelNextNote.Name = "labelNextNote";
            labelNextNote.Size = new Size(80, 65);
            labelNextNote.TabIndex = 4;
            labelNextNote.Text = "->";
            labelNextNote.Click += labelNextNote_Click;
            // 
            // labelBackNote
            // 
            labelBackNote.AutoSize = true;
            labelBackNote.Cursor = Cursors.Hand;
            labelBackNote.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelBackNote.Location = new Point(280, 62);
            labelBackNote.Name = "labelBackNote";
            labelBackNote.Size = new Size(80, 65);
            labelBackNote.TabIndex = 5;
            labelBackNote.Text = "<-";
            labelBackNote.Click += labelBackNote_Click;
            // 
            // labelUniqueNumber
            // 
            labelUniqueNumber.AutoSize = true;
            labelUniqueNumber.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUniqueNumber.Location = new Point(513, 87);
            labelUniqueNumber.Name = "labelUniqueNumber";
            labelUniqueNumber.Size = new Size(182, 40);
            labelUniqueNumber.TabIndex = 6;
            labelUniqueNumber.Text = "number note";
            labelUniqueNumber.Click += labelUniqueNumber_Click;
            // 
            // labelDateTime
            // 
            labelDateTime.AutoSize = true;
            labelDateTime.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDateTime.Location = new Point(894, 130);
            labelDateTime.Name = "labelDateTime";
            labelDateTime.Size = new Size(92, 25);
            labelDateTime.TabIndex = 7;
            labelDateTime.Text = "date note";
            labelDateTime.Click += labelDateTime_Click;
            // 
            // labelGeolocation
            // 
            labelGeolocation.AutoSize = true;
            labelGeolocation.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelGeolocation.Location = new Point(894, 184);
            labelGeolocation.Name = "labelGeolocation";
            labelGeolocation.Size = new Size(112, 25);
            labelGeolocation.TabIndex = 8;
            labelGeolocation.Text = "geolocation";
            labelGeolocation.Click += labelGeolocation_Click;
            // 
            // labelLoginUser
            // 
            labelLoginUser.AutoSize = true;
            labelLoginUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLoginUser.Location = new Point(894, 241);
            labelLoginUser.Name = "labelLoginUser";
            labelLoginUser.Size = new Size(93, 25);
            labelLoginUser.TabIndex = 9;
            labelLoginUser.Text = "loginUser";
            labelLoginUser.Click += labelLoginUser_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Cursor = Cursors.IBeam;
            textBoxSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSearch.Location = new Point(1, 0);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(248, 33);
            textBoxSearch.TabIndex = 10;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Cursor = Cursors.Hand;
            labelSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSearch.Location = new Point(264, 9);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(69, 25);
            labelSearch.TabIndex = 11;
            labelSearch.Text = "Search";
            labelSearch.Click += labelSearch_Click;
            // 
            // labelEnjoy
            // 
            labelEnjoy.AutoSize = true;
            labelEnjoy.Cursor = Cursors.Hand;
            labelEnjoy.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelEnjoy.Location = new Point(894, 290);
            labelEnjoy.Name = "labelEnjoy";
            labelEnjoy.Size = new Size(63, 30);
            labelEnjoy.TabIndex = 12;
            labelEnjoy.Text = "enjoy";
            labelEnjoy.Click += labelEnjoy_Click;
            // 
            // labelUnenjoy
            // 
            labelUnenjoy.AutoSize = true;
            labelUnenjoy.Cursor = Cursors.Hand;
            labelUnenjoy.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUnenjoy.Location = new Point(894, 346);
            labelUnenjoy.Name = "labelUnenjoy";
            labelUnenjoy.Size = new Size(89, 30);
            labelUnenjoy.TabIndex = 13;
            labelUnenjoy.Text = "Unenjoy";
            labelUnenjoy.Click += labelUnenjoy_Click;
            // 
            // labelIsUserNote
            // 
            labelIsUserNote.AutoSize = true;
            labelIsUserNote.Cursor = Cursors.Hand;
            labelIsUserNote.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelIsUserNote.ForeColor = SystemColors.Info;
            labelIsUserNote.Location = new Point(530, 4);
            labelIsUserNote.Name = "labelIsUserNote";
            labelIsUserNote.Size = new Size(114, 30);
            labelIsUserNote.TabIndex = 14;
            labelIsUserNote.Text = "isUserNote";
            labelIsUserNote.Click += labelIsUserNote_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1120, 658);
            Controls.Add(labelIsUserNote);
            Controls.Add(labelUnenjoy);
            Controls.Add(labelEnjoy);
            Controls.Add(labelSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(labelLoginUser);
            Controls.Add(labelGeolocation);
            Controls.Add(labelDateTime);
            Controls.Add(labelUniqueNumber);
            Controls.Add(labelBackNote);
            Controls.Add(labelNextNote);
            Controls.Add(labelCreatNote);
            Controls.Add(textBoxCreatNote);
            Controls.Add(textBoxNote);
            Controls.Add(buttonProfile);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonProfile;
        private RichTextBox textBoxNote;
        private RichTextBox textBoxCreatNote;
        private Label labelCreatNote;
        private Label labelNextNote;
        private Label labelBackNote;
        private Label labelUniqueNumber;
        private Label labelDateTime;
        private Label labelGeolocation;
        private Label labelLoginUser;
        private TextBox textBoxSearch;
        private Label labelSearch;
        private Label labelEnjoy;
        private Label labelUnenjoy;
        private Label labelIsUserNote;
    }
}