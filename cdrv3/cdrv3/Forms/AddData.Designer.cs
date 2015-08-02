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
            this.btn_SelectFile.Location = new System.Drawing.Point(462, 36);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(75, 49);
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
            // form_AddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(594, 405);
            this.Controls.Add(this.txb_SelectedFile);
            this.Controls.Add(this.btn_SelectFile);
            this.Controls.Add(this.lb_SelectFile);
            this.Name = "form_AddData";
            this.Text = "AddData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_SelectFile;
        private System.Windows.Forms.Button btn_SelectFile;
        private System.Windows.Forms.TextBox txb_SelectedFile;
    }
}