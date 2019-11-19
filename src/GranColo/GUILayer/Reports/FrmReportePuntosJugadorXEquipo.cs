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
            crearOrdenes();
            this.rwReporte.RefreshReport();
            this.rwReporte.RefreshReport();
        }

        private void crearOrdenes()
        {
            List<string> listaOrden = new List<string>();
            listaOrden.Add("Ascendente");
            listaOrden.Add("Descendente");
            listaOrden.Add("Sin Orden");
            cbo_ordenes.DataSource = listaOrden;
            cbo_ordenes.SelectedIndex = 0;
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
                rwReporte.LocalReport.DataSources.Add(new ReportDataSource("puntosJugadores", DataManager.GetInstance().GenerarReporte((int)cbo_torneos.SelectedValue, cbo_ordenes.SelectedIndex)));
                rwReporte.RefreshReport();
            }
            else
            {
                MessageBox.Show("Elija un torneo para generar el informe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
