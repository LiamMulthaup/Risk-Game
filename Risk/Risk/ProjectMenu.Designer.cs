namespace Risk
{
    partial class ProjectMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.riskInstructionsLabel = new System.Windows.Forms.Label();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(206, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(275, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "Risk";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Elephant", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(574, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "TextBox Turtorial";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Elephant", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(589, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 45);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mini Games";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // riskInstructionsLabel
            // 
            this.riskInstructionsLabel.AutoSize = true;
            this.riskInstructionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.riskInstructionsLabel.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.riskInstructionsLabel.ForeColor = System.Drawing.Color.Red;
            this.riskInstructionsLabel.Location = new System.Drawing.Point(230, 181);
            this.riskInstructionsLabel.Name = "riskInstructionsLabel";
            this.riskInstructionsLabel.Size = new System.Drawing.Size(213, 27);
            this.riskInstructionsLabel.TabIndex = 4;
            this.riskInstructionsLabel.Text = "Risk Instructions";
            this.riskInstructionsLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.BackColor = System.Drawing.Color.Transparent;
            this.commentsLabel.Font = new System.Drawing.Font("Elephant", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLabel.ForeColor = System.Drawing.Color.Red;
            this.commentsLabel.Location = new System.Drawing.Point(227, 236);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(222, 47);
            this.commentsLabel.TabIndex = 5;
            this.commentsLabel.Text = "Comments";
            this.commentsLabel.Click += new System.EventHandler(this.commentsLabel_Click);
            // 
            // ProjectMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Risk.Properties.Resources.The_Darkness_Wall_By_Kon_2560X1600_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(673, 456);
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.riskInstructionsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "ProjectMenu";
            this.Text = "ProjectMenu";
            this.Resize += new System.EventHandler(this.resizing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label riskInstructionsLabel;
        private System.Windows.Forms.Label commentsLabel;
    }
}