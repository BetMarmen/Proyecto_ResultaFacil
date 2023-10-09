using iTextSharp.text;
using iTextSharp.text.pdf;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xceed.Document.NET;
using Xceed.Words.NET;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace ResultaFacil
{
    public class Formato
    {
        public static void ExportToDocX(DataGridView dataGridView)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Word files (*.docx)|*.docx";
                saveFileDialog.Title = "Save a Word File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (DocX document = DocX.Create(saveFileDialog.FileName))
                    {
                        // Crear una tabla
                        Table table = document.AddTable(dataGridView.Rows.Count + 1, dataGridView.Columns.Count);

                        // Agregar encabezados
                        for (int columnIndex = 0; columnIndex < dataGridView.Columns.Count; columnIndex++)
                        {
                            table.Rows[0].Cells[columnIndex].Paragraphs[0].Append(dataGridView.Columns[columnIndex].HeaderText).Bold();
                        }

                        // Agregar datos
                        for (int rowIndex = 0; rowIndex < dataGridView.Rows.Count; rowIndex++)
                        {
                            for (int columnIndex = 0; columnIndex < dataGridView.Columns.Count; columnIndex++)
                            {
                                table.Rows[rowIndex + 1].Cells[columnIndex].Paragraphs[0].Append(dataGridView.Rows[rowIndex].Cells[columnIndex].Value?.ToString());
                            }
                        }

                        document.InsertTable(table);
                        document.Save();

                        MessageBox.Show("Datos exportados a archivo Word correctamente.");
                    }
                }
            }
        }
        public static void ExportToText(DataGridView dataGridView)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                saveFileDialog.Title = "Save a Text File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        // Escribir encabezados
                        for (int columnIndex = 0; columnIndex < dataGridView.Columns.Count; columnIndex++)
                        {
                            writer.Write(dataGridView.Columns[columnIndex].HeaderText);
                            if (columnIndex < dataGridView.Columns.Count - 1)
                            {
                                writer.Write("\t");
                            }
                        }
                        writer.WriteLine();

                        // Escribir datos
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            for (int columnIndex = 0; columnIndex < dataGridView.Columns.Count; columnIndex++)
                            {
                                writer.Write(row.Cells[columnIndex].Value);
                                if (columnIndex < dataGridView.Columns.Count - 1)
                                {
                                    writer.Write("\t");
                                }
                            }
                            writer.WriteLine();
                        }

                        MessageBox.Show("Datos exportados a archivo de texto correctamente.");
                    }
                }
            }
        }
        public static void ExportToPDF(DataGridView dataGridView)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save a PDF File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        PdfWriter writer = PdfWriter.GetInstance(document, fs);
                        document.Open();

                        PdfPTable pdfTable = new PdfPTable(dataGridView.Columns.Count);
                        pdfTable.DefaultCell.Padding = 3;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                        // Agregar encabezados
                        foreach (DataGridViewColumn column in dataGridView.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            pdfTable.AddCell(cell);
                        }

                        // Agregar datos
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.Value!=null)
                                    pdfTable.AddCell(cell.Value.ToString());
                            }
                        }

                        document.Add(pdfTable);
                        document.Close();
                        writer.Close();

                        MessageBox.Show("Datos exportados a PDF correctamente.");
                    }
                }
            }
        }

        public static void ExportToExcel(DataGridView dataGridView)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Save an Excel File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo excelFile = new FileInfo(saveFileDialog.FileName);

                    using (ExcelPackage excelPackage = new ExcelPackage(excelFile))
                    {
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                        // Agregar encabezados
                        for (int columnIndex = 0; columnIndex < dataGridView.Columns.Count; columnIndex++)
                        {
                            worksheet.Cells[1, columnIndex + 1].Value = dataGridView.Columns[columnIndex].HeaderText;
                        }

                        // Agregar datos
                        for (int rowIndex = 0; rowIndex < dataGridView.Rows.Count; rowIndex++)
                        {
                            for (int columnIndex = 0; columnIndex < dataGridView.Columns.Count; columnIndex++)
                            {
                                worksheet.Cells[rowIndex + 2, columnIndex + 1].Value = dataGridView.Rows[rowIndex].Cells[columnIndex].Value;
                            }
                        }

                        excelPackage.Save();
                        MessageBox.Show("Datos exportados a Excel correctamente.");
                    }

                }
            }
        }
    }
}

