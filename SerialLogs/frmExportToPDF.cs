using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace SerialLogs
{
    public partial class frmExportToPDF : Form
    {
        public frmExportToPDF()
        {
            InitializeComponent();
        }

        private void frmExportToPDF_Load(object sender, EventArgs e)
        {
            btnExportPDF.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedSearch.Text))
            {
                MessageBox.Show("Sorry you didn't enter a valid value to search for", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btnExportPDF.Enabled = true;
                serial_LogTableAdapter.SerialSearch(appData.Serial_Log, maskedSearch.Text);

                if (serialLogBindingSource.Count == 0)
                {
                    MessageBox.Show("Sorry serial logs matching date " + maskedSearch.Text + " Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    maskedSearch.Focus();
                    btnExportPDF.Enabled = false;
                }
                
            }
        }


        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(pdfDataGridView.ColumnCount);

            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 90;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in pdfDataGridView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in pdfDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }

            //Exporting to PDF
            try
            {
                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

                saveFileDialog.Filter = "PDF Text Format (*.pdf) | *.pdf|AllFiles (*.*) | *.*";
                saveFileDialog.ShowDialog();
                saveFileDialog.InitialDirectory = saveFileDialog.FileName;
                
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    //Document pdfDoc = new Document(PageSize.A4.Rotate());
                    Document pdfDoc = new Document(PageSize.A4.Rotate(), 5f, 5f, 5f, 5f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Serial log file saved", "Saved PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException)
            {

                throw;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
