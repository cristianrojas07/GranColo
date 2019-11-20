using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GranColo.GUILayer.Reports
{
    public partial class FrmEstadistico : Form
    {
        public FrmEstadistico()
        {
            InitializeComponent();
        }

        private void FrmEstadistico_Load(object sender, EventArgs e)
        {
            this.rv_estadistico.RefreshReport();
            this.dsEstadistico1.DTEstadistico.DefaultView.Sort = "porcentajeParticipacion";
            
            //rv_estadistico.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("nombreTorneo", cbo_torneos.Text) });
            rv_estadistico.LocalReport.DataSources.Clear();
            rv_estadistico.LocalReport.DataSources.Add(new ReportDataSource("DSEstadistico", DataManager.GetInstance().GenerarEstadistico()));
            rv_estadistico.RefreshReport();
            
        }
    }
}
