
namespace BRIDGEFINANCE
{
    partial class dailysaleslisting
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
            this.ExecuteGenReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toY = new System.Windows.Forms.ComboBox();
            this.toM = new System.Windows.Forms.ComboBox();
            this.toD = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fromY = new System.Windows.Forms.ComboBox();
            this.fromM = new System.Windows.Forms.ComboBox();
            this.fromD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.receiptlist = new System.Windows.Forms.DataGridView();
            this.invoicelist = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.receiptlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicelist)).BeginInit();
            this.SuspendLayout();
            // 
            // ExecuteGenReport
            // 
            this.ExecuteGenReport.BackColor = System.Drawing.Color.MediumPurple;
            this.ExecuteGenReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExecuteGenReport.Font = new System.Drawing.Font("Corbel", 19.93846F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteGenReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExecuteGenReport.Location = new System.Drawing.Point(69, 235);
            this.ExecuteGenReport.Name = "ExecuteGenReport";
            this.ExecuteGenReport.Size = new System.Drawing.Size(327, 135);
            this.ExecuteGenReport.TabIndex = 55;
            this.ExecuteGenReport.Text = "Generate\r\nDAILY SALES LISTING";
            this.ExecuteGenReport.UseVisualStyleBackColor = false;
            this.ExecuteGenReport.Click += new System.EventHandler(this.ExecuteGenReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(536, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "DD            MM              YYYY";
            // 
            // toY
            // 
            this.toY.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toY.FormattingEnabled = true;
            this.toY.Items.AddRange(new object[] {
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
            this.toY.Location = new System.Drawing.Point(660, 145);
            this.toY.Name = "toY";
            this.toY.Size = new System.Drawing.Size(140, 39);
            this.toY.TabIndex = 53;
            this.toY.Text = "2021";
            // 
            // toM
            // 
            this.toM.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toM.FormattingEnabled = true;
            this.toM.Items.AddRange(new object[] {
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
            this.toM.Location = new System.Drawing.Point(589, 145);
            this.toM.Name = "toM";
            this.toM.Size = new System.Drawing.Size(67, 39);
            this.toM.TabIndex = 52;
            this.toM.Text = "01";
            // 
            // toD
            // 
            this.toD.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toD.FormattingEnabled = true;
            this.toD.Items.AddRange(new object[] {
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
            this.toD.Location = new System.Drawing.Point(519, 145);
            this.toD.Name = "toD";
            this.toD.Size = new System.Drawing.Size(66, 39);
            this.toD.TabIndex = 51;
            this.toD.Text = "01";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 13.84615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(462, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 29);
            this.label2.TabIndex = 50;
            this.label2.Text = "TO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(130, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "DD            MM              YYYY";
            // 
            // fromY
            // 
            this.fromY.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.fromY.Location = new System.Drawing.Point(256, 146);
            this.fromY.Name = "fromY";
            this.fromY.Size = new System.Drawing.Size(140, 39);
            this.fromY.TabIndex = 48;
            this.fromY.Text = "2021";
            // 
            // fromM
            // 
            this.fromM.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.fromM.Location = new System.Drawing.Point(185, 146);
            this.fromM.Name = "fromM";
            this.fromM.Size = new System.Drawing.Size(67, 39);
            this.fromM.TabIndex = 47;
            this.fromM.Text = "01";
            // 
            // fromD
            // 
            this.fromD.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.fromD.Location = new System.Drawing.Point(113, 146);
            this.fromD.Name = "fromD";
            this.fromD.Size = new System.Drawing.Size(66, 39);
            this.fromD.TabIndex = 46;
            this.fromD.Text = "01";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 13.84615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(16, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 45;
            this.label3.Text = "FROM: ";
            // 
            // receiptlist
            // 
            this.receiptlist.AllowUserToAddRows = false;
            this.receiptlist.AllowUserToDeleteRows = false;
            this.receiptlist.AllowUserToResizeColumns = false;
            this.receiptlist.AllowUserToResizeRows = false;
            this.receiptlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receiptlist.Location = new System.Drawing.Point(22, 82);
            this.receiptlist.Name = "receiptlist";
            this.receiptlist.RowHeadersWidth = 56;
            this.receiptlist.RowTemplate.Height = 24;
            this.receiptlist.Size = new System.Drawing.Size(92, 10);
            this.receiptlist.TabIndex = 57;
            this.receiptlist.Visible = false;
            // 
            // invoicelist
            // 
            this.invoicelist.AllowUserToAddRows = false;
            this.invoicelist.AllowUserToDeleteRows = false;
            this.invoicelist.AllowUserToResizeColumns = false;
            this.invoicelist.AllowUserToResizeRows = false;
            this.invoicelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicelist.Location = new System.Drawing.Point(21, 12);
            this.invoicelist.Name = "invoicelist";
            this.invoicelist.RowHeadersWidth = 56;
            this.invoicelist.RowTemplate.Height = 24;
            this.invoicelist.Size = new System.Drawing.Size(93, 10);
            this.invoicelist.TabIndex = 56;
            this.invoicelist.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(584, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 28);
            this.label15.TabIndex = 99;
            this.label15.Text = "Branch";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "QIP",
            "QIT"});
            this.comboBox1.Location = new System.Drawing.Point(679, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 54);
            this.comboBox1.TabIndex = 98;
            this.comboBox1.Text = "QIP";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Corbel", 19.93846F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(473, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(327, 135);
            this.button1.TabIndex = 100;
            this.button1.Text = "Generate\r\nPURCHASE REPORT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumPurple;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Corbel", 19.93846F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(69, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(327, 135);
            this.button2.TabIndex = 101;
            this.button2.Text = "VAT REPORT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumPurple;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Corbel", 19.93846F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(473, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(327, 135);
            this.button3.TabIndex = 102;
            this.button3.Text = "Generate\r\n EXPENSES REPORT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dailysaleslisting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(854, 559);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.receiptlist);
            this.Controls.Add(this.invoicelist);
            this.Controls.Add(this.ExecuteGenReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toY);
            this.Controls.Add(this.toM);
            this.Controls.Add(this.toD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fromY);
            this.Controls.Add(this.fromM);
            this.Controls.Add(this.fromD);
            this.Controls.Add(this.label3);
            this.Name = "dailysaleslisting";
            this.Text = "dailysaleslisting";
            this.Load += new System.EventHandler(this.dailysaleslisting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.receiptlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicelist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExecuteGenReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox toY;
        private System.Windows.Forms.ComboBox toM;
        private System.Windows.Forms.ComboBox toD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox fromY;
        private System.Windows.Forms.ComboBox fromM;
        private System.Windows.Forms.ComboBox fromD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView receiptlist;
        private System.Windows.Forms.DataGridView invoicelist;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}