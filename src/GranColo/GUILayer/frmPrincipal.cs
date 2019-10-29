﻿using GranColo.GUILayer.Clubes;
using GranColo.GUILayer.Clubes.Equipos;
using GranColo.GUILayer.Equipos.Jugadores;
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
            
            
        }

        private void AsignarFechasATorneosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAsignarFecha frmAsignarFecha = new FrmAsignarFecha();
            frmAsignarFecha.ShowDialog();
        }

        private void ConsultarFechasAsignadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarAsignarFecha frmAMBAsignarFecha = new FrmConsultarAsignarFecha();
            frmAMBAsignarFecha.ShowDialog();
        }

        

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void añadirJugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJugador frmJugador = new FrmJugador();
            frmJugador.ShowDialog();
        }

        private void FechaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ifixture = new FrmFecha();
            Ifixture.ShowDialog();
        }

        private void TorneoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ifixture = new FrmTorneo();
            Ifixture.ShowDialog();
        }

        private void AsignarFechasATorneosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAsignarFecha frmAsignarFecha = new FrmAsignarFecha();
            frmAsignarFecha.ShowDialog();
        }

        private void ConsultarFechasAsignadasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultarAsignarFecha frmAMBAsignarFecha = new FrmConsultarAsignarFecha();
            frmAMBAsignarFecha.ShowDialog();
        }

        private void SalirToolStripMenuItem2_Click(object sender, EventArgs e)
        { 
            if (MessageBox.Show("¿Seguro que desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void JugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJugador frmJugador = new FrmJugador();
            frmJugador.ShowDialog();
        }

        private void EquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEquipo frmEquipo = new FrmEquipo();
            frmEquipo.ShowDialog();
        }

        private void asignarJugadoresAEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAsignarJugador frmAsignarJugador = new FrmAsignarJugador();
            frmAsignarJugador.ShowDialog();
        }
    }
}
