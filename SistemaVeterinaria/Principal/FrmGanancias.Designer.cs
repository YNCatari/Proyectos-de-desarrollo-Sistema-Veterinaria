namespace SistemaVeterinaria.Principal
{
    partial class FrmGanancias
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chGanancias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DtpfechaF = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpfechaI = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chGanancias)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chGanancias
            // 
            chartArea1.Name = "ChartArea1";
            this.chGanancias.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chGanancias.Legends.Add(legend1);
            this.chGanancias.Location = new System.Drawing.Point(44, 199);
            this.chGanancias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chGanancias.Name = "chGanancias";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chGanancias.Series.Add(series1);
            this.chGanancias.Size = new System.Drawing.Size(1055, 514);
            this.chGanancias.TabIndex = 0;
            this.chGanancias.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.DtpfechaF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DtpfechaI);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(99, 112);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(809, 68);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Ganancias";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Depth = 0;
            this.btnCalcular.Location = new System.Drawing.Point(675, 9);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcular.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Primary = true;
            this.btnCalcular.Size = new System.Drawing.Size(129, 50);
            this.btnCalcular.TabIndex = 104;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // DtpfechaF
            // 
            this.DtpfechaF.CustomFormat = "yyyy-MM-dd";
            this.DtpfechaF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpfechaF.Location = new System.Drawing.Point(392, 18);
            this.DtpfechaF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpfechaF.Name = "DtpfechaF";
            this.DtpfechaF.Size = new System.Drawing.Size(136, 22);
            this.DtpfechaF.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fecha Final :";
            // 
            // DtpfechaI
            // 
            this.DtpfechaI.CustomFormat = "yyyy-MM-dd";
            this.DtpfechaI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpfechaI.Location = new System.Drawing.Point(124, 18);
            this.DtpfechaI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpfechaI.Name = "DtpfechaI";
            this.DtpfechaI.Size = new System.Drawing.Size(136, 22);
            this.DtpfechaI.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Inicial :";
            // 
            // FrmGanancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 849);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chGanancias);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmGanancias";
            this.Text = "Ganancias";
            this.Load += new System.EventHandler(this.FrmGanancias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chGanancias)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chGanancias;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DtpfechaF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpfechaI;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialRaisedButton btnCalcular;
    }
}