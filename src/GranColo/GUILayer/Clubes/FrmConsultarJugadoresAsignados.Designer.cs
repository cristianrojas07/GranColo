namespace GranColo.GUILayer.Clubes
{
    partial class FrmConsultarJugadoresAsignados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarJugadoresAsignados));
            this.lbl_equipo = new System.Windows.Forms.Label();
            this.cbo_equipos = new System.Windows.Forms.ComboBox();
            this.dgv_equipo_jugadores = new System.Windows.Forms.DataGridView();
            this.id_equipo_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_equipo_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_jug_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_jug_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.cb_todos = new System.Windows.Forms.CheckBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_equipo_jugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_equipo
            // 
            this.lbl_equipo.AutoSize = true;
            this.lbl_equipo.Location = new System.Drawing.Point(9, 16);
            this.lbl_equipo.Name = "lbl_equipo";
            this.lbl_equipo.Size = new System.Drawing.Size(43, 13);
            this.lbl_equipo.TabIndex = 0;
            this.lbl_equipo.Text = "Equipo:";
            // 
            // cbo_equipos
            // 
            this.cbo_equipos.FormattingEnabled = true;
            this.cbo_equipos.Location = new System.Drawing.Point(63, 13);
            this.cbo_equipos.Name = "cbo_equipos";
            this.cbo_equipos.Size = new System.Drawing.Size(121, 21);
            this.cbo_equipos.TabIndex = 1;
            // 
            // dgv_equipo_jugadores
            // 
            this.dgv_equipo_jugadores.AllowUserToAddRows = false;
            this.dgv_equipo_jugadores.AllowUserToDeleteRows = false;
            this.dgv_equipo_jugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_equipo_jugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_equipo_col,
            this.nombre_equipo_col,
            this.id_jug_col,
            this.nombre_jug_col});
            this.dgv_equipo_jugadores.Location = new System.Drawing.Point(12, 63);
            this.dgv_equipo_jugadores.Name = "dgv_equipo_jugadores";
            this.dgv_equipo_jugadores.ReadOnly = true;
            this.dgv_equipo_jugadores.Size = new System.Drawing.Size(330, 375);
            this.dgv_equipo_jugadores.TabIndex = 2;
            // 
            // id_equipo_col
            // 
            this.id_equipo_col.HeaderText = "Nro. Equipo";
            this.id_equipo_col.Name = "id_equipo_col";
            this.id_equipo_col.ReadOnly = true;
            this.id_equipo_col.Visible = false;
            // 
            // nombre_equipo_col
            // 
            this.nombre_equipo_col.HeaderText = "Equipo";
            this.nombre_equipo_col.Name = "nombre_equipo_col";
            this.nombre_equipo_col.ReadOnly = true;
            // 
            // id_jug_col
            // 
            this.id_jug_col.HeaderText = "Nro. Jugador";
            this.id_jug_col.Name = "id_jug_col";
            this.id_jug_col.ReadOnly = true;
            this.id_jug_col.Visible = false;
            // 
            // nombre_jug_col
            // 
            this.nombre_jug_col.HeaderText = "Jugador";
            this.nombre_jug_col.Name = "nombre_jug_col";
            this.nombre_jug_col.ReadOnly = true;
            this.nombre_jug_col.Width = 175;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(12, 444);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 3;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(93, 444);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(267, 444);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 5;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // cb_todos
            // 
            this.cb_todos.AutoSize = true;
            this.cb_todos.Location = new System.Drawing.Point(12, 40);
            this.cb_todos.Name = "cb_todos";
            this.cb_todos.Size = new System.Drawing.Size(56, 17);
            this.cb_todos.TabIndex = 6;
            this.cb_todos.Text = "Todos";
            this.cb_todos.UseVisualStyleBackColor = true;
            this.cb_todos.CheckedChanged += new System.EventHandler(this.Cb_todos_CheckedChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(267, 13);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 7;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // FrmConsultarJugadoresAsignados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(355, 477);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.cb_todos);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.dgv_equipo_jugadores);
            this.Controls.Add(this.cbo_equipos);
            this.Controls.Add(this.lbl_equipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConsultarJugadoresAsignados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gran Colo";
            this.Load += new System.EventHandler(this.FrmConsultarJugadoresAsignados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_equipo_jugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_equipo;
        private System.Windows.Forms.ComboBox cbo_equipos;
        private System.Windows.Forms.DataGridView dgv_equipo_jugadores;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.CheckBox cb_todos;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_equipo_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_equipo_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_jug_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_jug_col;
    }
}