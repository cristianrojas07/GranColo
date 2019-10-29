namespace GranColo.GUILayer.Clubes
{
    partial class FrmAsignarJugador
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
            this.lbl_equipo = new System.Windows.Forms.Label();
            this.cbo_equipo = new System.Windows.Forms.ComboBox();
            this.gb_titulo = new System.Windows.Forms.GroupBox();
            this.cb_todos = new System.Windows.Forms.CheckBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgv_jugadoresS = new System.Windows.Forms.DataGridView();
            this.col_posiciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombreS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_costoS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_jugadores = new System.Windows.Forms.DataGridView();
            this.col_posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nud_max = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_min = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_club = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_posicion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.gb_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jugadoresS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jugadores)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_min)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_equipo
            // 
            this.lbl_equipo.AutoSize = true;
            this.lbl_equipo.Location = new System.Drawing.Point(13, 9);
            this.lbl_equipo.Name = "lbl_equipo";
            this.lbl_equipo.Size = new System.Drawing.Size(47, 13);
            this.lbl_equipo.TabIndex = 4;
            this.lbl_equipo.Text = "Equipo*:";
            // 
            // cbo_equipo
            // 
            this.cbo_equipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_equipo.FormattingEnabled = true;
            this.cbo_equipo.Location = new System.Drawing.Point(67, 6);
            this.cbo_equipo.Name = "cbo_equipo";
            this.cbo_equipo.Size = new System.Drawing.Size(185, 21);
            this.cbo_equipo.TabIndex = 5;
            // 
            // gb_titulo
            // 
            this.gb_titulo.Controls.Add(this.cb_todos);
            this.gb_titulo.Controls.Add(this.btnQuitar);
            this.gb_titulo.Controls.Add(this.btnAgregar);
            this.gb_titulo.Controls.Add(this.dgv_jugadoresS);
            this.gb_titulo.Controls.Add(this.dgv_jugadores);
            this.gb_titulo.Controls.Add(this.groupBox1);
            this.gb_titulo.Controls.Add(this.cb_club);
            this.gb_titulo.Controls.Add(this.label3);
            this.gb_titulo.Controls.Add(this.cb_posicion);
            this.gb_titulo.Controls.Add(this.label2);
            this.gb_titulo.Controls.Add(this.txt_apellido);
            this.gb_titulo.Controls.Add(this.label1);
            this.gb_titulo.Controls.Add(this.btn_consultar);
            this.gb_titulo.Controls.Add(this.txt_nombre);
            this.gb_titulo.Controls.Add(this.lbl_nombre);
            this.gb_titulo.Location = new System.Drawing.Point(16, 33);
            this.gb_titulo.Name = "gb_titulo";
            this.gb_titulo.Size = new System.Drawing.Size(578, 478);
            this.gb_titulo.TabIndex = 6;
            this.gb_titulo.TabStop = false;
            this.gb_titulo.Text = "Jugador";
            // 
            // cb_todos
            // 
            this.cb_todos.AutoSize = true;
            this.cb_todos.Checked = true;
            this.cb_todos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_todos.Location = new System.Drawing.Point(472, 88);
            this.cb_todos.Name = "cb_todos";
            this.cb_todos.Size = new System.Drawing.Size(56, 17);
            this.cb_todos.TabIndex = 47;
            this.cb_todos.Text = "Todos";
            this.cb_todos.UseVisualStyleBackColor = true;
            this.cb_todos.CheckedChanged += new System.EventHandler(this.cb_todos_CheckedChanged);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(242, 305);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(90, 59);
            this.btnQuitar.TabIndex = 46;
            this.btnQuitar.Text = "<< Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(242, 240);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 59);
            this.btnAgregar.TabIndex = 45;
            this.btnAgregar.Text = "Agregar >>";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgv_jugadoresS
            // 
            this.dgv_jugadoresS.AllowUserToAddRows = false;
            this.dgv_jugadoresS.AllowUserToDeleteRows = false;
            this.dgv_jugadoresS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_jugadoresS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_posiciones,
            this.col_nombreS,
            this.col_apellidos,
            this.col_costoS});
            this.dgv_jugadoresS.Location = new System.Drawing.Point(338, 138);
            this.dgv_jugadoresS.Name = "dgv_jugadoresS";
            this.dgv_jugadoresS.ReadOnly = true;
            this.dgv_jugadoresS.Size = new System.Drawing.Size(234, 332);
            this.dgv_jugadoresS.TabIndex = 44;
            // 
            // col_posiciones
            // 
            this.col_posiciones.HeaderText = "Posición";
            this.col_posiciones.Name = "col_posiciones";
            this.col_posiciones.ReadOnly = true;
            this.col_posiciones.Width = 70;
            // 
            // col_nombreS
            // 
            this.col_nombreS.HeaderText = "Nombre";
            this.col_nombreS.Name = "col_nombreS";
            this.col_nombreS.ReadOnly = true;
            // 
            // col_apellidos
            // 
            this.col_apellidos.HeaderText = "Apellido";
            this.col_apellidos.Name = "col_apellidos";
            this.col_apellidos.ReadOnly = true;
            // 
            // col_costoS
            // 
            this.col_costoS.HeaderText = "Costo";
            this.col_costoS.Name = "col_costoS";
            this.col_costoS.ReadOnly = true;
            // 
            // dgv_jugadores
            // 
            this.dgv_jugadores.AllowUserToAddRows = false;
            this.dgv_jugadores.AllowUserToDeleteRows = false;
            this.dgv_jugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_jugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_posicion,
            this.col_nombre,
            this.col_apellido,
            this.col_costo});
            this.dgv_jugadores.Location = new System.Drawing.Point(6, 138);
            this.dgv_jugadores.Name = "dgv_jugadores";
            this.dgv_jugadores.ReadOnly = true;
            this.dgv_jugadores.Size = new System.Drawing.Size(230, 332);
            this.dgv_jugadores.TabIndex = 43;
            // 
            // col_posicion
            // 
            this.col_posicion.HeaderText = "Posición";
            this.col_posicion.Name = "col_posicion";
            this.col_posicion.ReadOnly = true;
            this.col_posicion.Width = 70;
            // 
            // col_nombre
            // 
            this.col_nombre.HeaderText = "Nombre";
            this.col_nombre.Name = "col_nombre";
            this.col_nombre.ReadOnly = true;
            // 
            // col_apellido
            // 
            this.col_apellido.HeaderText = "Apellido";
            this.col_apellido.Name = "col_apellido";
            this.col_apellido.ReadOnly = true;
            // 
            // col_costo
            // 
            this.col_costo.HeaderText = "Costo";
            this.col_costo.Name = "col_costo";
            this.col_costo.ReadOnly = true;
            this.col_costo.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nud_max);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nud_min);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(9, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 54);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Costo";
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
            1000,
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Desde:";
            // 
            // cb_club
            // 
            this.cb_club.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_club.Enabled = false;
            this.cb_club.FormattingEnabled = true;
            this.cb_club.Location = new System.Drawing.Point(275, 51);
            this.cb_club.Name = "cb_club";
            this.cb_club.Size = new System.Drawing.Size(131, 21);
            this.cb_club.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Club:";
            // 
            // cb_posicion
            // 
            this.cb_posicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_posicion.Enabled = false;
            this.cb_posicion.FormattingEnabled = true;
            this.cb_posicion.Location = new System.Drawing.Point(59, 51);
            this.cb_posicion.Name = "cb_posicion";
            this.cb_posicion.Size = new System.Drawing.Size(131, 21);
            this.cb_posicion.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Posición:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Apellido:";
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(450, 19);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(103, 53);
            this.btn_consultar.TabIndex = 30;
            this.btn_consultar.Text = "Buscar Jugador";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
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
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(16, 517);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 7;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(519, 517);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // FrmAsignarJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 549);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.gb_titulo);
            this.Controls.Add(this.cbo_equipo);
            this.Controls.Add(this.lbl_equipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAsignarJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAsignarJugador";
            this.gb_titulo.ResumeLayout(false);
            this.gb_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jugadoresS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jugadores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_equipo;
        private System.Windows.Forms.ComboBox cbo_equipo;
        private System.Windows.Forms.GroupBox gb_titulo;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgv_jugadoresS;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_posiciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombreS;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_costoS;
        private System.Windows.Forms.DataGridView dgv_jugadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_costo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nud_max;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_min;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_club;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_posicion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.CheckBox cb_todos;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}