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
        readonly FechaXTorneo fechaXTorneo;
        readonly FechaXTorneoService fechaXTorneoService;
        readonly TorneoService torneoService;
        readonly FechaService fechaService;
        int torneoSeleccionado;
        int fechaSeleccionada;

        public string nombreFecha { get; set; }
        public string nombreTorneo { get; set; }

        public FrmEditarAsignacion(FechaXTorneo fechaXTorneo)
        {
            InitializeComponent();
            this.fechaXTorneo = fechaXTorneo;
            fechaService = new FechaService();
            torneoService = new TorneoService();
            fechaXTorneoService = new FechaXTorneoService();
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
            nombreFecha = cboFecha.Text;
            nombreTorneo = cboTorneo.Text;
            fechaSeleccionada = fechaXTorneo.Fecha.IdFecha;
            torneoSeleccionado = fechaXTorneo.Torneo.IdTorneo;
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            
            fechaXTorneo.Fecha.IdFecha = Int32.Parse(cboFecha.SelectedValue.ToString());
            fechaXTorneo.Torneo.IdTorneo = Int32.Parse(cboTorneo.SelectedValue.ToString());

            if (ValidarRepetidos(fechaXTorneo))
            {
                if (fechaXTorneoService.modificar(fechaXTorneo, fechaSeleccionada, torneoSeleccionado))
                {
                    MessageBox.Show("Registro modificado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmConsultarAsignarFecha frmConsultarAsignarFecha = Owner as FrmConsultarAsignarFecha;
                    frmConsultarAsignarFecha.ActualizarGrilla();
                }
                else
                {
                    MessageBox.Show("Registro no modificado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                this.Close();
            }
            
        }

        public bool ValidarRepetidos(FechaXTorneo oFechaxTorneo)
        {
            if (cambioDatos())
            {
                if (fechaXTorneoService.obtenerRepetidos(oFechaxTorneo))
                {
                    MessageBox.Show("Ya existe registro con los mismos datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private bool cambioDatos()
        {
            if (nombreFecha == cboFecha.Text && nombreTorneo==cboTorneo.Text)
            {
                return false;
            }
            return true;
        }

    }
}
