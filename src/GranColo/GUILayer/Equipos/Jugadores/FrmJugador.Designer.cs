namespace GranColo.GUILayer.Equipos.Jugadores
{
    partial class FrmJugador
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
            this.gb_titulo = new System.Windows.Forms.GroupBox();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dgw_fecha = new System.Windows.Forms.DataGridView();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.cb_todos = new System.Windows.Forms.CheckBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posición = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_fecha)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_titulo
            // 
            this.gb_titulo.Controls.Add(this.comboBox2);
            this.gb_titulo.Controls.Add(this.label3);
            this.gb_titulo.Controls.Add(this.comboBox1);
            this.gb_titulo.Controls.Add(this.label2);
            this.gb_titulo.Controls.Add(this.textBox1);
            this.gb_titulo.Controls.Add(this.label1);
            this.gb_titulo.Controls.Add(this.btn_cerrar);
            this.gb_titulo.Controls.Add(this.btn_eliminar);
            this.gb_titulo.Controls.Add(this.btn_editar);
            this.gb_titulo.Controls.Add(this.btn_agregar);
            this.gb_titulo.Controls.Add(this.dgw_fecha);
            this.gb_titulo.Controls.Add(this.btn_consultar);
            this.gb_titulo.Controls.Add(this.cb_todos);
            this.gb_titulo.Controls.Add(this.txt_nombre);
            this.gb_titulo.Controls.Add(this.lbl_nombre);
            this.gb_titulo.Location = new System.Drawing.Point(12, 12);
            this.gb_titulo.Name = "gb_titulo";
            this.gb_titulo.Size = new System.Drawing.Size(560, 386);
            this.gb_titulo.TabIndex = 2;
            this.gb_titulo.TabStop = false;
            this.gb_titulo.Text = "Jugador";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(471, 356);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 35;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(171, 356);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 34;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(90, 356);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 33;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(9, 356);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 32;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // dgw_fecha
            // 
            this.dgw_fecha.AllowUserToAddRows = false;
            this.dgw_fecha.AllowUserToDeleteRows = false;
            this.dgw_fecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_fecha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_col,
            this.nombre_col,
            this.Apellido,
            this.Club,
            this.Estado,
            this.Documento,
            this.Posición,
            this.Costo,
            this.estado_col});
            this.dgw_fecha.Location = new System.Drawing.Point(9, 101);
            this.dgw_fecha.Name = "dgw_fecha";
            this.dgw_fecha.ReadOnly = true;
            this.dgw_fecha.Size = new System.Drawing.Size(537, 249);
            this.dgw_fecha.TabIndex = 31;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(441, 22);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(76, 25);
            this.btn_consultar.TabIndex = 30;
            this.btn_consultar.Text = "Buscar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            // 
            // cb_todos
            // 
            this.cb_todos.AutoSize = true;
            this.cb_todos.Checked = true;
            this.cb_todos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_todos.Location = new System.Drawing.Point(9, 78);
            this.cb_todos.Name = "cb_todos";
            this.cb_todos.Size = new System.Drawing.Size(56, 17);
            this.cb_todos.TabIndex = 29;
            this.cb_todos.Text = "Todos";
            this.cb_todos.UseVisualStyleBackColor = true;
            // 
            // txt_nombre
            // 
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 22);
            this.textBox1.MaxLength = 95;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 37;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Posición:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(59, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 21);
            this.comboBox1.TabIndex = 39;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(275, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(131, 21);
            this.comboBox2.TabIndex = 41;
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
            // id_col
            // 
            this.id_col.HeaderText = "Nro.";
            this.id_col.Name = "id_col";
            this.id_col.ReadOnly = true;
            this.id_col.Visible = false;
            // 
            // nombre_col
            // 
            this.nombre_col.HeaderText = "Nombre";
            this.nombre_col.Name = "nombre_col";
            this.nombre_col.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Club
            // 
            this.Club.HeaderText = "Club";
            this.Club.Name = "Club";
            this.Club.ReadOnly = true;
            this.Club.Width = 75;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 75;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Nro. Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 75;
            // 
            // Posición
            // 
            this.Posición.HeaderText = "Posición";
            this.Posición.Name = "Posición";
            this.Posición.ReadOnly = true;
            this.Posición.Width = 75;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.Width = 75;
            // 
            // estado_col
            // 
            this.estado_col.HeaderText = "Estado";
            this.estado_col.Name = "estado_col";
            this.estado_col.ReadOnly = true;
            this.estado_col.Visible = false;
            this.estado_col.Width = 75;
            // 
            // FrmJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 409);
            this.Controls.Add(this.gb_titulo);
            this.Name = "FrmJugador";
            this.Text = "Gran Colo";
            this.gb_titulo.ResumeLayout(false);
            this.gb_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_fecha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_titulo;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dgw_fecha;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.CheckBox cb_todos;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Club;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posición;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_col;
    }
}