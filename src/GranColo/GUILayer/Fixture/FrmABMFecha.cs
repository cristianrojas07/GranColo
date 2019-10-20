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
    public partial class FrmABMFecha : Form
    {
        private FormMode formMode = FormMode.insert;
        private FechaService service;
        public string nombreFecha { get; set; }

        public FrmABMFecha()
        {
            service = new FechaService();
            InitializeComponent();
        }

        public enum FormMode
        {
            insert,
            update
        }

        public void DeterminarOperacion(FormMode op, FechaService oFechaService)
        {
            this.formMode = op;
            this.service = oFechaService;
        }

        //-----------------------BOTONES ABM--------------------------------//
        public void Btn_aceptar_Click(object sender, EventArgs e)
        {
            Fecha oFecha = new Fecha();
            switch (formMode)
            {
                case FormMode.insert:
                    if (ValidarCampos())
                    {
                        oFecha.Nombre = txt_nombre.Text;
                                            
                        if (ValidarRepetidos(oFecha))
                        {
                            if (service.insertarFecha(oFecha))
                            {
                                MessageBox.Show("Fecha agregada con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FrmFecha frmFecha = Owner as FrmFecha;
                                frmFecha.ActualizarGrilla();
                            }
                            else
                            {
                                MessageBox.Show("Error, fecha no agregada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            this.Close();
                        }

                    }
                    break;
                case FormMode.update:
                    if (ValidarCampos())
                    {
                        oFecha.Nombre = txt_nombre.Text;
                        if (ValidarRepetidos(oFecha))
                        {
                            if (service.modificarFecha(oFecha))
                            {
                                MessageBox.Show("Fecha modificada con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FrmFecha frmFecha = Owner as FrmFecha;
                                frmFecha.ActualizarGrilla();
                            }
                            else
                            {
                                MessageBox.Show("Error, fecha no modificada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        public bool ValidarRepetidos(Fecha oFecha)
        {
            if (cambioDatos())
            {
                if (service.obtenerRepetidos(oFecha))
                {
                    MessageBox.Show("Ya existe una fecha con el mismo nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private bool cambioDatos()
        {
            if (nombreFecha==txt_nombre.Text)
            {
                return false;
            }
            return true;
        }

        //----------------------------------------------------------------------//

        //-----------------------SHOW FORM ABM--------------------------------//
        private void FrmABMFecha_Load(object sender, EventArgs e)
        {
            if (formMode == FormMode.update)
            {
                IList<Fecha> list =  service.obtenerFechasPorId();
                txt_nombre.Text = list[0].Nombre.ToString();
                nombreFecha = txt_nombre.Text;
            }
        }
        //----------------------------------------------------------------------//
    }
}
