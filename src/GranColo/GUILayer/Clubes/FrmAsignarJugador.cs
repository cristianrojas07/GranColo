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

        public FrmAsignarJugador()
        {
            InitializeComponent();
            Cargar_comboBox(cbo_equipo, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Equipo"), "nombre", "idEquipo");
            Cargar_comboBox(cb_posicion, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Posicion"), "nombre", "idPosicion");
            Cargar_comboBox(cb_club, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Club"), "nombre", "idClub");
            JugadorService = new JugadorService();
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
                foreach (Jugador jug in listadoJugadores)
                {
                    dgv_jugadores.Rows.Add(new Object[] { jug.PosicionNombre.ToString(), jug.Nombre, jug.Apellido, jug.Costo.ToString() });
                }
            }
            else
            {
                dgv_jugadores.Rows.Clear();
                IList<Jugador> listTodosJugadores = JugadorService.ObtenerTodosJugadores();
                foreach (Jugador jug in listTodosJugadores)
                {
                    dgv_jugadores.Rows.Add(new Object[] { jug.PosicionNombre.ToString(), jug.Nombre, jug.Apellido, jug.Costo.ToString() });
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgv_jugadores.CurrentRow;
            if (selected != null)
            {
                dgv_jugadores.Rows.Remove(selected);
                dgv_jugadoresS.Rows.Add(selected);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgv_jugadoresS.CurrentRow;
            if (selected != null)
            {
                dgv_jugadoresS.Rows.Remove(selected);
                dgv_jugadores.Rows.Add(selected);
            }
        }
    }
}
