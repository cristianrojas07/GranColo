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

        public void Btn_consultar_Click(object sender, EventArgs e)
        {
            if (cb_todos.Checked)
            {
                IList<Fecha> listTodasFechas = service.obtenerTodasFechas();
                if (listTodasFechas.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgw_fecha.Rows.Clear();
                foreach (Fecha fecha in listTodasFechas)
                {
                    dgw_fecha.Rows.Add(new Object[] { fecha.idFecha.ToString(), fecha.nombre, fecha.estado });
                }
            }
            else
            {
                if (validarCampos())
                {
                    Fecha oFecha = new Fecha();
                    oFecha.nombre = txt_nombre.Text;
                    IList<Fecha> list = service.obtenerFechasPorNombre(oFecha);
                    if (list.Count == 0)
                    {
                        MessageBox.Show("No se encontraron registros en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dgw_fecha.Rows.Clear();
                    foreach (Fecha fecha in list)
                    {
                        dgw_fecha.Rows.Add(new Object[] { fecha.idFecha.ToString(), fecha.nombre, fecha.estado });
                    }
                }
                
            }
        }

        public void Btn_editar_Click(object sender, EventArgs e)
        {
            if (dgw_fecha.CurrentRow != null)
            {
                FrmABMFecha frmABMFecha = new FrmABMFecha();
                Fecha oFecha = (Fecha)dgw_fecha.CurrentRow.DataBoundItem;
                frmABMFecha.determinarOperacion(FrmABMFecha.FormMode.update, oFecha);
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
            frmABMFecha.ShowDialog();
        }

        private void FrmFecha_Load(object sender, EventArgs e)
        {
            cb_todos.Checked = true;
        }

        
    }
}
