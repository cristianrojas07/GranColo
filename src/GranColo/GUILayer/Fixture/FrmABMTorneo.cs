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

namespace GranColo.GUILayer.Fixture
{
    public partial class FrmABMTorneo : Form
    {
        private FormMode formMode = FormMode.insert;
        private TorneoService service;

        public FrmABMTorneo()
        {
            service = new TorneoService();
            InitializeComponent();
        }

        public enum FormMode
        {
            insert,
            update
            
        }

        public void DeterminarOperacion(FormMode op, TorneoService oTorneoService)
        {
            this.formMode = op;
            this.service  = oTorneoService;
        }

        //-----------------------BOTONES ABM--------------------------------//
        public void Btn_aceptar_Click(object sender, EventArgs e)
        {
            Torneo oTorneo = new Torneo();
            switch (formMode)
            {
                case FormMode.insert:
                    if (ValidarCampos())
                    {
                        oTorneo.Nombre = txt_nombre.Text;
                        if (ValidarRepetidos(oTorneo))
                        {
                            if (service.insertarTorneo(oTorneo))
                            {
                                MessageBox.Show("Torneo agregado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FrmTorneo frmTorneo = Owner as FrmTorneo;
                                frmTorneo.ActualizarGrilla();
                            }
                            else
                            {
                                MessageBox.Show("Error, torneo no agregado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            this.Close();
                        }
                    }
                    break;
                case FormMode.update:
                    oTorneo.Nombre = txt_nombre.Text;
                    if (ValidarCampos())
                    {
                        if (ValidarRepetidos(oTorneo))
                        {
                            if (service.modificarTorneo(oTorneo))
                            {
                                MessageBox.Show("Torneo modificado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FrmTorneo frmTorneo = Owner as FrmTorneo;
                                frmTorneo.ActualizarGrilla();
                            }
                            else
                            {
                                MessageBox.Show("Error, torneo no modificado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            this.Close();
                        }
                    }
                    break;
            }
        }

        public void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //----------------------------------------------------------------------//

        //-----------------------VALIDACIONES--------------------------------//
        public bool ValidarCampos()
        {
            if (String.IsNullOrEmpty(txt_nombre.Text))
            {
                MessageBox.Show("Se debe ingresar un nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        public bool ValidarRepetidos(Torneo oTorneo)
        {
            if (service.obtenerRepetidos(oTorneo))
            {
                MessageBox.Show("Ya existe un torneo con el mismo nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        //----------------------------------------------------------------------//

        //-----------------------SHOW FORM ABM--------------------------------//
        private void FrmABMTorneo_Load(object sender, EventArgs e)
        {
            if (formMode == FormMode.update)
            {
                IList<Torneo> list = service.obtenerTorneosPorId();
                txt_nombre.Text = list[0].Nombre.ToString();
            }
        }
        //----------------------------------------------------------------------//

    }
}
