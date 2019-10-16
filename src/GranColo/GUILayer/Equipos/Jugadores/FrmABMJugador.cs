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

namespace GranColo.GUILayer.Equipos.Jugadores
{
    public partial class FrmABMJugador : Form
    {
        private readonly ClubService ClubService;
        private readonly JugadorService JugadorService;
        private readonly PosicionService PosicionService;
        private readonly TipoDocumentoService TipoDocumentoService;
        private readonly EstadoActualService EstadoActualService;
        private readonly FormMode formMode = FormMode.insert;

        public enum FormMode
        {
            insert,
            update
        }

        public FrmABMJugador()
        {
            InitializeComponent();
            ClubService = new ClubService();
            PosicionService = new PosicionService();
            TipoDocumentoService = new TipoDocumentoService();
            EstadoActualService = new EstadoActualService();
            JugadorService = new JugadorService();
            LlenarCombo(cbo_club, ClubService.ObtenerTodosClubes(), "Nombre", "IdClub");
            LlenarCombo(cbo_estado, EstadoActualService.ObtenerTodosEstadosActuales(), "Nombre", "IdEstadoActual");
            LlenarCombo(cbo_posicion, PosicionService.ObtenerTodosPosiciones(), "Nombre", "IdPosicion");
            LlenarCombo(cbo_tipoDoc, TipoDocumentoService.ObtenerTodosTipoDocumentos(), "Nombre", "IdTipoDocumento");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Jugador oJugador = new Jugador();
            switch (formMode)
            {
                case FormMode.insert:
                    if (ValidarCampos())
                    {
                        oJugador.Nombre = txt_nombre.Text;
                        oJugador.Apellido = txt_apellido.Text;
                        oJugador.NroDocumento = Int32.Parse(txt_nroDoc.Text);
                        oJugador.Club = (Club)cbo_club.SelectedItem;
                        oJugador.EstadoActual = (EstadoActual)cbo_estado.SelectedItem;
                        oJugador.Posicion = (Posicion)cbo_posicion.SelectedItem;
                        oJugador.TipoDocumento = (TipoDocumento)cbo_tipoDoc.SelectedItem;
                        oJugador.Costo = nud_costo.Value;
                        if (ValidarRepetidos(oJugador))
                        {
                            if (JugadorService.InsertarJugador(oJugador))
                            {
                                MessageBox.Show("Jugador agregado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FrmJugador frmJugador = Owner as FrmJugador;
                                frmJugador.CargarGrid(JugadorService.ObtenerTodosJugadores());
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
                        oJugador.Nombre = txt_nombre.Text;
                        oJugador.Apellido = txt_apellido.Text;
                        oJugador.NroDocumento = Int32.Parse(txt_nroDoc.Text);
                        oJugador.Club = (Club)cbo_club.SelectedItem;
                        oJugador.EstadoActual = (EstadoActual)cbo_estado.SelectedItem;
                        oJugador.Posicion = (Posicion)cbo_posicion.SelectedItem;
                        oJugador.TipoDocumento = (TipoDocumento)cbo_tipoDoc.SelectedItem;
                        oJugador.Costo = nud_costo.Value;
                        if (ValidarRepetidos(oJugador))
                        {
                            if (JugadorService.ModificarJugador(oJugador))
                            {
                                MessageBox.Show("Jugador modificado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error, jugador no modificado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private bool ValidarRepetidos(Jugador oJugador)
        {
            if (JugadorService.ObtenerRepetidos(oJugador))
            {
                MessageBox.Show("Ya existe un jugador con el mismo nro. de documento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidarCampos()
        {
            if (ValidarTextBoxVacio(txt_nombre, "Se debe ingresar un nombre")&&
                ValidarTextBoxVacio(txt_apellido, "Se debe ingresar un apellido")&&
                ValidarTextBoxVacio(txt_nroDoc, "Se debe ingresar un nro. de documento")&&
                ValidarComboBoxVacio(cbo_tipoDoc, "Se debe elegir un tipo de documento")&&
                ValidarComboBoxVacio(cbo_club, "Se debe elegir un club")&&
                ValidarComboBoxVacio(cbo_estado, "Se debe elegir el estado actual del jugador")&&
                ValidarComboBoxVacio(cbo_posicion, "Se debe elegir una posicion para el jugador"))
                return true;
            return false;
        }

        private bool ValidarTextBoxVacio(TextBox textBox, String mensaje)
        {
            if (String.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private bool ValidarComboBoxVacio(ComboBox comboBox, String mensaje)
        {
            if (comboBox.SelectedIndex != -1)
                return true;
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        private void FrmABMJugador_Load(object sender, EventArgs e)
        {
            if (formMode == FormMode.update)
            {
                //IList<Fecha> list = service.obtenerFechasPorId();
                //txt_nombre.Text = list[0].Nombre.ToString();
            }
        }

        private void txt_nroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
    }
}