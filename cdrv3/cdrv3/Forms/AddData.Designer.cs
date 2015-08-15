namespace cdrv3.Forms
{
    partial class form_AddData
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
            this.lb_SelectFile = new System.Windows.Forms.Label();
            this.btn_SelectFile = new System.Windows.Forms.Button();
            this.txb_SelectedFile = new System.Windows.Forms.TextBox();
            this.btn_parse = new System.Windows.Forms.Button();
            this.dataGridView1_addData = new System.Windows.Forms.DataGridView();
            this.txb_caseName = new System.Windows.Forms.TextBox();
            this.lb_caseName = new System.Windows.Forms.Label();
            this.btn_savetoDatabase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_addData)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_SelectFile
            // 
            this.lb_SelectFile.AutoSize = true;
            this.lb_SelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SelectFile.Location = new System.Drawing.Point(34, 49);
            this.lb_SelectFile.Name = "lb_SelectFile";
            this.lb_SelectFile.Size = new System.Drawing.Size(87, 20);
            this.lb_SelectFile.TabIndex = 0;
            this.lb_SelectFile.Text = "Select File:";
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_SelectFile.Location = new System.Drawing.Point(446, 42);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(75, 27);
            this.btn_SelectFile.TabIndex = 2;
            this.btn_SelectFile.Text = "Select";
            this.btn_SelectFile.UseVisualStyleBackColor = false;
            this.btn_SelectFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_SelectedFile
            // 
            this.txb_SelectedFile.Location = new System.Drawing.Point(122, 49);
            this.txb_SelectedFile.Name = "txb_SelectedFile";
            this.txb_SelectedFile.Size = new System.Drawing.Size(318, 20);
            this.txb_SelectedFile.TabIndex = 3;
            this.txb_SelectedFile.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_parse
            // 
            this.btn_parse.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_parse.Location = new System.Drawing.Point(32, 431);
            this.btn_parse.Name = "btn_parse";
            this.btn_parse.Size = new System.Drawing.Size(75, 25);
            this.btn_parse.TabIndex = 5;
            this.btn_parse.Text = "Parse";
            this.btn_parse.UseVisualStyleBackColor = false;
            this.btn_parse.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1_addData
            // 
            this.dataGridView1_addData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_addData.Location = new System.Drawing.Point(32, 150);
            this.dataGridView1_addData.Name = "dataGridView1_addData";
            this.dataGridView1_addData.Size = new System.Drawing.Size(534, 235);
            this.dataGridView1_addData.TabIndex = 6;
            // 
            // txb_caseName
            // 
            this.txb_caseName.Location = new System.Drawing.Point(122, 82);
            this.txb_caseName.Name = "txb_caseName";
            this.txb_caseName.Size = new System.Drawing.Size(318, 20);
            this.txb_caseName.TabIndex = 7;
            // 
            // lb_caseName
            // 
            this.lb_caseName.AutoSize = true;
            this.lb_caseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_caseName.Location = new System.Drawing.Point(27, 82);
            this.lb_caseName.Name = "lb_caseName";
            this.lb_caseName.Size = new System.Drawing.Size(94, 20);
            this.lb_caseName.TabIndex = 8;
            this.lb_caseName.Text = "Case name:";
            // 
            // btn_savetoDatabase
            // 
            this.btn_savetoDatabase.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_savetoDatabase.Location = new System.Drawing.Point(146, 431);
            this.btn_savetoDatabase.Name = "btn_savetoDatabase";
            this.btn_savetoDatabase.Size = new System.Drawing.Size(115, 25);
            this.btn_savetoDatabase.TabIndex = 9;
            this.btn_savetoDatabase.Text = "Save to Database";
            this.btn_savetoDatabase.UseVisualStyleBackColor = false;
            this.btn_savetoDatabase.Click += new System.EventHandler(this.btn_savetoDatabase_Click);
            // 
            // form_AddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(594, 477);
            this.Controls.Add(this.btn_savetoDatabase);
            this.Controls.Add(this.lb_caseName);
            this.Controls.Add(this.txb_caseName);
            this.Controls.Add(this.dataGridView1_addData);
            this.Controls.Add(this.btn_parse);
            this.Controls.Add(this.txb_SelectedFile);
            this.Controls.Add(this.btn_SelectFile);
            this.Controls.Add(this.lb_SelectFile);
            this.Name = "form_AddData";
            this.Text = "AddData";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_addData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_SelectFile;
        private System.Windows.Forms.Button btn_SelectFile;
        private System.Windows.Forms.TextBox txb_SelectedFile;
        public System.Windows.Forms.Button btn_parse;
        private System.Windows.Forms.DataGridView dataGridView1_addData;
        private System.Windows.Forms.TextBox txb_caseName;
        private System.Windows.Forms.Label lb_caseName;
        public System.Windows.Forms.Button btn_savetoDatabase;
    }
}