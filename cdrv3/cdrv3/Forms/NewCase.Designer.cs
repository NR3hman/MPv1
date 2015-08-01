namespace cdrv3.Forms
{
    partial class form_NewCase
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
            this.txb_ProjectName = new System.Windows.Forms.TextBox();
            this.lb_ProjectName = new System.Windows.Forms.Label();
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_CreateDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_ProjectName
            // 
            this.txb_ProjectName.Location = new System.Drawing.Point(186, 83);
            this.txb_ProjectName.Name = "txb_ProjectName";
            this.txb_ProjectName.Size = new System.Drawing.Size(412, 26);
            this.txb_ProjectName.TabIndex = 0;
            // 
            // lb_ProjectName
            // 
            this.lb_ProjectName.AutoSize = true;
            this.lb_ProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ProjectName.Location = new System.Drawing.Point(36, 84);
            this.lb_ProjectName.Name = "lb_ProjectName";
            this.lb_ProjectName.Size = new System.Drawing.Size(135, 25);
            this.lb_ProjectName.TabIndex = 1;
            this.lb_ProjectName.Text = "Project Name:";
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_Home.Location = new System.Drawing.Point(70, 190);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(174, 80);
            this.btn_Home.TabIndex = 2;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btn_CreateDatabase
            // 
            this.btn_CreateDatabase.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_CreateDatabase.Location = new System.Drawing.Point(399, 190);
            this.btn_CreateDatabase.Name = "btn_CreateDatabase";
            this.btn_CreateDatabase.Size = new System.Drawing.Size(174, 80);
            this.btn_CreateDatabase.TabIndex = 3;
            this.btn_CreateDatabase.Text = "Create Database";
            this.btn_CreateDatabase.UseVisualStyleBackColor = false;
            this.btn_CreateDatabase.Click += new System.EventHandler(this.btn_CreateDatabase_Click);
            // 
            // form_NewCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(665, 343);
            this.Controls.Add(this.btn_CreateDatabase);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.lb_ProjectName);
            this.Controls.Add(this.txb_ProjectName);
            this.Name = "form_NewCase";
            this.Text = "New Case";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_ProjectName;
        private System.Windows.Forms.Label lb_ProjectName;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_CreateDatabase;
    }
}