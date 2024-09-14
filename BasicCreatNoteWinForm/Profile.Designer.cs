namespace BasicCreatNoteWinForm
{
    partial class Profile
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
            labelCountNotePostShow = new Label();
            labelCountTotalEnjoyNoteShow = new Label();
            labelCountNotePost = new Label();
            labelCountTotalEnjoyNote = new Label();
            labelRedirectMain = new Label();
            labelTotalUnenjoy = new Label();
            labelTotalUnenjoyCountNote = new Label();
            SuspendLayout();
            // 
            // labelCountNotePostShow
            // 
            labelCountNotePostShow.AutoSize = true;
            labelCountNotePostShow.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelCountNotePostShow.Location = new Point(22, 37);
            labelCountNotePostShow.Name = "labelCountNotePostShow";
            labelCountNotePostShow.Size = new Size(116, 32);
            labelCountNotePostShow.TabIndex = 0;
            labelCountNotePostShow.Text = "total post";
            // 
            // labelCountTotalEnjoyNoteShow
            // 
            labelCountTotalEnjoyNoteShow.AutoSize = true;
            labelCountTotalEnjoyNoteShow.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelCountTotalEnjoyNoteShow.Location = new Point(22, 96);
            labelCountTotalEnjoyNoteShow.Name = "labelCountTotalEnjoyNoteShow";
            labelCountTotalEnjoyNoteShow.Size = new Size(110, 32);
            labelCountTotalEnjoyNoteShow.TabIndex = 1;
            labelCountTotalEnjoyNoteShow.Text = "total like";
            // 
            // labelCountNotePost
            // 
            labelCountNotePost.AutoSize = true;
            labelCountNotePost.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelCountNotePost.Location = new Point(317, 37);
            labelCountNotePost.Name = "labelCountNotePost";
            labelCountNotePost.Size = new Size(125, 32);
            labelCountNotePost.TabIndex = 2;
            labelCountNotePost.Text = "total note ";
            labelCountNotePost.Click += labelCountNotePost_Click;
            // 
            // labelCountTotalEnjoyNote
            // 
            labelCountTotalEnjoyNote.AutoSize = true;
            labelCountTotalEnjoyNote.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelCountTotalEnjoyNote.Location = new Point(317, 96);
            labelCountTotalEnjoyNote.Name = "labelCountTotalEnjoyNote";
            labelCountTotalEnjoyNote.Size = new Size(128, 32);
            labelCountTotalEnjoyNote.TabIndex = 3;
            labelCountTotalEnjoyNote.Text = "total enjoy";
            labelCountTotalEnjoyNote.Click += labelCountTotalEnjoyNote_Click;
            // 
            // labelRedirectMain
            // 
            labelRedirectMain.AutoSize = true;
            labelRedirectMain.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelRedirectMain.ForeColor = SystemColors.Highlight;
            labelRedirectMain.Location = new Point(22, 607);
            labelRedirectMain.Name = "labelRedirectMain";
            labelRedirectMain.Size = new Size(237, 32);
            labelRedirectMain.TabIndex = 4;
            labelRedirectMain.Text = "return to main menu";
            labelRedirectMain.Click += labelRedirectMain_Click;
            // 
            // labelTotalUnenjoy
            // 
            labelTotalUnenjoy.AutoSize = true;
            labelTotalUnenjoy.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelTotalUnenjoy.Location = new Point(24, 159);
            labelTotalUnenjoy.Name = "labelTotalUnenjoy";
            labelTotalUnenjoy.Size = new Size(141, 32);
            labelTotalUnenjoy.TabIndex = 5;
            labelTotalUnenjoy.Text = "total dislike";
            // 
            // labelTotalUnenjoyCountNote
            // 
            labelTotalUnenjoyCountNote.AutoSize = true;
            labelTotalUnenjoyCountNote.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelTotalUnenjoyCountNote.Location = new Point(317, 159);
            labelTotalUnenjoyCountNote.Name = "labelTotalUnenjoyCountNote";
            labelTotalUnenjoyCountNote.Size = new Size(156, 32);
            labelTotalUnenjoyCountNote.TabIndex = 6;
            labelTotalUnenjoyCountNote.Text = "total unenjoy";
            labelTotalUnenjoyCountNote.Click += labelTotalUnenjoyCountNote_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1116, 648);
            Controls.Add(labelTotalUnenjoyCountNote);
            Controls.Add(labelTotalUnenjoy);
            Controls.Add(labelRedirectMain);
            Controls.Add(labelCountTotalEnjoyNote);
            Controls.Add(labelCountNotePost);
            Controls.Add(labelCountTotalEnjoyNoteShow);
            Controls.Add(labelCountNotePostShow);
            Name = "Profile";
            Text = "Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCountNotePostShow;
        private Label labelCountTotalEnjoyNoteShow;
        private Label labelCountNotePost;
        private Label labelCountTotalEnjoyNote;
        private Label labelRedirectMain;
        private Label labelTotalUnenjoy;
        private Label labelTotalUnenjoyCountNote;
    }
}