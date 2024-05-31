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
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Hostel_Assos_Application_V._2
{
    public partial class FormAdminLogin : Form
    {
        public FormAdminLogin()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-MCJ1PR1\\SQLEXPRESS;Initial Catalog=HostelAssos;Integrated Security = True;Encrypt=True;TrustServerCertificate=True");
        //Data Source = DESKTOP - MCJ1PR1\SQLEXPRESS;Initial Catalog = HostelAssos; Integrated Security = True; Encrypt=True;Trust Server Certificate=True
        private void FormAdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string sql1 = ("select * from AdminLogin where Username = @Username and Password = @Password");
                SqlParameter prmt1 = new SqlParameter("Username", TxtUsername.Text.Trim());
                SqlParameter prmt2 = new SqlParameter("Password", TxtPassword.Text.Trim());
                SqlCommand command = new SqlCommand(sql1, connection);
                command.Parameters.Add(prmt1);
                command.Parameters.Add(prmt2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    FormMain fr = new FormMain();
                    fr.Show();
                    this.Hide();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Username or password is wrong!");
            }
        }
    }
}
