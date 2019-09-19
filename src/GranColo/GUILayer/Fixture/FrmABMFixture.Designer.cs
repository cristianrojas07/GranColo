namespace GranColo.GUILayer.Fixture
{
    partial class FrmABMFixture
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.gb_titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_titulo
            // 
            this.gb_titulo.Controls.Add(this.btn_salir);
            this.gb_titulo.Controls.Add(this.btn_aceptar);
            this.gb_titulo.Controls.Add(this.txt_nombre);
            this.gb_titulo.Controls.Add(this.lbl_nombre);
            this.gb_titulo.Location = new System.Drawing.Point(13, 13);
            this.gb_titulo.Name = "gb_titulo";
            this.gb_titulo.Size = new System.Drawing.Size(405, 106);
            this.gb_titulo.TabIndex = 0;
            this.gb_titulo.TabStop = false;
            this.gb_titulo.Text = "groupBox1";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(324, 77);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Cerrar";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(6, 77);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 2;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.Btn_aceptar_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(60, 32);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(113, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(7, 35);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // FrmABMFixture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 123);
            this.Controls.Add(this.gb_titulo);
            this.Name = "FrmABMFixture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmABMFixture";
            this.gb_titulo.ResumeLayout(false);
            this.gb_titulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_titulo;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_salir;
    }
}