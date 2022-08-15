
namespace BRIDGEFINANCE
{
    partial class purchase
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
            this.tax = new System.Windows.Forms.TextBox();
            this.invoiceamt = new System.Windows.Forms.TextBox();
            this.invoiceno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.supplier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fromY = new System.Windows.Forms.ComboBox();
            this.fromM = new System.Windows.Forms.ComboBox();
            this.fromD = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tax
            // 
            this.tax.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tax.Location = new System.Drawing.Point(344, 418);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(417, 76);
            this.tax.TabIndex = 91;
            // 
            // invoiceamt
            // 
            this.invoiceamt.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceamt.Location = new System.Drawing.Point(344, 325);
            this.invoiceamt.Name = "invoiceamt";
            this.invoiceamt.Size = new System.Drawing.Size(417, 76);
            this.invoiceamt.TabIndex = 90;
            this.invoiceamt.TextChanged += new System.EventHandler(this.invoiceamt_TextChanged);
            // 
            // invoiceno
            // 
            this.invoiceno.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceno.Location = new System.Drawing.Point(344, 234);
            this.invoiceno.Name = "invoiceno";
            this.invoiceno.Size = new System.Drawing.Size(417, 76);
            this.invoiceno.TabIndex = 89;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(274, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 28);
            this.label9.TabIndex = 88;
            this.label9.Text = "TAX:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(118, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 28);
            this.label8.TabIndex = 87;
            this.label8.Text = "INVOICE AMOUNT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(118, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 28);
            this.label7.TabIndex = 86;
            this.label7.Text = "INVOICE NUMBER:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(209, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 28);
            this.label5.TabIndex = 85;
            this.label5.Text = "SUPPLIER:";
            // 
            // supplier
            // 
            this.supplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.supplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.supplier.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier.Location = new System.Drawing.Point(344, 145);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(417, 76);
            this.supplier.TabIndex = 84;
            this.supplier.TextChanged += new System.EventHandler(this.supplier_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(499, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 24);
            this.label6.TabIndex = 95;
            this.label6.Text = "DD            MM              YYYY";
            // 
            // fromY
            // 
            this.fromY.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromY.FormattingEnabled = true;
            this.fromY.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.fromY.Location = new System.Drawing.Point(626, 49);
            this.fromY.Name = "fromY";
            this.fromY.Size = new System.Drawing.Size(135, 52);
            this.fromY.TabIndex = 94;
            this.fromY.Text = "2022";
            // 
            // fromM
            // 
            this.fromM.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromM.FormattingEnabled = true;
            this.fromM.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.fromM.Location = new System.Drawing.Point(539, 49);
            this.fromM.Name = "fromM";
            this.fromM.Size = new System.Drawing.Size(81, 52);
            this.fromM.TabIndex = 93;
            this.fromM.Text = "01";
            // 
            // fromD
            // 
            this.fromD.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromD.FormattingEnabled = true;
            this.fromD.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.fromD.Location = new System.Drawing.Point(458, 49);
            this.fromD.Name = "fromD";
            this.fromD.Size = new System.Drawing.Size(75, 52);
            this.fromD.TabIndex = 92;
            this.fromD.Text = "01";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.Font = new System.Drawing.Font("Arial Black", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(514, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 64);
            this.button2.TabIndex = 98;
            this.button2.Text = "RECORD";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(272, 552);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 28);
            this.label15.TabIndex = 97;
            this.label15.Text = "Branch";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "QIP",
            "QIT"});
            this.comboBox1.Location = new System.Drawing.Point(367, 534);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 54);
            this.comboBox1.TabIndex = 96;
            this.comboBox1.Text = "QIP";
            // 
            // purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(870, 780);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fromY);
            this.Controls.Add(this.fromM);
            this.Controls.Add(this.fromD);
            this.Controls.Add(this.tax);
            this.Controls.Add(this.invoiceamt);
            this.Controls.Add(this.invoiceno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.supplier);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "purchase";
            this.Text = "purchase";
            this.Load += new System.EventHandler(this.purchase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tax;
        private System.Windows.Forms.TextBox invoiceamt;
        private System.Windows.Forms.TextBox invoiceno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox fromY;
        private System.Windows.Forms.ComboBox fromM;
        private System.Windows.Forms.ComboBox fromD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.TextBox supplier;
    }
}