using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using Font = iTextSharp.text.Font;
using Image = iTextSharp.text.Image;
using System.Reflection;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;
using Dapper;

namespace BRIDGEFINANCE
{
    public partial class dailysaleslisting : Form
    {
        public dailysaleslisting()
        {
            InitializeComponent();
        }

        private void ExecuteGenReport_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //DataTable dt2 = new DataTable();
            string queryString = $"SELECT [date] ,[cashregister],[cashbook],[juice],[cheque],[card],[credit],[lb],[charity],[other],[total] FROM [BRIDGEFINANCE].[dbo].[dailysales] WHERE acc = '{comboBox1.Text}' AND (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";
            //string queryreceipt = $"select * from receipt WHERE (date_paid BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";
            

            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
            {

                SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                adapt.Fill(dt);

                invoicelist.DataSource = dt;

                //double sumINVOICE = 0;
                //for (int i = 0; i < invoicelist.Rows.Count; ++i)
                //{
                //    sumINVOICE += Convert.ToDouble(invoicelist.Rows[i].Cells[3].Value);
                //}


            }   //try
                //{
            var pdfReport = new Document(PageSize.A4, 20f, 20f, 50f, 50f);
                Random rnd = new Random();
                int saveno = rnd.Next(1, 51);
                string path = $"C:\\Users\\DELL\\Desktop\\FINANCE SOFTWARE\\REPORTS\\DAILY SALES LISTING\\SALES{comboBox1.Text}_{fromY.Text}-{fromM.Text}-{fromD.Text} to {toY.Text}-{toM.Text}-{toD.Text}.pdf";

                PdfWriter.GetInstance(pdfReport, new FileStream(path, FileMode.OpenOrCreate));
                pdfReport.Open();

                var imagepth = @"C:\Users\DELL\Desktop\FINANCE SOFTWARE\RESOURCE\REPORT.jpg";
                using (FileStream fs = new FileStream(imagepth, FileMode.Open))
                {
                    var jpg = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                    jpg.ScaleToFit(pdfReport.PageSize);
                    jpg.SetAbsolutePosition(0, 0);
                    jpg.Alignment = iTextSharp.text.Image.UNDERLYING;
                    pdfReport.Add(jpg);
                }

                var spacer = new Paragraph("")
                {
                    SpacingBefore = 10f,
                    SpacingAfter = 10f,
                };
            var spacer3 = new Paragraph("")
            {
                SpacingBefore = 1f,
                SpacingAfter = 1f,
            };
            pdfReport.Add(spacer);
                pdfReport.Add(spacer);
                pdfReport.Add(spacer);
                pdfReport.Add(spacer);


                Font titleFont = FontFactory.GetFont("Courier");
                DateTime today = DateTime.Today;
            pdfReport.Add(spacer3); pdfReport.Add(spacer3);
            Paragraph title = new Paragraph($"Date Generated: {today.ToString("dd/MM/yyyy")}", titleFont);
                title.Alignment = 2;
                title.Font = FontFactory.GetFont("Helvetica Bold", 19);
                pdfReport.Add(title);



                title = new Paragraph($"Selected Period of Time: {fromD.Text}/{fromM.Text}/{fromY.Text} TO {toD.Text}/{toM.Text}/{toY.Text}", titleFont);
                title.Alignment = 0;
                title.Font = FontFactory.GetFont("Helvetica Bold", 19);
                pdfReport.Add(title);

                pdfReport.Add(spacer);

                title = new Paragraph($"{comboBox1.Text} DAILY SALES LISTING FOR THE SELECTED PERIOD OF TIME", titleFont);
                title.Alignment = 1;
                title.Font = FontFactory.GetFont("Courier", 16);

                pdfReport.Add(title);

                pdfReport.Add(spacer);
                //invoiceNo, date, clientName, totalCourse, coursePer, balRemaining
                invoicelist.Columns[0].HeaderText = "Date";
                invoicelist.Columns[1].HeaderText = "Cash Register";
                invoicelist.Columns[2].HeaderText = "Cash Book";
                invoicelist.Columns[3].HeaderText = "Juice";
                invoicelist.Columns[4].HeaderText = "Cheque";
                invoicelist.Columns[5].HeaderText = "Card";
                invoicelist.Columns[6].HeaderText = "Credit";
                invoicelist.Columns[7].HeaderText = "lb";
                invoicelist.Columns[8].HeaderText = "Charity";
                invoicelist.Columns[9].HeaderText = "Others";
                invoicelist.Columns[10].HeaderText = "TOTAL";

                PdfPTable producttable = new PdfPTable(11);
                producttable.DefaultCell.Padding = 3;
                producttable.WidthPercentage = 100;
                producttable.HorizontalAlignment = Element.ALIGN_LEFT;
                producttable.DefaultCell.BorderWidth = 1;
                BaseColor couleur = new BaseColor(255, 255, 255);
                Font titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);
                foreach (DataGridViewColumn column in invoicelist.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, titleFont3));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                    producttable.AddCell(cell);
                }

                float[] widths = new float[] { 1.2f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 0.8f, 1.5f};
                producttable.SetWidths(widths);

                foreach (DataGridViewRow row in invoicelist.Rows)
                {
                    int counta = 1;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        string text = cell.Value.ToString();
                        double d;
                        if (cell.Value == null)
                        {
                            text = "";
                        }
                        else
                        {
                            text = cell.Value.ToString();
                        }
                        if (counta == 1)
                        {
                            text = text.Substring(0, 10);
                        }
                        if (counta != 1)
                        {
                            if (double.TryParse(text, out d))
                            {
                                d = double.Parse(text);
                                text = String.Format("{0:f2}", d);
                            }
                        }
                        
                        counta = counta + 1;
                        producttable.AddCell(new PdfPCell(new Phrase(text, FontFactory.GetFont("Courier", 8))));
                    }
                }

                pdfReport.Add(producttable);

            double total;
            string cashregister, cashbook, juice, cheque, card, credit, lb, charity, other, totalds;
            cashregister = "00";

            cashbook = "00";

            juice = "00";

            cheque = "00";

            card = "00";

            credit = "00";

            lb = "00";

            charity = "00";

            other = "00";
            totalds = "00";


            if (invoicelist.RowCount != 0)
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                {
                    cashregister = connection.ExecuteScalar($"SELECT SUM(cashregister) FROM [BRIDGEFINANCE].[dbo].[dailysales] WHERE acc = '{comboBox1.Text}' AND (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')").ToString();

                    cashbook = connection.ExecuteScalar($"SELECT SUM(cashbook) FROM [BRIDGEFINANCE].[dbo].[dailysales] WHERE acc = '{comboBox1.Text}' AND (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')").ToString();

                    juice = connection.ExecuteScalar($"SELECT SUM(juice) FROM [BRIDGEFINANCE].[dbo].[dailysales] WHERE acc = '{comboBox1.Text}' AND (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')").ToString();

                    cheque = connection.ExecuteScalar($"SELECT SUM(cheque) FROM [BRIDGEFINANCE].[dbo].[dailysales] WHERE acc = '{comboBox1.Text}' AND (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')").ToString();

                    card = connection.ExecuteScalar($"SELECT SUM(card) FROM [BRIDGEFINANCE].[dbo].[dailysales] WHERE acc = '{comboBox1.Text}' AND (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')").ToString();

                    credit = connection.ExecuteScalar($"SELECT SUM(credit) FROM [BRIDGEFINANCE].[dbo].[dailysales] WHERE acc = '{comboBox1.Text}' AND (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')").ToString();

                    lb = connection.ExecuteScalar($"SELECT SUM(lb) FROM [BRIDGEFINANCE].[dbo].[dailysales] WHERE acc = '{comboBox1.Text}' AND (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')").ToString();

                    charity = connection.ExecuteScalar($"SELECT SUM(charity) FROM [BRIDGEFINANCE].[dbo].[dailysales] WHERE acc = '{comboBox1.Text}' AND (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')").ToString();

                    other = connection.ExecuteScalar($"SELECT SUM(other) FROM [BRIDGEFINANCE].[dbo].[dailysales] WHERE acc = '{comboBox1.Text}' AND (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')").ToString();

                    totalds = connection.ExecuteScalar($"SELECT SUM(total) FROM [BRIDGEFINANCE].[dbo].[dailysales] WHERE acc = '{comboBox1.Text}' AND (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')").ToString();

                }
            }
            
            pdfReport.Add(spacer3);

            title = new Paragraph($"TOTAL CASHREGISTER FOR SET PERIOD OF TIME: Rs. {cashregister.Substring(0, cashregister.Length - 2)}.", titleFont);
            title.Alignment = 0;
            title.Font = FontFactory.GetFont("Courier", 10);
            pdfReport.Add(title);

            title = new Paragraph($"TOTAL CASHBOOK FOR SET PERIOD OF TIME: Rs. {cashbook.Substring(0, cashbook.Length - 2)}.", titleFont);
            title.Alignment = 0;
            title.Font = FontFactory.GetFont("Courier", 10);
            pdfReport.Add(title);

            title = new Paragraph($"TOTAL JUICE FOR SET PERIOD OF TIME: Rs. {juice.Substring(0, juice.Length - 2)}.", titleFont);
            title.Alignment = 0;
            title.Font = FontFactory.GetFont("Courier", 10);
            pdfReport.Add(title);

            title = new Paragraph($"TOTAL CHEQUE FOR SET PERIOD OF TIME: Rs. {cheque.Substring(0, cheque.Length - 2)}.", titleFont);
            title.Alignment = 0;
            title.Font = FontFactory.GetFont("Courier", 10);
            pdfReport.Add(title);

            title = new Paragraph($"TOTAL CARD FOR SET PERIOD OF TIME: Rs. {card.Substring(0, card.Length - 2)}.", titleFont);
            title.Alignment = 0;
            title.Font = FontFactory.GetFont("Courier", 10);
            pdfReport.Add(title);

            title = new Paragraph($"TOTAL CREDIT FOR SET PERIOD OF TIME: Rs. {credit.Substring(0, credit.Length - 2)}.", titleFont);
            title.Alignment = 0;
            title.Font = FontFactory.GetFont("Courier", 10);
            pdfReport.Add(title);

            title = new Paragraph($"TOTAL LB FOR SET PERIOD OF TIME: Rs. {lb.Substring(0, lb.Length - 2)}.", titleFont);
            title.Alignment = 0;
            title.Font = FontFactory.GetFont("Courier", 10);
            pdfReport.Add(title);

            title = new Paragraph($"TOTAL CHARITY FOR SET PERIOD OF TIME: Rs. {charity.Substring(0, charity.Length - 2)}.", titleFont);
            title.Alignment = 0;
            title.Font = FontFactory.GetFont("Courier", 10);
            pdfReport.Add(title);

            title = new Paragraph($"TOTAL OTHERS FOR SET PERIOD OF TIME: Rs. {other.Substring(0, other.Length - 2)}.", titleFont);
            title.Alignment = 0;
            title.Font = FontFactory.GetFont("Courier", 10);
            pdfReport.Add(title);

            title = new Paragraph($"TOTAL SALE FOR SET PERIOD OF TIME: Rs. {totalds.Substring(0, totalds.Length - 2)}.", titleFont);
                title.Alignment = 0;
                title.Font = FontFactory.GetFont("Courier", 16);
                pdfReport.Add(title);
                //title = new Paragraph($"TOTAL TAX: Rs. {taxamt}.", titleFont);
                //title.Alignment = 0;
                //title.Font = FontFactory.GetFont("Courier", 16);
                //pdfReport.Add(title);



                pdfReport.Close();

                System.Diagnostics.Process.Start($"C:\\Users\\DELL\\Desktop\\FINANCE SOFTWARE\\REPORTS\\DAILY SALES LISTING\\SALES{comboBox1.Text}_{fromY.Text}-{fromM.Text}-{fromD.Text} to {toY.Text}-{toM.Text}-{toD.Text}.pdf");

            //invoicelist.Rows.Clear();


        }

        private void dailysaleslisting_Load(object sender, EventArgs e)
        {
            fromD.Text = $"{DateTime.Now.ToString("dd")}";
            fromM.Text = $"{DateTime.Now.ToString("MM")}";
            fromY.Text = $"{DateTime.Now.ToString("yyyy")}";
            toD.Text = $"{DateTime.Now.ToString("dd")}";
            toM.Text = $"{DateTime.Now.ToString("MM")}";
            toY.Text = $"{DateTime.Now.ToString("yyyy")}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //DataTable dt2 = new DataTable();
            string queryString = $"SELECT [date], [supplier], [invoiceno], [invoiceamt], [tax] FROM [BRIDGEFINANCE].[dbo].[purchase] WHERE branch = '{comboBox1.Text}' AND (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";
            //string queryreceipt = $"select * from receipt WHERE (date_paid BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";
            var table = new DataTable();

            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
            {

                SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                adapt.Fill(dt);

                invoicelist.DataSource = dt;

                //double sumINVOICE = 0;
                //for (int i = 0; i < invoicelist.Rows.Count; ++i)
                //{
                //    sumINVOICE += Convert.ToDouble(invoicelist.Rows[i].Cells[3].Value);
                //}


            }   //try
                //{
            var pdfReport = new Document(PageSize.A4, 20f, 20f, 50f, 50f);
            Random rnd = new Random();
            int saveno = rnd.Next(1, 51);
            string path = $"C:\\Users\\DELL\\Desktop\\FINANCE SOFTWARE\\REPORTS\\PURCHASE REPORT\\PURCHASE{comboBox1.Text}_{fromY.Text}-{fromM.Text}-{fromD.Text} to {toY.Text}-{toM.Text}-{toD.Text}.pdf";

            PdfWriter.GetInstance(pdfReport, new FileStream(path, FileMode.OpenOrCreate));
            pdfReport.Open();

            var imagepth = @"C:\Users\DELL\Desktop\FINANCE SOFTWARE\RESOURCE\REPORT.jpg";
            using (FileStream fs = new FileStream(imagepth, FileMode.Open))
            {
                var jpg = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                jpg.ScaleToFit(pdfReport.PageSize);
                jpg.SetAbsolutePosition(0, 0);
                jpg.Alignment = iTextSharp.text.Image.UNDERLYING;
                pdfReport.Add(jpg);
            }

            var spacer = new Paragraph("")
            {
                SpacingBefore = 10f,
                SpacingAfter = 10f,
            };
            var spacer3 = new Paragraph("")
            {
                SpacingBefore = 1f,
                SpacingAfter = 1f,
            };
            pdfReport.Add(spacer);
            pdfReport.Add(spacer);
            pdfReport.Add(spacer);
            pdfReport.Add(spacer);


            Font titleFont = FontFactory.GetFont("Courier");
            DateTime today = DateTime.Today;
            pdfReport.Add(spacer3); pdfReport.Add(spacer3);
            Paragraph title = new Paragraph($"Date Generated: {today.ToString("dd/MM/yyyy")}", titleFont);
            title.Alignment = 2;
            title.Font = FontFactory.GetFont("Helvetica Bold", 19);
            pdfReport.Add(title);



            title = new Paragraph($"Selected Period of Time: {fromD.Text}/{fromM.Text}/{fromY.Text} TO {toD.Text}/{toM.Text}/{toY.Text}", titleFont);
            title.Alignment = 0;
            title.Font = FontFactory.GetFont("Helvetica Bold", 19);
            pdfReport.Add(title);

            pdfReport.Add(spacer);

            title = new Paragraph($"{comboBox1.Text} PURCHASE REPORT FOR THE SELECTED PERIOD OF TIME", titleFont);
            title.Alignment = 1;
            title.Font = FontFactory.GetFont("Courier", 16);

            pdfReport.Add(title);

            pdfReport.Add(spacer);
            //invoiceNo, date, clientName, totalCourse, coursePer, balRemaining
            invoicelist.Columns[0].HeaderText = "Date";
            invoicelist.Columns[1].HeaderText = "Supplier";
            invoicelist.Columns[2].HeaderText = "Invoice";
            invoicelist.Columns[3].HeaderText = "Invoice Amount";
            invoicelist.Columns[4].HeaderText = "Tax";
            

            PdfPTable producttable = new PdfPTable(5);
            producttable.DefaultCell.Padding = 3;
            producttable.WidthPercentage = 100;
            producttable.HorizontalAlignment = Element.ALIGN_LEFT;
            producttable.DefaultCell.BorderWidth = 1;
            BaseColor couleur = new BaseColor(255, 255, 255);
            Font titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);
            foreach (DataGridViewColumn column in invoicelist.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, titleFont3));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                producttable.AddCell(cell);
            }

            float[] widths = new float[] { 1f, 1.5f, 0.8f, 0.8f, 0.8f};
            producttable.SetWidths(widths);

            foreach (DataGridViewRow row in invoicelist.Rows)
            {
                int counta = 1;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string text = cell.Value.ToString();
                    double d;
                    if (cell.Value == null)
                    {
                        text = "";
                    }
                    else
                    {
                        text = cell.Value.ToString();
                    }
                    if (counta == 1)
                    {
                        text = text.Substring(0, 10);
                    }
                    if (counta >3)
                    {
                        if (double.TryParse(text, out d))
                        {
                            d = double.Parse(text);
                            text = String.Format("{0:f2}", d);
                        }
                    }

                    counta = counta + 1;
                    producttable.AddCell(new PdfPCell(new Phrase(text, FontFactory.GetFont("Courier", 10))));
                }
            }

            pdfReport.Add(producttable);

            double total;
            string totalds = "00", totaltax= "00";
            if(invoicelist.RowCount != 0)
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                {
                    totalds = connection.ExecuteScalar($"SELECT SUM(invoiceamt) FROM [BRIDGEFINANCE].[dbo].[purchase] WHERE branch = '{comboBox1.Text}' AND (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')").ToString();
                    totaltax = connection.ExecuteScalar($"SELECT SUM(tax) FROM [BRIDGEFINANCE].[dbo].[purchase] WHERE branch = '{comboBox1.Text}' AND (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')").ToString();
                }
            }
            
            pdfReport.Add(spacer3);

            title = new Paragraph($"TOTAL PURCHASE FOR SET PERIOD OF TIME: Rs. {totalds.Substring(0, totalds.Length - 2)} (TAX: Rs. {totaltax.Substring(0, totaltax.Length - 2)})", titleFont);
            title.Alignment = 0;
            title.Font = FontFactory.GetFont("Courier", 16);
            pdfReport.Add(title);
            //title = new Paragraph($"TOTAL TAX: Rs. {taxamt}.", titleFont);
            //title.Alignment = 0;
            //title.Font = FontFactory.GetFont("Courier", 16);
            //pdfReport.Add(title);



            pdfReport.Close();

            System.Diagnostics.Process.Start($"C:\\Users\\DELL\\Desktop\\FINANCE SOFTWARE\\REPORTS\\PURCHASE REPORT\\PURCHASE{comboBox1.Text}_{fromY.Text}-{fromM.Text}-{fromD.Text} to {toY.Text}-{toM.Text}-{toD.Text}.pdf");

            //invoicelist.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //DataTable dt2 = new DataTable();
            string queryString = $"SELECT [date] ,[expensedetail] ,[amount] FROM [BRIDGEFINANCE].[dbo].[expenses]WHERE acc = '{comboBox1.Text}' AND (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";
            //string queryreceipt = $"select * from receipt WHERE (date_paid BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";
            var table = new DataTable();

            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
            {

                SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                adapt.Fill(dt);

                invoicelist.DataSource = dt;

                //double sumINVOICE = 0;
                //for (int i = 0; i < invoicelist.Rows.Count; ++i)
                //{
                //    sumINVOICE += Convert.ToDouble(invoicelist.Rows[i].Cells[3].Value);
                //}


            }   //try
                //{
            var pdfReport = new Document(PageSize.A4, 20f, 20f, 50f, 50f);
            Random rnd = new Random();
            int saveno = rnd.Next(1, 51);
            string path = $"C:\\Users\\DELL\\Desktop\\FINANCE SOFTWARE\\REPORTS\\OTHER REPORTS\\EXPENSE{comboBox1.Text}_{fromY.Text}-{fromM.Text}-{fromD.Text} to {toY.Text}-{toM.Text}-{toD.Text}.pdf";

            PdfWriter.GetInstance(pdfReport, new FileStream(path, FileMode.OpenOrCreate));
            pdfReport.Open();

            var imagepth = @"C:\Users\DELL\Desktop\FINANCE SOFTWARE\RESOURCE\REPORT.jpg";
            using (FileStream fs = new FileStream(imagepth, FileMode.Open))
            {
                var jpg = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                jpg.ScaleToFit(pdfReport.PageSize);
                jpg.SetAbsolutePosition(0, 0);
                jpg.Alignment = iTextSharp.text.Image.UNDERLYING;
                pdfReport.Add(jpg);
            }

            var spacer = new Paragraph("")
            {
                SpacingBefore = 10f,
                SpacingAfter = 10f,
            };
            var spacer3 = new Paragraph("")
            {
                SpacingBefore = 1f,
                SpacingAfter = 1f,
            };
            pdfReport.Add(spacer);
            pdfReport.Add(spacer);
            pdfReport.Add(spacer);
            pdfReport.Add(spacer);


            Font titleFont = FontFactory.GetFont("Courier");
            DateTime today = DateTime.Today;
            pdfReport.Add(spacer3); pdfReport.Add(spacer3);
            Paragraph title = new Paragraph($"Date Generated: {today.ToString("dd/MM/yyyy")}", titleFont);
            title.Alignment = 2;
            title.Font = FontFactory.GetFont("Helvetica Bold", 19);
            pdfReport.Add(title);



            title = new Paragraph($"Selected Period of Time: {fromD.Text}/{fromM.Text}/{fromY.Text} TO {toD.Text}/{toM.Text}/{toY.Text}", titleFont);
            title.Alignment = 0;
            title.Font = FontFactory.GetFont("Helvetica Bold", 19);
            pdfReport.Add(title);

            pdfReport.Add(spacer);

            title = new Paragraph($"{comboBox1.Text} EXPENSES REPORT FOR THE SELECTED PERIOD OF TIME", titleFont);
            title.Alignment = 1;
            title.Font = FontFactory.GetFont("Courier", 16);

            pdfReport.Add(title);

            pdfReport.Add(spacer);
            //invoiceNo, date, clientName, totalCourse, coursePer, balRemaining
            invoicelist.Columns[0].HeaderText = "Date";
            invoicelist.Columns[1].HeaderText = "Details";
            invoicelist.Columns[2].HeaderText = "Amount";
            
            


            PdfPTable producttable = new PdfPTable(3);
            producttable.DefaultCell.Padding = 3;
            producttable.WidthPercentage = 100;
            producttable.HorizontalAlignment = Element.ALIGN_LEFT;
            producttable.DefaultCell.BorderWidth = 1;
            BaseColor couleur = new BaseColor(255, 255, 255);
            Font titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);
            foreach (DataGridViewColumn column in invoicelist.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, titleFont3));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                producttable.AddCell(cell);
            }

            float[] widths = new float[] { 1f, 1.5f, 0.8f };
            producttable.SetWidths(widths);

            foreach (DataGridViewRow row in invoicelist.Rows)
            {
                int counta = 1;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string text = cell.Value.ToString();
                    double d;
                    if (cell.Value == null)
                    {
                        text = "";
                    }
                    else
                    {
                        text = cell.Value.ToString();
                    }
                    if (counta == 1)
                    {
                        text = text.Substring(0, 10);
                    }
                    if (counta == 3)
                    {
                        if (double.TryParse(text, out d))
                        {
                            d = double.Parse(text);
                            text = String.Format("{0:f2}", d);
                        }
                    }

                    counta = counta + 1;
                    producttable.AddCell(new PdfPCell(new Phrase(text, FontFactory.GetFont("Courier", 10))));
                }
            }

            pdfReport.Add(producttable);

            double total;
            string totalds = "00", totaltax = "00";

            if (invoicelist.RowCount != 0)
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
                {

                    totalds = connection.ExecuteScalar($"SELECT SUM(amount) FROM [BRIDGEFINANCE].[dbo].[expenses] WHERE acc = '{comboBox1.Text}' AND (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')").ToString();

                }
            }

                
            pdfReport.Add(spacer3);


            title = new Paragraph($"TOTAL EXPENSES FOR SET PERIOD OF TIME: Rs. {totalds.Substring(0, totalds.Length - 2)}", titleFont);
            title.Alignment = 0;
            title.Font = FontFactory.GetFont("Courier", 16);
            pdfReport.Add(title);
            //title = new Paragraph($"TOTAL TAX: Rs. {taxamt}.", titleFont);
            //title.Alignment = 0;
            //title.Font = FontFactory.GetFont("Courier", 16);
            //pdfReport.Add(title);



            pdfReport.Close();

            System.Diagnostics.Process.Start($"C:\\Users\\DELL\\Desktop\\FINANCE SOFTWARE\\REPORTS\\OTHER REPORTS\\EXPENSE{comboBox1.Text}_{fromY.Text}-{fromM.Text}-{fromD.Text} to {toY.Text}-{toM.Text}-{toD.Text}.pdf");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pdfReport = new Document(PageSize.A4, 20f, 20f, 50f, 50f);
            Random rnd = new Random();
            int saveno = rnd.Next(1, 51);
            string path = $"C:\\Users\\DELL\\Desktop\\FINANCE SOFTWARE\\REPORTS\\OTHER REPORTS\\VAT{comboBox1.Text}_{fromY.Text}-{fromM.Text}-{fromD.Text} to {toY.Text}-{toM.Text}-{toD.Text}.pdf";

            PdfWriter.GetInstance(pdfReport, new FileStream(path, FileMode.OpenOrCreate));
            pdfReport.Open();

            var imagepth = @"C:\Users\DELL\Desktop\FINANCE SOFTWARE\RESOURCE\REPORT.jpg";
            using (FileStream fs = new FileStream(imagepth, FileMode.Open))
            {
                var jpg = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                jpg.ScaleToFit(pdfReport.PageSize);
                jpg.SetAbsolutePosition(0, 0);
                jpg.Alignment = iTextSharp.text.Image.UNDERLYING;
                pdfReport.Add(jpg);
            }

            var spacer = new Paragraph("")
            {
                SpacingBefore = 10f,
                SpacingAfter = 10f,
            };
            var spacer3 = new Paragraph("")
            {
                SpacingBefore = 1f,
                SpacingAfter = 1f,
            };
            pdfReport.Add(spacer);
            pdfReport.Add(spacer);
            pdfReport.Add(spacer);
            pdfReport.Add(spacer);


            Font titleFont = FontFactory.GetFont("Courier");
            DateTime today = DateTime.Today;
            pdfReport.Add(spacer3); pdfReport.Add(spacer3);
            Paragraph title = new Paragraph($"Date Generated: {today.ToString("dd/MM/yyyy")}", titleFont);
            title.Alignment = 2;
            title.Font = FontFactory.GetFont("Helvetica Bold", 19);
            pdfReport.Add(title);



            title = new Paragraph($"Selected Period of Time: {fromD.Text}/{fromM.Text}/{fromY.Text} TO {toD.Text}/{toM.Text}/{toY.Text}", titleFont);
            title.Alignment = 0;
            title.Font = FontFactory.GetFont("Helvetica Bold", 19);
            pdfReport.Add(title);

            pdfReport.Add(spacer);

            title = new Paragraph($"{comboBox1.Text} VAT REPORT FOR THE SELECTED PERIOD OF TIME", titleFont);
            title.Alignment = 1;
            title.Font = FontFactory.GetFont("Courier", 16);

            pdfReport.Add(title);

            pdfReport.Add(spacer);

            double total;
            string totalds = "00", totalP = "00", totaltax = "00";

            
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
            {
                if ((connection.ExecuteScalar($"SELECT SUM(total) FROM [BRIDGEFINANCE].[dbo].[dailysales] WHERE acc = '{comboBox1.Text}' AND (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')")!=null) && (connection.ExecuteScalar($"SELECT SUM(invoiceamt) FROM [BRIDGEFINANCE].[dbo].[purchase] WHERE branch = '{comboBox1.Text}' AND (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')")!= null))
                {
                    totalds = connection.ExecuteScalar($"SELECT SUM(total) FROM [BRIDGEFINANCE].[dbo].[dailysales] WHERE acc = '{comboBox1.Text}' AND (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')").ToString();
                    totalP = connection.ExecuteScalar($"SELECT SUM(invoiceamt) FROM [BRIDGEFINANCE].[dbo].[purchase] WHERE branch = '{comboBox1.Text}' AND (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')").ToString();
                    totaltax = connection.ExecuteScalar($"SELECT SUM(tax) FROM [BRIDGEFINANCE].[dbo].[purchase] WHERE branch = '{comboBox1.Text}' AND (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')").ToString();
                }

                    
            }
            


            pdfReport.Add(spacer3);


            title = new Paragraph($"TOTAL SALES FOR SET PERIOD OF TIME: Rs. {totalds.Substring(0, totalds.Length - 2)} VAT: Rs. {((double.Parse(totalds)/1.15)*0.15).ToString("0.##")}", titleFont);
            title.Alignment = 0;
            title.Font = FontFactory.GetFont("Courier", 16);
            pdfReport.Add(title);

            title = new Paragraph($"TOTAL PURCHASE FOR SET PERIOD OF TIME: Rs. {totalP.Substring(0, totalP.Length - 2)} VAT: Rs. {totaltax}", titleFont);
            title.Alignment = 0;
            title.Font = FontFactory.GetFont("Courier", 16);
            pdfReport.Add(title);

            title = new Paragraph($"NET VAT FOR SET PERIOD OF TIME: Rs. {(((double.Parse(totalds) / 1.15) * 0.15) - double.Parse(totaltax)).ToString("0.##")}", titleFont);
            title.Alignment = 0;
            title.Font = FontFactory.GetFont("Courier", 16);
            pdfReport.Add(title);
            //title = new Paragraph($"TOTAL TAX: Rs. {taxamt}.", titleFont);
            //title.Alignment = 0;
            //title.Font = FontFactory.GetFont("Courier", 16);
            //pdfReport.Add(title);



            pdfReport.Close();

            System.Diagnostics.Process.Start($"C:\\Users\\DELL\\Desktop\\FINANCE SOFTWARE\\REPORTS\\OTHER REPORTS\\VAT{comboBox1.Text}_{fromY.Text}-{fromM.Text}-{fromD.Text} to {toY.Text}-{toM.Text}-{toD.Text}.pdf");

        }
    }
}
