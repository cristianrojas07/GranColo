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

namespace GranColo.GUILayer.Clubes.Jugadores
{
    public partial class FrmABMPuntajeJugadores : Form
    {
        readonly TorneoService TorneoService;
        readonly FechaService FechaService;
        readonly ClubService ClubService;
        readonly JugadorService JugadorService;
        readonly PosicionService PosicionService;

        public FrmABMPuntajeJugadores()
        {
            InitializeComponent();
            dgv_jugadores.AutoGenerateColumns = false;
            TorneoService = new TorneoService();
            FechaService = new FechaService();
            ClubService = new ClubService();
            JugadorService = new JugadorService();
            PosicionService = new PosicionService();
            LlenarCombo(cbo_torneo, TorneoService.obtenerTodosTorneos(), "Nombre", "IdTorneo");
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

        private void cbo_torneo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbo_torneo.SelectedItem != null)
            {
                cbo_fecha.Enabled = true;
                var idTorneo = (int)cbo_torneo.SelectedValue;
                LlenarCombo(cbo_fecha, FechaService.obtenerFechaPorTorneo(idTorneo), "Nombre", "IdFecha");
                dgv_jugadores.DataSource = null;
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                int idTorneo = (int)cbo_torneo.SelectedValue;
                int idFecha = (int)cbo_fecha.SelectedValue;
                List<Jugador> listJugadores = new List<Jugador>();
                if (dgv_jugadores.Rows.Count != 0)
                {
                    if (validarCeldasNull())
                    {
                        foreach (DataGridViewRow row in dgv_jugadores.Rows)
                        {
                            if (row.Cells["col_puntaje"].Value != null)
                            {
                                Jugador jugador = new Jugador();
                                jugador.IdJugador = (int)row.Cells["col_id"].Value;
                                jugador.Puntaje = Int32.Parse(row.Cells["col_puntaje"].Value.ToString());
                                listJugadores.Add(jugador);
                            }
                        }
                        if (JugadorService.insertarPuntajeJugador(listJugadores, idFecha, idTorneo))
                        {
                            MessageBox.Show("Puntajes agregados con éxito!.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ReiniciarFormPuntaje();
                        }
                        else
                        {
                            MessageBox.Show("Error, puntaje no agregado!.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor agregue puntaje a un jugador..", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No hay jugadores para puntuar..", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ReiniciarFormPuntaje()
        {
            cbo_fecha.SelectedIndex = -1;
            cbo_torneo.SelectedIndex = -1;
            cb_todos.Checked = true;
            dgv_jugadores.DataSource = null;
        }

        private bool validarCeldasNull()
        {
            foreach (DataGridViewRow row in dgv_jugadores.Rows)
            {
                if (row.Cells["col_puntaje"].Value != null)
                {
                    return true;
                }
            }
            return false;
        }

        private bool validarCampos()
        {
            if (cbo_torneo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un torneo..", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbo_torneo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una fecha..", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (validarFechaYTorneo())
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("idTorneo", cbo_torneo.SelectedValue.ToString());
                parametros.Add("nroFecha", cbo_fecha.SelectedValue.ToString());
                if (!cb_todos.Checked)
                {
                    parametros.Add("costoDesde", nud_min.Value);
                    parametros.Add("costoHasta", nud_max.Value);
                    parametros.Add("nombre", "%" + txt_nombre.Text + "%");
                    parametros.Add("apellido", "%" + txt_apellido.Text + "%");
                    if (cb_posicion.SelectedIndex != -1)
                    {
                        parametros.Add("idPosicion", cb_posicion.SelectedValue.ToString());
                    }
                    if (cb_club.SelectedIndex != -1)
                    {
                        parametros.Add("idClub", cb_club.SelectedValue.ToString());
                    }
                    IList<Jugador> listadoJugadores = JugadorService.ConsultarJugadoresConPuntaje(parametros);
                    dgv_jugadores.DataSource = listadoJugadores;

                    if (dgv_jugadores.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron jugadores con esos filtros!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    IList<Jugador> listTodosJugadores = JugadorService.ObtenerTodosJugadoresConPuntaje(parametros);
                    dgv_jugadores.DataSource = listTodosJugadores;
                    if (dgv_jugadores.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron jugadores puntuados en la fecha: " + cbo_fecha.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private bool validarFechaYTorneo()
        {
            if (cbo_torneo.SelectedIndex == -1)
            {
                MessageBox.Show("Elija un torneo..", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (cbo_fecha.SelectedIndex == -1)
            {
                MessageBox.Show("Elija una fecha..", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void cb_todos_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_todos.Checked)
            {
                cb_club.Enabled = false;
                cb_posicion.Enabled = false;
                txt_apellido.Enabled = false;
                txt_nombre.Enabled = false;
                nud_max.Enabled = false;
                nud_min.Enabled = false;
            }
            else
            {
                cb_club.Enabled = true;
                cb_posicion.Enabled = true;
                txt_apellido.Enabled = true;
                txt_nombre.Enabled = true;
                nud_min.Enabled = true;
                nud_max.Enabled = true;
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dgv_jugadores.CurrentRow != null)
            {
                Jugador jugador = new Jugador();
                jugador.IdJugador = Int32.Parse(dgv_jugadores.CurrentRow.Cells["col_id"].Value.ToString());
                jugador.Puntaje = Int32.Parse(dgv_jugadores.CurrentRow.Cells["col_puntaje"].Value.ToString());
                int nroFecha = (int)cbo_fecha.SelectedValue;
                int idTorneo = (int)cbo_torneo.SelectedValue;
                FrmEditarPuntaje frmEditarPuntaje = new FrmEditarPuntaje(jugador, nroFecha, idTorneo);
                frmEditarPuntaje.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Primero debe seleccionar un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbo_fecha_SelectedValueChanged(object sender, EventArgs e)
        {
            dgv_jugadores.DataSource = null;
        }

        private void ActualizarGrilla()
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("idTorneo", cbo_torneo.SelectedValue.ToString());
            parametros.Add("nroFecha", cbo_fecha.SelectedValue.ToString());
            if (!cb_todos.Checked)
            {
                parametros.Add("costoDesde", nud_min.Value);
                parametros.Add("costoHasta", nud_max.Value);
                parametros.Add("nombre", "%" + txt_nombre.Text + "%");
                parametros.Add("apellido", "%" + txt_apellido.Text + "%");
                if (cb_posicion.SelectedIndex != -1)
                {
                    parametros.Add("idPosicion", cb_posicion.SelectedValue.ToString());
                }
                if (cb_club.SelectedIndex != -1)
                {
                    parametros.Add("idClub", cb_club.SelectedValue.ToString());
                }
            }
            IList<Jugador> listadoJugadores = JugadorService.ConsultarJugadoresConPuntaje(parametros);
            dgv_jugadores.DataSource = listadoJugadores;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_jugadores.CurrentRow != null)
            {
                if (MessageBox.Show("Seguro que desea eliminar el puntaje del jugador?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Jugador jugador = new Jugador();
                    jugador.IdJugador = Int32.Parse(dgv_jugadores.CurrentRow.Cells["col_id"].Value.ToString());
                    jugador.Puntaje = Int32.Parse(dgv_jugadores.CurrentRow.Cells["col_puntaje"].Value.ToString());
                    int nroFecha = (int)cbo_fecha.SelectedValue;
                    int idTorneo = (int)cbo_torneo.SelectedValue;
                    if (JugadorService.EliminarPuntajeJugador(jugador, nroFecha, idTorneo))
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

        private void FrmABMPuntajeJugadores_Load(object sender, EventArgs e)
        {
            cbo_fecha.Enabled = false;
        }
    }
}
