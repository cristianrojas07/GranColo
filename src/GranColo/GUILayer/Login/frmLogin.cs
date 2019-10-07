using GranColo.BusinessLayer;
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

namespace GranColo.GUILayer
{
    public partial class frmLogin : Form
    {
        public bool bandera { get; set; }

        DirectorTecnicoService service;
        public frmLogin()
        {
            service = new DirectorTecnicoService();
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            bandera = true;
            this.CenterToParent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            
            //Validamos que se haya ingresado un usuario.
            if ((txtUsuario.Text == ""))
            {
                MessageBox.Show("Se debe ingresar un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Validamos que se haya ingresado una password
            if ((txtContraseña.Text == ""))
            {
                MessageBox.Show("Se debe ingresar una contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DirectorTecnico oDT = new DirectorTecnico();
            oDT.NombreUsuario = txtUsuario.Text;
            oDT.Password = txtContraseña.Text;
            if (service.validarDirectorTecnico(oDT))
            {
                MessageBox.Show("Bienvenido a gran colo !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bandera = false;
                this.Close();
            } else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        

        private void FrmLogin_FormClosed(object sender, FormClosingEventArgs e)
        {
            if (bandera)
            {
                if (MessageBox.Show("¿Seguro que desea salir?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
            }
            
            
                /*DialogResult rpta;
                rpta = MessageBox.Show("¿Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == DialogResult.No)
                    e.Cancel = true;*/
            
            

        }
    }

    
}
