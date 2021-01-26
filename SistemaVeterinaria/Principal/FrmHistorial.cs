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
    public partial class FrmHistorial : MaterialSkin.Controls.MaterialForm
    {
        public FrmHistorial()
        {
            InitializeComponent();
        }

        public FrmReportVacunas FrmReportVacunas
        {
            get => default(FrmReportVacunas);
            set
            {
            }
        }

        public FrmReportMantenimiento FrmReportMantenimiento
        {
            get => default(FrmReportMantenimiento);
            set
            {
            }
        }

        public FrmReportTratamientos FrmReportTratamientos
        {
            get => default(FrmReportTratamientos);
            set
            {
            }
        }

        public static string ayudni, ayunombre,ayuespecie,ayuraza,ayupeso,ayusexo,ayunaci;
        public static string Rnombres;
        private void FrmHistorial_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Equals("")) MessageBox.Show("El campo Dni Cliente esta vacio");
            else
            {
                ClsEHistorial objE = new ClsEHistorial();
                ClsNHistorial ojbjN = new ClsNHistorial();
                ClsEClientes objEC = new ClsEClientes();
                ClsNClientes ojbjNC = new ClsNClientes();
                objE.Dni = txtDni.Text;
                objEC.Dni = txtDni.Text;
                DataTable dtEmp = new DataTable();
                dtEmp = ojbjNC.MtdBuscarMySql(objEC);
                dgvMascotas.DataSource = ojbjN.MtdBuscarMascota(objE);
                if (dtEmp.Rows.Count > 0)
                {
                    DataRow Fila = dtEmp.Rows[0];
                    txtNombres.Text = Fila["apellido"].ToString() + "," + Fila["nombre"].ToString();
                    Rnombres = Fila["apellido"].ToString() + "," + Fila["nombre"].ToString();
                    txtDireccion.Text = Fila["direccion"].ToString();
                    txtTelefono.Text = Fila["telefono"].ToString();
                }
            }
        }

        private void btnVacunas_Click(object sender, EventArgs e)
        {
            if (dgvMascotas.RowCount == 0)  MessageBox.Show("No Hay Datos En la tabla ,busque un cliente o agregue una mascota ");
            else
            {
                if(ayunombre==null) MessageBox.Show("Seleccione una Mascota ");
                else
                {
                    FrmReportVacunas frm = new FrmReportVacunas();
                    frm.Show();
                }
                
            }

        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))//Si es número
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)//si es tecla borrar
            {
                e.Handled = false;
            }
            else //Si es otra tecla cancelamos
            {
                e.Handled = true;
            }
        }

        private void btnMantenimientos_Click(object sender, EventArgs e)
        {
            if (dgvMascotas.RowCount == 0) MessageBox.Show("No Hay Datos En la tabla ,busque un cliente o agregue una mascota ");
            else
            {
                if (ayunombre == null) MessageBox.Show("Seleccione una Mascota ");
                else
                {
                    FrmReportMantenimiento frm = new FrmReportMantenimiento();
                    frm.Show();
                }
            }
        }

        private void btnTratamientos_Click(object sender, EventArgs e)
        {
            if (dgvMascotas.RowCount == 0) MessageBox.Show("No Hay Datos En la tabla ,busque un cliente o agregue una mascota ");
            else
            {
                if (ayunombre == null) MessageBox.Show("Seleccione una Mascota ");
                else
                {
                    FrmReportTratamientos frm = new FrmReportTratamientos();
                    frm.Show();
                }
            }
        }
        //public static iTextSharp.text.Image img = Image.GetInstance("asd.jpg");
        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (dgvMascotas.RowCount == 0)
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
                    Chunk encab2 = new Chunk("CLIENTE : " + txtNombres.Text , FontFactory.GetFont("COURIER", 18));
                    Chunk encab3 = new Chunk("TIPO DE INFORMACION : Mascotas del Propietario", FontFactory.GetFont("COURIER", 18));
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
            PdfPTable datatable = new PdfPTable(dgvMascotas.ColumnCount);

            datatable.DefaultCell.Padding = 1;
            float[] headerwidths = GetTamañoColumnas(dgvMascotas);

            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 1;

            datatable.DefaultCell.BackgroundColor = iTextSharp.text.BaseColor.WHITE;

            datatable.DefaultCell.BorderColor = iTextSharp.text.BaseColor.BLACK;

            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA);

            Phrase objP = new Phrase("A", fuente);

            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            for (int i = 0; i < dgvMascotas.ColumnCount; i++)
            {

                objP = new Phrase(dgvMascotas.Columns[i].HeaderText, fuente);
                datatable.HorizontalAlignment = Element.ALIGN_CENTER;

                datatable.AddCell(objP);

            }
            datatable.HeaderRows = 2;

            datatable.DefaultCell.BorderWidth = 1;
            for (int i = 0; i < dgvMascotas.RowCount; i++)
            {
                for (int j = 0; j < dgvMascotas.ColumnCount; j++)
                {
                    objP = new Phrase(dgvMascotas[j, i].Value.ToString(), fuente);
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
        private void dgvMasctoras_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvMascotas.Rows.Count > 0)
            {
                DataGridViewRow tb = dgvMascotas.CurrentRow;
                ayudni = tb.Cells[0].Value.ToString();
                ayunombre = tb.Cells[1].Value.ToString();
                ayuespecie = tb.Cells[2].Value.ToString();
                ayuraza = tb.Cells[3].Value.ToString();
                ayupeso = tb.Cells[4].Value.ToString();
                ayusexo = tb.Cells[5].Value.ToString();
                ayunaci = tb.Cells[6].Value.ToString();
            }
        }
    }
}
