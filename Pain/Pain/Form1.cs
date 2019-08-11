using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2 = new Form2();
        Login login = new Login();
        private void btnNhap_Click(object sender, EventArgs e)
        {
            
            
            Random rnd = new Random();
            int a = rnd.Next(1,3);
            if (a == 1)
            {
                form2.lstTeam1.Items.Add(txtNhap.Text);
                MessageBox.Show("Bạn đã join TEAM 1!");
            }
            else
            {
                form2.lstTeam2.Items.Add(txtNhap.Text);
                MessageBox.Show("Bạn đã join TEAM 2!");
            }



            txtNhap.Clear();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
           
        }
    }
}
