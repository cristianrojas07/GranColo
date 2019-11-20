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
    public partial class FrmReportePuntosJugador : Form
    {

        TorneoService torneoService;
        public FrmReportePuntosJugador()
        {
            InitializeComponent();
            torneoService = new TorneoService();
            LlenarCombo(cbo_torneo, torneoService.obtenerTodosTorneos(), "Nombre", "IdTorneo");
        }

        private void FrmReportePuntosJugador_Load(object sender, EventArgs e)
        {
            this.rpv_puntos.RefreshReport();
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            if (cbo_torneo.SelectedIndex != -1)
            {
                rpv_puntos.LocalReport.SetParameters(new ReportParameter[]{ new ReportParameter("nombreTorneo", cbo_torneo.Text) });
                rpv_puntos.LocalReport.DataSources.Clear();
                rpv_puntos.LocalReport.DataSources.Add(new ReportDataSource("puntosJugadores", DataManager.GetInstance().GenerarReporte((int)cbo_torneo.SelectedValue)));
                rpv_puntos.RefreshReport();
            }
            else
            {
                MessageBox.Show("Elija un torneo para generar el informe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    }
}
