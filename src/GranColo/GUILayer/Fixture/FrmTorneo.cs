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
    public partial class FrmTorneo : Form, InterfazFixture
    {
        readonly TorneoService service;

        public FrmTorneo()
        {
            InitializeComponent();
            service = new TorneoService();
            dgw_torneo.AutoGenerateColumns = false;
        }

        //-----------------------BOTONES ABM--------------------------------//
        public void Btn_agregar_Click(object sender, EventArgs e)
        {
            FrmABMTorneo frmABMTorneo = new FrmABMTorneo();
            AddOwnedForm(frmABMTorneo);
            frmABMTorneo.ShowDialog();
        }

        public void Btn_editar_Click(object sender, EventArgs e)
        {
            if (dgw_torneo.CurrentRow != null)
            {
                FrmABMTorneo frmABMTorneo = new FrmABMTorneo();
                AddOwnedForm(frmABMTorneo);
                service.selected = Int32.Parse(dgw_torneo.CurrentRow.Cells["id_col"].Value.ToString());
                frmABMTorneo.DeterminarOperacion(FrmABMTorneo.FormMode.update, service);
                frmABMTorneo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Primero debe seleccionar un registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgw_torneo.CurrentRow != null)
            {
                if (MessageBox.Show("Seguro que desea eliminar la fecha?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    service.selected = Int32.Parse(dgw_torneo.CurrentRow.Cells["id_col"].Value.ToString());
                    if (service.eliminarTorneo())
                    {
                        MessageBox.Show("Torneo eliminado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Error, torneo no eliminado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
            else
            {
                MessageBox.Show("Primero debe seleccionar un registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Btn_consultar_Click(object sender, EventArgs e)
        {
            if (!cb_todos.Checked)
            {
                if (ValidarCampos())
                {
                    Torneo oTorneo = new Torneo();
                    oTorneo.Nombre = txt_nombre.Text;
                    IList<Torneo> list = service.obtenerTorneosPorNombre(oTorneo);
                    dgw_torneo.DataSource = list;
                    if (dgw_torneo.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron registros en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                IList<Torneo> listTodosTorneos = service.obtenerTodosTorneos();
                dgw_torneo.DataSource = listTodosTorneos;
                if (dgw_torneo.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //----------------------------------------------------------------------//

        //-----------------------VALIDACIONES--------------------------------//
        public bool ValidarCampos()
        {
            if (String.IsNullOrEmpty(txt_nombre.Text))
            {
                MessageBox.Show("Se debe ingresar un nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        //----------------------------------------------------------------------//

        //-----------------------OTRAS FUNCIONES--------------------------------//
        public void ActualizarGrilla()
        {
            IList<Torneo> listTodosTorneos = service.obtenerTodosTorneos();
            dgw_torneo.DataSource = listTodosTorneos;
        }

        private void cb_todos_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_todos.Checked)
                txt_nombre.Enabled = false;
            else
                txt_nombre.Enabled = true;
        }
        //----------------------------------------------------------------------//
    }
}
