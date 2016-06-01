namespace Risk
{
    partial class Comments
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
            this.components = new System.ComponentModel.Container();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.commentLabel = new System.Windows.Forms.Label();
            this.latestCommentsLabel = new System.Windows.Forms.Label();
            this.commentViewer = new System.Windows.Forms.ListBox();
            this.commentButton = new System.Windows.Forms.Button();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.loginPanel = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.beginButton = new System.Windows.Forms.Button();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(91, 23);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(154, 20);
            this.commentTextBox.TabIndex = 1;
            this.commentTextBox.Visible = false;
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(31, 26);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(54, 13);
            this.commentLabel.TabIndex = 1;
            this.commentLabel.Text = "Comment:";
            // 
            // latestCommentsLabel
            // 
            this.latestCommentsLabel.AutoSize = true;
            this.latestCommentsLabel.Location = new System.Drawing.Point(21, 86);
            this.latestCommentsLabel.Name = "latestCommentsLabel";
            this.latestCommentsLabel.Size = new System.Drawing.Size(59, 13);
            this.latestCommentsLabel.TabIndex = 2;
            this.latestCommentsLabel.Text = "Comments:";
            // 
            // commentViewer
            // 
            this.commentViewer.AccessibleDescription = "";
            this.commentViewer.AccessibleName = "";
            this.commentViewer.FormattingEnabled = true;
            this.commentViewer.Location = new System.Drawing.Point(24, 105);
            this.commentViewer.Name = "commentViewer";
            this.commentViewer.Size = new System.Drawing.Size(238, 290);
            this.commentViewer.TabIndex = 3;
            // 
            // commentButton
            // 
            this.commentButton.Location = new System.Drawing.Point(108, 49);
            this.commentButton.Name = "commentButton";
            this.commentButton.Size = new System.Drawing.Size(75, 23);
            this.commentButton.TabIndex = 2;
            this.commentButton.Text = "Comment";
            this.commentButton.UseVisualStyleBackColor = true;
            this.commentButton.Visible = false;
            this.commentButton.Click += new System.EventHandler(this.commentButton_Click);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.beginButton);
            this.loginPanel.Controls.Add(this.usernameTextbox);
            this.loginPanel.Controls.Add(this.usernameLabel);
            this.loginPanel.Location = new System.Drawing.Point(12, 12);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(260, 87);
            this.loginPanel.TabIndex = 5;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(41, 37);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(105, 34);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextbox.TabIndex = 0;
            // 
            // beginButton
            // 
            this.beginButton.Location = new System.Drawing.Point(84, 60);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(75, 23);
            this.beginButton.TabIndex = 1;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // Comments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 493);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.commentButton);
            this.Controls.Add(this.commentViewer);
            this.Controls.Add(this.latestCommentsLabel);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.commentTextBox);
            this.Name = "Comments";
            this.Text = "Comments";
            this.Load += new System.EventHandler(this.Comments_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.Label latestCommentsLabel;
        private System.Windows.Forms.ListBox commentViewer;
        private System.Windows.Forms.Button commentButton;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label usernameLabel;
    }
}