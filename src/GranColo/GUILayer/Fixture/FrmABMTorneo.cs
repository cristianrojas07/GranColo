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
        private Torneo torneo;
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
            //delete
        }

        public void determinarOperacion(FormMode op, Torneo oTorneo)
        {
            this.formMode = op;
            this.torneo = oTorneo;
        }

        public bool validarCampos()
        {
            if (String.IsNullOrEmpty(txt_nombre.Text))
            {
                MessageBox.Show("Se debe ingresar un nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        public void Btn_aceptar_Click(object sender, EventArgs e)
        {
            Torneo oTorneo = new Torneo();
            switch (formMode)
            {
                case FormMode.insert:
                    if (validarCampos())
                    {
                        oTorneo.nombre = txt_nombre.Text;
                        if (service.insertarTorneo(oTorneo))
                        {
                            MessageBox.Show("Torneo agregado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error, torneo no agregado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        this.Close();

                    }
                    break;
                case FormMode.update:
                    oTorneo.nombre = txt_nombre.Text;
                    if (validarCampos())
                    {
                        if (service.modificarTorneo(oTorneo))
                        {
                            MessageBox.Show("Torneo modificado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error, torneo no modificado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        this.Close();
                    }
                    break;
                    /*
                case FormMode.delete:
                    break;
                    */
            }
        }

        public void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmABMTorneo_Load(object sender, EventArgs e)
        {
            if (formMode == FormMode.update)
            {
                txt_nombre.Text = torneo.nombre;
            }
        }

        
    }
}
