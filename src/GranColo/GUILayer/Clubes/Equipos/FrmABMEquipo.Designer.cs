namespace GranColo.GUILayer.Clubes.Equipos
{
    partial class FrmABMEquipo
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
            this.gb_equipo = new System.Windows.Forms.GroupBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_dt = new System.Windows.Forms.Label();
            this.cbo_dt = new System.Windows.Forms.ComboBox();
            this.lbl_lema = new System.Windows.Forms.Label();
            this.txt_lema = new System.Windows.Forms.TextBox();
            this.lbl_color = new System.Windows.Forms.Label();
            this.cbo_color = new System.Windows.Forms.ComboBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.gb_equipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_equipo
            // 
            this.gb_equipo.Controls.Add(this.btn_cerrar);
            this.gb_equipo.Controls.Add(this.btn_aceptar);
            this.gb_equipo.Controls.Add(this.cbo_color);
            this.gb_equipo.Controls.Add(this.lbl_color);
            this.gb_equipo.Controls.Add(this.txt_lema);
            this.gb_equipo.Controls.Add(this.lbl_lema);
            this.gb_equipo.Controls.Add(this.cbo_dt);
            this.gb_equipo.Controls.Add(this.lbl_dt);
            this.gb_equipo.Controls.Add(this.txt_nombre);
            this.gb_equipo.Controls.Add(this.lbl_nombre);
            this.gb_equipo.Location = new System.Drawing.Point(13, 13);
            this.gb_equipo.Name = "gb_equipo";
            this.gb_equipo.Size = new System.Drawing.Size(374, 104);
            this.gb_equipo.TabIndex = 0;
            this.gb_equipo.TabStop = false;
            this.gb_equipo.Text = "Equipo";
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
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(59, 16);
            this.txt_nombre.MaxLength = 45;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(121, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // lbl_dt
            // 
            this.lbl_dt.AutoSize = true;
            this.lbl_dt.Location = new System.Drawing.Point(6, 45);
            this.lbl_dt.Name = "lbl_dt";
            this.lbl_dt.Size = new System.Drawing.Size(31, 13);
            this.lbl_dt.TabIndex = 2;
            this.lbl_dt.Text = "D.T.:";
            // 
            // cbo_dt
            // 
            this.cbo_dt.FormattingEnabled = true;
            this.cbo_dt.Location = new System.Drawing.Point(59, 42);
            this.cbo_dt.Name = "cbo_dt";
            this.cbo_dt.Size = new System.Drawing.Size(121, 21);
            this.cbo_dt.TabIndex = 3;
            // 
            // lbl_lema
            // 
            this.lbl_lema.AutoSize = true;
            this.lbl_lema.Location = new System.Drawing.Point(197, 16);
            this.lbl_lema.Name = "lbl_lema";
            this.lbl_lema.Size = new System.Drawing.Size(36, 13);
            this.lbl_lema.TabIndex = 4;
            this.lbl_lema.Text = "Lema:";
            // 
            // txt_lema
            // 
            this.txt_lema.Location = new System.Drawing.Point(239, 16);
            this.txt_lema.MaxLength = 95;
            this.txt_lema.Name = "txt_lema";
            this.txt_lema.Size = new System.Drawing.Size(121, 20);
            this.txt_lema.TabIndex = 5;
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Location = new System.Drawing.Point(197, 45);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(34, 13);
            this.lbl_color.TabIndex = 6;
            this.lbl_color.Text = "Color:";
            // 
            // cbo_color
            // 
            this.cbo_color.FormattingEnabled = true;
            this.cbo_color.Location = new System.Drawing.Point(239, 42);
            this.cbo_color.Name = "cbo_color";
            this.cbo_color.Size = new System.Drawing.Size(121, 21);
            this.cbo_color.TabIndex = 7;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(9, 69);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 8;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(285, 69);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 9;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            // 
            // FrmABMEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(397, 126);
            this.Controls.Add(this.gb_equipo);
            this.MaximizeBox = false;
            this.Name = "FrmABMEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gran Colo";
            this.gb_equipo.ResumeLayout(false);
            this.gb_equipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_equipo;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_dt;
        private System.Windows.Forms.TextBox txt_lema;
        private System.Windows.Forms.Label lbl_lema;
        private System.Windows.Forms.ComboBox cbo_dt;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.ComboBox cbo_color;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cerrar;
    }
}