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
    public partial class FrmFixture : Form
    {
        public int modo { get; set; }
        FechaService fechaService;
        TorneoService torneoService;

        public FrmFixture(int modo)
        {
            this.modo = modo;
            fechaService = new FechaService();
            torneoService = new TorneoService();
            InitializeComponent();
            setGroupBox(modo);
        }




        public void setGroupBox(int modo)
        {
            if (modo==1)
            {
                gb_titulo.Text = "Fecha";
            }
            else
            {
                gb_titulo.Text = "Torneo";
            }
        }
        public string determinarModo(int modo)
        {
            switch (modo)
            {
                case 1:
                    return "fecha";
                case 2:
                    return "torneo";
                default:
                    return "";
            }
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            
            if (String.Equals("fecha", determinarModo(modo)))
            {
                if (cb_todos.Checked)
                {
                    IList<Fecha> listTodasFechas = fechaService.obtenerTodasFechas();
                    if (listTodasFechas.Count==0)
                    {
                        MessageBox.Show("No se encontraron registros en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dgw_fecha_torneo.Rows.Clear();
                    foreach (Fecha fecha in listTodasFechas)
                    {
                        dgw_fecha_torneo.Rows.Add(new Object[] { fecha.idFecha.ToString(), fecha.nombre, fecha.estado });
                    }
                }
                else
                {
                    if (!validarCampos())
                    {
                        return;
                    }
                    Fecha oFecha = new Fecha();
                    oFecha.nombre = txt_nombre.Text;
                    IList<Fecha> list = fechaService.obtenerFechasPorNombre(oFecha);
                    if (list.Count == 0)
                    {
                        MessageBox.Show("No se encontraron registros en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dgw_fecha_torneo.Rows.Clear();
                    foreach (Fecha fecha in list)
                    {
                        dgw_fecha_torneo.Rows.Add(new Object[] { fecha.idFecha.ToString(), fecha.nombre, fecha.estado });
                    }
                }
            }
            if (String.Equals("torneo", determinarModo(modo)))
            {
                if (cb_todos.Checked)
                {
                    IList<Torneo> listTodosTorneos = torneoService.obtenerTodosTorneos();
                    if (listTodosTorneos.Count == 0)
                    {
                        MessageBox.Show("No se encontraron registros en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dgw_fecha_torneo.Rows.Clear();
                    foreach (Torneo torneo in listTodosTorneos)
                    {
                        dgw_fecha_torneo.Rows.Add(new Object[] { torneo.idFecha.ToString(), torneo.nombre, torneo.estado });
                    }
                }
                else
                {
                    if (!validarCampos())
                    {
                        return;
                    }
                    Torneo oTorneo = new Torneo();
                    oTorneo.nombre = txt_nombre.Text;
                    IList<Torneo> list = torneoService.obtenerTorneosPorNombre(oTorneo);
                    if (list.Count == 0)
                    {
                        MessageBox.Show("No se encontraron registros en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dgw_fecha_torneo.Rows.Clear();
                    foreach (Torneo torneo in list)
                    {
                        dgw_fecha_torneo.Rows.Add(new Object[] { torneo.idFecha.ToString(), torneo.nombre, torneo.estado });
                    }
                }
            }
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            FrmABMFixture frmABMFixture = new FrmABMFixture(modo, 1);
            frmABMFixture.ShowDialog();
            dgw_fecha_torneo.Rows.Clear();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (dgw_fecha_torneo.CurrentRow != null)
            {
                switch (determinarModo(modo))
                {
                    case "fecha":
                        fechaService.selected = Int32.Parse(dgw_fecha_torneo.CurrentRow.Cells["id_col"].Value.ToString());
                        FrmABMFixture frmABMFixtureFecha = new FrmABMFixture(modo, 2, fechaService);
                        frmABMFixtureFecha.ShowDialog();
                        break;
                    case "torneo":
                        torneoService.selected = Int32.Parse(dgw_fecha_torneo.CurrentRow.Cells["id_col"].Value.ToString());
                        FrmABMFixture frmABMFixtureTorneo = new FrmABMFixture(modo, 2, torneoService);
                        frmABMFixtureTorneo.ShowDialog();
                        break;
                }

            }
            else
            {
                MessageBox.Show("Primero debe seleccionar un registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgw_fecha_torneo.Rows.Clear();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgw_fecha_torneo.CurrentRow != null)
            {
                switch (determinarModo(modo))
                {
                    case "fecha":
                        if (MessageBox.Show("Seguro que desea eliminar la fecha?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            fechaService.selected = Int32.Parse(dgw_fecha_torneo.CurrentRow.Cells["id_col"].Value.ToString());
                            if (fechaService.eliminarFecha())
                            {
                                MessageBox.Show("Fecha elminada con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }else
                            {
                                MessageBox.Show("Error, fecha no eliminada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        break;
                    case "torneo":
                        if (MessageBox.Show("Seguro que desea eliminar el torneo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            torneoService.selected = Int32.Parse(dgw_fecha_torneo.CurrentRow.Cells["id_col"].Value.ToString());
                            if (torneoService.eliminarFecha())
                            {
                                MessageBox.Show("Torneo elminado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error, torneo no eliminado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        break;
                }

            }
            else
            {
                MessageBox.Show("Primero debe seleccionar un registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgw_fecha_torneo.Rows.Clear();
        }

        public bool validarCampos()
        {
            if (String.IsNullOrEmpty(txt_nombre.Text))
            {
                MessageBox.Show("Se tiene que ingresar un nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
    }
}
