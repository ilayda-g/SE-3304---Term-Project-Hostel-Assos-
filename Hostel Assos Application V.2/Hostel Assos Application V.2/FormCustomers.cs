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
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-MCJ1PR1\\SQLEXPRESS;Initial Catalog=HostelAssos;Integrated Security = True;Encrypt=True;TrustServerCertificate=True");

        private void ShowData()
        {
            listView1.Items.Clear();
            connection.Open();
            SqlCommand command = new SqlCommand("select * from AddCustomer", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = reader["CustomerID"].ToString();
                item.SubItems.Add(reader["CustomerName"].ToString());
                item.SubItems.Add(reader["CustomerSurname"].ToString());
                item.SubItems.Add(reader["Gender"].ToString());
                item.SubItems.Add(reader["Phone"].ToString());
                item.SubItems.Add(reader["Mail"].ToString());
                item.SubItems.Add(reader["TCNumber"].ToString());
                item.SubItems.Add(reader["RoomNumber"].ToString());
                item.SubItems.Add(reader["Fee"].ToString());
                item.SubItems.Add(reader["CheckInDate"].ToString());
                item.SubItems.Add(reader["CheckOutDate"].ToString());

                listView1.Items.Add(item);
            }
            connection.Close();
        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {

        }

        private void TxtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnShowData_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSurname.Text = listView1.SelectedItems[0].SubItems[2].Text;
            CmbxGender.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTxtPhone.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtTCNumber.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtRoomNumber.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtFee.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpCheckIn.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpCheckOut.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TxtRoomNumber.Text == "101")
            {
                connection.Open();
                //SqlCommand command = new SqlCommand("delete from AddCustomer where CustomerID = (" + id + ")", connection);
                SqlCommand command1 = new SqlCommand("delete from Room101", connection);
                command1.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Customer deleted successfully.");
                ShowData();
            }


            if (TxtRoomNumber.Text == "102")
            {
                connection.Open();
                //SqlCommand command = new SqlCommand("delete from AddCustomer where CustomerID = (" + id + ")", connection);
                SqlCommand command2 = new SqlCommand("delete from Room102", connection);
                command2.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Customer deleted successfully.");
                ShowData();
            }


            if (TxtRoomNumber.Text == "103")
            {
                connection.Open();
                //SqlCommand command = new SqlCommand("delete from AddCustomer where CustomerID = (" + id + ")", connection);
                SqlCommand command3 = new SqlCommand("delete from Room103", connection);
                command3.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Customer deleted successfully.");
                ShowData();
            }


            if (TxtRoomNumber.Text == "104")
            {
                connection.Open();
                //SqlCommand command = new SqlCommand("delete from AddCustomer where CustomerID = (" + id + ")", connection);
                SqlCommand command4 = new SqlCommand("delete from Room104", connection);
                command4.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Customer deleted successfully.");
                ShowData();
            }


            if (TxtRoomNumber.Text == "105")
            {
                connection.Open();
                //SqlCommand command = new SqlCommand("delete from AddCustomer where CustomerID = (" + id + ")", connection);
                SqlCommand command5 = new SqlCommand("delete from Room105", connection);
                command5.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Customer deleted successfully.");
                ShowData();
            }


            if (TxtRoomNumber.Text == "106")
            {
                connection.Open();
                //SqlCommand command = new SqlCommand("delete from AddCustomer where CustomerID = (" + id + ")", connection);
                SqlCommand command6 = new SqlCommand("delete from Room106", connection);
                command6.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Customer deleted successfully.");
                ShowData();
            }


            if (TxtRoomNumber.Text == "107")
            {
                connection.Open();
                //SqlCommand command = new SqlCommand("delete from AddCustomer where CustomerID = (" + id + ")", connection);
                SqlCommand command7 = new SqlCommand("delete from Room107", connection);
                command7.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Customer deleted successfully.");
                ShowData();
            }

            if (TxtRoomNumber.Text == "108")
            {
                connection.Open();
                //SqlCommand command = new SqlCommand("delete from AddCustomer where CustomerID = (" + id + ")", connection);
                SqlCommand command8 = new SqlCommand("delete from Room108", connection);
                command8.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Customer deleted successfully.");
                ShowData();
            }

            if (TxtRoomNumber.Text == "109")
            {
                connection.Open();
                //SqlCommand command = new SqlCommand("delete from AddCustomer where CustomerID = (" + id + ")", connection);
                SqlCommand command9 = new SqlCommand("delete from Room109", connection);
                command9.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Customer deleted successfully.");
                ShowData();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtName.Clear();
            TxtSurname.Clear();
            CmbxGender.Text = "";
            MskTxtPhone.Clear();
            TxtMail.Clear();
            TxtTCNumber.Clear();
            TxtRoomNumber.Clear();
            TxtFee.Clear();
            DtpCheckIn.Text = "";
            DtpCheckOut.Text = "";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update AddCustomer set CustomerName='" + TxtName.Text + "', CustomerSurname='" + TxtSurname.Text + "', Gender='" + CmbxGender.Text + "', Phone='" + MskTxtPhone.Text + "', Mail='" + TxtMail.Text + "', TCNumber='" + TxtTCNumber.Text + "', RoomNumber='" + TxtRoomNumber.Text + "', Fee='" + TxtFee.Text + "', CheckInDate='" + DtpCheckIn.Value.ToString("yyyy-MM-dd") + "', CheckOutDate='" + DtpCheckOut.Value.ToString("yyyy-MM-dd") + "' where CustomerID=" + id + "", connection);
            command.ExecuteNonQuery();
            connection.Close();
            ShowData();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            connection.Open();
            SqlCommand command = new SqlCommand("select * from AddCustomer where CustomerName like '%" + TxtSearchName.Text + "%'", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = reader["CustomerID"].ToString();
                item.SubItems.Add(reader["CustomerName"].ToString());
                item.SubItems.Add(reader["CustomerSurname"].ToString());
                item.SubItems.Add(reader["Gender"].ToString());
                item.SubItems.Add(reader["Phone"].ToString());
                item.SubItems.Add(reader["Mail"].ToString());
                item.SubItems.Add(reader["TCNumber"].ToString());
                item.SubItems.Add(reader["RoomNumber"].ToString());
                item.SubItems.Add(reader["Fee"].ToString());
                item.SubItems.Add(reader["CheckInDate"].ToString());
                item.SubItems.Add(reader["CheckOutDate"].ToString());

                listView1.Items.Add(item);
            }
            connection.Close();
        }
    }
}
