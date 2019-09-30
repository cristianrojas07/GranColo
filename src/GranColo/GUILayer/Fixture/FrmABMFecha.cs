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
        private Fecha fecha;
        private FechaService service;

        public FrmABMFecha()
        {
            service = new FechaService();
            InitializeComponent();
        }

        public enum FormMode
        {
            insert,
            update
            //delete
        }

        public void determinarOperacion(FormMode op, Fecha oFecha)
        {
            this.formMode = op;
            this.fecha = oFecha;
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

        public bool validarRepetidos(Fecha oFecha)
        {
            if (service.obtenerRepetidos(oFecha))
            {
                MessageBox.Show("Ya existe una fecha con el mismo nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void Btn_aceptar_Click(object sender, EventArgs e)
        {
            Fecha oFecha = new Fecha();
            switch (formMode)
            {
                case FormMode.insert:
                    if (validarCampos())
                    {
                        oFecha.nombre = txt_nombre.Text;
                        if (validarRepetidos(oFecha))
                        {
                            if (service.insertarFecha(oFecha))
                            {
                                MessageBox.Show("Fecha agregada con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FrmFecha frmFecha = Owner as FrmFecha;
                                frmFecha.CargarGrid(service.obtenerTodasFechas());
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
                    oFecha.nombre = txt_nombre.Text;
                    if (validarCampos())
                    {
                        if (validarRepetidos(oFecha))
                        {
                            if (service.modificarFecha(oFecha))
                            {
                                MessageBox.Show("Fecha modificada con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FrmFecha frmFecha = Owner as FrmFecha;
                                frmFecha.CargarGrid(service.obtenerTodasFechas());
                            }
                            else
                            {
                                MessageBox.Show("Error, fecha no modificada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            this.Close();
                        }
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

        private void FrmABMFecha_Load(object sender, EventArgs e)
        {
            if (formMode == FormMode.update)
            {
                txt_nombre.Text = fecha.nombre;
            }
        }
    } 
}
