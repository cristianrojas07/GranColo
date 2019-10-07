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
        FechaService service;
        public FrmFecha()
        {
            service = new FechaService();
            InitializeComponent();
        }

        internal void CargarGrid(IList<Fecha> listTodasFechas)
        {
            dgw_fecha.Rows.Clear();
            foreach (Fecha fecha in listTodasFechas)
            {
                dgw_fecha.Rows.Add(new Object[] { fecha.IdFecha.ToString(), fecha.Nombre, fecha.Estado });
            }
        }

        public void Btn_consultar_Click(object sender, EventArgs e)
        {
            if (!cb_todos.Checked)
            {
                if (validarCampos())
                {
                    Fecha oFecha = new Fecha();
                    oFecha.Nombre = txt_nombre.Text;
                    IList<Fecha> list = service.obtenerFechasPorNombre(oFecha);
                    if (list.Count == 0)
                    {
                        MessageBox.Show("No se encontraron registros en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    CargarGrid(list);
                }
            }
            else
            {
                IList<Fecha> listTodasFechas = service.obtenerTodasFechas();
                if (listTodasFechas.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                CargarGrid(listTodasFechas);
            }
        }

        public void actualizarGrilla()
        {
            IList<Fecha> listTodasFechas = service.obtenerTodasFechas();
            CargarGrid(listTodasFechas);
        }

        public void Btn_editar_Click(object sender, EventArgs e)
        {
            if (dgw_fecha.CurrentRow != null)
            {
                FrmABMFecha frmABMFecha = new FrmABMFecha();
                
                service.selected = Int32.Parse(dgw_fecha.CurrentRow.Cells["id_col"].Value.ToString());
                frmABMFecha.determinarOperacion(FrmABMFecha.FormMode.update, service);
                frmABMFecha.ShowDialog();
                actualizarGrilla();
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
                        actualizarGrilla();
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

        public bool validarCampos()
        {
            if (String.IsNullOrEmpty(txt_nombre.Text))
            {
                MessageBox.Show("Se debe ingresar un nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        public void Btn_agregar_Click(object sender, EventArgs e)
        {
            FrmABMFecha frmABMFecha = new FrmABMFecha();
            AddOwnedForm(frmABMFecha);
            frmABMFecha.ShowDialog();
        }
    }
}
