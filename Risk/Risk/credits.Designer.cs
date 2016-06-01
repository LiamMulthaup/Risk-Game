namespace Risk
{
    partial class credits
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
            this.creditsLabel = new System.Windows.Forms.Label();
            this.liamsCredit = new System.Windows.Forms.Label();
            this.korysCredit = new System.Windows.Forms.Label();
            this.rollingCredits = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.BackColor = System.Drawing.Color.Transparent;
            this.creditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLabel.ForeColor = System.Drawing.Color.Red;
            this.creditsLabel.Location = new System.Drawing.Point(343, 324);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(176, 55);
            this.creditsLabel.TabIndex = 5;
            this.creditsLabel.Text = "Credits";
            // 
            // liamsCredit
            // 
            this.liamsCredit.AutoSize = true;
            this.liamsCredit.BackColor = System.Drawing.Color.Black;
            this.liamsCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liamsCredit.ForeColor = System.Drawing.Color.Red;
            this.liamsCredit.Location = new System.Drawing.Point(295, 388);
            this.liamsCredit.Name = "liamsCredit";
            this.liamsCredit.Size = new System.Drawing.Size(296, 31);
            this.liamsCredit.TabIndex = 4;
            this.liamsCredit.Text = "Creator: Liam Multhaup";
            // 
            // korysCredit
            // 
            this.korysCredit.AutoSize = true;
            this.korysCredit.BackColor = System.Drawing.Color.Black;
            this.korysCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.korysCredit.ForeColor = System.Drawing.Color.Red;
            this.korysCredit.Location = new System.Drawing.Point(362, 426);
            this.korysCredit.Name = "korysCredit";
            this.korysCredit.Size = new System.Drawing.Size(141, 13);
            this.korysCredit.TabIndex = 3;
            this.korysCredit.Text = "That One Guy: Kory Haydon";
            // 
            // rollingCredits
            // 
            this.rollingCredits.Interval = 1;
            this.rollingCredits.Tick += new System.EventHandler(this.rollingCredits_Tick);
            // 
            // credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(872, 448);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.liamsCredit);
            this.Controls.Add(this.korysCredit);
            this.Name = "credits";
            this.Text = "credits";
            this.Load += new System.EventHandler(this.credits_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.Label liamsCredit;
        private System.Windows.Forms.Label korysCredit;
        private System.Windows.Forms.Timer rollingCredits;
    }
}