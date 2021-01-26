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
using System.Text.RegularExpressions;

namespace SistemaVeterinaria.Principal
{
    public partial class FrmClientes : MaterialSkin.Controls.MaterialForm
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevos_Click(object sender, EventArgs e)
        {
            MtdLimpiarCajas();
        }
        private void MtdLimpiarCajas()
        {

            txtDni.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtDni.Focus();

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Equals("")) MessageBox.Show("El campo Dni Cliente esta vacio");
            else if (txtNombres.Text.Equals("")) MessageBox.Show("El campo Nombre   esta vacio");
            else if (txtApellidos.Text.Equals("")) MessageBox.Show("El campo Apellido  esta vacio");
            else if (txtTelefono.Text.Equals("")) MessageBox.Show("El campo Telefono  esta vacio");
            else if (txtDireccion.Text.Equals("")) MessageBox.Show("El campo Direccion  esta vacio");
            else if (txtEmail.Text.Equals("")) MessageBox.Show("El campo Email  esta vacio");
            else
            {
                ClsEClientes objEcli = new ClsEClientes();
                ClsNClientes ojbjNcli = new ClsNClientes();
                objEcli.Dni = txtDni.Text;
                objEcli.Nombre = txtNombres.Text;
                objEcli.Apellido = txtApellidos.Text;
                objEcli.Email = txtEmail.Text;
                objEcli.Telefono = txtTelefono.Text;
                objEcli.Direccion = txtDireccion.Text;
                ojbjNcli.MtdAgregarClienteMysql(objEcli);
                MessageBox.Show("Cliente Agregado");
                MtdLimpiarCajas();
                listar();
            }

          
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Equals("")) MessageBox.Show("El campo Dni Cliente esta vacio");
            else if (txtNombres.Text.Equals("")) MessageBox.Show("El campo Nombre de Mascota  esta vacio");
            else if (txtApellidos.Text.Equals("")) MessageBox.Show("El campo Apellido  esta vacio");
            else if (txtTelefono.Text.Equals("")) MessageBox.Show("El campo Telefono  esta vacio");
            else if (txtDireccion.Text.Equals("")) MessageBox.Show("El campo Direccion  esta vacio");
            else if (txtEmail.Text.Equals("")) MessageBox.Show("El campo Email  esta vacio");
            else
            {

                ClsEClientes objEcli = new ClsEClientes();
                ClsNClientes ojbjNcli = new ClsNClientes();
                objEcli.Dni = txtDni.Text;
                objEcli.Nombre = txtNombres.Text;
                objEcli.Apellido = txtApellidos.Text;
                objEcli.Email = txtEmail.Text;
                objEcli.Telefono = txtTelefono.Text;
                objEcli.Direccion = txtDireccion.Text;
                ojbjNcli.MtdMoficarMysql(objEcli);
                MessageBox.Show("Cliente Modificado");
                MtdLimpiarCajas();
                listar();
            }
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Equals("")) MessageBox.Show("El campo Dni Cliente esta vacio");
            else if (txtNombres.Text.Equals("")) MessageBox.Show("El campo Nombre de Mascota  esta vacio");
            else if (txtApellidos.Text.Equals("")) MessageBox.Show("El campo Apellido  esta vacio");
            else if (txtTelefono.Text.Equals("")) MessageBox.Show("El campo Telefono  esta vacio");
            else if (txtDireccion.Text.Equals("")) MessageBox.Show("El campo Direccion  esta vacio");
            else if (txtEmail.Text.Equals("")) MessageBox.Show("El campo Email  esta vacio");
            else
            {
                ClsEClientes objEcli = new ClsEClientes();
                ClsNClientes ojbjNcli = new ClsNClientes();
                objEcli.Dni = txtDni.Text;
                ojbjNcli.MtdEliminarMySql(objEcli);
                MessageBox.Show("Datos Eliminados correctamente...");
                listar();
            }
        }
        public void listar()
        {
            ClsNClientes objcar = new ClsNClientes();
            dgvClientes.DataSource = objcar.MtdListarTodo();
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ClsEClientes objEcli = new ClsEClientes();
            ClsNClientes ojbjNcli = new ClsNClientes();
            objEcli.Dni = textBuscar.Text;
            dgvClientes.DataSource = ojbjNcli.MtdBuscarMySql(objEcli);
            MessageBox.Show("Datos Buscados correctamente...");


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

        private void dgvClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (dgvClientes.Rows.Count > 0)
            {
                DataGridViewRow tb = dgvClientes.CurrentRow;
                txtDni.Text = tb.Cells[0].Value.ToString();
                txtNombres.Text = tb.Cells[1].Value.ToString();
                txtApellidos.Text = tb.Cells[2].Value.ToString();
                txtTelefono.Text = tb.Cells[3].Value.ToString();
                txtEmail.Text = tb.Cells[4].Value.ToString();
                txtDireccion.Text = tb.Cells[5].Value.ToString();
                

            }
        }

        private void textBuscar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (dgvClientes.RowCount == 0)
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
                    Chunk encab3 = new Chunk("TIPO DE INFORMACION : Clientes", FontFactory.GetFont("COURIER", 18));
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
            PdfPTable datatable = new PdfPTable(dgvClientes.ColumnCount);

            datatable.DefaultCell.Padding = 1;
            float[] headerwidths = GetTamañoColumnas(dgvClientes);

            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 1;

            datatable.DefaultCell.BackgroundColor = iTextSharp.text.BaseColor.WHITE;

            datatable.DefaultCell.BorderColor = iTextSharp.text.BaseColor.BLACK;

            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA);

            Phrase objP = new Phrase("A", fuente);

            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            for (int i = 0; i < dgvClientes.ColumnCount; i++)
            {

                objP = new Phrase(dgvClientes.Columns[i].HeaderText, fuente);
                datatable.HorizontalAlignment = Element.ALIGN_CENTER;

                datatable.AddCell(objP);

            }
            datatable.HeaderRows = 2;

            datatable.DefaultCell.BorderWidth = 1;
            for (int i = 0; i < dgvClientes.RowCount; i++)
            {
                for (int j = 0; j < dgvClientes.ColumnCount; j++)
                {
                    objP = new Phrase(dgvClientes[j, i].Value.ToString(), fuente);
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

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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
