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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\WindowsFormsApplication1\WindowsFormsApplication1\gym.mdf;Integrated Security=True"))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from payment", con);
                DataTable d1 = new DataTable();
                da.Fill(d1);
                dataGridView1.DataSource = d1;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 d = new Form2();
            d.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            addinfo();
        }
        public void addinfo()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\WindowsFormsApplication1\WindowsFormsApplication1\gym.mdf;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into payment(Id,amount,paymentdate) Values('" + Convert.ToInt32(TextBox1.Text) + "',  '" +int.Parse( TextBox3.Text) + "','"+DateTimePicker1.Text+"'",con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Saved successfuly");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
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
