using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GranColo.GUILayer.Reports
{
    public partial class FrmEstadisticoTwo : Form
    {
        public FrmEstadisticoTwo()
        {
            InitializeComponent();
        }

        private void EstadisticoTwo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSEstadisticoTwo.DTEstadisticoTwo' Puede moverla o quitarla según sea necesario.
            this.dTEstadisticoTwoTableAdapter.Fill(this.dSEstadisticoTwo.DTEstadisticoTwo);

            this.reportViewer1.RefreshReport();
        }
    }
}
