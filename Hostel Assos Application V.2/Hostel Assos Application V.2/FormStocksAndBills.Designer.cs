namespace Hostel_Assos_Application_V._2
{
    partial class FormStocksAndBills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStocksAndBills));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtFood = new TextBox();
            TxtDrinks = new TextBox();
            TxtSnacks = new TextBox();
            BtnSave = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            BtnSaveBills = new Button();
            label5 = new Label();
            TxtInternet = new TextBox();
            label6 = new Label();
            TxtWater = new TextBox();
            TxtElectric = new TextBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            listView2 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(49, 41);
            label1.Name = "label1";
            label1.Size = new Size(117, 23);
            label1.TabIndex = 0;
            label1.Text = "Cost of Food:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(37, 77);
            label2.Name = "label2";
            label2.Size = new Size(129, 23);
            label2.TabIndex = 1;
            label2.Text = "Cost of Drinks:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(35, 113);
            label3.Name = "label3";
            label3.Size = new Size(131, 23);
            label3.TabIndex = 2;
            label3.Text = "Cost of Snacks:";
            // 
            // TxtFood
            // 
            TxtFood.BackColor = SystemColors.Window;
            TxtFood.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtFood.Location = new Point(172, 38);
            TxtFood.Name = "TxtFood";
            TxtFood.Size = new Size(154, 30);
            TxtFood.TabIndex = 3;
            // 
            // TxtDrinks
            // 
            TxtDrinks.BackColor = SystemColors.Window;
            TxtDrinks.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtDrinks.Location = new Point(172, 74);
            TxtDrinks.Name = "TxtDrinks";
            TxtDrinks.Size = new Size(154, 30);
            TxtDrinks.TabIndex = 4;
            // 
            // TxtSnacks
            // 
            TxtSnacks.BackColor = SystemColors.Window;
            TxtSnacks.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtSnacks.Location = new Point(172, 110);
            TxtSnacks.Name = "TxtSnacks";
            TxtSnacks.Size = new Size(154, 30);
            TxtSnacks.TabIndex = 5;
            // 
            // BtnSave
            // 
            BtnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnSave.Location = new Point(196, 146);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(102, 32);
            BtnSave.TabIndex = 6;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MistyRose;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(BtnSave);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtSnacks);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtDrinks);
            groupBox1.Controls.Add(TxtFood);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(34, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 215);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Stocks";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.MistyRose;
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(BtnSaveBills);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(TxtInternet);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(TxtWater);
            groupBox2.Controls.Add(TxtElectric);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(455, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(390, 215);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bills";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(32, 44);
            label4.Name = "label4";
            label4.Size = new Size(166, 23);
            label4.TabIndex = 7;
            label4.Text = "Cost of Electric Bill:";
            label4.Click += label4_Click;
            // 
            // BtnSaveBills
            // 
            BtnSaveBills.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnSaveBills.Location = new Point(223, 146);
            BtnSaveBills.Name = "BtnSaveBills";
            BtnSaveBills.Size = new Size(102, 32);
            BtnSaveBills.TabIndex = 13;
            BtnSaveBills.Text = "Save";
            BtnSaveBills.UseVisualStyleBackColor = true;
            BtnSaveBills.Click += BtnSaveBills_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(42, 76);
            label5.Name = "label5";
            label5.Size = new Size(156, 23);
            label5.TabIndex = 8;
            label5.Text = "Cost of Water Bill:";
            // 
            // TxtInternet
            // 
            TxtInternet.BackColor = SystemColors.Window;
            TxtInternet.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtInternet.Location = new Point(198, 106);
            TxtInternet.Name = "TxtInternet";
            TxtInternet.Size = new Size(154, 30);
            TxtInternet.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(26, 109);
            label6.Name = "label6";
            label6.Size = new Size(172, 23);
            label6.TabIndex = 9;
            label6.Text = "Cost of Internet Bill:";
            // 
            // TxtWater
            // 
            TxtWater.BackColor = SystemColors.Window;
            TxtWater.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtWater.Location = new Point(198, 73);
            TxtWater.Name = "TxtWater";
            TxtWater.Size = new Size(154, 30);
            TxtWater.TabIndex = 11;
            // 
            // TxtElectric
            // 
            TxtElectric.BackColor = SystemColors.Window;
            TxtElectric.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtElectric.Location = new Point(198, 37);
            TxtElectric.Name = "TxtElectric";
            TxtElectric.Size = new Size(154, 30);
            TxtElectric.TabIndex = 10;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(40, 286);
            listView1.Name = "listView1";
            listView1.Size = new Size(352, 165);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Food";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Drinks";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Snacks";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            listView2.Location = new Point(455, 286);
            listView2.Name = "listView2";
            listView2.Size = new Size(390, 165);
            listView2.TabIndex = 10;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Electric";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Water";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Internet";
            // 
            // FormStocksAndBills
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(882, 495);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormStocksAndBills";
            Text = "Stocks And Bills";
            Load += FormStocksAndBills_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtFood;
        private TextBox TxtDrinks;
        private TextBox TxtSnacks;
        private Button BtnSave;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Button BtnSaveBills;
        private Label label5;
        private TextBox TxtInternet;
        private Label label6;
        private TextBox TxtWater;
        private TextBox TxtElectric;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView listView2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}