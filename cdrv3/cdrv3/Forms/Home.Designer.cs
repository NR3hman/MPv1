namespace cdrv3
{
    partial class form_Home
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
            this.btn_NewCase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NewCase
            // 
            this.btn_NewCase.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_NewCase.Location = new System.Drawing.Point(152, 44);
            this.btn_NewCase.Name = "btn_NewCase";
            this.btn_NewCase.Size = new System.Drawing.Size(181, 85);
            this.btn_NewCase.TabIndex = 0;
            this.btn_NewCase.Text = "New Case";
            this.btn_NewCase.UseVisualStyleBackColor = false;
            this.btn_NewCase.Click += new System.EventHandler(this.btn_NewCase_Click);
            // 
            // form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(514, 350);
            this.Controls.Add(this.btn_NewCase);
            this.Name = "form_Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NewCase;
    }
}

