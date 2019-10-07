using GranColo.GUILayer.Fixture;
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
    public partial class frmPrincipal : Form
    {
        InterfazFixture Ifixture;
        public frmPrincipal()
        {
            
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rpta;
            rpta = MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.No)
                e.Cancel = true;
        }

        

        private void FechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ifixture = new FrmFecha();
            Ifixture.ShowDialog();
        }

        private void TorneoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ifixture = new FrmTorneo();
            Ifixture.ShowDialog();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que desea salir?", "Confimación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            
        }

        private void AsignarFechasATorneosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAsignarFecha frmAsignarFecha = new FrmAsignarFecha();
            frmAsignarFecha.ShowDialog();
        }
    }
}
