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

                }
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
