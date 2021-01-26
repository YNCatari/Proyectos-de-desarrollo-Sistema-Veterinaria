namespace SistemaVeterinaria.Principal
{
    partial class FrmReportVacunas
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
            this.btnVacunas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvVacunas = new System.Windows.Forms.DataGridView();
            this.btnPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacunas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVacunas
            // 
            this.btnVacunas.Depth = 0;
            this.btnVacunas.Location = new System.Drawing.Point(274, 197);
            this.btnVacunas.Margin = new System.Windows.Forms.Padding(2);
            this.btnVacunas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVacunas.Name = "btnVacunas";
            this.btnVacunas.Primary = true;
            this.btnVacunas.Size = new System.Drawing.Size(93, 33);
            this.btnVacunas.TabIndex = 86;
            this.btnVacunas.Text = "Cerrar";
            this.btnVacunas.UseVisualStyleBackColor = true;
            this.btnVacunas.Click += new System.EventHandler(this.btnVacunas_Click);
            // 
            // dgvVacunas
            // 
            this.dgvVacunas.AllowUserToAddRows = false;
            this.dgvVacunas.AllowUserToDeleteRows = false;
            this.dgvVacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacunas.Location = new System.Drawing.Point(12, 68);
            this.dgvVacunas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVacunas.Name = "dgvVacunas";
            this.dgvVacunas.ReadOnly = true;
            this.dgvVacunas.RowTemplate.Height = 24;
            this.dgvVacunas.Size = new System.Drawing.Size(355, 126);
            this.dgvVacunas.TabIndex = 85;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.Transparent;
            this.btnPDF.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Apps_Pdf_icon;
            this.btnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.Color.White;
            this.btnPDF.Location = new System.Drawing.Point(12, 197);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(2);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(62, 50);
            this.btnPDF.TabIndex = 91;
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // FrmReportVacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 248);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnVacunas);
            this.Controls.Add(this.dgvVacunas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmReportVacunas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes de Vacunas";
            this.Load += new System.EventHandler(this.FrmReportVacunas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacunas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnVacunas;
        private System.Windows.Forms.DataGridView dgvVacunas;
        private System.Windows.Forms.Button btnPDF;
    }
}