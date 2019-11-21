namespace GranColo.GUILayer.Reports
{
    partial class FrmEstadisticoTwo
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dTEstadisticoTwoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSEstadisticoTwo = new GranColo.GUILayer.Reports.DataSets.DSEstadisticoTwo();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dTEstadisticoTwoTableAdapter = new GranColo.GUILayer.Reports.DataSets.DSEstadisticoTwoTableAdapters.DTEstadisticoTwoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dTEstadisticoTwoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadisticoTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // dTEstadisticoTwoBindingSource
            // 
            this.dTEstadisticoTwoBindingSource.DataMember = "DTEstadisticoTwo";
            this.dTEstadisticoTwoBindingSource.DataSource = this.dSEstadisticoTwo;
            // 
            // dSEstadisticoTwo
            // 
            this.dSEstadisticoTwo.DataSetName = "DSEstadisticoTwo";
            this.dSEstadisticoTwo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSEstadisticoTwo";
            reportDataSource1.Value = this.dTEstadisticoTwoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GranColo.GUILayer.Reports.Diseño.rpt_EstadisticoTwo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(633, 792);
            this.reportViewer1.TabIndex = 0;
            // 
            // dTEstadisticoTwoTableAdapter
            // 
            this.dTEstadisticoTwoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmEstadisticoTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 792);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmEstadisticoTwo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gran Colo";
            this.Load += new System.EventHandler(this.EstadisticoTwo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dTEstadisticoTwoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadisticoTwo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSets.DSEstadisticoTwo dSEstadisticoTwo;
        private System.Windows.Forms.BindingSource dTEstadisticoTwoBindingSource;
        private DataSets.DSEstadisticoTwoTableAdapters.DTEstadisticoTwoTableAdapter dTEstadisticoTwoTableAdapter;
    }
}