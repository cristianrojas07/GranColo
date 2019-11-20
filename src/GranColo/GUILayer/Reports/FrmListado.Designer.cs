namespace GranColo.GUILayer.Reports
{
    partial class FrmListado
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
            this.dSListadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSListado = new GranColo.GUILayer.Reports.DataSets.DSListado();
            this.dtListadoTableAdapter1 = new GranColo.GUILayer.Reports.DataSets.DSListadoTableAdapters.DTListadoTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dSListadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSListado)).BeginInit();
            this.SuspendLayout();
            // 
            // dSListadoBindingSource
            // 
            this.dSListadoBindingSource.DataSource = this.dSListado;
            this.dSListadoBindingSource.Position = 0;
            // 
            // dSListado
            // 
            this.dSListado.DataSetName = "DSListado";
            this.dSListado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtListadoTableAdapter1
            // 
            this.dtListadoTableAdapter1.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSListado";
            reportDataSource1.Value = this.dSListadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GranColo.GUILayer.Reports.Diseño.rpt_Listado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // FrmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmListado";
            this.Text = "FrmListado";
            this.Load += new System.EventHandler(this.FrmListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSListadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dSListadoBindingSource;
        private DataSets.DSListado dSListado;
        private DataSets.DSListadoTableAdapters.DTListadoTableAdapter dtListadoTableAdapter1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}