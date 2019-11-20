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
    public partial class FrmListado : Form
    {
        public FrmListado()
        {
            InitializeComponent();
        }

        private void FrmListado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSListado.DTListado' Puede moverla o quitarla según sea necesario.
            this.dTListadoTableAdapter.Fill(this.dSListado.DTListado);
            this.rpv_listado.RefreshReport();
        }


    }
}
