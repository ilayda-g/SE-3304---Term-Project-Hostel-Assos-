namespace Hostel_Assos_Application_V._2
{
    partial class FormMessages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMessages));
            LblMoneyInTheSafe = new Label();
            label1 = new Label();
            TxtNameSurname = new TextBox();
            RchTxtMessage = new RichTextBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            BtnSave = new Button();
            SuspendLayout();
            // 
            // LblMoneyInTheSafe
            // 
            LblMoneyInTheSafe.AutoSize = true;
            LblMoneyInTheSafe.BackColor = Color.Transparent;
            LblMoneyInTheSafe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblMoneyInTheSafe.ForeColor = Color.Black;
            LblMoneyInTheSafe.Location = new Point(53, 46);
            LblMoneyInTheSafe.Name = "LblMoneyInTheSafe";
            LblMoneyInTheSafe.Size = new Size(171, 28);
            LblMoneyInTheSafe.TabIndex = 1;
            LblMoneyInTheSafe.Text = "Name/ Surname:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(125, 98);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 2;
            label1.Text = "Message:";
            // 
            // TxtNameSurname
            // 
            TxtNameSurname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtNameSurname.Location = new Point(230, 43);
            TxtNameSurname.Name = "TxtNameSurname";
            TxtNameSurname.Size = new Size(439, 34);
            TxtNameSurname.TabIndex = 3;
            // 
            // RchTxtMessage
            // 
            RchTxtMessage.Location = new Point(230, 102);
            RchTxtMessage.Name = "RchTxtMessage";
            RchTxtMessage.Size = new Size(439, 127);
            RchTxtMessage.TabIndex = 4;
            RchTxtMessage.Text = "";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(0, 315);
            listView1.Name = "listView1";
            listView1.Size = new Size(740, 262);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name/ Surname";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Message";
            columnHeader3.Width = 500;
            // 
            // BtnSave
            // 
            BtnSave.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnSave.Location = new Point(368, 249);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(174, 35);
            BtnSave.TabIndex = 21;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // FormMessages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(739, 576);
            Controls.Add(BtnSave);
            Controls.Add(listView1);
            Controls.Add(RchTxtMessage);
            Controls.Add(TxtNameSurname);
            Controls.Add(label1);
            Controls.Add(LblMoneyInTheSafe);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMessages";
            Text = "Customer Messages";
            Load += FormMessages_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblMoneyInTheSafe;
        private Label label1;
        private TextBox TxtNameSurname;
        private RichTextBox RchTxtMessage;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button BtnSave;
    }
}