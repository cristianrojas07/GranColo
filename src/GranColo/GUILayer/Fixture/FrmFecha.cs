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
    public partial class FrmFecha : Form, InterfazFixture
    {
        readonly FechaService service;

        public FrmFecha()
        {
            InitializeComponent();
            service = new FechaService();
            dgw_fecha.AutoGenerateColumns = false;
        }

        //-----------------------BOTONES ABM--------------------------------//
        public void Btn_agregar_Click(object sender, EventArgs e)
        {
            FrmABMFecha frmABMFecha = new FrmABMFecha();
            AddOwnedForm(frmABMFecha);
            frmABMFecha.ShowDialog();
        }

        public void Btn_consultar_Click(object sender, EventArgs e)
        {
            if (!cb_todos.Checked)
            {
                if (ValidarCampos())
                {
                    Fecha oFecha = new Fecha();
                    oFecha.Nombre = txt_nombre.Text;
                    IList<Fecha> list = service.obtenerFechasPorNombre(oFecha);
                    dgw_fecha.DataSource = list;
                    if (list.Count == 0)
                    {
                        MessageBox.Show("No se encontraron registros en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                IList<Fecha> listTodasFechas = service.obtenerTodasFechas();
                dgw_fecha.DataSource = listTodasFechas;
                if (dgw_fecha.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void Btn_editar_Click(object sender, EventArgs e)
        {
            if (dgw_fecha.CurrentRow != null)
            {
                FrmABMFecha frmABMFecha = new FrmABMFecha();
                AddOwnedForm(frmABMFecha);
                service.selected = Int32.Parse(dgw_fecha.CurrentRow.Cells["id_col"].Value.ToString());
                frmABMFecha.DeterminarOperacion(FrmABMFecha.FormMode.update, service);
                frmABMFecha.ShowDialog();
            }
            else
            {
                MessageBox.Show("Primero debe seleccionar un registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgw_fecha.CurrentRow != null)
            {
                if (MessageBox.Show("Seguro que desea eliminar la fecha?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    service.selected = Int32.Parse(dgw_fecha.CurrentRow.Cells["id_col"].Value.ToString());
                    if (service.eliminarFecha())
                    {
                        MessageBox.Show("Fecha elminada con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Error, fecha no eliminada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
            else
            {
                MessageBox.Show("Primero debe seleccionar un registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            IList<Fecha> listTodasFechas = service.obtenerTodasFechas();
            dgw_fecha.DataSource = listTodasFechas;
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
