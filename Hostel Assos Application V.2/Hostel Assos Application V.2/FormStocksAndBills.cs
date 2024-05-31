using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Assos_Application_V._2
{
    public partial class FormStocksAndBills : Form
    {
        public FormStocksAndBills()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-MCJ1PR1\\SQLEXPRESS;Initial Catalog=HostelAssos;Integrated Security = True;Encrypt=True;TrustServerCertificate=True");

        private void Data()
        {
            listView1.Items.Clear();
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Stock", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = reader["Food"].ToString();
                item.SubItems.Add(reader["Drink"].ToString());
                item.SubItems.Add(reader["Snacks"].ToString());
                listView1.Items.Add(item);
            }
            connection.Close();
        }

        private void Data2()
        {
            listView2.Items.Clear();
            connection.Open();
            SqlCommand command2 = new SqlCommand("select * from Bills", connection);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                ListViewItem item2 = new ListViewItem();
                item2.Text = reader2["Electric"].ToString();
                item2.SubItems.Add(reader2["Water"].ToString());
                item2.SubItems.Add(reader2["Internet"].ToString());
                listView2.Items.Add(item2);
            }
            connection.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormStocksAndBills_Load(object sender, EventArgs e)
        {
            Data();
            Data2();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Stock(Food, Drink, Snacks) values('" + TxtFood.Text + "', '" + TxtDrinks.Text + "', '" + TxtSnacks.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            Data();
        }

        private void BtnSaveBills_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Bills(Electric, Water, Internet) values('" + TxtElectric.Text + "', '" + TxtWater.Text + "', '" + TxtInternet.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            Data2();
        }
    }
}
