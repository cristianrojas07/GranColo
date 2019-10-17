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
    public partial class FrmConsultarAsignarFecha : Form
    {
        private readonly FechaXTorneoService fechaXTorneoService;
        private readonly TorneoService torneoService;

        public FrmConsultarAsignarFecha()
        {
            InitializeComponent();
            torneoService = new TorneoService();
            fechaXTorneoService = new FechaXTorneoService();
            dgw_asignadas.AutoGenerateColumns = false;
            LlenarCombo(cbo_torneo, torneoService.obtenerTodosTorneos(), "Nombre", "IdTorneo");
        }

        //-----------------------BOTONES ABM--------------------------------//
        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (dgw_asignadas.CurrentRow != null)
            {
                FechaXTorneo fechaXTorneo = new FechaXTorneo();
                fechaXTorneo.Fecha = new Fecha();
                fechaXTorneo.Torneo = new Torneo();
                fechaXTorneo.Fecha.IdFecha = Int32.Parse(dgw_asignadas.CurrentRow.Cells["id_fecha_col"].Value.ToString());
                fechaXTorneo.Torneo.IdTorneo = Int32.Parse(dgw_asignadas.CurrentRow.Cells["id_torneo_col"].Value.ToString());
                fechaXTorneo.Fecha.Nombre = dgw_asignadas.CurrentRow.Cells["nombre_fecha_col"].Value.ToString();
                fechaXTorneo.Torneo.Nombre = dgw_asignadas.CurrentRow.Cells["nombre_torneo_col"].Value.ToString();
                FrmEditarAsignacion frmEditarAsignacion = new FrmEditarAsignacion(fechaXTorneo);
                AddOwnedForm(frmEditarAsignacion);
                frmEditarAsignacion.ShowDialog();
            }
            else
            {
                MessageBox.Show("Primero debe seleccionar un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgw_asignadas.CurrentRow!=null)
            {
                if(MessageBox.Show("Esta seguro que desea eliminar el registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FechaXTorneo fechaXTorneo = new FechaXTorneo();
                    fechaXTorneo.Fecha = new Fecha();
                    fechaXTorneo.Torneo = new Torneo();
                    fechaXTorneo.Fecha.IdFecha = Int32.Parse(dgw_asignadas.CurrentRow.Cells["id_fecha_col"].Value.ToString());
                    fechaXTorneo.Torneo.IdTorneo = Int32.Parse(dgw_asignadas.CurrentRow.Cells["id_torneo_col"].Value.ToString());
                    if (fechaXTorneoService.eliminar(fechaXTorneo))
                    {
                        MessageBox.Show("Registro eliminado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registro no eliminado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Primero debe seleccionar un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            if (cb_todos.Checked)
            {
                IList<FechaXTorneo> list = fechaXTorneoService.obtenerTodos();
                dgw_asignadas.DataSource = list;
                if (dgw_asignadas.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (ValidarCampos())
                {
                    Torneo torneo = new Torneo();
                    torneo.IdTorneo = Int32.Parse(cbo_torneo.SelectedValue.ToString());
                    IList<FechaXTorneo> list = fechaXTorneoService.obtenerRegistrosConFiltros(torneo);
                    dgw_asignadas.DataSource = list;
                    if (dgw_asignadas.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron registros en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //----------------------------------------------------------------------//

        //-----------------------VALIDACIONES--------------------------------//
        public bool ValidarCampos()
        {
            if (String.IsNullOrEmpty(cbo_torneo.Text))
            {
                MessageBox.Show("Debe seleccionar un torneo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        //----------------------------------------------------------------------//

        //-----------------------SHOW FORM ABM--------------------------------//
        private void FrmAMBAsignarFecha_Load(object sender, EventArgs e)
        {
            cb_todos.Checked = true;
        }
        //----------------------------------------------------------------------//

        //-----------------------OTRAS FUNCIONES--------------------------------//
        public void ActualizarGrilla()
        {
            if (cb_todos.Checked)
            {
                IList<FechaXTorneo> list = fechaXTorneoService.obtenerTodos();
                dgw_asignadas.DataSource = list;
            }
            else
            {
                Torneo torneo = new Torneo();
                torneo.IdTorneo = Int32.Parse(cbo_torneo.SelectedValue.ToString());
                IList<FechaXTorneo> list = fechaXTorneoService.obtenerRegistrosConFiltros(torneo);
                dgw_asignadas.DataSource = list;
            }
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }

        private void Cb_todos_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_todos.Checked)
            {
                cbo_torneo.Enabled = false;
            }
            else
            {
                cbo_torneo.Enabled = true;
            }
        }
        //----------------------------------------------------------------------//
    }
}
