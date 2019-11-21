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

namespace GranColo.GUILayer.Clubes
{
    public partial class FrmConsultarJugadoresAsignados : Form
    {
        public EquipoService equipoService { get; set; }

        public FrmConsultarJugadoresAsignados()
        {
            equipoService = new EquipoService();
            InitializeComponent();
        }

        private void FrmConsultarJugadoresAsignados_Load(object sender, EventArgs e)
        {
            cb_todos.Checked = true;
            cbo_equipos.Enabled = false;
            llenarCombo(cbo_equipos, equipoService.obtenerTodos(), "Nombre", "IdEquipo");
        }

        private void llenarCombo(ComboBox cbo, object source, string member, string value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = member;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            if (cb_todos.Checked==true)
            {
                IList<Equipo> listEquiposTodos = equipoService.obtenerTodosEquiposXJugadores();
                if (listEquiposTodos.Count==0)
                {
                    MessageBox.Show("No se encontraron registro en la BD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cargarGrilla(listEquiposTodos);
            }
            else
            {
                if (!String.IsNullOrEmpty(cbo_equipos.Text))
                {
                    int idEquipo = Int32.Parse(cbo_equipos.SelectedValue.ToString());
                    IList<Equipo> listEquipos = equipoService.obtenerEquiposXJugadores(idEquipo);
                    if (listEquipos.Count == 0)
                    {
                        MessageBox.Show("No se encontraron registro en la BD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    cargarGrilla(listEquipos);
                }
                else
                {
                    MessageBox.Show("Seleccione un torneo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void cargarGrilla(IList<Equipo> list)
        {
            dgv_equipo_jugadores.Rows.Clear();
            foreach (Equipo equipo in list)
            {
                foreach(Jugador jugador in equipo.GetJugadores())
                {
                    
                    dgv_equipo_jugadores.Rows.Add(new Object[] { equipo.IdEquipo.ToString(), equipo.Nombre.ToString(),
                        jugador.IdJugador.ToString(), jugador.Nombre.ToString() + " " + jugador.Apellido.ToString()
                    });
                }
                
            }
        }

        public void buscarTodos()
        {
            IList<Equipo> listEquiposTodos = equipoService.obtenerTodosEquiposXJugadores();
            cargarGrilla(listEquiposTodos);
        }

        private void Cb_todos_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_todos.Checked==false)
            {
                cbo_equipos.Enabled = true;
            }
            else
            {
                cbo_equipos.Enabled = false;
            }
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            int idEquipo = Int32.Parse(dgv_equipo_jugadores.CurrentRow.Cells["id_equipo_col"].Value.ToString());
            int idJugador = Int32.Parse(dgv_equipo_jugadores.CurrentRow.Cells["id_jug_col"].Value.ToString());
            if ((MessageBox.Show("¿Esta seguro que desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question))==DialogResult.Yes)
            {
                if (equipoService.eliminarEquipoXJugador(idEquipo, idJugador))
                {
                    MessageBox.Show("Registro eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buscarTodos();
                }
                else
                {
                    MessageBox.Show("Error, registro no eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            if (dgv_equipo_jugadores.CurrentRow != null)
            {
                int idEquipo = Int32.Parse(dgv_equipo_jugadores.CurrentRow.Cells["id_equipo_col"].Value.ToString());
                string equipo = dgv_equipo_jugadores.CurrentRow.Cells["nombre_equipo_col"].Value.ToString();
                int idJugador = Int32.Parse(dgv_equipo_jugadores.CurrentRow.Cells["id_jug_col"].Value.ToString());
                string jugador = dgv_equipo_jugadores.CurrentRow.Cells["nombre_jug_col"].Value.ToString();

                FrmModificarJugadoresAsingados frmModificarJugadoresAsingados = new FrmModificarJugadoresAsingados(idEquipo, idJugador, equipo, jugador);
                AddOwnedForm(frmModificarJugadoresAsingados);
                frmModificarJugadoresAsingados.ShowDialog();
                buscarTodos();
            }
        }
    }
}
