namespace Hostel_Assos_Application_V._2
{
    partial class FormIncomeAndExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIncomeAndExpenses));
            LblInternetBill = new GroupBox();
            label3 = new Label();
            BtnCalculate = new Button();
            TxtStaffAmount = new TextBox();
            textBox1 = new TextBox();
            label12 = new Label();
            label11 = new Label();
            LblResult = new Label();
            LblInternetBills = new Label();
            LblWaterBills = new Label();
            LblElectricBills = new Label();
            LblPurchasedSnack = new Label();
            LblPurchasedDrink = new Label();
            LblPurchasedFood = new Label();
            LblStaffSalaries = new Label();
            LblMoneyInSafe = new Label();
            label2 = new Label();
            LblPurchasedProducts = new Label();
            label1 = new Label();
            LblMoneyInTheSafe = new Label();
            LblInternetBill.SuspendLayout();
            SuspendLayout();
            // 
            // LblInternetBill
            // 
            LblInternetBill.BackColor = Color.Linen;
            LblInternetBill.Controls.Add(label3);
            LblInternetBill.Controls.Add(BtnCalculate);
            LblInternetBill.Controls.Add(TxtStaffAmount);
            LblInternetBill.Controls.Add(textBox1);
            LblInternetBill.Controls.Add(label12);
            LblInternetBill.Controls.Add(label11);
            LblInternetBill.Controls.Add(LblResult);
            LblInternetBill.Controls.Add(LblInternetBills);
            LblInternetBill.Controls.Add(LblWaterBills);
            LblInternetBill.Controls.Add(LblElectricBills);
            LblInternetBill.Controls.Add(LblPurchasedSnack);
            LblInternetBill.Controls.Add(LblPurchasedDrink);
            LblInternetBill.Controls.Add(LblPurchasedFood);
            LblInternetBill.Controls.Add(LblStaffSalaries);
            LblInternetBill.Controls.Add(LblMoneyInSafe);
            LblInternetBill.Controls.Add(label2);
            LblInternetBill.Controls.Add(LblPurchasedProducts);
            LblInternetBill.Controls.Add(label1);
            LblInternetBill.Controls.Add(LblMoneyInTheSafe);
            LblInternetBill.Location = new Point(55, 45);
            LblInternetBill.Name = "LblInternetBill";
            LblInternetBill.Size = new Size(808, 327);
            LblInternetBill.TabIndex = 0;
            LblInternetBill.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(35, 219);
            label3.Name = "label3";
            label3.Size = new Size(735, 20);
            label3.TabIndex = 18;
            label3.Text = "-------------------------------------------------------------------------------------------------------------------------";
            // 
            // BtnCalculate
            // 
            BtnCalculate.BackColor = Color.LightBlue;
            BtnCalculate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnCalculate.Location = new Point(535, 175);
            BtnCalculate.Name = "BtnCalculate";
            BtnCalculate.Size = new Size(208, 41);
            BtnCalculate.TabIndex = 17;
            BtnCalculate.Text = "Calculate";
            BtnCalculate.UseVisualStyleBackColor = false;
            BtnCalculate.Click += BtnCalculate_Click;
            // 
            // TxtStaffAmount
            // 
            TxtStaffAmount.Location = new Point(692, 35);
            TxtStaffAmount.Name = "TxtStaffAmount";
            TxtStaffAmount.Size = new Size(89, 27);
            TxtStaffAmount.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(-36, 404);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.ForeColor = Color.DarkRed;
            label12.Location = new Point(554, 37);
            label12.Name = "label12";
            label12.Size = new Size(132, 25);
            label12.TabIndex = 14;
            label12.Text = "Staff Amount:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.ForeColor = Color.DarkRed;
            label11.Location = new Point(268, 239);
            label11.Name = "label11";
            label11.Size = new Size(69, 25);
            label11.TabIndex = 13;
            label11.Text = "Result:";
            // 
            // LblResult
            // 
            LblResult.AutoSize = true;
            LblResult.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblResult.Location = new Point(343, 241);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(30, 23);
            LblResult.TabIndex = 12;
            LblResult.Text = "00";
            // 
            // LblInternetBills
            // 
            LblInternetBills.AutoSize = true;
            LblInternetBills.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblInternetBills.Location = new Point(474, 145);
            LblInternetBills.Name = "LblInternetBills";
            LblInternetBills.Size = new Size(30, 23);
            LblInternetBills.TabIndex = 11;
            LblInternetBills.Text = "00";
            // 
            // LblWaterBills
            // 
            LblWaterBills.AutoSize = true;
            LblWaterBills.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblWaterBills.Location = new Point(408, 143);
            LblWaterBills.Name = "LblWaterBills";
            LblWaterBills.Size = new Size(30, 23);
            LblWaterBills.TabIndex = 10;
            LblWaterBills.Text = "00";
            // 
            // LblElectricBills
            // 
            LblElectricBills.AutoSize = true;
            LblElectricBills.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblElectricBills.Location = new Point(343, 145);
            LblElectricBills.Name = "LblElectricBills";
            LblElectricBills.Size = new Size(30, 23);
            LblElectricBills.TabIndex = 9;
            LblElectricBills.Text = "00";
            // 
            // LblPurchasedSnack
            // 
            LblPurchasedSnack.AutoSize = true;
            LblPurchasedSnack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblPurchasedSnack.Location = new Point(474, 108);
            LblPurchasedSnack.Name = "LblPurchasedSnack";
            LblPurchasedSnack.Size = new Size(30, 23);
            LblPurchasedSnack.TabIndex = 8;
            LblPurchasedSnack.Text = "00";
            // 
            // LblPurchasedDrink
            // 
            LblPurchasedDrink.AutoSize = true;
            LblPurchasedDrink.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblPurchasedDrink.Location = new Point(408, 108);
            LblPurchasedDrink.Name = "LblPurchasedDrink";
            LblPurchasedDrink.Size = new Size(30, 23);
            LblPurchasedDrink.TabIndex = 7;
            LblPurchasedDrink.Text = "00";
            // 
            // LblPurchasedFood
            // 
            LblPurchasedFood.AutoSize = true;
            LblPurchasedFood.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblPurchasedFood.Location = new Point(343, 110);
            LblPurchasedFood.Name = "LblPurchasedFood";
            LblPurchasedFood.Size = new Size(30, 23);
            LblPurchasedFood.TabIndex = 6;
            LblPurchasedFood.Text = "00";
            // 
            // LblStaffSalaries
            // 
            LblStaffSalaries.AutoSize = true;
            LblStaffSalaries.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblStaffSalaries.Location = new Point(343, 73);
            LblStaffSalaries.Name = "LblStaffSalaries";
            LblStaffSalaries.Size = new Size(30, 23);
            LblStaffSalaries.TabIndex = 5;
            LblStaffSalaries.Text = "00";
            LblStaffSalaries.Click += LblStaffSalaries_Click;
            // 
            // LblMoneyInSafe
            // 
            LblMoneyInSafe.AutoSize = true;
            LblMoneyInSafe.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblMoneyInSafe.Location = new Point(343, 38);
            LblMoneyInSafe.Name = "LblMoneyInSafe";
            LblMoneyInSafe.Size = new Size(30, 23);
            LblMoneyInSafe.TabIndex = 4;
            LblMoneyInSafe.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(286, 143);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 3;
            label2.Text = "Bills:";
            // 
            // LblPurchasedProducts
            // 
            LblPurchasedProducts.AutoSize = true;
            LblPurchasedProducts.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblPurchasedProducts.ForeColor = Color.DarkRed;
            LblPurchasedProducts.Location = new Point(54, 108);
            LblPurchasedProducts.Name = "LblPurchasedProducts";
            LblPurchasedProducts.Size = new Size(283, 25);
            LblPurchasedProducts.TabIndex = 2;
            LblPurchasedProducts.Text = "Amount of Products Purchased:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(210, 71);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 1;
            label1.Text = "Staff Salaries:";
            // 
            // LblMoneyInTheSafe
            // 
            LblMoneyInTheSafe.AutoSize = true;
            LblMoneyInTheSafe.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblMoneyInTheSafe.ForeColor = Color.DarkRed;
            LblMoneyInTheSafe.Location = new Point(17, 34);
            LblMoneyInTheSafe.Name = "LblMoneyInTheSafe";
            LblMoneyInTheSafe.Size = new Size(320, 25);
            LblMoneyInTheSafe.TabIndex = 0;
            LblMoneyInTheSafe.Text = "Total Amount of Money in The Safe:";
            // 
            // FormIncomeAndExpenses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(924, 432);
            Controls.Add(LblInternetBill);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormIncomeAndExpenses";
            Text = "FormIncomeAndExpenses";
            Load += FormIncomeAndExpenses_Load;
            LblInternetBill.ResumeLayout(false);
            LblInternetBill.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox LblInternetBill;
        private Label LblMoneyInTheSafe;
        private TextBox TxtStaffAmount;
        private TextBox textBox1;
        private Label label12;
        private Label label11;
        private Label LblResult;
        private Label LblInternetBills;
        private Label LblWaterBills;
        private Label LblElectricBills;
        private Label LblPurchasedSnack;
        private Label LblPurchasedDrink;
        private Label LblPurchasedFood;
        private Label LblStaffSalaries;
        private Label LblMoneyInSafe;
        private Label label2;
        private Label LblPurchasedProducts;
        private Label label1;
        private Label label3;
        private Button BtnCalculate;
    }
}