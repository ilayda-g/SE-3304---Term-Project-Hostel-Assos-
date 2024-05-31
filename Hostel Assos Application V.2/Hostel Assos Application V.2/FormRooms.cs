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
    public partial class FormRooms : Form
    {
        public FormRooms()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-MCJ1PR1\\SQLEXPRESS;Initial Catalog=HostelAssos;Integrated Security = True;Encrypt=True;TrustServerCertificate=True");

        private void FormRooms_Load(object sender, EventArgs e)
        {
            // Room 101
            connection.Open();
            SqlCommand command1 = new SqlCommand("select * from Room101", connection);
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                BtnRoom101.Text = reader1["CustomerName"].ToString() + " " + reader1["CustomerSurname"].ToString();
            }
            connection.Close();
            if (BtnRoom101.Text != "101")
            {
                BtnRoom101.BackColor = Color.OrangeRed;
            }

            // Room 102
            connection.Open();
            SqlCommand command2 = new SqlCommand("select * from Room102", connection);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                BtnRoom102.Text = reader2["CustomerName"].ToString() + " " + reader2["CustomerSurname"].ToString();
            }
            connection.Close();
            if (BtnRoom102.Text != "102")
            {
                BtnRoom102.BackColor = Color.OrangeRed;
            }

            // Room 103
            connection.Open();
            SqlCommand command3 = new SqlCommand("select * from Room103", connection);
            SqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                BtnRoom103.Text = reader3["CustomerName"].ToString() + " " + reader3["CustomerSurname"].ToString();
            }
            connection.Close();
            if (BtnRoom103.Text != "103")
            {
                BtnRoom103.BackColor = Color.OrangeRed;
            }

            // Room 104
            connection.Open();
            SqlCommand command4 = new SqlCommand("select * from Room104", connection);
            SqlDataReader reader4 = command4.ExecuteReader();
            while (reader4.Read())
            {
                BtnRoom104.Text = reader4["CustomerName"].ToString() + " " + reader4["CustomerSurname"].ToString();
            }
            connection.Close();
            if (BtnRoom104.Text != "104")
            {
                BtnRoom104.BackColor = Color.OrangeRed;
            }

            // Room 105
            connection.Open();
            SqlCommand command5 = new SqlCommand("select * from Room105", connection);
            SqlDataReader reader5 = command5.ExecuteReader();
            while (reader5.Read())
            {
                BtnRoom105.Text = reader5["CustomerName"].ToString() + " " + reader5["CustomerSurname"].ToString();
            }
            connection.Close();
            if (BtnRoom105.Text != "105")
            {
                BtnRoom105.BackColor = Color.OrangeRed;
            }

            // Room 106
            connection.Open();
            SqlCommand command6 = new SqlCommand("select * from Room106", connection);
            SqlDataReader reader6 = command6.ExecuteReader();
            while (reader6.Read())
            {
                BtnRoom106.Text = reader6["CustomerName"].ToString() + " " + reader6["CustomerSurname"].ToString();
            }
            connection.Close();
            if (BtnRoom106.Text != "106")
            {
                BtnRoom106.BackColor = Color.OrangeRed;
            }

            // Room 107
            connection.Open();
            SqlCommand command7 = new SqlCommand("select * from Room107", connection);
            SqlDataReader reader7 = command7.ExecuteReader();
            while (reader7.Read())
            {
                BtnRoom107.Text = reader7["CustomerName"].ToString() + " " + reader7["CustomerSurname"].ToString();
            }
            connection.Close();
            if (BtnRoom107.Text != "107")
            {
                BtnRoom107.BackColor = Color.OrangeRed;
            }

            // Room 108
            connection.Open();
            SqlCommand command8 = new SqlCommand("select * from Room108", connection);
            SqlDataReader reader8 = command8.ExecuteReader();
            while (reader8.Read())
            {
                BtnRoom108.Text = reader8["CustomerName"].ToString() + " " + reader8["CustomerSurname"].ToString();
            }
            connection.Close();
            if (BtnRoom108.Text != "108")
            {
                BtnRoom108.BackColor = Color.OrangeRed;
            }

            // Room 109
            connection.Open();
            SqlCommand command9 = new SqlCommand("select * from Room109", connection);
            SqlDataReader reader9 = command9.ExecuteReader();
            while (reader9.Read())
            {
                BtnRoom109.Text = reader9["CustomerName"].ToString() + " " + reader9["CustomerSurname"].ToString();
            }
            connection.Close();
            if (BtnRoom109.Text != "109")
            {
                BtnRoom109.BackColor = Color.OrangeRed;
            }
        }

        private void BtnRoom105_Click(object sender, EventArgs e)
        {

        }

        private void BtnRoom104_Click(object sender, EventArgs e)
        {

        }
    }
}
