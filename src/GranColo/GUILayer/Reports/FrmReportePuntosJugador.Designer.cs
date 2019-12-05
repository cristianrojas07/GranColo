namespace GranColo.GUILayer.Reports
{
    partial class FrmReportePuntosJugador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportePuntosJugador));
            this.dsPuntaje1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPuntaje1 = new GranColo.GUILayer.Reports.DataSets.DSPuntaje();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_torneo = new System.Windows.Forms.ComboBox();
            this.btn_generar = new System.Windows.Forms.Button();
            this.rpv_puntos = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dsPuntaje1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPuntaje1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsPuntaje1BindingSource
            // 
            this.dsPuntaje1BindingSource.DataSource = this.dsPuntaje1;
            this.dsPuntaje1BindingSource.Position = 0;
            // 
            // dsPuntaje1
            // 
            this.dsPuntaje1.DataSetName = "DSPuntaje";
            this.dsPuntaje1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Torneo:";
            // 
            // cbo_torneo
            // 
            this.cbo_torneo.FormattingEnabled = true;
            this.cbo_torneo.Location = new System.Drawing.Point(59, 6);
            this.cbo_torneo.Name = "cbo_torneo";
            this.cbo_torneo.Size = new System.Drawing.Size(121, 21);
            this.cbo_torneo.TabIndex = 2;
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(186, 5);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(75, 23);
            this.btn_generar.TabIndex = 3;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // rpv_puntos
            // 
            this.rpv_puntos.LocalReport.ReportEmbeddedResource = "GranColo.GUILayer.Reports.Diseño.rpt_puntaje.rdlc";
            this.rpv_puntos.Location = new System.Drawing.Point(12, 34);
            this.rpv_puntos.Name = "rpv_puntos";
            this.rpv_puntos.ServerReport.BearerToken = null;
            this.rpv_puntos.Size = new System.Drawing.Size(697, 502);
            this.rpv_puntos.TabIndex = 4;
            // 
            // FrmReportePuntosJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 548);
            this.Controls.Add(this.rpv_puntos);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.cbo_torneo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmReportePuntosJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gran Colo";
            this.Load += new System.EventHandler(this.FrmReportePuntosJugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPuntaje1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPuntaje1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_torneo;
        private System.Windows.Forms.Button btn_generar;
        private DataSets.DSPuntaje dsPuntaje1;
        private System.Windows.Forms.BindingSource dsPuntaje1BindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_puntos;
    }
}