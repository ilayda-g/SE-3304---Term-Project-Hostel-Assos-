namespace Hostel_Assos_Application_V._2
{
    partial class FormCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomers));
            groupBox1 = new GroupBox();
            label11 = new Label();
            DtpCheckOut = new DateTimePicker();
            DtpCheckIn = new DateTimePicker();
            TxtFee = new TextBox();
            TxtRoomNumber = new TextBox();
            TxtTCNumber = new TextBox();
            TxtMail = new TextBox();
            MskTxtPhone = new MaskedTextBox();
            CmbxGender = new ComboBox();
            TxtSurname = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            TxtName = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            TxtSearchName = new TextBox();
            label12 = new Label();
            BtnSearch = new Button();
            BtnClear = new Button();
            BtnDelete = new Button();
            BtnUpdate = new Button();
            BtnShowData = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Linen;
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(DtpCheckOut);
            groupBox1.Controls.Add(DtpCheckIn);
            groupBox1.Controls.Add(TxtFee);
            groupBox1.Controls.Add(TxtRoomNumber);
            groupBox1.Controls.Add(TxtTCNumber);
            groupBox1.Controls.Add(TxtMail);
            groupBox1.Controls.Add(MskTxtPhone);
            groupBox1.Controls.Add(CmbxGender);
            groupBox1.Controls.Add(TxtSurname);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(691, 199);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label11.Location = new Point(651, 173);
            label11.Name = "label11";
            label11.Size = new Size(20, 23);
            label11.TabIndex = 21;
            label11.Text = "0";
            label11.Visible = false;
            // 
            // DtpCheckOut
            // 
            DtpCheckOut.CalendarFont = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            DtpCheckOut.Location = new Point(452, 141);
            DtpCheckOut.Name = "DtpCheckOut";
            DtpCheckOut.Size = new Size(219, 27);
            DtpCheckOut.TabIndex = 19;
            // 
            // DtpCheckIn
            // 
            DtpCheckIn.CalendarFont = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            DtpCheckIn.Location = new Point(452, 110);
            DtpCheckIn.Name = "DtpCheckIn";
            DtpCheckIn.Size = new Size(219, 27);
            DtpCheckIn.TabIndex = 18;
            // 
            // TxtFee
            // 
            TxtFee.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            TxtFee.Location = new Point(452, 77);
            TxtFee.Name = "TxtFee";
            TxtFee.Size = new Size(219, 27);
            TxtFee.TabIndex = 17;
            // 
            // TxtRoomNumber
            // 
            TxtRoomNumber.Enabled = false;
            TxtRoomNumber.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            TxtRoomNumber.Location = new Point(453, 48);
            TxtRoomNumber.Name = "TxtRoomNumber";
            TxtRoomNumber.Size = new Size(218, 27);
            TxtRoomNumber.TabIndex = 16;
            // 
            // TxtTCNumber
            // 
            TxtTCNumber.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            TxtTCNumber.Location = new Point(453, 18);
            TxtTCNumber.Name = "TxtTCNumber";
            TxtTCNumber.Size = new Size(218, 27);
            TxtTCNumber.TabIndex = 15;
            // 
            // TxtMail
            // 
            TxtMail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtMail.Location = new Point(92, 148);
            TxtMail.Name = "TxtMail";
            TxtMail.Size = new Size(215, 27);
            TxtMail.TabIndex = 14;
            TxtMail.TextChanged += TxtMail_TextChanged;
            // 
            // MskTxtPhone
            // 
            MskTxtPhone.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            MskTxtPhone.Location = new Point(92, 115);
            MskTxtPhone.Mask = "(999) 000-0000";
            MskTxtPhone.Name = "MskTxtPhone";
            MskTxtPhone.Size = new Size(215, 27);
            MskTxtPhone.TabIndex = 13;
            // 
            // CmbxGender
            // 
            CmbxGender.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            CmbxGender.FormattingEnabled = true;
            CmbxGender.Items.AddRange(new object[] { "Female", "Male" });
            CmbxGender.Location = new Point(92, 81);
            CmbxGender.Name = "CmbxGender";
            CmbxGender.Size = new Size(215, 28);
            CmbxGender.TabIndex = 12;
            // 
            // TxtSurname
            // 
            TxtSurname.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtSurname.Location = new Point(92, 48);
            TxtSurname.Name = "TxtSurname";
            TxtSurname.Size = new Size(215, 27);
            TxtSurname.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(362, 146);
            label10.Name = "label10";
            label10.Size = new Size(85, 20);
            label10.TabIndex = 10;
            label10.Text = "Check-Out:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(374, 115);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 9;
            label9.Text = "Check-In:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.Location = new Point(404, 81);
            label8.Name = "label8";
            label8.Size = new Size(42, 23);
            label8.TabIndex = 8;
            label8.Text = "Fee:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(329, 51);
            label7.Name = "label7";
            label7.Size = new Size(118, 20);
            label7.TabIndex = 7;
            label7.Text = "Room Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(354, 25);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 6;
            label6.Text = "TC Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(43, 151);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 5;
            label5.Text = "Mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(29, 118);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 4;
            label4.Text = "Phone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(21, 88);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 3;
            label3.Text = "Gender:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(11, 52);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Surname:";
            // 
            // TxtName
            // 
            TxtName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtName.Location = new Point(92, 18);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(215, 27);
            TxtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(31, 23);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Linen;
            groupBox2.Controls.Add(TxtSearchName);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(BtnSearch);
            groupBox2.Controls.Add(BtnClear);
            groupBox2.Controls.Add(BtnDelete);
            groupBox2.Controls.Add(BtnUpdate);
            groupBox2.Controls.Add(BtnShowData);
            groupBox2.Location = new Point(709, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(213, 320);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // TxtSearchName
            // 
            TxtSearchName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtSearchName.Location = new Point(20, 267);
            TxtSearchName.Name = "TxtSearchName";
            TxtSearchName.Size = new Size(172, 27);
            TxtSearchName.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(20, 244);
            label12.Name = "label12";
            label12.Size = new Size(55, 20);
            label12.TabIndex = 5;
            label12.Text = "Name:";
            // 
            // BtnSearch
            // 
            BtnSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnSearch.Location = new Point(20, 201);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(172, 40);
            BtnSearch.TabIndex = 4;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // BtnClear
            // 
            BtnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnClear.Location = new Point(20, 155);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(172, 40);
            BtnClear.TabIndex = 3;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnDelete.Location = new Point(20, 109);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(172, 40);
            BtnDelete.TabIndex = 2;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnUpdate.Location = new Point(20, 63);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(172, 40);
            BtnUpdate.TabIndex = 1;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnShowData
            // 
            BtnShowData.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnShowData.Location = new Point(20, 17);
            BtnShowData.Name = "BtnShowData";
            BtnShowData.Size = new Size(172, 40);
            BtnShowData.TabIndex = 0;
            BtnShowData.Text = "Show Data";
            BtnShowData.UseVisualStyleBackColor = true;
            BtnShowData.Click += BtnShowData_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listView1.Location = new Point(-1, 372);
            listView1.Name = "listView1";
            listView1.Size = new Size(930, 253);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Surname";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Gender";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Phone";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Mail";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "TC";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Room";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Fee";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "CheckIn";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "CheckOut";
            // 
            // FormCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(929, 623);
            Controls.Add(listView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCustomers";
            Text = "Customers Information";
            Load += FormCustomers_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label11;
        private DateTimePicker DtpCheckOut;
        private DateTimePicker DtpCheckIn;
        private TextBox TxtFee;
        private TextBox TxtRoomNumber;
        private TextBox TxtTCNumber;
        private TextBox TxtMail;
        private MaskedTextBox MskTxtPhone;
        private ComboBox CmbxGender;
        private TextBox TxtSurname;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox TxtName;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox TxtSearchName;
        private Label label12;
        private Button BtnSearch;
        private Button BtnClear;
        private Button BtnDelete;
        private Button BtnUpdate;
        private Button BtnShowData;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
    }
}