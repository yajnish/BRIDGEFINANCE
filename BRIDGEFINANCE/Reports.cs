﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
using System.Reflection;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace BRIDGEFINANCE
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string queryString = $"SELECT * FROM statement WHERE acc = '{comboBox1.Text}' ORDER BY Date ASC";
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRIDGEDB")))
            {
                SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                adapt.Fill(dt);

                invoicelist.DataSource = dt;
                double balance = 0;
                var pdfReport = new Document(PageSize.A4, 20f, 20f, 50f, 50f);
                Random rnd = new Random();
                int saveno = rnd.Next(1, 51);
                string path = $"C:\\Users\\DELL\\Desktop\\FINANCE SOFTWARE\\REPORTS\\STATEMENT OF ACCOUNT\\Statement{fromY.Text}{fromM.Text}{fromD.Text}_{saveno}.pdf";

                PdfWriter.GetInstance(pdfReport, new System.IO.FileStream(path, FileMode.OpenOrCreate));
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

                var spacer2 = new Paragraph("")
                {
                    SpacingBefore = 5f,
                    SpacingAfter = 5f,
                };
                pdfReport.Add(spacer);
                pdfReport.Add(spacer);
                pdfReport.Add(spacer);
                pdfReport.Add(spacer);
                pdfReport.Add(spacer);


                Font titleFont = FontFactory.GetFont("Helvetica Bold");

                Paragraph title = new Paragraph($"STATEMENT OF ACCOUNT FOR {comboBox1.Text} AS OF {DateTime.Now}", titleFont);
                title.Alignment = 1;
                title.Font = FontFactory.GetFont("Helvetica Bold", 19);
                pdfReport.Add(title);

                PdfPTable producttable = new PdfPTable(5);
                producttable.DefaultCell.Padding = 3;
                producttable.WidthPercentage = 100;
                producttable.HorizontalAlignment = Element.ALIGN_LEFT;
                producttable.DefaultCell.BorderWidth = 1;
                BaseColor couleur = new BaseColor(255, 255, 255);
                Font titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);

                PdfPCell cell = new PdfPCell(new Phrase("Date", titleFont3));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                producttable.AddCell(cell);

                cell = new PdfPCell(new Phrase("Reference", titleFont3));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                producttable.AddCell(cell);

                cell = new PdfPCell(new Phrase("Deposit", titleFont3));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                producttable.AddCell(cell);

                cell = new PdfPCell(new Phrase("Withdrawal", titleFont3));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                producttable.AddCell(cell);


                cell = new PdfPCell(new Phrase("Balance (MUR)", titleFont3));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                producttable.AddCell(cell);

                float[] widths = new float[] { 0.80f, 1.5f, 0.80f, 0.80f, 0.80f };
                producttable.SetWidths(widths);
                string text = ""; ;
                int counta = 1;
                double openbal = 0;

                foreach (DataGridViewRow row in invoicelist.Rows)
                {
                    int countrow = 1;
                    foreach (DataGridViewCell cell1 in row.Cells)
                    {
                        if (cell1.Value == null)
                        {
                            text = "";
                        }
                        else
                        {
                            text = cell1.Value.ToString();
                        }

                        if ((countrow == 1) && (counta == 2))
                        {

                            DateTime datecheck = Convert.ToDateTime(text);

                            producttable.AddCell(new PdfPCell(new Phrase("", FontFactory.GetFont("Courier", 10))));
                            producttable.AddCell(new PdfPCell(new Phrase("Opening Balance", FontFactory.GetFont("Courier", 10))));
                            producttable.AddCell(new PdfPCell(new Phrase("", FontFactory.GetFont("Courier", 10))));
                            producttable.AddCell(new PdfPCell(new Phrase("", FontFactory.GetFont("Courier", 10))));
                            producttable.AddCell(new PdfPCell(new Phrase("0", FontFactory.GetFont("Courier", 10))));
                            
                            

                            
                        }
                        countrow = countrow + 1;
                        
                    }
                    counta = counta + 1;
                }

                string typeTxt = "";
                bool dr = false;
                bool cr = false;
                int rowcount = 0;
                foreach (DataGridViewRow row in invoicelist.Rows)
                {
                    counta = 1;
                    foreach (DataGridViewCell cell1 in row.Cells)
                    {
                        if ((counta == 1) && (rowcount != 0))
                        {
                            if (cell1.Value == null)
                            {
                                text = "";
                                goto Here;
                            }
                            else
                            {
                                text = cell1.Value.ToString();
                            }

                            
                            producttable.AddCell(new PdfPCell(new Phrase($"{text.Substring(0, 10)}", FontFactory.GetFont("Courier", 10))));
                            
                            
                        }
                        else if ((counta == 3) && (rowcount != 0))
                        {
                            if (cell1.Value == null)
                            {
                                text = "";
                            }
                            else
                            {
                                text = cell1.Value.ToString();
                            }
                            if (text == "DEPOSIT")
                            {
                                dr = true;
                                cr = false;
                                typeTxt = "Deposit";
                            }
                            if (text == "WITHDRAW")
                            {
                                dr = false;
                                cr = true;
                                typeTxt = "Withdrawal";
                            }
                            if (text == "CHEQUE WITHDRAW")
                            {
                                dr = false;
                                cr = true;
                                typeTxt = "Cheque Claim";
                            }
                            if (text.Substring(0, 7) == "Payment")
                            {
                                dr = false;
                                cr = true;
                                typeTxt = text;
                            }
                        }
                        else if (((counta == 4)) && (rowcount != 0))
                        {
                            if (cell1.Value == null)
                            {
                                text = "";
                            }
                            else
                            {
                                text = cell1.Value.ToString();
                            }
                            

                        }
                        else if ((counta == 5) && (rowcount != 0))
                        {
                            if (cell1.Value == null)
                            {
                                text = text + " ";
                            }
                            else
                            {
                                text = text + " " + cell1.Value.ToString();
                            }
                            producttable.AddCell(new PdfPCell(new Phrase($"{typeTxt} {text}", FontFactory.GetFont("Courier", 10))));
                        }
                        else if ((counta == 6) && (rowcount != 0))
                        {
                            if (cell1.Value == null)
                            {
                                text = "0";
                            }
                            else
                            {
                                text = cell1.Value.ToString();
                            }

                            double bal = Convert.ToDouble(text);
                            balance = balance + bal;


                            if (dr == true)
                            {
                                double value = Math.Abs(double.Parse(text));
                                producttable.AddCell(new PdfPCell(new Phrase($"{value}", FontFactory.GetFont("Courier", 10))));
                                producttable.AddCell(new PdfPCell(new Phrase($"", FontFactory.GetFont("Courier", 10))));
                                producttable.AddCell(new PdfPCell(new Phrase($"{balance}", FontFactory.GetFont("Courier", 10))));
                            }
                            else if (cr == true)
                            {
                                double value = Math.Abs(double.Parse(text));
                                producttable.AddCell(new PdfPCell(new Phrase($"", FontFactory.GetFont("Courier", 10))));
                                producttable.AddCell(new PdfPCell(new Phrase($"{value}", FontFactory.GetFont("Courier", 10))));
                                producttable.AddCell(new PdfPCell(new Phrase($"{balance}", FontFactory.GetFont("Courier", 10))));
                            }
                        }

                        counta = counta + 1;


                    }
                Here:
                    counta = 1;
                    rowcount = rowcount + 1;
                }
                pdfReport.Add(spacer);
                pdfReport.Add(producttable);


                pdfReport.Close();

                System.Diagnostics.Process.Start($"C:\\Users\\DELL\\Desktop\\FINANCE SOFTWARE\\REPORTS\\STATEMENT OF ACCOUNT\\Statement{fromY.Text}{fromM.Text}{fromD.Text}_{saveno}.pdf");
            }
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            fromD.Text = $"{DateTime.Now.ToString("dd")}";
            fromM.Text = $"{DateTime.Now.ToString("MM")}";
            fromY.Text = $"{DateTime.Now.ToString("yyyy")}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dailysaleslisting ddaily = new dailysaleslisting();
            ddaily.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            miscRep misc = new miscRep();
            misc.Show();
        }
    }
}
