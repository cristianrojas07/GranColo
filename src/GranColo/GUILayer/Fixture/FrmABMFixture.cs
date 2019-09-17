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
    public partial class FrmABMFixture : Form
    {
        public int modo { get; set; }
        public int operacion { get; set; }

        private FechaService fechaService;
        private TorneoService torneoService;

        public FrmABMFixture(int modo, int operacion)
        {
            fechaService = new FechaService();
            torneoService = new TorneoService();
            this.modo = modo;
            this.operacion = operacion;
            InitializeComponent();
            setGroupBox(modo);
        }
        public FrmABMFixture(int modo, int operacion, FechaService fechaService)
        {
            this.fechaService = fechaService;
            this.modo = modo;
            this.operacion = operacion;
            InitializeComponent();
            setGroupBox(modo);
        }

        public FrmABMFixture(int modo, int operacion, TorneoService torneoService)
        {
            this.torneoService = torneoService;
            this.modo = modo;
            this.operacion = operacion;
            InitializeComponent();
            setGroupBox(modo);
        }

        public void setGroupBox(int modo)
        {
            if (modo == 1)
            {
                gb_titulo.Text = "Fecha";
            }
            else
            {
                gb_titulo.Text = "Torneo";
            }
        }
        public string determinarModo(int modo)
        {
            switch (modo)
            {
                case 1:
                    return "fecha";
                case 2:
                    return "torneo";
                default:
                    return "";
            }
        }

        public string determinarOperacion(int operacion)
        {
            switch (operacion)
            {
                case 1:
                    return "agregar";
                case 2:
                    return "modificar";
                default:
                    return "";
            }
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            switch (determinarModo(modo))
            {
                case "fecha":
                    Fecha oFecha = new Fecha();
                    switch (determinarOperacion(operacion))
                    {

                        case "agregar":
                            //Fecha oFecha = new Fecha();
                            oFecha.nombre = txt_nombre.Text;
                            if (fechaService.insertarFecha(oFecha))
                            {
                                MessageBox.Show("Fecha agregada con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }else
                            {
                                MessageBox.Show("Error, fecha no agregada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            this.Close();
                            break;
                        case "modificar":
                            oFecha.nombre = txt_nombre.Text;
                            if (fechaService.modificarFecha(oFecha))
                            {
                                MessageBox.Show("Fecha modificada con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error, fecha no modificada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            this.Close();
                            break;
                    }
                    break;
                case "torneo":
                    Torneo oTorneo = new Torneo();
                    switch (determinarOperacion(operacion))
                    {

                        case "agregar":
                            oTorneo.nombre = txt_nombre.Text;
                            if (torneoService.insertarTorneo(oTorneo))
                            {
                                MessageBox.Show("Torneo agregado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error, torneo no agregado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            this.Close();
                            break;
                        case "modificar":
                            oTorneo.nombre = txt_nombre.Text;
                            if (torneoService.modificarTorneo(oTorneo))
                            {
                                MessageBox.Show("Torneo modificado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error, torneo no modificado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            this.Close();
                            break;
                    }
                    break;
            }
            
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
