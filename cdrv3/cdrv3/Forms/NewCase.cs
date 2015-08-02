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

        private void btn_CreateDatabase_Click(object sender, EventArgs e)
        {
            
            //Database.CreateDatabase createdb = new Database.CreateDatabase();
            //var createdb = new Database.CreateDatabase();
            MessageBox.Show("To Do");
        }
    }
}
