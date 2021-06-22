using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using System.IO;

namespace NationalFootballChampionshipManagement
{
    class ExportDatagridViewToPDF
    {
        DataGridView dataGridView;
        public ExportDatagridViewToPDF(DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
        }
        public void Export(string filename)
        {
            //Add Header
            BaseFont bff = BaseFont.CreateFont(Environment.GetEnvironmentVariable("windir") + @"\\font\times.ttf", BaseFont.IDENTITY_H, true);
            Font NormalFont = new iTextSharp.text.Font(bff, 15, Font.NORMAL);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            string strHeader = "danh sách cầu thủ";
            prgHeading.Add(new Chunk(strHeader.ToUpper(), NormalFont));


            // Add Table
            PdfPTable pdfPTable = new PdfPTable(dataGridView.Columns.Count);
            pdfPTable.DefaultCell.Padding = 3;
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfPTable.DefaultCell.BorderWidth = 1;


            iTextSharp.text.Font text = new iTextSharp.text.Font(bff, 10, Font.NORMAL);
            //Add header
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfPTable.AddCell(cell);
            }

            //Add datarow
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfPTable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }
            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";

            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(prgHeading);
                    pdfdoc.Add(pdfPTable);
                    pdfdoc.Close();
                    stream.Close();
                }
                System.Diagnostics.Process.Start(savefiledialoge.FileName);
            }
        }
    }
}
