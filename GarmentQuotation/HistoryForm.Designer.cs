using System.ComponentModel;

namespace GarmentQuotation
{
    partial class HistoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.labelHistory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHistory
            // 
            this.labelHistory.Location = new System.Drawing.Point(10, 12);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(277, 331);
            this.labelHistory.TabIndex = 0;
            this.labelHistory.Text = "label1";
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 371);
            this.Controls.Add(this.labelHistory);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelHistory;

        #endregion
    }
}