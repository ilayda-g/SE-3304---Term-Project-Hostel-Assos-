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
    public partial class FormNewCustomer : Form
    {
        public FormNewCustomer()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-MCJ1PR1\\SQLEXPRESS;Initial Catalog=HostelAssos;Integrated Security = True;Encrypt=True;TrustServerCertificate=True");

        private void FormNewCustomer_Load(object sender, EventArgs e)
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
                BtnRoom101.Text = "101";
                BtnRoom101.BackColor = Color.OrangeRed;
                BtnRoom101.Enabled = false;
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
                BtnRoom102.Text = "102";
                BtnRoom102.BackColor = Color.OrangeRed;
                BtnRoom102.Enabled = false;
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
                BtnRoom103.Text = "103";
                BtnRoom103.BackColor = Color.OrangeRed;
                BtnRoom103.Enabled = false;
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
                BtnRoom104.Text = "104";
                BtnRoom104.BackColor = Color.OrangeRed;
                BtnRoom104.Enabled = false;
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
                BtnRoom105.Text = "105";
                BtnRoom105.BackColor = Color.OrangeRed;
                BtnRoom105.Enabled = false;
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
                BtnRoom106.Text = "106";
                BtnRoom106.BackColor = Color.OrangeRed;
                BtnRoom106.Enabled = false;
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
                BtnRoom107.Text = "107";
                BtnRoom107.BackColor = Color.OrangeRed;
                BtnRoom107.Enabled = false;
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
                BtnRoom108.Text = "108";
                BtnRoom108.BackColor = Color.OrangeRed;
                BtnRoom108.Enabled = false;
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
                BtnRoom109.Text = "109";
                BtnRoom109.BackColor = Color.OrangeRed;
                BtnRoom109.Enabled = false;
            }
        }

        private void BtnRoom101_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "101";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Room101(CustomerName, CustomerSurname) values('" + TxtName.Text + "','" + TxtSurname.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnRoom102_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "102";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Room102(CustomerName, CustomerSurname) values('" + TxtName.Text + "','" + TxtSurname.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnRoom103_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "103";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Room103(CustomerName, CustomerSurname) values('" + TxtName.Text + "','" + TxtSurname.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnRoom104_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "104";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Room104(CustomerName, CustomerSurname) values('" + TxtName.Text + "','" + TxtSurname.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnRoom105_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "105";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Room105(CustomerName, CustomerSurname) values('" + TxtName.Text + "','" + TxtSurname.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnRoom106_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "106";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Room106(CustomerName, CustomerSurname) values('" + TxtName.Text + "','" + TxtSurname.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnRoom107_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "107";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Room107(CustomerName, CustomerSurname) values('" + TxtName.Text + "','" + TxtSurname.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnRoom108_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "108";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Room108(CustomerName, CustomerSurname) values('" + TxtName.Text + "','" + TxtSurname.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnRoom109_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "109";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Room109(CustomerName, CustomerSurname) values('" + TxtName.Text + "','" + TxtSurname.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnFully_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Red buttons indicate occupied rooms.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Green buttons indicate non-occupied rooms.");
        }

        private void DtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            int Fee;
            DateTime SmallDate = Convert.ToDateTime(DtpCheckIn.Text);
            DateTime BigDate = Convert.ToDateTime(DtpCheckOut.Text);

            TimeSpan Result;
            Result = BigDate - SmallDate;

            label11.Text = Result.TotalDays.ToString();

            Fee = Convert.ToInt32(label11.Text) * 3000;
            TxtFee.Text = Fee.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into AddCustomer (CustomerName, CustomerSurname, Gender, Phone, Mail, TCNumber, RoomNumber, Fee, CheckInDate, CheckOutDate) " +
                "values ('" + TxtName.Text + "','" + TxtSurname.Text + "', '" + CmbxGender.Text + "', '" + MskTxtPhone.Text + "', '" + TxtMail.Text + "', '" + TxtTCNumber.Text + "', '" + TxtRoomNumber.Text + "', '" + TxtFee.Text + "', '" + DtpCheckIn.Value.ToString("yyyy-MM-dd") + "', '" + DtpCheckOut.Value.ToString("yyyy-MM-dd") + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Customer registration has been completed successfully");
        }

        private void TxtFee_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
