
namespace BRIDGEFINANCE
{
    partial class Reports
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
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fromY = new System.Windows.Forms.ComboBox();
            this.fromM = new System.Windows.Forms.ComboBox();
            this.fromD = new System.Windows.Forms.ComboBox();
            this.invoicelist = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.invoicelist)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 140);
            this.button2.TabIndex = 93;
            this.button2.Text = "STATEMENT\r\nOF\r\nACCOUNT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "qip1",
            "qip2",
            "qit1",
            "qit2"});
            this.comboBox1.Location = new System.Drawing.Point(12, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 54);
            this.comboBox1.TabIndex = 94;
            this.comboBox1.Text = "qip1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(500, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 24);
            this.label6.TabIndex = 98;
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
            this.fromY.Location = new System.Drawing.Point(627, 36);
            this.fromY.Name = "fromY";
            this.fromY.Size = new System.Drawing.Size(135, 52);
            this.fromY.TabIndex = 97;
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
            this.fromM.Location = new System.Drawing.Point(540, 36);
            this.fromM.Name = "fromM";
            this.fromM.Size = new System.Drawing.Size(81, 52);
            this.fromM.TabIndex = 96;
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
            this.fromD.Location = new System.Drawing.Point(459, 36);
            this.fromD.Name = "fromD";
            this.fromD.Size = new System.Drawing.Size(75, 52);
            this.fromD.TabIndex = 95;
            this.fromD.Text = "01";
            // 
            // invoicelist
            // 
            this.invoicelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicelist.Location = new System.Drawing.Point(160, 8);
            this.invoicelist.Name = "invoicelist";
            this.invoicelist.RowHeadersWidth = 51;
            this.invoicelist.RowTemplate.Height = 24;
            this.invoicelist.Size = new System.Drawing.Size(33, 34);
            this.invoicelist.TabIndex = 99;
            this.invoicelist.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(277, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 140);
            this.button1.TabIndex = 100;
            this.button1.Text = "PERIODIC REPORTS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCyan;
            this.button3.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(540, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(231, 140);
            this.button3.TabIndex = 101;
            this.button3.Text = "MISC REPORT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCyan;
            this.button4.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 332);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(231, 140);
            this.button4.TabIndex = 102;
            this.button4.Text = "ADVANCED FORECASTING";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(812, 532);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.invoicelist);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fromY);
            this.Controls.Add(this.fromM);
            this.Controls.Add(this.fromD);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoicelist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox fromY;
        private System.Windows.Forms.ComboBox fromM;
        private System.Windows.Forms.ComboBox fromD;
        private System.Windows.Forms.DataGridView invoicelist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}