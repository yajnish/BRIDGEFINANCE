
namespace BRIDGEFINANCE
{
    partial class miscRep
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.export = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.key = new System.Windows.Forms.TextBox();
            this.depo = new System.Windows.Forms.RadioButton();
            this.withrawal = new System.Windows.Forms.RadioButton();
            this.both = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(29, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1217, 452);
            this.dataGridView1.TabIndex = 0;
            // 
            // export
            // 
            this.export.BackColor = System.Drawing.Color.LightCyan;
            this.export.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export.Location = new System.Drawing.Point(927, 659);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(319, 91);
            this.export.TabIndex = 102;
            this.export.Text = "EXPORT TO PDF";
            this.export.UseVisualStyleBackColor = false;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.LightCyan;
            this.refresh.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(1089, 122);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(157, 47);
            this.refresh.TabIndex = 103;
            this.refresh.Text = "REFRESH";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // key
            // 
            this.key.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key.Location = new System.Drawing.Point(647, 54);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(599, 62);
            this.key.TabIndex = 104;
            // 
            // depo
            // 
            this.depo.AutoSize = true;
            this.depo.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.depo.Location = new System.Drawing.Point(29, 12);
            this.depo.Name = "depo";
            this.depo.Size = new System.Drawing.Size(187, 46);
            this.depo.TabIndex = 105;
            this.depo.Text = "DEPOSIT";
            this.depo.UseVisualStyleBackColor = true;
            // 
            // withrawal
            // 
            this.withrawal.AutoSize = true;
            this.withrawal.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withrawal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.withrawal.Location = new System.Drawing.Point(29, 64);
            this.withrawal.Name = "withrawal";
            this.withrawal.Size = new System.Drawing.Size(270, 46);
            this.withrawal.TabIndex = 106;
            this.withrawal.Text = "WITHDRAWAL";
            this.withrawal.UseVisualStyleBackColor = true;
            // 
            // both
            // 
            this.both.AutoSize = true;
            this.both.Checked = true;
            this.both.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.both.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.both.Location = new System.Drawing.Point(29, 116);
            this.both.Name = "both";
            this.both.Size = new System.Drawing.Size(133, 46);
            this.both.TabIndex = 107;
            this.both.TabStop = true;
            this.both.Text = "BOTH";
            this.both.UseVisualStyleBackColor = true;
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
            this.comboBox1.Location = new System.Drawing.Point(520, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 54);
            this.comboBox1.TabIndex = 108;
            this.comboBox1.Text = "qip1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // miscRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1272, 762);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.both);
            this.Controls.Add(this.withrawal);
            this.Controls.Add(this.depo);
            this.Controls.Add(this.key);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.export);
            this.Controls.Add(this.dataGridView1);
            this.Name = "miscRep";
            this.Text = "miscRep";
            this.Load += new System.EventHandler(this.miscRep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.RadioButton depo;
        private System.Windows.Forms.RadioButton withrawal;
        private System.Windows.Forms.RadioButton both;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}