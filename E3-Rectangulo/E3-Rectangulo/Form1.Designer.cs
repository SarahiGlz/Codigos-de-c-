
namespace E3_Rectangulo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLargo = new System.Windows.Forms.Label();
            this.lblAncho = new System.Windows.Forms.Label();
            this.txtLargo = new System.Windows.Forms.TextBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.radVentana = new System.Windows.Forms.RadioButton();
            this.radPared = new System.Windows.Forms.RadioButton();
            this.btnCapturarDatos = new System.Windows.Forms.Button();
            this.btnTiempo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpObjetos = new System.Windows.Forms.GroupBox();
            this.grpObjetos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLargo
            // 
            this.lblLargo.AutoSize = true;
            this.lblLargo.Location = new System.Drawing.Point(117, 33);
            this.lblLargo.Name = "lblLargo";
            this.lblLargo.Size = new System.Drawing.Size(34, 13);
            this.lblLargo.TabIndex = 0;
            this.lblLargo.Text = "Largo";
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(117, 71);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(38, 13);
            this.lblAncho.TabIndex = 1;
            this.lblAncho.Text = "Ancho";
            // 
            // txtLargo
            // 
            this.txtLargo.Location = new System.Drawing.Point(161, 37);
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(56, 20);
            this.txtLargo.TabIndex = 2;
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(161, 68);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(56, 20);
            this.txtAncho.TabIndex = 3;
            // 
            // radVentana
            // 
            this.radVentana.AutoSize = true;
            this.radVentana.Location = new System.Drawing.Point(6, 27);
            this.radVentana.Name = "radVentana";
            this.radVentana.Size = new System.Drawing.Size(65, 17);
            this.radVentana.TabIndex = 4;
            this.radVentana.TabStop = true;
            this.radVentana.Text = "Ventana";
            this.radVentana.UseVisualStyleBackColor = true;
            // 
            // radPared
            // 
            this.radPared.AutoSize = true;
            this.radPared.Location = new System.Drawing.Point(6, 50);
            this.radPared.Name = "radPared";
            this.radPared.Size = new System.Drawing.Size(53, 17);
            this.radPared.TabIndex = 5;
            this.radPared.TabStop = true;
            this.radPared.Text = "Pared";
            this.radPared.UseVisualStyleBackColor = true;
            // 
            // btnCapturarDatos
            // 
            this.btnCapturarDatos.Location = new System.Drawing.Point(120, 106);
            this.btnCapturarDatos.Name = "btnCapturarDatos";
            this.btnCapturarDatos.Size = new System.Drawing.Size(97, 26);
            this.btnCapturarDatos.TabIndex = 6;
            this.btnCapturarDatos.Text = "Capturar datos";
            this.btnCapturarDatos.UseVisualStyleBackColor = true;
            this.btnCapturarDatos.Click += new System.EventHandler(this.btnCapturarDatos_Click);
            // 
            // btnTiempo
            // 
            this.btnTiempo.Location = new System.Drawing.Point(120, 138);
            this.btnTiempo.Name = "btnTiempo";
            this.btnTiempo.Size = new System.Drawing.Size(97, 22);
            this.btnTiempo.TabIndex = 7;
            this.btnTiempo.Text = "Tiempo";
            this.btnTiempo.UseVisualStyleBackColor = true;
            this.btnTiempo.Click += new System.EventHandler(this.btnTiempo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(120, 166);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grpObjetos
            // 
            this.grpObjetos.Controls.Add(this.radPared);
            this.grpObjetos.Controls.Add(this.radVentana);
            this.grpObjetos.Location = new System.Drawing.Point(19, 14);
            this.grpObjetos.Name = "grpObjetos";
            this.grpObjetos.Size = new System.Drawing.Size(84, 78);
            this.grpObjetos.TabIndex = 10;
            this.grpObjetos.TabStop = false;
            this.grpObjetos.Text = "Objetos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 199);
            this.Controls.Add(this.grpObjetos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnTiempo);
            this.Controls.Add(this.btnCapturarDatos);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.txtLargo);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.lblLargo);
            this.Name = "Form1";
            this.Text = "Tiempo en pintar pared";
            this.grpObjetos.ResumeLayout(false);
            this.grpObjetos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLargo;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.TextBox txtLargo;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.RadioButton radVentana;
        private System.Windows.Forms.RadioButton radPared;
        private System.Windows.Forms.Button btnCapturarDatos;
        private System.Windows.Forms.Button btnTiempo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grpObjetos;
    }
}

