using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using Font = iTextSharp.text.Font;
using Image = iTextSharp.text.Image;
using System.IO;
using System.Drawing.Imaging;

namespace BRIDGEFINANCE
{
    public partial class miscRep : Form
    {
        public miscRep()
        {
            InitializeComponent();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            if(both.Checked == true) {

                string queryString = $"SELECT date, reference, description, value FROM statement WHERE (description LIKE '%{key.Text}%') AND (acc = '{comboBox1.Text}')";
                //string queryreceipt = $"select * from receipt WHERE (date_paid BETEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";


                DataTable dt = new System.Data.DataTable();
                using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                {

                    SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                    adapt.Fill(dt);

                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoResizeColumns();
                    dataGridView1.Columns[0].HeaderText = "DATE:";
                    dataGridView1.Columns[1].HeaderText = "REFERENCE:";
                    dataGridView1.Columns[2].HeaderText = "DESCRIPTION:";
                    dataGridView1.Columns[3].HeaderText = "VALUE:";
                    dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("ARIAL", 30F, GraphicsUnit.Pixel);
                    DataGridViewColumn column = dataGridView1.Columns[0];
                    column.Width = 250;
                    column = dataGridView1.Columns[1];
                    column.Width = 250;
                    column = dataGridView1.Columns[2];
                    column.Width = 500;
                    column = dataGridView1.Columns[3];
                    column.Width = 200;

                }

            }else if(withrawal.Checked == true)
            {
                string queryString = $"SELECT date, reference, description, value FROM statement WHERE (description LIKE '%{key.Text}%') AND (acc = '{comboBox1.Text}') AND (type LIKE '%WITHDRAW%')";
                //string queryreceipt = $"select * from receipt WHERE (date_paid BETEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";


                DataTable dt = new System.Data.DataTable();
                using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                {

                    SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                    adapt.Fill(dt);

                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoResizeColumns();
                    dataGridView1.Columns[0].HeaderText = "DATE:";
                    dataGridView1.Columns[1].HeaderText = "REFERENCE:";
                    dataGridView1.Columns[2].HeaderText = "DESCRIPTION:";
                    dataGridView1.Columns[3].HeaderText = "VALUE:";
                    dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("ARIAL", 30F, GraphicsUnit.Pixel);
                    DataGridViewColumn column = dataGridView1.Columns[0];
                    column.Width = 250;
                    column = dataGridView1.Columns[1];
                    column.Width = 250;
                    column = dataGridView1.Columns[2];
                    column.Width = 500;
                    column = dataGridView1.Columns[3];
                    column.Width = 200;

                }
            }else if(depo.Checked == true)
            {
                string queryString = $"SELECT date, reference, description, value FROM statement WHERE (description LIKE '%{key.Text}%') AND (acc = '{comboBox1.Text}') AND (type LIKE '%DEPOSIT%')";
                //string queryreceipt = $"select * from receipt WHERE (date_paid BETEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";


                DataTable dt = new System.Data.DataTable();
                using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                {

                    SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                    adapt.Fill(dt);

                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoResizeColumns();
                    dataGridView1.Columns[0].HeaderText = "DATE:";
                    dataGridView1.Columns[1].HeaderText = "REFERENCE:";
                    dataGridView1.Columns[2].HeaderText = "DESCRIPTION:";
                    dataGridView1.Columns[3].HeaderText = "VALUE:";
                    dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("ARIAL", 30F, GraphicsUnit.Pixel);
                    DataGridViewColumn column = dataGridView1.Columns[0];
                    column.Width = 250;
                    column = dataGridView1.Columns[1];
                    column.Width = 250;
                    column = dataGridView1.Columns[2];
                    column.Width = 500;
                    column = dataGridView1.Columns[3];
                    column.Width = 200;

                }
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            try
            {
                var pdfInvoice = new Document(PageSize.A4, 30f, 30f, 45f, 50f);
                string path = $"C:\\Users\\DELL\\Desktop\\FINANCE SOFTWARE\\REPORTS\\OTHER REPORTS\\REP{key.Text}.pdf";
                PdfWriter.GetInstance(pdfInvoice, new FileStream(path, FileMode.OpenOrCreate));
                pdfInvoice.Open();

                var imagepth = @"C:\Users\DELL\Desktop\FINANCE SOFTWARE\RESOURCE\REPORT.jpg";
                using (FileStream fs = new FileStream(imagepth, FileMode.Open))
                {
                    var jpg = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                    jpg.ScaleToFit(pdfInvoice.PageSize);
                    jpg.SetAbsolutePosition(0, 0);
                    jpg.Alignment = iTextSharp.text.Image.UNDERLYING;
                    pdfInvoice.Add(jpg);
                }

                var spacer = new Paragraph("")
                {
                    SpacingBefore = 10f,
                    SpacingAfter = 10f,
                };
                pdfInvoice.Add(spacer);
                pdfInvoice.Add(spacer);
                pdfInvoice.Add(spacer);
                pdfInvoice.Add(spacer);
                pdfInvoice.Add(spacer);
                Font titleFont = FontFactory.GetFont("Helvetica", 12);


                Paragraph title = new Paragraph($"", titleFont);

                title.Alignment = 2;
                pdfInvoice.Add(title);




                titleFont = FontFactory.GetFont("Helvetica", 12);

                var spacerx = new Paragraph("")
                {
                    SpacingBefore = 2f,
                    SpacingAfter = 2f,
                };
                pdfInvoice.Add(spacerx);
                pdfInvoice.Add(spacerx);
                pdfInvoice.Add(spacerx);

                Paragraph dateToday = new Paragraph($"{DateTime.Now.ToString("ddd dd MMMM yyyy")}", titleFont);
                dateToday.Alignment = 2;

                pdfInvoice.Add(dateToday);

                pdfInvoice.Add(spacerx);

                var spacer4 = new Paragraph("")
                {
                    SpacingBefore = 0.5f,
                    SpacingAfter = 0.5f,
                };

                pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);

                var invoicenum = new Paragraph($"", titleFont);
                invoicenum.Alignment = 2;
                pdfInvoice.Add(invoicenum);

                pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);
                Paragraph compName = new Paragraph($"REPORT:", titleFont);
                compName.Alignment = 0;
                pdfInvoice.Add(compName);



                pdfInvoice.Add(spacer4);
                

                pdfInvoice.Add(spacerx);


                pdfInvoice.Add(spacerx); pdfInvoice.Add(spacerx); pdfInvoice.Add(spacerx);


                //Font titleFont2 = FontFactory.GetFont("Helvetica Bold", 12);
                PdfPCell cell = new PdfPCell();
                PdfPTable producttable = new PdfPTable(dataGridView1.ColumnCount);
                producttable.DefaultCell.Padding = 8;
                producttable.WidthPercentage = 100;
                producttable.HorizontalAlignment = Element.ALIGN_RIGHT;
                producttable.DefaultCell.BorderWidth = 0;
                BaseColor couleur = new BaseColor(255, 255, 255);
                Font titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    cell = new PdfPCell(new Phrase(column.HeaderText, titleFont3));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                    producttable.AddCell(cell);
                }
                float[] widths = new float[] { 2.5f, 2.5f, 5f, 2f };
                producttable.SetWidths(widths);


                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell1 in row.Cells)
                    {
                        string text = cell1.Value.ToString();

                        producttable.AddCell(new PdfPCell(new Phrase(text, titleFont)));
                    }
                }

                pdfInvoice.Add(spacerx); pdfInvoice.Add(spacerx);

                pdfInvoice.Add(producttable);

                



                pdfInvoice.Close();


                System.Diagnostics.Process.Start($"C:\\Users\\DELL\\Desktop\\FINANCE SOFTWARE\\REPORTS\\OTHER REPORTS\\REP{key.Text}.pdf");


            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
        }

        private void miscRep_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
