namespace GranColo.GUILayer.Clubes.Equipos
{
    partial class FrmEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEquipo));
            this.gb_equipo = new System.Windows.Forms.GroupBox();
            this.txt_lema = new System.Windows.Forms.TextBox();
            this.lbl_lema = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.cb_todos = new System.Windows.Forms.CheckBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dgw_equipo = new System.Windows.Forms.DataGridView();
            this.id_equipo_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_equipo_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_equipo_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lema_equipo_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color_equipo_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_color = new System.Windows.Forms.Label();
            this.cbo_color = new System.Windows.Forms.ComboBox();
            this.lbl_dt = new System.Windows.Forms.Label();
            this.cbo_dt = new System.Windows.Forms.ComboBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.gb_equipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_equipo)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_equipo
            // 
            this.gb_equipo.Controls.Add(this.txt_lema);
            this.gb_equipo.Controls.Add(this.lbl_lema);
            this.gb_equipo.Controls.Add(this.btn_cerrar);
            this.gb_equipo.Controls.Add(this.btn_eliminar);
            this.gb_equipo.Controls.Add(this.btn_editar);
            this.gb_equipo.Controls.Add(this.btn_agregar);
            this.gb_equipo.Controls.Add(this.cb_todos);
            this.gb_equipo.Controls.Add(this.btn_buscar);
            this.gb_equipo.Controls.Add(this.dgw_equipo);
            this.gb_equipo.Controls.Add(this.lbl_color);
            this.gb_equipo.Controls.Add(this.cbo_color);
            this.gb_equipo.Controls.Add(this.lbl_dt);
            this.gb_equipo.Controls.Add(this.cbo_dt);
            this.gb_equipo.Controls.Add(this.txt_nombre);
            this.gb_equipo.Controls.Add(this.lbl_nombre);
            this.gb_equipo.Location = new System.Drawing.Point(12, 12);
            this.gb_equipo.Name = "gb_equipo";
            this.gb_equipo.Size = new System.Drawing.Size(461, 439);
            this.gb_equipo.TabIndex = 0;
            this.gb_equipo.TabStop = false;
            this.gb_equipo.Text = "Equipo";
            // 
            // txt_lema
            // 
            this.txt_lema.Location = new System.Drawing.Point(226, 45);
            this.txt_lema.MaxLength = 95;
            this.txt_lema.Name = "txt_lema";
            this.txt_lema.Size = new System.Drawing.Size(121, 20);
            this.txt_lema.TabIndex = 14;
            // 
            // lbl_lema
            // 
            this.lbl_lema.AutoSize = true;
            this.lbl_lema.Location = new System.Drawing.Point(186, 45);
            this.lbl_lema.Name = "lbl_lema";
            this.lbl_lema.Size = new System.Drawing.Size(36, 13);
            this.lbl_lema.TabIndex = 13;
            this.lbl_lema.Text = "Lema:";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(380, 410);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 12;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(171, 410);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 11;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(90, 411);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 10;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(9, 411);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 9;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // cb_todos
            // 
            this.cb_todos.AutoSize = true;
            this.cb_todos.Location = new System.Drawing.Point(9, 69);
            this.cb_todos.Name = "cb_todos";
            this.cb_todos.Size = new System.Drawing.Size(56, 17);
            this.cb_todos.TabIndex = 8;
            this.cb_todos.Text = "Todos";
            this.cb_todos.UseVisualStyleBackColor = true;
            this.cb_todos.CheckedChanged += new System.EventHandler(this.Cb_todos_CheckedChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(380, 15);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 7;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // dgw_equipo
            // 
            this.dgw_equipo.AllowUserToAddRows = false;
            this.dgw_equipo.AllowUserToDeleteRows = false;
            this.dgw_equipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_equipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_equipo_col,
            this.nombre_equipo_col,
            this.dt_equipo_col,
            this.lema_equipo_col,
            this.color_equipo_col});
            this.dgw_equipo.Location = new System.Drawing.Point(9, 92);
            this.dgw_equipo.Name = "dgw_equipo";
            this.dgw_equipo.ReadOnly = true;
            this.dgw_equipo.Size = new System.Drawing.Size(446, 313);
            this.dgw_equipo.TabIndex = 6;
            // 
            // id_equipo_col
            // 
            this.id_equipo_col.HeaderText = "Nro.";
            this.id_equipo_col.Name = "id_equipo_col";
            this.id_equipo_col.ReadOnly = true;
            this.id_equipo_col.Visible = false;
            // 
            // nombre_equipo_col
            // 
            this.nombre_equipo_col.HeaderText = "Nombre";
            this.nombre_equipo_col.Name = "nombre_equipo_col";
            this.nombre_equipo_col.ReadOnly = true;
            // 
            // dt_equipo_col
            // 
            this.dt_equipo_col.HeaderText = "Director Técnico";
            this.dt_equipo_col.Name = "dt_equipo_col";
            this.dt_equipo_col.ReadOnly = true;
            // 
            // lema_equipo_col
            // 
            this.lema_equipo_col.HeaderText = "Lema";
            this.lema_equipo_col.Name = "lema_equipo_col";
            this.lema_equipo_col.ReadOnly = true;
            // 
            // color_equipo_col
            // 
            this.color_equipo_col.HeaderText = "Color";
            this.color_equipo_col.Name = "color_equipo_col";
            this.color_equipo_col.ReadOnly = true;
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Location = new System.Drawing.Point(186, 16);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(34, 13);
            this.lbl_color.TabIndex = 5;
            this.lbl_color.Text = "Color:";
            // 
            // cbo_color
            // 
            this.cbo_color.FormattingEnabled = true;
            this.cbo_color.Location = new System.Drawing.Point(226, 15);
            this.cbo_color.Name = "cbo_color";
            this.cbo_color.Size = new System.Drawing.Size(121, 21);
            this.cbo_color.TabIndex = 4;
            // 
            // lbl_dt
            // 
            this.lbl_dt.AutoSize = true;
            this.lbl_dt.Location = new System.Drawing.Point(6, 45);
            this.lbl_dt.Name = "lbl_dt";
            this.lbl_dt.Size = new System.Drawing.Size(31, 13);
            this.lbl_dt.TabIndex = 3;
            this.lbl_dt.Text = "D.T.:";
            // 
            // cbo_dt
            // 
            this.cbo_dt.FormattingEnabled = true;
            this.cbo_dt.Location = new System.Drawing.Point(59, 42);
            this.cbo_dt.Name = "cbo_dt";
            this.cbo_dt.Size = new System.Drawing.Size(121, 21);
            this.cbo_dt.TabIndex = 2;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(59, 16);
            this.txt_nombre.MaxLength = 45;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(121, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(6, 16);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // FrmEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(481, 458);
            this.Controls.Add(this.gb_equipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gran Colo";
            this.Load += new System.EventHandler(this.FrmEquipo_Load);
            this.gb_equipo.ResumeLayout(false);
            this.gb_equipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_equipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_equipo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_dt;
        private System.Windows.Forms.ComboBox cbo_dt;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.ComboBox cbo_color;
        private System.Windows.Forms.DataGridView dgw_equipo;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.CheckBox cb_todos;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label lbl_lema;
        private System.Windows.Forms.TextBox txt_lema;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_equipo_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_equipo_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_equipo_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn lema_equipo_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn color_equipo_col;
    }
}