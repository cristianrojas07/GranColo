namespace GranColo.GUILayer
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixtureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torneoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarFechasATorneosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(377, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fixtureToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // fixtureToolStripMenuItem
            // 
            this.fixtureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fechaToolStripMenuItem,
            this.torneoToolStripMenuItem,
            this.asignarFechasATorneosToolStripMenuItem});
            this.fixtureToolStripMenuItem.Name = "fixtureToolStripMenuItem";
            this.fixtureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fixtureToolStripMenuItem.Text = "Fixture";
            // 
            // fechaToolStripMenuItem
            // 
            this.fechaToolStripMenuItem.Name = "fechaToolStripMenuItem";
            this.fechaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.fechaToolStripMenuItem.Text = "Fecha";
            this.fechaToolStripMenuItem.Click += new System.EventHandler(this.FechaToolStripMenuItem_Click);
            // 
            // torneoToolStripMenuItem
            // 
            this.torneoToolStripMenuItem.Name = "torneoToolStripMenuItem";
            this.torneoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.torneoToolStripMenuItem.Text = "Torneo";
            this.torneoToolStripMenuItem.Click += new System.EventHandler(this.TorneoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // asignarFechasATorneosToolStripMenuItem
            // 
            this.asignarFechasATorneosToolStripMenuItem.Name = "asignarFechasATorneosToolStripMenuItem";
            this.asignarFechasATorneosToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.asignarFechasATorneosToolStripMenuItem.Text = "Asignar Fechas a Torneos";
            this.asignarFechasATorneosToolStripMenuItem.Click += new System.EventHandler(this.AsignarFechasATorneosToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(377, 245);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Gran Colo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixtureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torneoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarFechasATorneosToolStripMenuItem;
    }
}