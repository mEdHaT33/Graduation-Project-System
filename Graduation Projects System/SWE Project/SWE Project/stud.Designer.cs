namespace SWE_Project
{
    partial class stud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stud));
            this.Upload = new System.Windows.Forms.Button();
            this.p_name = new System.Windows.Forms.TextBox();
            this.s_name = new System.Windows.Forms.TextBox();
            this.s_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Show_G = new System.Windows.Forms.Button();
            this.grade_GridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grade_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(262, 305);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(124, 23);
            this.Upload.TabIndex = 0;
            this.Upload.Text = "Upload";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // p_name
            // 
            this.p_name.Location = new System.Drawing.Point(217, 81);
            this.p_name.Name = "p_name";
            this.p_name.Size = new System.Drawing.Size(238, 22);
            this.p_name.TabIndex = 1;
            this.p_name.TextChanged += new System.EventHandler(this.p_name_TextChanged);
            // 
            // s_name
            // 
            this.s_name.Location = new System.Drawing.Point(214, 222);
            this.s_name.Name = "s_name";
            this.s_name.Size = new System.Drawing.Size(238, 22);
            this.s_name.TabIndex = 2;
            this.s_name.TextChanged += new System.EventHandler(this.s_name_TextChanged);
            // 
            // s_id
            // 
            this.s_id.Location = new System.Drawing.Point(214, 148);
            this.s_id.Name = "s_id";
            this.s_id.Size = new System.Drawing.Size(238, 22);
            this.s_id.TabIndex = 3;
            this.s_id.TextChanged += new System.EventHandler(this.s_id_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Location = new System.Drawing.Point(112, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Project name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label2.Location = new System.Drawing.Point(112, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stud_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OldLace;
            this.label3.Location = new System.Drawing.Point(112, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Studen Name";
            // 
            // Show_G
            // 
            this.Show_G.Location = new System.Drawing.Point(262, 384);
            this.Show_G.Name = "Show_G";
            this.Show_G.Size = new System.Drawing.Size(124, 23);
            this.Show_G.TabIndex = 7;
            this.Show_G.Text = "Show Grade";
            this.Show_G.UseVisualStyleBackColor = true;
            this.Show_G.Click += new System.EventHandler(this.Show_G_Click);
            // 
            // grade_GridView
            // 
            this.grade_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade_GridView.Location = new System.Drawing.Point(494, 305);
            this.grade_GridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grade_GridView.Name = "grade_GridView";
            this.grade_GridView.RowTemplate.Height = 28;
            this.grade_GridView.Size = new System.Drawing.Size(203, 105);
            this.grade_GridView.TabIndex = 12;
            this.grade_GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grade_GridView_CellContentClick);
            // 
            // stud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(744, 466);
            this.Controls.Add(this.grade_GridView);
            this.Controls.Add(this.Show_G);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.s_id);
            this.Controls.Add(this.s_name);
            this.Controls.Add(this.p_name);
            this.Controls.Add(this.Upload);
            this.Name = "stud";
            this.Text = "stud";
            this.Load += new System.EventHandler(this.stud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grade_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.TextBox p_name;
        private System.Windows.Forms.TextBox s_name;
        private System.Windows.Forms.TextBox s_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Show_G;
        private System.Windows.Forms.DataGridView grade_GridView;
    }
}