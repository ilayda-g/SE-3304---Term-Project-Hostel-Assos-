namespace Hostel_Assos_Application_V._2
{
    partial class FormNewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewCustomer));
            groupBox1 = new GroupBox();
            label11 = new Label();
            BtnSave = new Button();
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
            BtnRoom109 = new Button();
            BtnRoom106 = new Button();
            BtnRoom103 = new Button();
            BtnRoom108 = new Button();
            BtnRoom105 = new Button();
            BtnRoom102 = new Button();
            BtnRoom107 = new Button();
            BtnRoom104 = new Button();
            BtnRoom101 = new Button();
            BtnFully = new Button();
            BtnEmpty = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Linen;
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(BtnSave);
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
            groupBox1.Location = new Point(30, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 472);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Information";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label11.Location = new Point(392, 429);
            label11.Name = "label11";
            label11.Size = new Size(20, 23);
            label11.TabIndex = 21;
            label11.Text = "0";
            label11.Visible = false;
            // 
            // BtnSave
            // 
            BtnSave.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnSave.Location = new Point(189, 394);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(174, 35);
            BtnSave.TabIndex = 20;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // DtpCheckOut
            // 
            DtpCheckOut.CalendarFont = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            DtpCheckOut.Location = new Point(148, 359);
            DtpCheckOut.Name = "DtpCheckOut";
            DtpCheckOut.Size = new Size(264, 27);
            DtpCheckOut.TabIndex = 19;
            DtpCheckOut.ValueChanged += DtpCheckOut_ValueChanged;
            // 
            // DtpCheckIn
            // 
            DtpCheckIn.CalendarFont = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            DtpCheckIn.Location = new Point(148, 326);
            DtpCheckIn.Name = "DtpCheckIn";
            DtpCheckIn.Size = new Size(264, 27);
            DtpCheckIn.TabIndex = 18;
            // 
            // TxtFee
            // 
            TxtFee.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtFee.Location = new Point(148, 291);
            TxtFee.Name = "TxtFee";
            TxtFee.Size = new Size(264, 30);
            TxtFee.TabIndex = 17;
            TxtFee.TextChanged += TxtFee_TextChanged;
            // 
            // TxtRoomNumber
            // 
            TxtRoomNumber.Enabled = false;
            TxtRoomNumber.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtRoomNumber.Location = new Point(148, 255);
            TxtRoomNumber.Name = "TxtRoomNumber";
            TxtRoomNumber.Size = new Size(264, 30);
            TxtRoomNumber.TabIndex = 16;
            // 
            // TxtTCNumber
            // 
            TxtTCNumber.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtTCNumber.Location = new Point(148, 219);
            TxtTCNumber.MaxLength = 11;
            TxtTCNumber.Name = "TxtTCNumber";
            TxtTCNumber.Size = new Size(264, 30);
            TxtTCNumber.TabIndex = 15;
            // 
            // TxtMail
            // 
            TxtMail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtMail.Location = new Point(148, 183);
            TxtMail.Name = "TxtMail";
            TxtMail.Size = new Size(264, 30);
            TxtMail.TabIndex = 14;
            // 
            // MskTxtPhone
            // 
            MskTxtPhone.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            MskTxtPhone.Location = new Point(148, 147);
            MskTxtPhone.Mask = "(999) 000-0000";
            MskTxtPhone.Name = "MskTxtPhone";
            MskTxtPhone.Size = new Size(264, 30);
            MskTxtPhone.TabIndex = 13;
            // 
            // CmbxGender
            // 
            CmbxGender.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            CmbxGender.FormattingEnabled = true;
            CmbxGender.Items.AddRange(new object[] { "Female", "Male" });
            CmbxGender.Location = new Point(148, 109);
            CmbxGender.Name = "CmbxGender";
            CmbxGender.Size = new Size(264, 31);
            CmbxGender.TabIndex = 12;
            // 
            // TxtSurname
            // 
            TxtSurname.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtSurname.Location = new Point(148, 73);
            TxtSurname.Name = "TxtSurname";
            TxtSurname.Size = new Size(264, 30);
            TxtSurname.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label10.Location = new Point(43, 363);
            label10.Name = "label10";
            label10.Size = new Size(99, 23);
            label10.TabIndex = 10;
            label10.Text = "Check-Out:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label9.Location = new Point(58, 330);
            label9.Name = "label9";
            label9.Size = new Size(84, 23);
            label9.TabIndex = 9;
            label9.Text = "Check-In:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.Location = new Point(100, 294);
            label8.Name = "label8";
            label8.Size = new Size(42, 23);
            label8.TabIndex = 8;
            label8.Text = "Fee:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(8, 258);
            label7.Name = "label7";
            label7.Size = new Size(134, 23);
            label7.TabIndex = 7;
            label7.Text = "Room Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(35, 222);
            label6.Name = "label6";
            label6.Size = new Size(107, 23);
            label6.TabIndex = 6;
            label6.Text = "TC Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(90, 183);
            label5.Name = "label5";
            label5.Size = new Size(50, 23);
            label5.TabIndex = 5;
            label5.Text = "Mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(78, 150);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 4;
            label4.Text = "Phone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(68, 114);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 3;
            label3.Text = "Gender:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(56, 76);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 2;
            label2.Text = "Surname:";
            // 
            // TxtName
            // 
            TxtName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtName.Location = new Point(148, 37);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(264, 30);
            TxtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(78, 44);
            label1.Name = "label1";
            label1.Size = new Size(62, 23);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Linen;
            groupBox2.Controls.Add(BtnRoom109);
            groupBox2.Controls.Add(BtnRoom106);
            groupBox2.Controls.Add(BtnRoom103);
            groupBox2.Controls.Add(BtnRoom108);
            groupBox2.Controls.Add(BtnRoom105);
            groupBox2.Controls.Add(BtnRoom102);
            groupBox2.Controls.Add(BtnRoom107);
            groupBox2.Controls.Add(BtnRoom104);
            groupBox2.Controls.Add(BtnRoom101);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(514, 35);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(352, 268);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rooms";
            // 
            // BtnRoom109
            // 
            BtnRoom109.BackColor = Color.DarkSeaGreen;
            BtnRoom109.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BtnRoom109.Location = new Point(246, 183);
            BtnRoom109.Name = "BtnRoom109";
            BtnRoom109.Size = new Size(63, 48);
            BtnRoom109.TabIndex = 10;
            BtnRoom109.Text = "109";
            BtnRoom109.UseVisualStyleBackColor = false;
            BtnRoom109.Click += BtnRoom109_Click;
            // 
            // BtnRoom106
            // 
            BtnRoom106.BackColor = Color.DarkSeaGreen;
            BtnRoom106.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BtnRoom106.Location = new Point(246, 109);
            BtnRoom106.Name = "BtnRoom106";
            BtnRoom106.Size = new Size(63, 48);
            BtnRoom106.TabIndex = 9;
            BtnRoom106.Text = "106";
            BtnRoom106.UseVisualStyleBackColor = false;
            BtnRoom106.Click += BtnRoom106_Click;
            // 
            // BtnRoom103
            // 
            BtnRoom103.BackColor = Color.DarkSeaGreen;
            BtnRoom103.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BtnRoom103.Location = new Point(246, 34);
            BtnRoom103.Name = "BtnRoom103";
            BtnRoom103.Size = new Size(63, 48);
            BtnRoom103.TabIndex = 8;
            BtnRoom103.Text = "103";
            BtnRoom103.UseVisualStyleBackColor = false;
            BtnRoom103.Click += BtnRoom103_Click;
            // 
            // BtnRoom108
            // 
            BtnRoom108.BackColor = Color.DarkSeaGreen;
            BtnRoom108.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BtnRoom108.Location = new Point(142, 183);
            BtnRoom108.Name = "BtnRoom108";
            BtnRoom108.Size = new Size(63, 48);
            BtnRoom108.TabIndex = 7;
            BtnRoom108.Text = "108";
            BtnRoom108.UseVisualStyleBackColor = false;
            BtnRoom108.Click += BtnRoom108_Click;
            // 
            // BtnRoom105
            // 
            BtnRoom105.BackColor = Color.DarkSeaGreen;
            BtnRoom105.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BtnRoom105.Location = new Point(142, 109);
            BtnRoom105.Name = "BtnRoom105";
            BtnRoom105.Size = new Size(63, 48);
            BtnRoom105.TabIndex = 6;
            BtnRoom105.Text = "105";
            BtnRoom105.UseVisualStyleBackColor = false;
            BtnRoom105.Click += BtnRoom105_Click;
            // 
            // BtnRoom102
            // 
            BtnRoom102.BackColor = Color.DarkSeaGreen;
            BtnRoom102.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BtnRoom102.Location = new Point(142, 34);
            BtnRoom102.Name = "BtnRoom102";
            BtnRoom102.Size = new Size(63, 48);
            BtnRoom102.TabIndex = 5;
            BtnRoom102.Text = "102";
            BtnRoom102.UseVisualStyleBackColor = false;
            BtnRoom102.Click += BtnRoom102_Click;
            // 
            // BtnRoom107
            // 
            BtnRoom107.BackColor = Color.DarkSeaGreen;
            BtnRoom107.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BtnRoom107.Location = new Point(36, 183);
            BtnRoom107.Name = "BtnRoom107";
            BtnRoom107.Size = new Size(63, 48);
            BtnRoom107.TabIndex = 4;
            BtnRoom107.Text = "107";
            BtnRoom107.UseVisualStyleBackColor = false;
            BtnRoom107.Click += BtnRoom107_Click;
            // 
            // BtnRoom104
            // 
            BtnRoom104.BackColor = Color.DarkSeaGreen;
            BtnRoom104.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BtnRoom104.Location = new Point(36, 109);
            BtnRoom104.Name = "BtnRoom104";
            BtnRoom104.Size = new Size(63, 48);
            BtnRoom104.TabIndex = 3;
            BtnRoom104.Text = "104";
            BtnRoom104.UseVisualStyleBackColor = false;
            BtnRoom104.Click += BtnRoom104_Click;
            // 
            // BtnRoom101
            // 
            BtnRoom101.BackColor = Color.DarkSeaGreen;
            BtnRoom101.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BtnRoom101.Location = new Point(36, 34);
            BtnRoom101.Name = "BtnRoom101";
            BtnRoom101.Size = new Size(63, 48);
            BtnRoom101.TabIndex = 0;
            BtnRoom101.Text = "101";
            BtnRoom101.UseVisualStyleBackColor = false;
            BtnRoom101.Click += BtnRoom101_Click;
            // 
            // BtnFully
            // 
            BtnFully.BackColor = Color.OrangeRed;
            BtnFully.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnFully.Location = new Point(760, 314);
            BtnFully.Name = "BtnFully";
            BtnFully.Size = new Size(91, 45);
            BtnFully.TabIndex = 8;
            BtnFully.Text = "Fully";
            BtnFully.UseVisualStyleBackColor = false;
            BtnFully.Click += BtnFully_Click;
            // 
            // BtnEmpty
            // 
            BtnEmpty.BackColor = Color.DarkSeaGreen;
            BtnEmpty.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnEmpty.Location = new Point(760, 365);
            BtnEmpty.Name = "BtnEmpty";
            BtnEmpty.Size = new Size(91, 46);
            BtnEmpty.TabIndex = 9;
            BtnEmpty.Text = "Empty";
            BtnEmpty.UseVisualStyleBackColor = false;
            BtnEmpty.Click += button1_Click;
            // 
            // FormNewCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(901, 561);
            Controls.Add(BtnEmpty);
            Controls.Add(BtnFully);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormNewCustomer";
            Text = "Add New Customer";
            Load += FormNewCustomer_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox TxtName;
        private Label label1;
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
        private Button BtnSave;
        private Label label11;
        private GroupBox groupBox2;
        private Button BtnRoom101;
        private Button BtnRoom109;
        private Button BtnRoom106;
        private Button BtnRoom103;
        private Button BtnRoom108;
        private Button BtnRoom105;
        private Button BtnRoom102;
        private Button BtnRoom107;
        private Button BtnRoom104;
        private Button BtnFully;
        private Button BtnEmpty;
    }
}