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
                /*if (ValidarCampos())
                {
                    Fecha oFecha = new Fecha();
                    oFecha.Nombre = txt_nombre.Text;
                    IList<Fecha> list = service.obtenerFechasPorNombre(oFecha);
                    if (list.Count == 0)
                    {
                        MessageBox.Show("No se encontraron registros en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    CargarGrid(list);
                }*/
            }
            else
            {
                IList<Jugador> listTodosJugadores = JugadorService.ObtenerTodosJugadores();
                if (listTodosJugadores.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                CargarGrid(listTodosJugadores);
            }
        }

        private bool ValidarCampos()
        {
            if (ValidarTextBoxVacio(txt_nombre, "Se debe ingresar un nombre") &&
                ValidarTextBoxVacio(txt_apellido, "Se debe ingresar un apellido") &&
                ValidarComboBoxVacio(cb_club, "Se debe elegir un club") &&
                ValidarComboBoxVacio(cb_posicion, "Se debe elegir una posicion para el jugador"))
                return true;
            return false;
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
            CargarGrid(listTodosJugadores);
        }

        internal void CargarGrid(IList<Jugador> listTodosJugadores)
        {
            dgw_fecha.Rows.Clear();
            foreach (Jugador Jugador in listTodosJugadores)
            {
                dgw_fecha.Rows.Add(new Object[] { Jugador.IdJugador.ToString(), Jugador.Nombre, Jugador.Apellido, Jugador.Club.Nombre
                    , Jugador.EstadoActual.Nombre, Jugador.NroDocumento.ToString(), Jugador.TipoDocumento.Nombre, Jugador.Posicion.Nombre, Jugador.Costo.ToString()});
            }
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
