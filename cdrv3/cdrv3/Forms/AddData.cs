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
    public partial class form_AddData : Form
    {
        public form_AddData()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txb_SelectedFile.Text = openFileDialog1.FileName;
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
