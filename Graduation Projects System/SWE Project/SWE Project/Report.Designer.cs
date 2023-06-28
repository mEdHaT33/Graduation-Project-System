namespace SWE_Project
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.button1 = new System.Windows.Forms.Button();
            this.tr_viewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(924, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "show successed students";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tr_viewer
            // 
            this.tr_viewer.ActiveViewIndex = -1;
            this.tr_viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tr_viewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.tr_viewer.Location = new System.Drawing.Point(-4, 2);
            this.tr_viewer.Name = "tr_viewer";
            this.tr_viewer.Size = new System.Drawing.Size(1136, 472);
            this.tr_viewer.TabIndex = 1;
            this.tr_viewer.Load += new System.EventHandler(this.tr_viewer_Load);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1144, 589);
            this.Controls.Add(this.tr_viewer);
            this.Controls.Add(this.button1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer tr_viewer;
    }
}