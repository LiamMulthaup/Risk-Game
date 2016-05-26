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
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.commentLabel = new System.Windows.Forms.Label();
            this.latestCommentsLabel = new System.Windows.Forms.Label();
            this.commentViewer = new System.Windows.Forms.ListBox();
            this.commentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(91, 23);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(154, 20);
            this.commentTextBox.TabIndex = 0;
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
            this.latestCommentsLabel.Location = new System.Drawing.Point(31, 76);
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
            this.commentViewer.Location = new System.Drawing.Point(34, 105);
            this.commentViewer.Name = "commentViewer";
            this.commentViewer.Size = new System.Drawing.Size(238, 147);
            this.commentViewer.TabIndex = 3;
            // 
            // commentButton
            // 
            this.commentButton.Location = new System.Drawing.Point(108, 49);
            this.commentButton.Name = "commentButton";
            this.commentButton.Size = new System.Drawing.Size(75, 23);
            this.commentButton.TabIndex = 4;
            this.commentButton.Text = "Comment";
            this.commentButton.UseVisualStyleBackColor = true;
            this.commentButton.Click += new System.EventHandler(this.commentButton_Click);
            // 
            // Comments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.commentButton);
            this.Controls.Add(this.commentViewer);
            this.Controls.Add(this.latestCommentsLabel);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.commentTextBox);
            this.Name = "Comments";
            this.Text = "Comments";
            this.Load += new System.EventHandler(this.Comments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.Label latestCommentsLabel;
        private System.Windows.Forms.ListBox commentViewer;
        private System.Windows.Forms.Button commentButton;
    }
}