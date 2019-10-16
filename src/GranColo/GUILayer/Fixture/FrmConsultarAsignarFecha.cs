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
        private FechaXTorneoService fechaXTorneoService;
        private TorneoService torneoService;
        public FrmConsultarAsignarFecha()
        {
            torneoService = new TorneoService();
            fechaXTorneoService = new FechaXTorneoService();
            InitializeComponent();
            llenarCombo(cbo_torneo, torneoService.obtenerTodosTorneos(), "Nombre", "IdTorneo");
             
        }
        private void llenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (dgw_asignadas.CurrentRow != null)
            {
                FechaXTorneo fechaXTorneo = new FechaXTorneo
                {
                    Fecha = new Fecha(),
                    Torneo = new Torneo()
                };
                fechaXTorneo.Fecha.IdFecha = Int32.Parse(dgw_asignadas.CurrentRow.Cells["id_fecha_col"].Value.ToString());
                fechaXTorneo.Torneo.IdTorneo = Int32.Parse(dgw_asignadas.CurrentRow.Cells["id_torneo_col"].Value.ToString());
                fechaXTorneo.Fecha.Nombre = dgw_asignadas.CurrentRow.Cells["nombre_fecha_col"].Value.ToString();
                fechaXTorneo.Torneo.Nombre = dgw_asignadas.CurrentRow.Cells["nombre_torneo_col"].Value.ToString();
                FrmEditarAsignacion frmEditarAsignacion = new FrmEditarAsignacion(fechaXTorneo);
                frmEditarAsignacion.ShowDialog();
            }
            ActualizarGrilla();
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgw_asignadas.CurrentRow!=null)
            {
                if(MessageBox.Show("Esta seguro que desea eliminar el registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FechaXTorneo fechaXTorneo = new FechaXTorneo
                    {
                        Fecha = new Fecha(),
                        Torneo = new Torneo()
                    };
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

        public void ActualizarGrilla()
        {
            if (cb_todos.Checked)
            {
                IList<FechaXTorneo> list = fechaXTorneoService.obtenerTodos();
                CargarGrid(list);
            }
            else
            {
                Torneo torneo = new Torneo
                {
                    IdTorneo = Int32.Parse(cbo_torneo.SelectedValue.ToString())
                };
                IList<FechaXTorneo> list = fechaXTorneoService.obtenerRegistrosConFiltros(torneo);
                CargarGrid(list);
            }
        }

        private void FrmAMBAsignarFecha_Load(object sender, EventArgs e)
        {
            cb_todos.Checked = true;
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            if(cb_todos.Checked)
            {
                IList<FechaXTorneo> list = fechaXTorneoService.obtenerTodos();
                if (list.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                CargarGrid(list);
            }
            else
            {
                if (ValidarCampos())
                {
                    Torneo torneo = new Torneo
                    {
                        IdTorneo = Int32.Parse(cbo_torneo.SelectedValue.ToString())
                    };
                    IList<FechaXTorneo> list = fechaXTorneoService.obtenerRegistrosConFiltros(torneo);
                    if (list.Count == 0)
                    {
                        MessageBox.Show("No se encontraron registros en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    CargarGrid(list);
                }
            }
        }

        

        internal void CargarGrid(IList<FechaXTorneo> list)
        {
            dgw_asignadas.Rows.Clear();
            foreach (FechaXTorneo item in list)
            {
                dgw_asignadas.Rows.Add(new Object[] { item.Torneo.Nombre.ToString(), item.Torneo.IdTorneo.ToString(), item.Fecha.IdFecha.ToString(), item.Fecha.Nombre.ToString() });
            }
        }

        public bool ValidarCampos()
        {
            if (String.IsNullOrEmpty(cbo_torneo.Text))
            {
                MessageBox.Show("Debe seleccionar un torneo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
