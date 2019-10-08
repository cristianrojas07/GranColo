using GranColo.BusinessLayer.Entities;
using GranColo.BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GranColo.GUILayer.Fixture
{
    public partial class FrmEditarAsignacion : Form
    {
        FechaXTorneo fechaXTorneo;
        FechaXTorneoService fechaXTorneoService;
        TorneoService torneoService;
        FechaService fechaService;
        int torneoSeleccionado;
        int fechaSeleccionada;
        public FrmEditarAsignacion(FechaXTorneo fechaXTorneo)
        {
            this.fechaXTorneo = fechaXTorneo;
            fechaService = new FechaService();
            torneoService = new TorneoService();
            fechaXTorneoService = new FechaXTorneoService();
            InitializeComponent();
            LlenarCombo(cboTorneo, torneoService.obtenerTodosTorneos(), "Nombre", "IdTorneo");
            LlenarCombo(cboFecha, fechaService.obtenerTodasFechas(), "Nombre", "IdFecha");
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEditarAsignacion_Load(object sender, EventArgs e)
        {
            cboFecha.Text = fechaXTorneo.Fecha.Nombre;
            cboTorneo.Text = fechaXTorneo.Torneo.Nombre;
            fechaSeleccionada = fechaXTorneo.Fecha.IdFecha;
            torneoSeleccionado = fechaXTorneo.Torneo.IdTorneo;
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            fechaXTorneo.Fecha.IdFecha = Int32.Parse(cboFecha.SelectedValue.ToString());
            fechaXTorneo.Torneo.IdTorneo = Int32.Parse(cboTorneo.SelectedValue.ToString());
            if (fechaXTorneoService.modificar(fechaXTorneo, fechaSeleccionada, torneoSeleccionado))
            {
                MessageBox.Show("Registro modificado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Registro no modificado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            this.Close();
        }
    }
}
