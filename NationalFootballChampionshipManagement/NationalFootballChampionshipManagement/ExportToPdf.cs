using NationalFootballChampionshipManagement.DAO.NationalFootballChampionshipManagement.DAO;
using NationalFootballChampionshipManagement.DAO;
using NationalFootballChampionshipManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace NationalFootballChampionshipManagement
{
    class ExportDatagridViewToPDF
    {
        DataGridView dataGridView;
        public ExportDatagridViewToPDF(DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
        }
        public void Export(string filename, string header)
        {
            //Add Header
            BaseFont bff = BaseFont.CreateFont(Environment.GetEnvironmentVariable("windir") + @"\\fonts\times.ttf", BaseFont.IDENTITY_H, true);
            Font NormalFont = new iTextSharp.text.Font(bff, 15, Font.NORMAL);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            string strHeader = header;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), NormalFont));


            // Add Table
            PdfPTable pdfPTable = new PdfPTable(dataGridView.Columns.Count);
            pdfPTable.SpacingBefore = 10f;
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

        public void ExportRanking(string header, string filename, float[] width, List<TeamScoreDetails> lt)
        {
            //Add Header
            BaseFont bff = BaseFont.CreateFont(Environment.GetEnvironmentVariable("windir") + @"\\fonts\times.ttf", BaseFont.IDENTITY_H, true);
            Font NormalFont = new iTextSharp.text.Font(bff, 20, Font.NORMAL);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            string strHeader = header;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), NormalFont));


            // Add Table
            PdfPTable pdfPTable = new PdfPTable(dataGridView.Columns.Count);
            pdfPTable.SpacingBefore = 10f;
            pdfPTable.DefaultCell.Padding = 3;
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfPTable.DefaultCell.BorderWidth = 1;
            pdfPTable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfPTable.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfPTable.SetWidths(width);


            iTextSharp.text.Font text = new iTextSharp.text.Font(bff, 10, Font.NORMAL);
            //Add header
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfPTable.AddCell(cell);
            }

            //Add datarow
            int rCnt = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                int cCnt = row.Cells.Count;
                for (int i = 0; i < cCnt; i++)
                {
                    //align
                    if (i != 2)
                    {
                        pdfPTable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfPTable.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    }
                    else
                    {
                        pdfPTable.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
                        pdfPTable.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    }
                    //add content
                    if (i != 1 && i != cCnt - 1)
                    {
                        pdfPTable.AddCell(new Phrase(row.Cells[i].Value.ToString(), text));
                    }
                    if (i == 1)
                    {
                        byte[] imageByte = ImageProcessing.Instance.convertImgToByte(lt[rCnt].LogoTeam);
                        iTextSharp.text.Image myImage = iTextSharp.text.Image.GetInstance(imageByte);
                        myImage.ScaleAbsolute(20, 20);
                        pdfPTable.AddCell(new Phrase(new Chunk(myImage, 0f, 0f, false)));
                    }
                    if (i == cCnt - 1)
                    {
                        byte[] imageByte = ImageProcessing.Instance.convertImgToByte((System.Drawing.Image)(row.Cells[cCnt-1].Value));
                        iTextSharp.text.Image myImage = iTextSharp.text.Image.GetInstance(imageByte);
                        pdfPTable.AddCell(myImage);
                    }
                }
                rCnt++;
            }


            //save file;
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
