using GranColo.BusinessLayer.Services;
using GranColo.BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GranColo.GUILayer;
using GranColo.GUILayer.Clubes;

namespace GranColo.GUILayer
{
    public partial class FrmModificarJugadoresAsingados : Form
    {
        public int idEquipo { get; set; }
        public string nombreEquipo { get; set; }
        public int idJugador { get; set; }
        public string nombreJugador { get; set; }
        public EquipoService equipoService {get;set;}
        public JugadorService jugadorService { get; set; }
        public FrmModificarJugadoresAsingados(int idEquipo, int idJugador, string equipo, string jugador)
        {
            this.idEquipo = idEquipo;
            this.idJugador = idJugador;
            this.nombreEquipo = equipo;
            this.nombreJugador = jugador;
            equipoService = new EquipoService();
            jugadorService = new JugadorService();
            InitializeComponent();
        }

        private void llenarCombo(ComboBox cbo, object source, string member, string value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = member;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void FrmModificarJugadoresAsingados_Load(object sender, EventArgs e)
        {
            llenarCombo(cbo_jugadores, jugadorService.ObtenerTodosJugadoresSinEquipo2(idEquipo), "Nombre_Apellido", "IdJugador");
            cbo_equipos.Text = nombreEquipo;
            cbo_jugadores.Text = nombreJugador;
            cbo_equipos.Enabled = false;
            
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            if (cbo_jugadores.Text==nombreJugador)
            {
                MessageBox.Show("¡No ha modificado la asginacion!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (cbo_jugadores.SelectedIndex != -1)
                {
                    int jugadorNuevo = Int32.Parse(cbo_jugadores.SelectedValue.ToString());
                    if (!String.IsNullOrEmpty(cbo_jugadores.Text))
                    {
                        if (equipoService.modificarEquipoXJugador(idEquipo, jugadorNuevo, idJugador))
                        {
                            MessageBox.Show("Jugador asignado modificado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FrmConsultarJugadoresAsignados frmConsultarAsignarFecha = Owner as FrmConsultarJugadoresAsignados;
                            frmConsultarAsignarFecha.buscarTodos();
                        }
                        else
                        {
                            MessageBox.Show("Error, jugador asignado no modificado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    this.Close();
                }
                
            }
            
        }
    }
}
