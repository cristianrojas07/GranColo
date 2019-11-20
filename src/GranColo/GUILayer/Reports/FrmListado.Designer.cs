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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpv_listado = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSListado = new GranColo.GUILayer.Reports.DataSets.DSListado();
            this.dTListadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dTListadoTableAdapter = new GranColo.GUILayer.Reports.DataSets.DSListadoTableAdapters.DTListadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTListadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpv_listado
            // 
            this.rpv_listado.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DSListado";
            reportDataSource2.Value = this.dTListadoBindingSource;
            this.rpv_listado.LocalReport.DataSources.Add(reportDataSource2);
            this.rpv_listado.LocalReport.ReportEmbeddedResource = "GranColo.GUILayer.Reports.Diseño.rpt_Listado.rdlc";
            this.rpv_listado.Location = new System.Drawing.Point(0, 0);
            this.rpv_listado.Name = "rpv_listado";
            this.rpv_listado.ServerReport.BearerToken = null;
            this.rpv_listado.Size = new System.Drawing.Size(628, 604);
            this.rpv_listado.TabIndex = 0;
            // 
            // dSListado
            // 
            this.dSListado.DataSetName = "DSListado";
            this.dSListado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTListadoBindingSource
            // 
            this.dTListadoBindingSource.DataMember = "DTListado";
            this.dTListadoBindingSource.DataSource = this.dSListado;
            // 
            // dTListadoTableAdapter
            // 
            this.dTListadoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 604);
            this.Controls.Add(this.rpv_listado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GranColo";
            this.Load += new System.EventHandler(this.FrmListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTListadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpv_listado;
        private DataSets.DSListado dSListado;
        private System.Windows.Forms.BindingSource dTListadoBindingSource;
        private DataSets.DSListadoTableAdapters.DTListadoTableAdapter dTListadoTableAdapter;
    }
}