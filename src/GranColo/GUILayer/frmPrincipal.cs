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
            FrmFixture frmFixture = new FrmFixture(1);
            frmFixture.ShowDialog();
        }

        private void TorneoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFixture frmFixture = new FrmFixture(2);
            frmFixture.ShowDialog();
        }


    }
}
