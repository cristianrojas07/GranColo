﻿using GranColo.BusinessLayer.Entities;
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
        TorneoService service;
        public FrmTorneo()
        {
            service = new TorneoService();
            InitializeComponent();
        }

        internal void CargarGrid(IList<Torneo> listTodosTorneos)
        {
            dgw_torneo.Rows.Clear();
            foreach (Torneo torneo in listTodosTorneos)
            {
                dgw_torneo.Rows.Add(new Object[] { torneo.IdTorneo.ToString(), torneo.Nombre, torneo.Estado });
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
                    if (list.Count == 0)
                    {
                        MessageBox.Show("No se encontraron registros en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    CargarGrid(list);
                }
            }
            else
            {
                IList<Torneo> listTodosTorneos = service.obtenerTodosTorneos();
                if (listTodosTorneos.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                CargarGrid(listTodosTorneos);
            }
        }

        public void actualizarGrilla()
        {
            IList<Torneo> listTodosTorneos = service.obtenerTodosTorneos();
            CargarGrid(listTodosTorneos);
        }

        public void Btn_editar_Click(object sender, EventArgs e)
        {
            if (dgw_torneo.CurrentRow != null)
            {
                FrmABMTorneo frmABMTorneo = new FrmABMTorneo();
                service.selected = Int32.Parse(dgw_torneo.CurrentRow.Cells["id_col"].Value.ToString());
                frmABMTorneo.determinarOperacion(FrmABMTorneo.FormMode.update, service);
                frmABMTorneo.ShowDialog();
                actualizarGrilla();
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
                        actualizarGrilla();
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

        public void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool ValidarCampos()
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
            FrmABMTorneo frmABMTorneo = new FrmABMTorneo();
            AddOwnedForm(frmABMTorneo);
            frmABMTorneo.ShowDialog();
        }

        private void cb_todos_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_todos.Checked)
                txt_nombre.Enabled = false;
            else
                txt_nombre.Enabled = true;
        }
    }
}
