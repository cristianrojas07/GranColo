using GranColo.BusinessLayer.Services;
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
    public partial class FrmReportePuntosJugadorXEquipo : Form
    {
        public TorneoService torneoService { get; set; }
        public FrmReportePuntosJugadorXEquipo()
        {
            torneoService = new TorneoService();
            InitializeComponent();
        }

        private void FrmReportePuntosJugadorXEquipo_Load(object sender, EventArgs e)
        {
            llenarCombo(cbo_torneos, torneoService.obtenerTodosTorneos(), "Nombre", "idTorneo");
            this.rwReporte.RefreshReport();
        }

        private void llenarCombo(ComboBox cbo, object source, string member, string value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = member;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void Btn_generar_Click(object sender, EventArgs e)
        {
            if (cbo_torneos.SelectedIndex!=-1)
            {
                rwReporte.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("nombreTorneo", cbo_torneos.Text) });
                rwReporte.LocalReport.DataSources.Clear();
                rwReporte.LocalReport.DataSources.Add(new ReportDataSource("DSReporte2", DataManager.GetInstance().GenerarReporteEquipoXJugador((int)cbo_torneos.SelectedValue)));
                rwReporte.RefreshReport();
            }
            else
            {
                MessageBox.Show("Elija un torneo para generar el informe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
