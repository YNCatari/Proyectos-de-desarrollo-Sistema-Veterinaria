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
    public partial class FrmMascota : MaterialSkin.Controls.MaterialForm
    {
        public FrmMascota()
        {
            InitializeComponent();
        }

        private void FrmMascota_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MtdLimpiarCajas();
        }
        private void MtdLimpiarCajas()
        {

            txtDni.Text = "";
            txtNombres.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtNombre.Text = "";
            txtEspecie.Text = "";
            txtRaza.Text = "";
            txtPeso.Text = "";
            cmbSexo.Text = "";
            rdbActivo.Checked = false;
            rdbInactivo.Checked = false;
            txtDni.Focus();

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Equals("")) MessageBox.Show("El campo Dni Cliente esta vacio");
            else if (txtNombre.Text.Equals("")) MessageBox.Show("El campo Nombre de Mascota  esta vacio");
            else if (txtRaza.Text.Equals("")) MessageBox.Show("El campo Raza  esta vacio");
            else if (txtPeso.Text.Equals("")) MessageBox.Show("El campo Peso  esta vacio");
            else if (rdbActivo.Checked==false && rdbInactivo.Checked == false) MessageBox.Show("Seleccione un Estado");
            else
            {
                ClsEMascota objEMas = new ClsEMascota();
                ClsNMascota ojbjNMas = new ClsNMascota();
                objEMas.Dni = txtDni.Text;
                objEMas.Nombres = txtNombre.Text;
                objEMas.Especie = txtEspecie.Text;
                objEMas.Raza = txtRaza.Text;
                objEMas.Peso = txtPeso.Text;
                objEMas.Sexo = cmbSexo.Text;
                objEMas.Nacimiento = dateFecha.Text;
                string Estado = null;
                if (rdbActivo.Checked == true)
                {
                    Estado = "TRUE";
                }
                if (rdbInactivo.Checked == true)
                {
                    Estado = "FALSE";
                }
                objEMas.Estado = Estado;
                ojbjNMas.MtdAgregarMySql(objEMas);
                MessageBox.Show("Mascota Agregado");
                MtdLimpiarCajas();
                listar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Equals("")) MessageBox.Show("El campo Dni Cliente esta vacio");
            else if (txtNombre.Text.Equals("")) MessageBox.Show("El campo Nombre de Mascota  esta vacio");
            else if (txtRaza.Text.Equals("")) MessageBox.Show("El campo Raza  esta vacio");
            else if (txtPeso.Text.Equals("")) MessageBox.Show("El campo Peso  esta vacio");
            else if (rdbActivo.Checked == false && rdbInactivo.Checked == false) MessageBox.Show("Seleccione un Estado");
            else
            {
                ClsEMascota objEMas = new ClsEMascota();
                ClsNMascota ojbjNMas = new ClsNMascota();
                objEMas.Dni = txtDni.Text;
                objEMas.Nombres = txtNombre.Text;
                objEMas.Especie = txtEspecie.Text;
                objEMas.Raza = txtRaza.Text;
                objEMas.Peso = txtPeso.Text;
                objEMas.Sexo = cmbSexo.Text;
                objEMas.Nacimiento = dateFecha.Text;
                string Estado = null;
                if (rdbActivo.Checked == true)
                {
                    Estado = "TRUE";
                }
                if (rdbInactivo.Checked == true)
                {
                    Estado = "FALSE";
                }
                objEMas.Estado = Estado;
                ojbjNMas.MtdMoficarMySql(objEMas);
                MessageBox.Show("Mascota  Modificado");
                MtdLimpiarCajas();
                listar();
            }
        }
        public void listar()
        {
            ClsNMascota objNMas = new ClsNMascota();
            dgvMascotas.DataSource = objNMas.MtdListarTodo();
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void textDni_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
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
                    txtNombres.Text = Fila["apellido"].ToString() + "," + Fila["nombre"].ToString();
                    txtDireccion.Text = Fila["direccion"].ToString();
                    txtTelefono.Text = Fila["telefono"].ToString();
                }
            }
        }

        private void btnBuscarPorDni_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals("")) MessageBox.Show("El campo Buscar por Dni esta vacio");
            else
            {
                ClsEHistorial objE = new ClsEHistorial();
                ClsNHistorial ojbjN = new ClsNHistorial();
                objE.Dni = txtDni.Text;
                dgvMascotas.DataSource = ojbjN.MtdBuscarMascota(objE);

            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvMascotas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvMascotas.Rows.Count > 0)
            {
                DataGridViewRow tb = dgvMascotas.CurrentRow;
                txtDni.Text = tb.Cells[0].Value.ToString();
                txtNombre.Text = tb.Cells[1].Value.ToString();
                txtEspecie.Text = tb.Cells[2].Value.ToString();
                txtRaza.Text = tb.Cells[3].Value.ToString();
                txtPeso.Text = tb.Cells[4].Value.ToString();
                cmbSexo.Text = tb.Cells[5].Value.ToString();
                dateFecha.Text = tb.Cells[6].Value.ToString();
                if (tb.Cells[7].Value.ToString().Equals("TRUE")) rdbActivo.Checked = true;
                if (tb.Cells[7].Value.ToString().Equals("FALSE")) rdbInactivo.Checked = true;
            }
        }

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
                    Chunk encab2 = new Chunk("FECHA : " + DateTime.Today, FontFactory.GetFont("COURIER", 18));
                    Chunk encab3 = new Chunk("TIPO DE INFORMACION : Mascotas", FontFactory.GetFont("COURIER", 18));
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtEspecie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtRaza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
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
