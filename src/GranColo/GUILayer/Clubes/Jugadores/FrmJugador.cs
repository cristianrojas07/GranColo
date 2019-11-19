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

namespace GranColo.GUILayer.Equipos.Jugadores
{
    public partial class FrmJugador : Form
    {
        private readonly JugadorService JugadorService;
        private readonly ClubService ClubService;
        private readonly PosicionService PosicionService;

        public FrmJugador()
        {
            InitializeComponent();
            dgvJugadores.AutoGenerateColumns = false;
            JugadorService = new JugadorService();
            ClubService = new ClubService();
            PosicionService = new PosicionService();
            LlenarCombo(cb_club, ClubService.ObtenerTodosClubes(), "Nombre", "IdClub");
            LlenarCombo(cb_posicion, PosicionService.ObtenerTodosPosiciones(), "Nombre", "IdPosicion");
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
                txt_nombre.Enabled = false;
                txt_apellido.Enabled = false;
                cb_club.Enabled = false;
                cb_posicion.Enabled = false;
                nud_min.Enabled = false;
                nud_max.Enabled = false;
            }
            else
            {
                txt_nombre.Enabled = true;
                txt_apellido.Enabled = true;
                cb_club.Enabled = true;
                cb_posicion.Enabled = true;
                nud_min.Enabled = true;
                nud_max.Enabled = true;
            }
                
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            if (!cb_todos.Checked)
            {
                if (ValidarCampos())
                {
                    Dictionary<string, object> parametros = new Dictionary<string, object>();
                    parametros.Add("costoDesde", nud_min.Value);
                    parametros.Add("costoHasta", nud_max.Value);
                    if (!String.IsNullOrEmpty(txt_nombre.Text))
                    {
                        parametros.Add("nombre", "%" + txt_nombre.Text + "%");
                    }
                    if (!String.IsNullOrEmpty(txt_nombre.Text))
                    {
                        parametros.Add("apellido", "%" + txt_apellido.Text + "%");
                    }
                    if (cb_posicion.SelectedIndex != -1)
                    {
                        parametros.Add("idPosicion", cb_posicion.SelectedValue.ToString());
                    }
                    if (cb_club.SelectedIndex != -1)
                    {
                        parametros.Add("idClub", cb_club.SelectedValue.ToString());
                    }

                    IList<Jugador> listadoJugadores = JugadorService.ConsultarJugadoresConFiltros(parametros);
                    dgvJugadores.DataSource = listadoJugadores;

                    if (dgvJugadores.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                IList<Jugador> listTodosJugadores = JugadorService.ObtenerTodosJugadores();
                dgvJugadores.DataSource = listTodosJugadores;
                if (dgvJugadores.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool ValidarCampos()
        {
            if (String.IsNullOrEmpty(nud_min.Value.ToString()))
            {
                MessageBox.Show("Los rangos del costo son campos obligatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (String.IsNullOrEmpty(nud_max.Value.ToString()))
            {
                MessageBox.Show("Los rangos del costo son campos obligatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;

            /*if (ValidarTextBoxVacio(txt_nombre, "Se debe ingresar un nombre") &&
                ValidarTextBoxVacio(txt_apellido, "Se debe ingresar un apellido") &&
                ValidarComboBoxVacio(cb_club, "Se debe elegir un club") &&
                ValidarComboBoxVacio(cb_posicion, "Se debe elegir una posicion para el jugador"))
                return true;
            return false;*/
        }

        private bool ValidarTextBoxVacio(TextBox textBox, String mensaje)
        {
            if (String.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private bool ValidarComboBoxVacio(ComboBox comboBox, String mensaje)
        {
            if (comboBox.SelectedIndex != -1)
                return true;
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            FrmABMJugador frmABMJugador = new FrmABMJugador();
            AddOwnedForm(frmABMJugador);
            frmABMJugador.ShowDialog();
        }

        public void ActualizarGrilla()
        {
            IList<Jugador> listTodosJugadores = JugadorService.ObtenerTodosJugadores();
            dgvJugadores.DataSource = listTodosJugadores;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dgvJugadores.CurrentRow != null)
            {
                FrmABMJugador frmABMJugador = new FrmABMJugador();
                AddOwnedForm(frmABMJugador);
                JugadorService.Selected = Int32.Parse(dgvJugadores.CurrentRow.Cells["id_col"].Value.ToString());
                frmABMJugador.DeterminarOperacion(FrmABMJugador.FormMode.update, JugadorService);
                frmABMJugador.ShowDialog();
            }
            else
            {
                MessageBox.Show("Primero debe seleccionar un registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgvJugadores.CurrentRow != null)
            {
                if (MessageBox.Show("Seguro que desea eliminar el jugador?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    JugadorService.Selected = Int32.Parse(dgvJugadores.CurrentRow.Cells["id_col"].Value.ToString());
                    if (JugadorService.EliminarJugador())
                    {
                        MessageBox.Show("Jugador eliminado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Error, jugador no eliminado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
            else
            {
                MessageBox.Show("Primero debe seleccionar un registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
