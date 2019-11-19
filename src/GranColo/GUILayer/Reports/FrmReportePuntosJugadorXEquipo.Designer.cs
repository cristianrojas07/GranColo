namespace GranColo.GUILayer.Reports
{
    partial class FrmReportePuntosJugadorXEquipo
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_torneos = new System.Windows.Forms.ComboBox();
            this.cbo_ordenes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Button();
            this.rwReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Torneo:";
            // 
            // cbo_torneos
            // 
            this.cbo_torneos.FormattingEnabled = true;
            this.cbo_torneos.Location = new System.Drawing.Point(63, 10);
            this.cbo_torneos.Name = "cbo_torneos";
            this.cbo_torneos.Size = new System.Drawing.Size(121, 21);
            this.cbo_torneos.TabIndex = 1;
            // 
            // cbo_ordenes
            // 
            this.cbo_ordenes.FormattingEnabled = true;
            this.cbo_ordenes.Location = new System.Drawing.Point(276, 10);
            this.cbo_ordenes.Name = "cbo_ordenes";
            this.cbo_ordenes.Size = new System.Drawing.Size(121, 21);
            this.cbo_ordenes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Orden:";
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(541, 10);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(75, 23);
            this.btn_generar.TabIndex = 4;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.Btn_generar_Click);
            // 
            // rwReporte
            // 
            this.rwReporte.LocalReport.ReportEmbeddedResource = "GranColo.GUILayer.Reports.Diseño.rpt_puntajeXEquipoXTorneo.rdlc";
            this.rwReporte.Location = new System.Drawing.Point(16, 37);
            this.rwReporte.Name = "rwReporte";
            this.rwReporte.ServerReport.BearerToken = null;
            this.rwReporte.Size = new System.Drawing.Size(600, 555);
            this.rwReporte.TabIndex = 5;
            // 
            // FrmReportePuntosJugadorXEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(628, 604);
            this.Controls.Add(this.rwReporte);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.cbo_ordenes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_torneos);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmReportePuntosJugadorXEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gran Colo:";
            this.Load += new System.EventHandler(this.FrmReportePuntosJugadorXEquipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_torneos;
        private System.Windows.Forms.ComboBox cbo_ordenes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_generar;
        private Microsoft.Reporting.WinForms.ReportViewer rwReporte;
    }
}