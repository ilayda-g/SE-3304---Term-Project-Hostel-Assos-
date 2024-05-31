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
using System.Data.Sql;
using System.Xml.Linq;

namespace Hostel_Assos_Application_V._2
{
    public partial class FormMessages : Form
    {
        public FormMessages()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-MCJ1PR1\\SQLEXPRESS;Initial Catalog=HostelAssos;Integrated Security = True;Encrypt=True;TrustServerCertificate=True");

        private void ShowData()
        {
            listView1.Items.Clear();
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Messages", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = reader["MessageID"].ToString();
                item.SubItems.Add(reader["NameSurname"].ToString());
                item.SubItems.Add(reader["Message"].ToString());
                listView1.Items.Add(item);
            }
            connection.Close();
        }

        private void FormMessages_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into messages(NameSurname, Message) values('" + TxtNameSurname.Text + "', '" + RchTxtMessage.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            ShowData();
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtNameSurname.Text = listView1.SelectedItems[0].SubItems[1].Text;
            RchTxtMessage.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
