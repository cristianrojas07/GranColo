namespace GranColo.GUILayer.Fixture
{
    partial class FrmTorneo
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
            this.dgw_torneo = new System.Windows.Forms.DataGridView();
            this.id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.cb_todos = new System.Windows.Forms.CheckBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.gb_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_torneo)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_titulo
            // 
            this.gb_titulo.Controls.Add(this.btn_cerrar);
            this.gb_titulo.Controls.Add(this.btn_eliminar);
            this.gb_titulo.Controls.Add(this.btn_editar);
            this.gb_titulo.Controls.Add(this.btn_agregar);
            this.gb_titulo.Controls.Add(this.dgw_torneo);
            this.gb_titulo.Controls.Add(this.btn_consultar);
            this.gb_titulo.Controls.Add(this.cb_todos);
            this.gb_titulo.Controls.Add(this.txt_nombre);
            this.gb_titulo.Controls.Add(this.lbl_nombre);
            this.gb_titulo.Location = new System.Drawing.Point(12, 12);
            this.gb_titulo.Name = "gb_titulo";
            this.gb_titulo.Size = new System.Drawing.Size(382, 448);
            this.gb_titulo.TabIndex = 2;
            this.gb_titulo.TabStop = false;
            this.gb_titulo.Text = "Torneo";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(277, 421);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 35;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(167, 421);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 34;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(86, 421);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 33;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(5, 421);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 32;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // dgw_torneo
            // 
            this.dgw_torneo.AllowUserToAddRows = false;
            this.dgw_torneo.AllowUserToDeleteRows = false;
            this.dgw_torneo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_torneo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_col,
            this.nombre_col,
            this.estado_col});
            this.dgw_torneo.Location = new System.Drawing.Point(5, 95);
            this.dgw_torneo.Name = "dgw_torneo";
            this.dgw_torneo.ReadOnly = true;
            this.dgw_torneo.Size = new System.Drawing.Size(346, 319);
            this.dgw_torneo.TabIndex = 31;
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
            this.nombre_col.Width = 303;
            // 
            // estado_col
            // 
            this.estado_col.HeaderText = "Estado";
            this.estado_col.Name = "estado_col";
            this.estado_col.ReadOnly = true;
            this.estado_col.Visible = false;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(275, 21);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(76, 25);
            this.btn_consultar.TabIndex = 30;
            this.btn_consultar.Text = "Buscar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.Btn_consultar_Click);
            // 
            // cb_todos
            // 
            this.cb_todos.AutoSize = true;
            this.cb_todos.Checked = true;
            this.cb_todos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_todos.Location = new System.Drawing.Point(9, 55);
            this.cb_todos.Name = "cb_todos";
            this.cb_todos.Size = new System.Drawing.Size(56, 17);
            this.cb_todos.TabIndex = 29;
            this.cb_todos.Text = "Todos";
            this.cb_todos.UseVisualStyleBackColor = true;
            this.cb_todos.CheckedChanged += new System.EventHandler(this.cb_todos_CheckedChanged);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Location = new System.Drawing.Point(59, 24);
            this.txt_nombre.MaxLength = 95;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(173, 20);
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
            // FrmTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(403, 473);
            this.Controls.Add(this.gb_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTorneo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gran Colo";
            this.gb_titulo.ResumeLayout(false);
            this.gb_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_torneo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_titulo;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dgw_torneo;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.CheckBox cb_todos;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_col;
    }
}