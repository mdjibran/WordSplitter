namespace WordSplitter
{
    partial class Summary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Summary));
            this._rtbSummaryBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // _rtbSummaryBox
            // 
            this._rtbSummaryBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rtbSummaryBox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._rtbSummaryBox.Location = new System.Drawing.Point(0, 0);
            this._rtbSummaryBox.Name = "_rtbSummaryBox";
            this._rtbSummaryBox.ReadOnly = true;
            this._rtbSummaryBox.Size = new System.Drawing.Size(800, 450);
            this._rtbSummaryBox.TabIndex = 0;
            this._rtbSummaryBox.Text = "";
            this._rtbSummaryBox.TextChanged += new System.EventHandler(this._rtbSummaryBox_TextChanged);
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._rtbSummaryBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Summary";
            this.Text = "Summary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Summary_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox _rtbSummaryBox;
    }
}