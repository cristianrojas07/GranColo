namespace GranColo.GUILayer.Reports
{
    partial class FrmEstadistico
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
            this.rv_estadistico = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsEstadistico1 = new GranColo.GUILayer.Reports.DataSets.DSEstadistico();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstadistico1)).BeginInit();
            this.SuspendLayout();
            // 
            // rv_estadistico
            // 
            this.rv_estadistico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_estadistico.LocalReport.ReportEmbeddedResource = "GranColo.GUILayer.Reports.Diseño.rpt_Estadistico.rdlc";
            this.rv_estadistico.Location = new System.Drawing.Point(0, 0);
            this.rv_estadistico.Name = "rv_estadistico";
            this.rv_estadistico.ServerReport.BearerToken = null;
            this.rv_estadistico.Size = new System.Drawing.Size(628, 604);
            this.rv_estadistico.TabIndex = 0;
            // 
            // dsEstadistico1
            // 
            this.dsEstadistico1.DataSetName = "DSEstadistico";
            this.dsEstadistico1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(628, 604);
            this.Controls.Add(this.rv_estadistico);
            this.MaximizeBox = false;
            this.Name = "FrmEstadistico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gran Colo";
            this.Load += new System.EventHandler(this.FrmEstadistico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsEstadistico1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_estadistico;
        private DataSets.DSEstadistico dsEstadistico1;
    }
}