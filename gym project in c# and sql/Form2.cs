using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            
        }


        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 d = new Form1();
            d.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 d = new Form3();
            d.Show();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form4 d = new Form4();
            d.Show();
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form6 d = new Form6();
            d.Show();
           
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form5 d = new Form5();
            d.Show();
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 d = new Form1();
            d.Show();
        }
    }
}
