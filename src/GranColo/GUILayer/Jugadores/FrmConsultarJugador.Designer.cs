namespace GranColo.GUILayer.Jugadores
{
    partial class FrmConsultarJugador
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.cbo_club = new System.Windows.Forms.ComboBox();
            this.lbl_club = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_posicion = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.cbo_estado = new System.Windows.Forms.ComboBox();
            this.lbl_nro_doc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_costo1 = new System.Windows.Forms.Label();
            this.txt_costo1 = new System.Windows.Forms.TextBox();
            this.lbl_costo2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_tipo_doc = new System.Windows.Forms.Label();
            this.cbo_tipo_doc = new System.Windows.Forms.ComboBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_jugador_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_jugador_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_jugador_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.club_jugador_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posicion_jugador_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_jugador_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_doc_jugador_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_doc_jugador_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_jugador_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(13, 13);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(67, 13);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(122, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(67, 39);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(122, 20);
            this.txt_apellido.TabIndex = 3;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(14, 42);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(47, 13);
            this.lbl_apellido.TabIndex = 2;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // cbo_club
            // 
            this.cbo_club.FormattingEnabled = true;
            this.cbo_club.Location = new System.Drawing.Point(67, 65);
            this.cbo_club.Name = "cbo_club";
            this.cbo_club.Size = new System.Drawing.Size(122, 21);
            this.cbo_club.TabIndex = 4;
            // 
            // lbl_club
            // 
            this.lbl_club.AutoSize = true;
            this.lbl_club.Location = new System.Drawing.Point(14, 65);
            this.lbl_club.Name = "lbl_club";
            this.lbl_club.Size = new System.Drawing.Size(31, 13);
            this.lbl_club.TabIndex = 5;
            this.lbl_club.Text = "Club:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(264, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // lbl_posicion
            // 
            this.lbl_posicion.AutoSize = true;
            this.lbl_posicion.Location = new System.Drawing.Point(208, 13);
            this.lbl_posicion.Name = "lbl_posicion";
            this.lbl_posicion.Size = new System.Drawing.Size(50, 13);
            this.lbl_posicion.TabIndex = 7;
            this.lbl_posicion.Text = "Posicion:";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(208, 43);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(43, 13);
            this.lbl_estado.TabIndex = 8;
            this.lbl_estado.Text = "Estado:";
            // 
            // cbo_estado
            // 
            this.cbo_estado.FormattingEnabled = true;
            this.cbo_estado.Location = new System.Drawing.Point(264, 39);
            this.cbo_estado.Name = "cbo_estado";
            this.cbo_estado.Size = new System.Drawing.Size(121, 21);
            this.cbo_estado.TabIndex = 9;
            // 
            // lbl_nro_doc
            // 
            this.lbl_nro_doc.AutoSize = true;
            this.lbl_nro_doc.Location = new System.Drawing.Point(208, 65);
            this.lbl_nro_doc.Name = "lbl_nro_doc";
            this.lbl_nro_doc.Size = new System.Drawing.Size(53, 13);
            this.lbl_nro_doc.TabIndex = 10;
            this.lbl_nro_doc.Text = "Nro.Doc.:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(264, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 11;
            // 
            // lbl_costo1
            // 
            this.lbl_costo1.AutoSize = true;
            this.lbl_costo1.Location = new System.Drawing.Point(401, 43);
            this.lbl_costo1.Name = "lbl_costo1";
            this.lbl_costo1.Size = new System.Drawing.Size(83, 13);
            this.lbl_costo1.TabIndex = 12;
            this.lbl_costo1.Text = "Costo (mayor a):";
            // 
            // txt_costo1
            // 
            this.txt_costo1.Location = new System.Drawing.Point(488, 39);
            this.txt_costo1.Name = "txt_costo1";
            this.txt_costo1.Size = new System.Drawing.Size(121, 20);
            this.txt_costo1.TabIndex = 13;
            // 
            // lbl_costo2
            // 
            this.lbl_costo2.AutoSize = true;
            this.lbl_costo2.Location = new System.Drawing.Point(401, 65);
            this.lbl_costo2.Name = "lbl_costo2";
            this.lbl_costo2.Size = new System.Drawing.Size(84, 13);
            this.lbl_costo2.TabIndex = 14;
            this.lbl_costo2.Text = "Costo (menor a):";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(488, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 15;
            // 
            // lbl_tipo_doc
            // 
            this.lbl_tipo_doc.AutoSize = true;
            this.lbl_tipo_doc.Location = new System.Drawing.Point(401, 13);
            this.lbl_tipo_doc.Name = "lbl_tipo_doc";
            this.lbl_tipo_doc.Size = new System.Drawing.Size(57, 13);
            this.lbl_tipo_doc.TabIndex = 16;
            this.lbl_tipo_doc.Text = "Tipo Doc.:";
            // 
            // cbo_tipo_doc
            // 
            this.cbo_tipo_doc.FormattingEnabled = true;
            this.cbo_tipo_doc.Location = new System.Drawing.Point(488, 13);
            this.cbo_tipo_doc.Name = "cbo_tipo_doc";
            this.cbo_tipo_doc.Size = new System.Drawing.Size(121, 21);
            this.cbo_tipo_doc.TabIndex = 17;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(638, 12);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(86, 74);
            this.btn_consultar.TabIndex = 18;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_jugador_col,
            this.nombre_jugador_col,
            this.apellido_jugador_id,
            this.club_jugador_col,
            this.posicion_jugador_col,
            this.estado_jugador_col,
            this.nro_doc_jugador_col,
            this.tipo_doc_jugador_col,
            this.costo_jugador_col});
            this.dataGridView1.Location = new System.Drawing.Point(13, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(943, 363);
            this.dataGridView1.TabIndex = 19;
            // 
            // id_jugador_col
            // 
            this.id_jugador_col.HeaderText = "Nro. jugador";
            this.id_jugador_col.Name = "id_jugador_col";
            this.id_jugador_col.ReadOnly = true;
            // 
            // nombre_jugador_col
            // 
            this.nombre_jugador_col.HeaderText = "Nombre";
            this.nombre_jugador_col.Name = "nombre_jugador_col";
            this.nombre_jugador_col.ReadOnly = true;
            // 
            // apellido_jugador_id
            // 
            this.apellido_jugador_id.HeaderText = "Apellido";
            this.apellido_jugador_id.Name = "apellido_jugador_id";
            this.apellido_jugador_id.ReadOnly = true;
            // 
            // club_jugador_col
            // 
            this.club_jugador_col.HeaderText = "Club";
            this.club_jugador_col.Name = "club_jugador_col";
            this.club_jugador_col.ReadOnly = true;
            // 
            // posicion_jugador_col
            // 
            this.posicion_jugador_col.HeaderText = "Posicion";
            this.posicion_jugador_col.Name = "posicion_jugador_col";
            this.posicion_jugador_col.ReadOnly = true;
            // 
            // estado_jugador_col
            // 
            this.estado_jugador_col.HeaderText = "Estado";
            this.estado_jugador_col.Name = "estado_jugador_col";
            this.estado_jugador_col.ReadOnly = true;
            // 
            // nro_doc_jugador_col
            // 
            this.nro_doc_jugador_col.HeaderText = "Nro.Doc.";
            this.nro_doc_jugador_col.Name = "nro_doc_jugador_col";
            this.nro_doc_jugador_col.ReadOnly = true;
            // 
            // tipo_doc_jugador_col
            // 
            this.tipo_doc_jugador_col.HeaderText = "Tipo Doc.";
            this.tipo_doc_jugador_col.Name = "tipo_doc_jugador_col";
            this.tipo_doc_jugador_col.ReadOnly = true;
            // 
            // costo_jugador_col
            // 
            this.costo_jugador_col.HeaderText = "Costo";
            this.costo_jugador_col.Name = "costo_jugador_col";
            this.costo_jugador_col.ReadOnly = true;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(13, 475);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(106, 23);
            this.btn_registrar.TabIndex = 20;
            this.btn_registrar.Text = "Registrar jugador";
            this.btn_registrar.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(136, 475);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(125, 23);
            this.btn_editar.TabIndex = 21;
            this.btn_editar.Text = "Editar seleccionado";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(280, 475);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(130, 23);
            this.btn_eliminar.TabIndex = 22;
            this.btn_eliminar.Text = "Eliminar seleccionado";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(877, 475);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 23;
            this.btn_salir.Text = "Cerrar";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // FrmConsultarJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 510);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.cbo_tipo_doc);
            this.Controls.Add(this.lbl_tipo_doc);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_costo2);
            this.Controls.Add(this.txt_costo1);
            this.Controls.Add(this.lbl_costo1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_nro_doc);
            this.Controls.Add(this.cbo_estado);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.lbl_posicion);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_club);
            this.Controls.Add(this.cbo_club);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "FrmConsultarJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultarJugador";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.ComboBox cbo_club;
        private System.Windows.Forms.Label lbl_club;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_posicion;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.ComboBox cbo_estado;
        private System.Windows.Forms.Label lbl_nro_doc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_costo1;
        private System.Windows.Forms.TextBox txt_costo1;
        private System.Windows.Forms.Label lbl_costo2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_tipo_doc;
        private System.Windows.Forms.ComboBox cbo_tipo_doc;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_jugador_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_jugador_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_jugador_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn club_jugador_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicion_jugador_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_jugador_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_doc_jugador_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_doc_jugador_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_jugador_col;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_salir;
    }
}