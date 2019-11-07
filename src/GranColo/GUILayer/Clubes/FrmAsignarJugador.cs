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

namespace GranColo.GUILayer.Clubes
{
    public partial class FrmAsignarJugador : Form
    {
        private readonly JugadorService JugadorService;
        private readonly EquipoService EquipoService;
        private readonly PosicionService PosicionService;
        private readonly ClubService ClubService;

        public FrmAsignarJugador()
        {
            InitializeComponent();
            JugadorService = new JugadorService();
            EquipoService = new EquipoService();
            ClubService = new ClubService();
            PosicionService = new PosicionService();
            Cargar_comboBox(cbo_equipo, EquipoService.obtenerTodos(), "nombre", "idEquipo");
            Cargar_comboBox(cb_posicion, PosicionService.ObtenerTodosPosiciones(), "nombre", "idPosicion");
            Cargar_comboBox(cb_club, ClubService.ObtenerTodosClubes(), "nombre", "idClub");
            
        }

        private void Cargar_comboBox(ComboBox comboBox, object dataSource, string displayMember, string valueMember)
        {
            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            comboBox.SelectedIndex = -1;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_todos_CheckedChanged(object sender, EventArgs e)
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

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (!cb_todos.Checked)
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("costoDesde", nud_min.Value);
                parametros.Add("costoHasta", nud_max.Value);
                if(cb_posicion.SelectedIndex != -1)
                    parametros.Add("idPosicion", cb_posicion.SelectedValue.ToString());
                if (cb_club.SelectedIndex != -1)
                    parametros.Add("idClub", cb_club.SelectedValue.ToString());
                if (!String.IsNullOrWhiteSpace(txt_nombre.Text))
                    parametros.Add("nombre", "%" + txt_nombre.Text.ToString() + "%");
                if (!String.IsNullOrWhiteSpace(txt_apellido.Text))
                    parametros.Add("apellido", "%" + txt_apellido.Text.ToString() + "%");

                dgv_jugadores.Rows.Clear();
                IList<Jugador> listadoJugadores = JugadorService.ConsultarJugadoresConFiltros(parametros);
                if (listadoJugadores.Count==0)
                {
                    MessageBox.Show("No se encontraron registros en la BD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                foreach (Jugador jug in listadoJugadores)
                {
                    dgv_jugadores.Rows.Add(new Object[] { jug.IdJugador, jug.PosicionNombre.ToString(), jug.Nombre, jug.Apellido, jug.Costo.ToString() });
                }
            }
            else
            {
                dgv_jugadores.Rows.Clear();
                IList<Jugador> listTodosJugadores = JugadorService.ObtenerTodosJugadores();
                if (listTodosJugadores.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros en la BD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                foreach (Jugador jug in listTodosJugadores)
                {
                    dgv_jugadores.Rows.Add(new Object[] { jug.IdJugador, jug.PosicionNombre.ToString(), jug.Nombre, jug.Apellido, jug.Costo.ToString() });
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgv_jugadores.CurrentRow;
            if (selected != null)
            {
                if (validarJugadoresAgregar(selected))
                {
                    dgv_jugadores.Rows.Remove(selected);
                    dgv_jugadoresS.Rows.Add(selected);
                }
                
            }
        }

        private bool validarJugadoresAgregar(DataGridViewRow selected)
        {
            foreach (DataGridViewRow row in dgv_jugadoresS.Rows)
            {
                if (selected.Cells["col_idJugador"].Value.ToString() == row.Cells["col_idJugadores"].Value.ToString())
                {
                    return false;
                }
            }
            return true;
        }

        private bool validarJugadoresQuitar(DataGridViewRow selected)
        {
            foreach (DataGridViewRow row in dgv_jugadores.Rows)
            {
                if (selected.Cells["col_idJugadores"].Value.ToString() == row.Cells["col_idJugador"].Value.ToString())
                {
                    return false;
                }
            }
            return true;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgv_jugadoresS.CurrentRow;
            if (selected != null)
            {
                if (validarJugadoresQuitar(selected))
                {
                    dgv_jugadores.Rows.Add(selected);
                }
                dgv_jugadoresS.Rows.Remove(selected);
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if(cbo_equipo.SelectedIndex != -1)
            {
                Equipo equipo = new Equipo();
                equipo.IdEquipo = (int)cbo_equipo.SelectedValue;

                foreach (DataGridViewRow filaGrilla in dgv_jugadoresS.Rows)
                {
                    int jugador = (int)filaGrilla.Cells[0].Value;
                    equipo.AgregarJugador(jugador);
                }

                if (EquipoService.registrarJugadores(equipo))
                {
                    MessageBox.Show("Jugadores agregados al equipo: " + cbo_equipo.Text + " con exitó.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_jugadores.Rows.Clear();
                    dgv_jugadoresS.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Error al registrar los jugadores! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un equipo para agregar los jugadores", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
