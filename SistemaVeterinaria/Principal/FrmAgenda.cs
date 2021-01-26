using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaVeterinaria.Entidades;
using SistemaVeterinaria.Negocios;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;
namespace SistemaVeterinaria.Principal
{
    public partial class FrmAgenda : MaterialSkin.Controls.MaterialForm
    {
        public FrmAgenda()
        {
            InitializeComponent();
        }
        public static string ayucodigo;
        private void FrmAgenda_Load(object sender, EventArgs e)
        {

        }

      
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MtdLimpiarCajas();
        }
        private void MtdLimpiarCajas()
        {

            txtDni.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            Dtpfecha.Text = "";
            cbHora.Text = "00";
            cbMin.Text = "00";
            cbSeg.Text = "00";
            txtActividad.Text = "";
            txtDni.Focus();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Equals("")) MessageBox.Show("El campo Dni Cliente esta vacio");
            else if(cbHora.Text.Equals("00")) MessageBox.Show("Elija una Hora");
            else if(txtActividad.Text.Equals("")) MessageBox.Show("El campo Actividad Cliente esta vacio");
            else
            {
                ClsEAgenda objEAge = new ClsEAgenda();
                ClsNAgenda ojbjNAge = new ClsNAgenda();
                objEAge.Dni = txtDni.Text;
                objEAge.Nombres = txtNombre.Text;
                objEAge.Direccion = txtDireccion.Text;
                objEAge.Telefono = txtTelefono.Text;
                objEAge.Fecha = Dtpfecha.Text;
                objEAge.Hora = cbHora.Text + ":" + cbMin.Text + ":" + cbSeg.Text;
                objEAge.Actividad = txtActividad.Text;
                ojbjNAge.MtdAgregarMySql(objEAge);
                MessageBox.Show("Agenda Agregado");
                MtdLimpiarCajas();
                listar();
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Equals("")) MessageBox.Show("El campo Dni Cliente esta vacio");
            else if (cbHora.Text.Equals("00")) MessageBox.Show("Elija una Hora");
            else if (txtActividad.Text.Equals("")) MessageBox.Show("El campo Actividad Cliente esta vacio");
            else
            {
                MessageBox.Show(ayucodigo);
                ClsEAgenda objEAge = new ClsEAgenda();
                ClsNAgenda ojbjNAge = new ClsNAgenda();
                objEAge.Codigo = ayucodigo;
                objEAge.Dni = txtDni.Text;
                objEAge.Nombres = txtNombre.Text;
                objEAge.Direccion = txtDireccion.Text;
                objEAge.Telefono = txtTelefono.Text;
                objEAge.Fecha = Dtpfecha.Text;
                objEAge.Hora = cbHora.Text + ":" + cbMin.Text + ":" + cbSeg.Text;
                objEAge.Actividad = txtActividad.Text;
                ojbjNAge.MtdMoficarMySql(objEAge);
                MessageBox.Show("Agenda Modificada");
                MtdLimpiarCajas();
                listar();
            }

        }
        public void listar()
        {
            ClsNAgenda objcar = new ClsNAgenda();
            dgvAgenda.DataSource = objcar.MtdListarTodo();
            dgvAgenda.AutoResizeColumns();
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            ClsNAgenda objcar = new ClsNAgenda();
            dgvAgenda.DataSource = objcar.MtdListarTodo();
            dgvAgenda.AutoResizeColumns();
        }

        private void btnBuscar1_Click_1(object sender, EventArgs e)
        {
            if (txtDni.Text.Equals("")) MessageBox.Show("El campo Dni Cliente esta vacio");
            else
            {
                ClsEClientes objEC = new ClsEClientes();
                ClsNClientes ojbjNC = new ClsNClientes();
                objEC.Dni = txtDni.Text;
                DataTable dtEmp = new DataTable();
                dtEmp = ojbjNC.MtdBuscarMySql(objEC);
                if (dtEmp.Rows.Count > 0)
                {
                    DataRow Fila = dtEmp.Rows[0];
                    txtNombre.Text = Fila["apellido"].ToString() + "," + Fila["nombre"].ToString();
                    txtDireccion.Text = Fila["direccion"].ToString();
                    txtTelefono.Text = Fila["telefono"].ToString();

                }
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

                ClsEAgenda objEAge = new ClsEAgenda();
                ClsNAgenda ojbjNAge = new ClsNAgenda();
                objEAge.Fecha = dtpBuscar.Text;
                dgvAgenda.DataSource = ojbjNAge.MtdBuscarMySql(objEAge);
                dgvAgenda.AutoResizeColumns();
        }

        private void dgvAgenda_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvAgenda.Rows.Count > 0)
            {
                DataGridViewRow tb = dgvAgenda.CurrentRow;
                ayucodigo = tb.Cells[0].Value.ToString();
                txtDni.Text = tb.Cells[1].Value.ToString();
                txtNombre.Text = tb.Cells[2].Value.ToString();
                txtTelefono.Text = tb.Cells[3].Value.ToString();
                txtDireccion.Text = tb.Cells[4].Value.ToString();
                Dtpfecha.Text = tb.Cells[5].Value.ToString();
                txtActividad.Text = tb.Cells[7].Value.ToString();
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (dgvAgenda.RowCount == 0)
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
                    Chunk encab2 = new Chunk("FECHA : " +dtpBuscar.Text, FontFactory.GetFont("COURIER", 18));
                    Chunk encab3 = new Chunk("TIPO DE INFORMACION : Agenda de Servicios", FontFactory.GetFont("COURIER", 18));
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
            PdfPTable datatable = new PdfPTable(dgvAgenda.ColumnCount);

            datatable.DefaultCell.Padding = 1;
            float[] headerwidths = GetTamañoColumnas(dgvAgenda);

            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 1;

            datatable.DefaultCell.BackgroundColor = iTextSharp.text.BaseColor.WHITE;

            datatable.DefaultCell.BorderColor = iTextSharp.text.BaseColor.BLACK;

            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA);

            Phrase objP = new Phrase("A", fuente);

            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            for (int i = 0; i < dgvAgenda.ColumnCount; i++)
            {

                objP = new Phrase(dgvAgenda.Columns[i].HeaderText, fuente);
                datatable.HorizontalAlignment = Element.ALIGN_CENTER;

                datatable.AddCell(objP);

            }
            datatable.HeaderRows = 2;

            datatable.DefaultCell.BorderWidth = 1;
            for (int i = 0; i < dgvAgenda.RowCount; i++)
            {
                for (int j = 0; j < dgvAgenda.ColumnCount; j++)
                {
                    objP = new Phrase(dgvAgenda[j, i].Value.ToString(), fuente);
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
    }
}
