namespace SistemaVeterinaria.Principal
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.group = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEmpleado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGanancias = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnRMascota = new System.Windows.Forms.Button();
            this.btnSVacunacion = new System.Windows.Forms.Button();
            this.btnECanina = new System.Windows.Forms.Button();
            this.btnAActividades = new System.Windows.Forms.Button();
            this.btnMPacientes = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.btnPProductos = new System.Windows.Forms.Button();
            this.panelIzquierdo.SuspendLayout();
            this.group.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.Controls.Add(this.btnGanancias);
            this.panelIzquierdo.Controls.Add(this.btnHistorial);
            this.panelIzquierdo.Controls.Add(this.btnRMascota);
            this.panelIzquierdo.Controls.Add(this.btnSVacunacion);
            this.panelIzquierdo.Controls.Add(this.btnECanina);
            this.panelIzquierdo.Controls.Add(this.btnAActividades);
            this.panelIzquierdo.Controls.Add(this.btnMPacientes);
            this.panelIzquierdo.Controls.Add(this.btncerrar);
            this.panelIzquierdo.Controls.Add(this.btnclientes);
            this.panelIzquierdo.Controls.Add(this.btnPProductos);
            this.panelIzquierdo.Controls.Add(this.Contenedor);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(259, 682);
            this.panelIzquierdo.TabIndex = 9;
            // 
            // Contenedor
            // 
            this.Contenedor.Location = new System.Drawing.Point(259, 0);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(769, 637);
            this.Contenedor.TabIndex = 2;
            // 
            // group
            // 
            this.group.BackColor = System.Drawing.Color.White;
            this.group.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.asd;
            this.group.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.group.Controls.Add(this.statusStrip1);
            this.group.Controls.Add(this.pictureBox1);
            this.group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group.Location = new System.Drawing.Point(259, 0);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(853, 682);
            this.group.TabIndex = 10;
            this.group.TabStop = false;
            this.group.Enter += new System.EventHandler(this.group_Enter);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblEmpleado,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.lblNombre});
            this.statusStrip1.Location = new System.Drawing.Point(3, 657);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(847, 22);
            this.statusStrip1.TabIndex = 68;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabel1.Text = "Tipo de Usuario";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(69, 17);
            this.lblEmpleado.Text = "Empleado";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel3.Text = "              ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel4.Text = "Usuario:";
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(97, 17);
            this.lblNombre.Text = "Administrador";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(847, 663);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            // 
            // btnGanancias
            // 
            this.btnGanancias.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGanancias.FlatAppearance.BorderSize = 0;
            this.btnGanancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGanancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGanancias.ForeColor = System.Drawing.Color.White;
            this.btnGanancias.Image = ((System.Drawing.Image)(resources.GetObject("btnGanancias.Image")));
            this.btnGanancias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGanancias.Location = new System.Drawing.Point(3, 444);
            this.btnGanancias.Name = "btnGanancias";
            this.btnGanancias.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnGanancias.Size = new System.Drawing.Size(262, 48);
            this.btnGanancias.TabIndex = 85;
            this.btnGanancias.Text = "Ganancias";
            this.btnGanancias.UseVisualStyleBackColor = false;
            this.btnGanancias.Click += new System.EventHandler(this.btnGanancias_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.Color.White;
            this.btnHistorial.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorial.Image")));
            this.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.Location = new System.Drawing.Point(-3, 336);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHistorial.Size = new System.Drawing.Size(262, 48);
            this.btnHistorial.TabIndex = 84;
            this.btnHistorial.Text = "Historial Clinico";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnRMascota
            // 
            this.btnRMascota.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRMascota.FlatAppearance.BorderSize = 0;
            this.btnRMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRMascota.ForeColor = System.Drawing.Color.White;
            this.btnRMascota.Image = ((System.Drawing.Image)(resources.GetObject("btnRMascota.Image")));
            this.btnRMascota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRMascota.Location = new System.Drawing.Point(-3, 119);
            this.btnRMascota.Name = "btnRMascota";
            this.btnRMascota.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnRMascota.Size = new System.Drawing.Size(265, 48);
            this.btnRMascota.TabIndex = 81;
            this.btnRMascota.Text = "Registro Mascotas";
            this.btnRMascota.UseVisualStyleBackColor = false;
            this.btnRMascota.Click += new System.EventHandler(this.btnRMascota_Click);
            // 
            // btnSVacunacion
            // 
            this.btnSVacunacion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSVacunacion.FlatAppearance.BorderSize = 0;
            this.btnSVacunacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSVacunacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSVacunacion.ForeColor = System.Drawing.Color.White;
            this.btnSVacunacion.Image = ((System.Drawing.Image)(resources.GetObject("btnSVacunacion.Image")));
            this.btnSVacunacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSVacunacion.Location = new System.Drawing.Point(0, 173);
            this.btnSVacunacion.Name = "btnSVacunacion";
            this.btnSVacunacion.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSVacunacion.Size = new System.Drawing.Size(262, 48);
            this.btnSVacunacion.TabIndex = 80;
            this.btnSVacunacion.Text = "Servicios Vacunación";
            this.btnSVacunacion.UseVisualStyleBackColor = false;
            this.btnSVacunacion.Click += new System.EventHandler(this.btnSVacunacion_Click);
            // 
            // btnECanina
            // 
            this.btnECanina.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnECanina.FlatAppearance.BorderSize = 0;
            this.btnECanina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnECanina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnECanina.ForeColor = System.Drawing.Color.White;
            this.btnECanina.Image = ((System.Drawing.Image)(resources.GetObject("btnECanina.Image")));
            this.btnECanina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnECanina.Location = new System.Drawing.Point(-3, 282);
            this.btnECanina.Name = "btnECanina";
            this.btnECanina.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnECanina.Size = new System.Drawing.Size(265, 48);
            this.btnECanina.TabIndex = 79;
            this.btnECanina.Text = "     Tratamientos de Mascota";
            this.btnECanina.UseVisualStyleBackColor = false;
            this.btnECanina.Click += new System.EventHandler(this.btnECanina_Click);
            // 
            // btnAActividades
            // 
            this.btnAActividades.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAActividades.FlatAppearance.BorderSize = 0;
            this.btnAActividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAActividades.ForeColor = System.Drawing.Color.White;
            this.btnAActividades.Image = ((System.Drawing.Image)(resources.GetObject("btnAActividades.Image")));
            this.btnAActividades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAActividades.Location = new System.Drawing.Point(0, 390);
            this.btnAActividades.Name = "btnAActividades";
            this.btnAActividades.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAActividades.Size = new System.Drawing.Size(262, 48);
            this.btnAActividades.TabIndex = 78;
            this.btnAActividades.Text = "Agenda de Servicios";
            this.btnAActividades.UseVisualStyleBackColor = false;
            this.btnAActividades.Click += new System.EventHandler(this.btnAActividades_Click);
            // 
            // btnMPacientes
            // 
            this.btnMPacientes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMPacientes.FlatAppearance.BorderSize = 0;
            this.btnMPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMPacientes.ForeColor = System.Drawing.Color.White;
            this.btnMPacientes.Image = ((System.Drawing.Image)(resources.GetObject("btnMPacientes.Image")));
            this.btnMPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMPacientes.Location = new System.Drawing.Point(-3, 228);
            this.btnMPacientes.Name = "btnMPacientes";
            this.btnMPacientes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMPacientes.Size = new System.Drawing.Size(262, 48);
            this.btnMPacientes.TabIndex = 75;
            this.btnMPacientes.Text = "        Mantenimiento de Mascota";
            this.btnMPacientes.UseVisualStyleBackColor = false;
            this.btnMPacientes.Click += new System.EventHandler(this.btnMPacientes_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.Color.White;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncerrar.Location = new System.Drawing.Point(0, 608);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btncerrar.Size = new System.Drawing.Size(259, 48);
            this.btncerrar.TabIndex = 73;
            this.btncerrar.Text = "Cerrar Sesion";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnclientes.FlatAppearance.BorderSize = 0;
            this.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.ForeColor = System.Drawing.Color.White;
            this.btnclientes.Image = ((System.Drawing.Image)(resources.GetObject("btnclientes.Image")));
            this.btnclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclientes.Location = new System.Drawing.Point(-3, 11);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnclientes.Size = new System.Drawing.Size(262, 48);
            this.btnclientes.TabIndex = 68;
            this.btnclientes.Text = "Registro Clientes";
            this.btnclientes.UseVisualStyleBackColor = false;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // btnPProductos
            // 
            this.btnPProductos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPProductos.FlatAppearance.BorderSize = 0;
            this.btnPProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPProductos.ForeColor = System.Drawing.Color.White;
            this.btnPProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnPProductos.Image")));
            this.btnPProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPProductos.Location = new System.Drawing.Point(-3, 65);
            this.btnPProductos.Name = "btnPProductos";
            this.btnPProductos.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnPProductos.Size = new System.Drawing.Size(262, 48);
            this.btnPProductos.TabIndex = 69;
            this.btnPProductos.Text = "Registro Empleados";
            this.btnPProductos.UseVisualStyleBackColor = false;
            this.btnPProductos.Click += new System.EventHandler(this.btnPProductos_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 682);
            this.Controls.Add(this.group);
            this.Controls.Add(this.panelIzquierdo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panelIzquierdo.ResumeLayout(false);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblEmpleado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lblNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Button btnSVacunacion;
        private System.Windows.Forms.Button btnECanina;
        private System.Windows.Forms.Button btnAActividades;
        private System.Windows.Forms.Button btnMPacientes;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Button btnPProductos;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Button btnRMascota;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnGanancias;
    }
}