namespace GranColo.GUILayer.Fixture
{
    partial class FrmConsultarAsignarFecha
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
            this.dgw_asignadas = new System.Windows.Forms.DataGridView();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.cbo_torneo = new System.Windows.Forms.ComboBox();
            this.lbl_torneo = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.cb_todos = new System.Windows.Forms.CheckBox();
            this.nombre_torneo_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_torneo_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_fecha_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_fecha_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_asignadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_asignadas
            // 
            this.dgw_asignadas.AllowUserToAddRows = false;
            this.dgw_asignadas.AllowUserToDeleteRows = false;
            this.dgw_asignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_asignadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre_torneo_col,
            this.id_torneo_col,
            this.id_fecha_col,
            this.nombre_fecha_col,
            this.estado_col});
            this.dgw_asignadas.Location = new System.Drawing.Point(12, 64);
            this.dgw_asignadas.Name = "dgw_asignadas";
            this.dgw_asignadas.ReadOnly = true;
            this.dgw_asignadas.Size = new System.Drawing.Size(378, 355);
            this.dgw_asignadas.TabIndex = 1;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(12, 425);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 2;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(93, 425);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(315, 425);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // cbo_torneo
            // 
            this.cbo_torneo.FormattingEnabled = true;
            this.cbo_torneo.Location = new System.Drawing.Point(62, 14);
            this.cbo_torneo.Name = "cbo_torneo";
            this.cbo_torneo.Size = new System.Drawing.Size(149, 21);
            this.cbo_torneo.TabIndex = 5;
            // 
            // lbl_torneo
            // 
            this.lbl_torneo.AutoSize = true;
            this.lbl_torneo.Location = new System.Drawing.Point(12, 17);
            this.lbl_torneo.Name = "lbl_torneo";
            this.lbl_torneo.Size = new System.Drawing.Size(44, 13);
            this.lbl_torneo.TabIndex = 7;
            this.lbl_torneo.Text = "Torneo:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(315, 14);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 9;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // cb_todos
            // 
            this.cb_todos.AutoSize = true;
            this.cb_todos.Location = new System.Drawing.Point(12, 41);
            this.cb_todos.Name = "cb_todos";
            this.cb_todos.Size = new System.Drawing.Size(56, 17);
            this.cb_todos.TabIndex = 10;
            this.cb_todos.Text = "Todos";
            this.cb_todos.UseVisualStyleBackColor = true;
            // 
            // nombre_torneo_col
            // 
            this.nombre_torneo_col.HeaderText = "Torneo";
            this.nombre_torneo_col.Name = "nombre_torneo_col";
            this.nombre_torneo_col.ReadOnly = true;
            this.nombre_torneo_col.Width = 166;
            // 
            // id_torneo_col
            // 
            this.id_torneo_col.HeaderText = "idTorneo";
            this.id_torneo_col.Name = "id_torneo_col";
            this.id_torneo_col.ReadOnly = true;
            this.id_torneo_col.Visible = false;
            // 
            // id_fecha_col
            // 
            this.id_fecha_col.HeaderText = "idFecha";
            this.id_fecha_col.Name = "id_fecha_col";
            this.id_fecha_col.ReadOnly = true;
            this.id_fecha_col.Visible = false;
            // 
            // nombre_fecha_col
            // 
            this.nombre_fecha_col.HeaderText = "Fecha";
            this.nombre_fecha_col.Name = "nombre_fecha_col";
            this.nombre_fecha_col.ReadOnly = true;
            this.nombre_fecha_col.Width = 166;
            // 
            // estado_col
            // 
            this.estado_col.HeaderText = "Estado";
            this.estado_col.Name = "estado_col";
            this.estado_col.ReadOnly = true;
            this.estado_col.Visible = false;
            // 
            // FrmAMBAsignarFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(402, 456);
            this.Controls.Add(this.cb_todos);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lbl_torneo);
            this.Controls.Add(this.cbo_torneo);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.dgw_asignadas);
            this.MaximizeBox = false;
            this.Name = "FrmAMBAsignarFecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gran Colo";
            this.Load += new System.EventHandler(this.FrmAMBAsignarFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_asignadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_asignadas;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.ComboBox cbo_torneo;
        private System.Windows.Forms.Label lbl_torneo;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.CheckBox cb_todos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_torneo_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_torneo_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_fecha_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_fecha_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_col;
    }
}