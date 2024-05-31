using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Assos_Application_V._2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void BtnAdminLogin_Click(object sender, EventArgs e)
        {
            FormAdminLogin fr = new FormAdminLogin();
            fr.Show();
        }

        private void BtnNewCustomer_Click(object sender, EventArgs e)
        {
            FormNewCustomer fr = new FormNewCustomer();
            fr.Show();
        }

        private void BtnRooms_Click(object sender, EventArgs e)
        {
            FormRooms fr = new FormRooms();
            fr.Show();
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            FormCustomers fr = new FormCustomers();
            fr.Show();
        }

        private void BtnIncomeAndExpenses_Click(object sender, EventArgs e)
        {
            FormIncomeAndExpenses fr = new FormIncomeAndExpenses();
            fr.Show();
        }

        private void BtnStockAndBills_Click(object sender, EventArgs e)
        {
            FormStocksAndBills fr = new FormStocksAndBills();
            fr.Show();
        }

        private void BtnCustomerMessages_Click(object sender, EventArgs e)
        {
            FormMessages fr = new FormMessages();
            fr.Show();
        }

        private void BtnAboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hostel Assos Registration Application / 2024 - Ýzmir");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
