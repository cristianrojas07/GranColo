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
    public partial class FrmAsignarFecha : Form
    {
        private readonly TorneoService torneoService;
        private readonly FechaService fechaService;
        private readonly FechaXTorneoService fechaXTorneoService;
        private readonly BindingList<FechaXTorneo> listaFechaXTorneo;

        public FrmAsignarFecha()
        {
            InitializeComponent();
            dgvDetalle.AutoGenerateColumns = false;
            torneoService = new TorneoService();
            fechaService = new FechaService();
            fechaXTorneoService = new FechaXTorneoService();
            listaFechaXTorneo = new BindingList<FechaXTorneo>();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAsignarFecha_Load(object sender, EventArgs e)
        {
            InicializarFormulario();
            LlenarCombo(cboTorneo, torneoService.obtenerTodosTorneos(), "Nombre", "IdTorneo");
            LlenarCombo(cboFecha, fechaService.obtenerTodasFechas(), "Nombre", "IdFecha");
            dgvDetalle.DataSource = listaFechaXTorneo;
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }

        private void InicializarFormulario()
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            cboTorneo.SelectedIndex = -1;
            cboFecha.SelectedIndex = -1;
            dgvDetalle.Rows.Clear();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            InicializarFormulario();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            var fecha = (Fecha)cboFecha.SelectedItem;
            var torneo = (Torneo)cboTorneo.SelectedItem;
            listaFechaXTorneo.Add(new FechaXTorneo()
            {
                Fecha = fecha,
                Torneo = torneo,
                Estado = "S"
            });
            btnEliminar.Enabled = (dgvDetalle.Rows.Count > 0);
            btnGuardar.Enabled = (dgvDetalle.Rows.Count > 0);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDetalle.Rows.Count > 0)
                {
                    fechaXTorneoService.Crear(listaFechaXTorneo);
                    MessageBox.Show(string.Concat("Se asignaron las fechas correctamente."), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InicializarFormulario();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar las fechas! " + ex.Message + ex.StackTrace, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CboTorneo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFecha.SelectedIndex != -1 & cboTorneo.SelectedIndex != -1)
            {
                btnAgregar.Enabled = true;
            }
        }

        private void CboFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFecha.SelectedIndex != -1 & cboTorneo.SelectedIndex != -1)
            {
                btnAgregar.Enabled = true;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow != null)
            {
                var itemSeleccionado = (FechaXTorneo)dgvDetalle.CurrentRow.DataBoundItem;
                listaFechaXTorneo.Remove(itemSeleccionado);
            }
        }

        
    }
}
