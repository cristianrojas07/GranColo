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
//Es necesario usar asi la clase color por un error de ambiguedad que tiene visual studio con otra clase color
using Color = GranColo.BusinessLayer.Entities.Color;

namespace GranColo.GUILayer.Clubes.Equipos
{
    public partial class FrmEquipo : Form
    {
        DirectorTecnicoService dtService;
        ColorService colorService;
        EquipoService equipoService;
        public FrmEquipo()
        {
            dtService = new DirectorTecnicoService();
            colorService = new ColorService();
            equipoService = new EquipoService();
            InitializeComponent();
        }

        private void FrmEquipo_Load(object sender, EventArgs e)
        {
            cb_todos.Checked = true;
            deshabilitarBusqueda();
            llenarCombo(cbo_dt, dtService.obtenerTodos(), "Nombre", "IdDirectorTecnico");
            llenarCombo(cbo_color, colorService.obtenerTodos(), "Nombre", "IdColor");
        }

        private void habilitarBusqueda()
        {
            txt_nombre.Enabled = true;
            cbo_dt.Enabled = true;
            cbo_color.Enabled = true;
            txt_lema.Enabled = true;
        }

        private void deshabilitarBusqueda()
        {
            txt_nombre.Enabled = false;
            cbo_dt.Enabled = false;
            cbo_color.Enabled = false;
            txt_lema.Enabled = false;
        }

        private void Cb_todos_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_todos.Checked)
            {
                deshabilitarBusqueda();
            }
            else
            {
                habilitarBusqueda();
            }
        }

        private void llenarCombo(ComboBox cbo, object source, string display, string value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private bool validarCampos()
        {
            if (String.IsNullOrEmpty(txt_nombre.Text))
            {
                MessageBox.Show("El nombre es un campo obligatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void cargarGrilla(IList<Equipo> list)
        {
            dgw_equipo.Rows.Clear();
            foreach(var item in list)
            {
                dgw_equipo.Rows.Add(new Object[] { item.IdEquipo.ToString(), item.Nombre.ToString(),
                    item.DT.Nombre.ToString(), item.Lema.ToString(), item.Color.Nombre.ToString()});
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            
            if (cb_todos.Checked)
            {
                IList<Equipo> list = equipoService.obtenerTodos();
                if (list.Count==0)
                {
                    MessageBox.Show("No se encontraron registros en la BD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cargarGrilla(list);
            }
            else
            {
                if (validarCampos())
                {
                    Equipo equipo = new Equipo();
                    equipo.Nombre = txt_nombre.Text;
                    equipo.DT = new DirectorTecnico();
                    equipo.Color = new Color();
                    camposOpcionales(equipo, cbo_dt.Text, cbo_color.Text, txt_lema.Text);
                    IList<Equipo> list = equipoService.obtenerEquiposConFiltros(equipo);
                    if (list.Count==0)
                    {
                        MessageBox.Show("No se encontraron registros en la BD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    cargarGrilla(list);
                }
            }
        }

        private void camposOpcionales(Equipo equipo, string dt, string color, string lema)
        {
            if (!String.IsNullOrEmpty(dt))
            {
                equipo.DT.Nombre = dt;
            }
            if (!String.IsNullOrEmpty(color))
            {
                equipo.Color.Nombre = color;
            }
            if (!String.IsNullOrEmpty(dt))
            {
                equipo.Lema = lema;
            }

        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgw_equipo.CurrentRow != null)
            {
                if (MessageBox.Show("¿Seguro que desea eliminar el equipo?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Equipo equipo = new Equipo();
                    equipo.IdEquipo = Int32.Parse(dgw_equipo.CurrentRow.Cells["id_equipo_col"].Value.ToString());
                    if (equipoService.eliminar(equipo))
                    {
                        MessageBox.Show("Registro eliminado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualizarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Error, el registro no se elimino", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Primero debe seleccionar un registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {

        }

        public void actualizarGrilla()
        {
            IList<Equipo> list = equipoService.obtenerTodos();
            cargarGrilla(list);
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            FrmABMEquipo frmABMEquipo = new FrmABMEquipo();
            AddOwnedForm(frmABMEquipo);
            frmABMEquipo.ShowDialog();
            

        }
    }
}
