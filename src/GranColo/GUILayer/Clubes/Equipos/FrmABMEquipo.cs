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
//Es necesario usar asi la clase color por un error de ambiguedad que tiene visual studio con otra clase color
using Color = GranColo.BusinessLayer.Entities.Color;

namespace GranColo.GUILayer.Clubes.Equipos
{
    public partial class FrmABMEquipo : Form
    {
        private FormMode formMode = FormMode.insert;
        private EquipoService equipoService;
        private DirectorTecnicoService dtService;
        private ColorService colorService;
        public int selected { get; set; }

        public string nombreEquipo { get; set; }
        public string colorEquipo { get; set; }

        public FrmABMEquipo()
        {
            colorService = new ColorService();
            dtService = new DirectorTecnicoService();
            equipoService = new EquipoService();
            InitializeComponent();
        }

        public enum FormMode
        {
            insert,
            update
        }

        public void determinarOperacion(FormMode op, int selected)
        {
            this.formMode = op;
            this.selected = selected;
        }

        private void FrmABMEquipo_Load(object sender, EventArgs e)
        {
            llenarCombo(cbo_dt, dtService.obtenerTodos(), "Nombre", "IdDirectorTecnico");
            llenarCombo(cbo_color, colorService.obtenerTodos(), "Nombre", "IdColor");
            if (formMode == FormMode.update)
            {
                Equipo equipo = new Equipo();
                equipo.DT = new DirectorTecnico();
                equipo.Color = new Color();
                equipo.IdEquipo = selected;
                IList<Equipo> list = equipoService.obtenerEquiposConFiltros(equipo);
                txt_nombre.Text = list[0].Nombre.ToString();
                nombreEquipo = txt_nombre.Text;
                txt_lema.Text = list[0].Lema.ToString();
                cbo_dt.Text = list[0].DT.Nombre.ToString();
                cbo_color.Text = list[0].Color.Nombre.ToString();
                colorEquipo = cbo_color.Text;

            }
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            
            if (validarCampos())
            {
                Equipo equipo = new Equipo();
                equipo.DT = new DirectorTecnico();
                equipo.Color = new Color();
                equipo.Nombre = txt_nombre.Text;
                equipo.Lema = txt_lema.Text;
                equipo.DT.IdDirectorTecnico = Int32.Parse(cbo_dt.SelectedValue.ToString());
                equipo.Color.IdColor = Int32.Parse(cbo_color.SelectedValue.ToString());
                switch (formMode)
                {
                    case FormMode.insert:
                        if (validarRepetidos(equipo)) { 
                            if (equipoService.insertarEquipo(equipo))
                            {
                                MessageBox.Show("Equipo insertado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FrmEquipo frmEquipo = Owner as FrmEquipo;
                                frmEquipo.actualizarGrilla();
                            }
                            else
                            {
                                MessageBox.Show("Equipo no inserado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            this.Close();
                        }
                        break;
                    case FormMode.update:
                        equipo.IdEquipo = selected;
                        if (validarRepetidos(equipo))
                        {
                            if (equipoService.modificarEquipo(equipo))
                            {
                                MessageBox.Show("Equipo modificado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FrmEquipo frmEquipo = Owner as FrmEquipo;
                                frmEquipo.actualizarGrilla();
                            }
                            else
                            {
                                MessageBox.Show("Equipo no modificado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            this.Close();
                        }

                        break;
                }
            }
            

        }

        private bool validarRepetidos(Equipo equipo)
        {
            if (cambioDatos())
            {
                if (equipoService.validarRepetido(equipo))
                {
                    MessageBox.Show("Ya existe un equipo con mismo nombre y color", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            return true;
        }

        private bool cambioDatos()
        {
            if (nombreEquipo == txt_nombre.Text && colorEquipo==cbo_color.Text)
            {
                return false;
            }
            return true;
        }

        private void llenarCombo(ComboBox cbo, object source, string member, string value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = member;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private bool validarCampos()
        {
            if (String.IsNullOrEmpty(txt_nombre.Text))
            {
                MessageBox.Show("Debe ingresar todos los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (String.IsNullOrEmpty(txt_lema.Text))
            {
                MessageBox.Show("Debe ingresar todos los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (String.IsNullOrEmpty(cbo_dt.Text))
            {
                MessageBox.Show("Debe ingresar todos los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (String.IsNullOrEmpty(cbo_color.Text))
            {
                MessageBox.Show("Debe ingresar todos los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

    }
}
