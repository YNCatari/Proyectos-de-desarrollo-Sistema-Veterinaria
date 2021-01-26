using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVeterinaria.Entidades;
using SistemaVeterinaria.Negocios;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;
namespace SistemaVeterinaria.Principal
{
    public partial class FrmReportMantenimiento : MaterialSkin.Controls.MaterialForm
    {
        public FrmReportMantenimiento()
        {
            InitializeComponent();
        }

        private void FrmReportMantenimiento_Load(object sender, EventArgs e)
        {
            ClsEHistorial objE = new ClsEHistorial();
            ClsNHistorial objN = new ClsNHistorial();
            objE.Dni = FrmHistorial.ayudni;
            objE.Nombres = FrmHistorial.ayunombre;
            dgvMantenimiento.DataSource = objN.MtdBuscarMantenimiento(objE);
            dgvMantenimiento.AutoResizeColumns();
        }

        private void btnVacunas_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (dgvMantenimiento.RowCount == 0)
            {
                MessageBox.Show("No Hay Datos Para Realizar Un Reporte");
            }
            else
            {    //ESCOJE A RUTA DONDE GUARDAREMOS EL PDF 
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    var img = iTextSharp.text.Image.GetInstance("logo.png");
                    string filename = save.FileName;
                    Document doc = new Document(PageSize.A3, 9, 9, 9, 9);
                    Chunk encab0 = new Chunk("                                  VETERINARIA PETS PLANET", FontFactory.GetFont("Arial Black", 25)); ;
                    Chunk encab1 = new Chunk("DIRECCION : Calle zela #256              TELEFONO :952698564-052659863                     ", FontFactory.GetFont("COURIER", 18)); ;
                    Chunk encab2 = new Chunk("CLIENTE : " + FrmHistorial.Rnombres, FontFactory.GetFont("COURIER", 18));
                    Chunk encab3 = new Chunk("TIPO DE INFORMACION : Mantenimiento de Mascota", FontFactory.GetFont("COURIER", 18));
                    Chunk encab4 = new Chunk("DATOS DE MASCOTA :", FontFactory.GetFont("COURIER", 22));
                    Chunk encab5 = new Chunk("NOMBRE :" + FrmHistorial.ayunombre + "         " + "ESPECIE :" + FrmHistorial.ayuespecie, FontFactory.GetFont("COURIER", 18));
                    Chunk encab6 = new Chunk("RAZA :" + FrmHistorial.ayuraza + "         " + "PESO(Kg) :" + FrmHistorial.ayupeso, FontFactory.GetFont("COURIER", 18));
                    Chunk encab7 = new Chunk("SEXO :" + FrmHistorial.ayusexo + "         " + "Fecha de Nacimiento :" + FrmHistorial.ayunaci, FontFactory.GetFont("COURIER", 18));
                    Chunk espacio = new Chunk("                                                                                           ", FontFactory.GetFont("COURIER", 18));
                    try
                    {
                        FileStream file = new FileStream(filename, FileMode.OpenOrCreate);
                        PdfWriter writer = PdfWriter.GetInstance(doc, file);
                        writer.ViewerPreferences = PdfWriter.PageModeUseThumbs;
                        writer.ViewerPreferences = PdfWriter.PageLayoutOneColumn;
                        doc.Open();
                        img.ScaleToFit(200f, 100F);
                        img.SetAbsolutePosition(730, 0);
                        doc.Add(img);
                        doc.Add(new Paragraph(encab0));
                        doc.Add(new Paragraph(espacio));
                        doc.Add(new Paragraph(encab1));
                        doc.Add(new Paragraph(encab2));
                        doc.Add(new Paragraph(encab3));
                        doc.Add(new Paragraph(encab4));
                        doc.Add(new Paragraph(encab5));
                        doc.Add(new Paragraph(encab6));
                        doc.Add(new Paragraph(encab7));
                        doc.Add(new Paragraph(espacio));
                        doc.Add(new Paragraph(espacio));
                        GenerarDocumentos(doc);

                        Process.Start(filename);
                        doc.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public void GenerarDocumentos(Document document)
        {
            PdfPTable datatable = new PdfPTable(dgvMantenimiento.ColumnCount);

            datatable.DefaultCell.Padding = 1;
            float[] headerwidths = GetTamañoColumnas(dgvMantenimiento);

            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 1;

            datatable.DefaultCell.BackgroundColor = iTextSharp.text.BaseColor.WHITE;

            datatable.DefaultCell.BorderColor = iTextSharp.text.BaseColor.BLACK;

            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA);

            Phrase objP = new Phrase("A", fuente);

            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            for (int i = 0; i < dgvMantenimiento.ColumnCount; i++)
            {

                objP = new Phrase(dgvMantenimiento.Columns[i].HeaderText, fuente);
                datatable.HorizontalAlignment = Element.ALIGN_CENTER;

                datatable.AddCell(objP);

            }
            datatable.HeaderRows = 2;

            datatable.DefaultCell.BorderWidth = 1;
            for (int i = 0; i < dgvMantenimiento.RowCount; i++)
            {
                for (int j = 0; j < dgvMantenimiento.ColumnCount; j++)
                {
                    objP = new Phrase(dgvMantenimiento[j, i].Value.ToString(), fuente);
                    datatable.AddCell(objP);
                }
                datatable.CompleteRow();
            }
            document.Add(datatable);
        }

        public float[] GetTamañoColumnas(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }
    }
}
