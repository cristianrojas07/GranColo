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

        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            FrmABMJugador frmABMJugador = new FrmABMJugador();
            AddOwnedForm(frmABMJugador);
            frmABMJugador.ShowDialog();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
