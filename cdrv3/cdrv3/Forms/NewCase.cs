using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cdrv3.Forms
{
    public partial class form_NewCase : Form
    {
        public form_NewCase()
        {
            InitializeComponent();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            var home = new cdrv3.form_Home();
            this.Hide();
            home.ShowDialog();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // form_NewCase
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(373, 318);
            this.Name = "form_NewCase";
            this.Text = "New Case";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);

        }

       
    }
}
