namespace GranColo.GUILayer.Clubes.Jugadores
{
    partial class FrmPuntajeJugador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPuntajeJugador));
            this.cbo_fecha = new System.Windows.Forms.ComboBox();
            this.cbo_torneo = new System.Windows.Forms.ComboBox();
            this.cbo_club = new System.Windows.Forms.ComboBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_jugadores = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_puntaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_titulo = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nud_max = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_min = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_posicion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.cb_todos = new System.Windows.Forms.CheckBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jugadores)).BeginInit();
            this.gb_titulo.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_min)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_fecha
            // 
            this.cbo_fecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_fecha.Enabled = false;
            this.cbo_fecha.FormattingEnabled = true;
            this.cbo_fecha.Location = new System.Drawing.Point(61, 57);
            this.cbo_fecha.Name = "cbo_fecha";
            this.cbo_fecha.Size = new System.Drawing.Size(148, 21);
            this.cbo_fecha.TabIndex = 3;
            this.cbo_fecha.SelectedValueChanged += new System.EventHandler(this.cbo_fecha_SelectedValueChanged);
            // 
            // cbo_torneo
            // 
            this.cbo_torneo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_torneo.FormattingEnabled = true;
            this.cbo_torneo.Location = new System.Drawing.Point(61, 26);
            this.cbo_torneo.Name = "cbo_torneo";
            this.cbo_torneo.Size = new System.Drawing.Size(148, 21);
            this.cbo_torneo.TabIndex = 5;
            this.cbo_torneo.SelectedValueChanged += new System.EventHandler(this.cbo_torneo_SelectedValueChanged);
            // 
            // cbo_club
            // 
            this.cbo_club.Enabled = false;
            this.cbo_club.FormattingEnabled = true;
            this.cbo_club.Location = new System.Drawing.Point(275, 51);
            this.cbo_club.Name = "cbo_club";
            this.cbo_club.Size = new System.Drawing.Size(131, 21);
            this.cbo_club.TabIndex = 5;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(383, 550);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 8;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(12, 550);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 9;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbo_fecha);
            this.groupBox3.Controls.Add(this.dgv_jugadores);
            this.groupBox3.Controls.Add(this.gb_titulo);
            this.groupBox3.Controls.Add(this.cbo_torneo);
            this.groupBox3.Controls.Add(this.cb_todos);
            this.groupBox3.Controls.Add(this.btn_buscar);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 532);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Campeonato";
            // 
            // dgv_jugadores
            // 
            this.dgv_jugadores.AllowUserToAddRows = false;
            this.dgv_jugadores.AllowUserToDeleteRows = false;
            this.dgv_jugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_jugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.Nombre,
            this.Apellido,
            this.Club,
            this.Posicion,
            this.Costo,
            this.col_puntaje});
            this.dgv_jugadores.Location = new System.Drawing.Point(14, 239);
            this.dgv_jugadores.Name = "dgv_jugadores";
            this.dgv_jugadores.Size = new System.Drawing.Size(420, 281);
            this.dgv_jugadores.TabIndex = 9;
            this.dgv_jugadores.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_jugadores_CellBeginEdit);
            this.dgv_jugadores.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_jugadores_CellEndEdit);
            // 
            // col_id
            // 
            this.col_id.DataPropertyName = "IdJugador";
            this.col_id.HeaderText = "Nro";
            this.col_id.Name = "col_id";
            this.col_id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "JugadorNombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "JugadorApellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Club
            // 
            this.Club.DataPropertyName = "ClubNombre";
            this.Club.HeaderText = "Club";
            this.Club.Name = "Club";
            // 
            // Posicion
            // 
            this.Posicion.DataPropertyName = "PosicionNombre";
            this.Posicion.HeaderText = "Posición";
            this.Posicion.Name = "Posicion";
            // 
            // Costo
            // 
            this.Costo.DataPropertyName = "JugadorCosto";
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            // 
            // col_puntaje
            // 
            this.col_puntaje.HeaderText = "Puntaje";
            this.col_puntaje.MaxInputLength = 4;
            this.col_puntaje.Name = "col_puntaje";
            // 
            // gb_titulo
            // 
            this.gb_titulo.Controls.Add(this.groupBox4);
            this.gb_titulo.Controls.Add(this.cbo_club);
            this.gb_titulo.Controls.Add(this.label6);
            this.gb_titulo.Controls.Add(this.cb_posicion);
            this.gb_titulo.Controls.Add(this.label7);
            this.gb_titulo.Controls.Add(this.txt_apellido);
            this.gb_titulo.Controls.Add(this.label8);
            this.gb_titulo.Controls.Add(this.txt_nombre);
            this.gb_titulo.Controls.Add(this.lbl_nombre);
            this.gb_titulo.Location = new System.Drawing.Point(14, 93);
            this.gb_titulo.Name = "gb_titulo";
            this.gb_titulo.Size = new System.Drawing.Size(420, 140);
            this.gb_titulo.TabIndex = 5;
            this.gb_titulo.TabStop = false;
            this.gb_titulo.Text = "Jugador";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nud_max);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.nud_min);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(9, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(397, 54);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Costo";
            // 
            // nud_max
            // 
            this.nud_max.Enabled = false;
            this.nud_max.Location = new System.Drawing.Point(257, 20);
            this.nud_max.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nud_max.Name = "nud_max";
            this.nud_max.Size = new System.Drawing.Size(131, 20);
            this.nud_max.TabIndex = 3;
            this.nud_max.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hasta:";
            // 
            // nud_min
            // 
            this.nud_min.Enabled = false;
            this.nud_min.Location = new System.Drawing.Point(50, 20);
            this.nud_min.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nud_min.Name = "nud_min";
            this.nud_min.Size = new System.Drawing.Size(131, 20);
            this.nud_min.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Desde:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Club:";
            // 
            // cb_posicion
            // 
            this.cb_posicion.Enabled = false;
            this.cb_posicion.FormattingEnabled = true;
            this.cb_posicion.Location = new System.Drawing.Point(59, 51);
            this.cb_posicion.Name = "cb_posicion";
            this.cb_posicion.Size = new System.Drawing.Size(131, 21);
            this.cb_posicion.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Posición:";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Enabled = false;
            this.txt_apellido.Location = new System.Drawing.Point(275, 22);
            this.txt_apellido.MaxLength = 95;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(131, 20);
            this.txt_apellido.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Apellido:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Location = new System.Drawing.Point(59, 21);
            this.txt_nombre.MaxLength = 95;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(131, 20);
            this.txt_nombre.TabIndex = 28;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(6, 25);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 27;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // cb_todos
            // 
            this.cb_todos.AutoSize = true;
            this.cb_todos.Checked = true;
            this.cb_todos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_todos.Location = new System.Drawing.Point(335, 70);
            this.cb_todos.Name = "cb_todos";
            this.cb_todos.Size = new System.Drawing.Size(56, 17);
            this.cb_todos.TabIndex = 8;
            this.cb_todos.Text = "Todos";
            this.cb_todos.UseVisualStyleBackColor = true;
            this.cb_todos.CheckedChanged += new System.EventHandler(this.cb_todos_CheckedChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(316, 19);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(95, 40);
            this.btn_buscar.TabIndex = 7;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Fecha:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Torneo:";
            // 
            // FrmPuntajeJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 584);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPuntajeJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gran Colo";
            this.Load += new System.EventHandler(this.FrmPuntajeJugador_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jugadores)).EndInit();
            this.gb_titulo.ResumeLayout(false);
            this.gb_titulo.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_min)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbo_fecha;
        private System.Windows.Forms.ComboBox cbo_torneo;
        private System.Windows.Forms.ComboBox cbo_club;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_jugadores;
        private System.Windows.Forms.GroupBox gb_titulo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown nud_max;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_min;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_posicion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.CheckBox cb_todos;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Club;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_puntaje;
    }
}