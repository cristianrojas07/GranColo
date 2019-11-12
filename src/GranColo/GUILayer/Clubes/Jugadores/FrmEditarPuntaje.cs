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
    public partial class FrmEditarPuntaje : Form
    {
        readonly JugadorService jugadorService;
        readonly Jugador jugadorSeleccionado;
        readonly int nroFechaSeleccionado;
        readonly int idTorneoSeleccionado;

        public FrmEditarPuntaje(Jugador jugador, int nroFecha, int idTorneo)
        {
            InitializeComponent();
            jugadorSeleccionado = jugador;
            nroFechaSeleccionado = nroFecha;
            idTorneoSeleccionado = idTorneo;
            jugadorService = new JugadorService();
        }

        private void FrmEditarPuntaje_Load(object sender, EventArgs e)
        {
            nud_puntaje.Value = jugadorSeleccionado.Puntaje;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Jugador jugador = new Jugador();
            jugador.IdJugador = jugadorSeleccionado.IdJugador;
            jugador.Puntaje = nud_puntaje.Value;
            if (jugadorService.actualizarPuntaje(jugador, nroFechaSeleccionado, idTorneoSeleccionado))
            {
                MessageBox.Show("Puntaje modificado con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error, el puntaje no se pudo modificar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
