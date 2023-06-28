namespace SWE_Project
{
    partial class TA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TA));
            this.Requirments = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            this.Grade = new System.Windows.Forms.Label();
            this.gradee = new System.Windows.Forms.TextBox();
            this.stud_ID = new System.Windows.Forms.Label();
            this.Req = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.update = new System.Windows.Forms.Button();
            this.TA_names = new System.Windows.Forms.Button();
            this.tanames = new System.Windows.Forms.DataGridView();
            this.Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tanames)).BeginInit();
            this.SuspendLayout();
            // 
            // Requirments
            // 
            this.Requirments.AutoSize = true;
            this.Requirments.BackColor = System.Drawing.Color.OldLace;
            this.Requirments.Location = new System.Drawing.Point(12, 203);
            this.Requirments.Name = "Requirments";
            this.Requirments.Size = new System.Drawing.Size(88, 17);
            this.Requirments.TabIndex = 1;
            this.Requirments.Text = "Requirments";
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(316, 102);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 30);
            this.insert.TabIndex = 4;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // Grade
            // 
            this.Grade.AutoSize = true;
            this.Grade.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Grade.Location = new System.Drawing.Point(22, 102);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(48, 17);
            this.Grade.TabIndex = 5;
            this.Grade.Text = "Grade";
            this.Grade.Click += new System.EventHandler(this.Grade_Click);
            // 
            // gradee
            // 
            this.gradee.Location = new System.Drawing.Point(138, 102);
            this.gradee.Name = "gradee";
            this.gradee.Size = new System.Drawing.Size(121, 22);
            this.gradee.TabIndex = 6;
            this.gradee.TextChanged += new System.EventHandler(this.gradee_TextChanged);
            // 
            // stud_ID
            // 
            this.stud_ID.AutoSize = true;
            this.stud_ID.BackColor = System.Drawing.Color.AntiqueWhite;
            this.stud_ID.Location = new System.Drawing.Point(12, 54);
            this.stud_ID.Name = "stud_ID";
            this.stud_ID.Size = new System.Drawing.Size(74, 17);
            this.stud_ID.TabIndex = 7;
            this.stud_ID.Text = "Student ID";
            // 
            // Req
            // 
            this.Req.Location = new System.Drawing.Point(123, 165);
            this.Req.Name = "Req";
            this.Req.Size = new System.Drawing.Size(254, 93);
            this.Req.TabIndex = 8;
            this.Req.Text = "";
            this.Req.TextChanged += new System.EventHandler(this.req);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "show IDs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.stud_info);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(138, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(428, 196);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 30);
            this.update.TabIndex = 3;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // TA_names
            // 
            this.TA_names.Location = new System.Drawing.Point(428, 282);
            this.TA_names.Name = "TA_names";
            this.TA_names.Size = new System.Drawing.Size(124, 36);
            this.TA_names.TabIndex = 16;
            this.TA_names.Text = "Show TA names";
            this.TA_names.UseVisualStyleBackColor = true;
            this.TA_names.Click += new System.EventHandler(this.TA_names_Click);
            // 
            // tanames
            // 
            this.tanames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tanames.Location = new System.Drawing.Point(123, 282);
            this.tanames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tanames.Name = "tanames";
            this.tanames.RowTemplate.Height = 28;
            this.tanames.Size = new System.Drawing.Size(254, 163);
            this.tanames.TabIndex = 17;
            this.tanames.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tanames_CellContentClick);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(428, 377);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(124, 36);
            this.Save.TabIndex = 18;
            this.Save.Text = "Save any edites";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Savee);
            // 
            // TA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(810, 446);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.tanames);
            this.Controls.Add(this.TA_names);
            this.Controls.Add(this.update);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Req);
            this.Controls.Add(this.stud_ID);
            this.Controls.Add(this.gradee);
            this.Controls.Add(this.Grade);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.Requirments);
            this.Name = "TA";
            this.Text = "TA";
            this.Load += new System.EventHandler(this.TA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tanames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Requirments;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Label Grade;
        private System.Windows.Forms.TextBox gradee;
        private System.Windows.Forms.Label stud_ID;
        private System.Windows.Forms.RichTextBox Req;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button TA_names;
        private System.Windows.Forms.DataGridView tanames;
        private System.Windows.Forms.Button Save;
    }
}