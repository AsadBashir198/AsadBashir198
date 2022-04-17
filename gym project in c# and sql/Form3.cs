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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\WindowsFormsApplication1\WindowsFormsApplication1\gym.mdf;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\WindowsFormsApplication1\WindowsFormsApplication1\gym.mdf;Integrated Security=True"))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from instructor", con);
                DataTable d1 = new DataTable();
                da.Fill(d1);
                dataGridView1.DataSource = d1;
            }
        }

       
        public void addinfo()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\WindowsFormsApplication1\WindowsFormsApplication1\gym.mdf;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into instructor(id,name,contact,address,email) Values('" + Convert.ToInt32(TextBox1.Text) + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "','"+TextBox4.Text+"','"+TextBox5.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Saved successfuly");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void Save_Click_1(object sender, EventArgs e)
        {
            addinfo();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 d = new Form2();
            d.Show();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            } 
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            } 
        }
    }
}
