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

namespace GranColo.GUILayer.Equipos.Jugadores
{
    public partial class FrmABMJugador : Form
    {
        private readonly ClubService ClubService;
        private readonly PosicionService PosicionService;
        private readonly TipoDocumentoService TipoDocumentoService;
        private readonly EstadoActualService EstadoActualService;

        public FrmABMJugador()
        {
            InitializeComponent();
            ClubService = new ClubService();
            PosicionService = new PosicionService();
            TipoDocumentoService = new TipoDocumentoService();
            EstadoActualService = new EstadoActualService();
            LlenarCombo(cbo_club, ClubService.ObtenerTodosClubes(), "Nombre", "IdClub");
            LlenarCombo(cbo_estado, EstadoActualService.ObtenerTodosEstadosActuales(), "Nombre", "IdEstadoActual");
            LlenarCombo(cbo_posicion, PosicionService.ObtenerTodosPosiciones(), "Nombre", "IdPosicion");
            LlenarCombo(cbo_tipoDoc, TipoDocumentoService.ObtenerTodosTipoDocumentos(), "Nombre", "IdTipoDocumento");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
