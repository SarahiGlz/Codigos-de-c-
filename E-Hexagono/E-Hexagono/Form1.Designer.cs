
namespace E_Hexagono
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpHexagono = new System.Windows.Forms.GroupBox();
            this.radHexagonoVerde = new System.Windows.Forms.RadioButton();
            this.radHexagonoRojo = new System.Windows.Forms.RadioButton();
            this.lblLado = new System.Windows.Forms.Label();
            this.lblApotema = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.txtApotema = new System.Windows.Forms.TextBox();
            this.btnGuardarDatos = new System.Windows.Forms.Button();
            this.btnCalcularCantidadDePintura = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpHexagono.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpHexagono
            // 
            this.grpHexagono.Controls.Add(this.radHexagonoRojo);
            this.grpHexagono.Controls.Add(this.radHexagonoVerde);
            this.grpHexagono.Location = new System.Drawing.Point(10, 33);
            this.grpHexagono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpHexagono.Name = "grpHexagono";
            this.grpHexagono.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpHexagono.Size = new System.Drawing.Size(154, 109);
            this.grpHexagono.TabIndex = 0;
            this.grpHexagono.TabStop = false;
            this.grpHexagono.Text = "Adornos Hexágonales";
            // 
            // radHexagonoVerde
            // 
            this.radHexagonoVerde.AutoSize = true;
            this.radHexagonoVerde.Location = new System.Drawing.Point(8, 42);
            this.radHexagonoVerde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radHexagonoVerde.Name = "radHexagonoVerde";
            this.radHexagonoVerde.Size = new System.Drawing.Size(125, 21);
            this.radHexagonoVerde.TabIndex = 0;
            this.radHexagonoVerde.TabStop = true;
            this.radHexagonoVerde.Text = "Hexágono Verde";
            this.radHexagonoVerde.UseVisualStyleBackColor = true;
            // 
            // radHexagonoRojo
            // 
            this.radHexagonoRojo.AutoSize = true;
            this.radHexagonoRojo.Location = new System.Drawing.Point(8, 72);
            this.radHexagonoRojo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radHexagonoRojo.Name = "radHexagonoRojo";
            this.radHexagonoRojo.Size = new System.Drawing.Size(117, 21);
            this.radHexagonoRojo.TabIndex = 1;
            this.radHexagonoRojo.TabStop = true;
            this.radHexagonoRojo.Text = "Hexágono Rojo";
            this.radHexagonoRojo.UseVisualStyleBackColor = true;
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(176, 33);
            this.lblLado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(37, 17);
            this.lblLado.TabIndex = 1;
            this.lblLado.Text = "Lado";
            // 
            // lblApotema
            // 
            this.lblApotema.AutoSize = true;
            this.lblApotema.Location = new System.Drawing.Point(172, 64);
            this.lblApotema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApotema.Name = "lblApotema";
            this.lblApotema.Size = new System.Drawing.Size(61, 17);
            this.lblApotema.TabIndex = 2;
            this.lblApotema.Text = "Apotema";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(241, 30);
            this.txtLado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(74, 23);
            this.txtLado.TabIndex = 3;
            // 
            // txtApotema
            // 
            this.txtApotema.Location = new System.Drawing.Point(241, 62);
            this.txtApotema.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApotema.Name = "txtApotema";
            this.txtApotema.Size = new System.Drawing.Size(74, 23);
            this.txtApotema.TabIndex = 4;
            // 
            // btnGuardarDatos
            // 
            this.btnGuardarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarDatos.Location = new System.Drawing.Point(179, 114);
            this.btnGuardarDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarDatos.Name = "btnGuardarDatos";
            this.btnGuardarDatos.Size = new System.Drawing.Size(144, 30);
            this.btnGuardarDatos.TabIndex = 5;
            this.btnGuardarDatos.Text = "Guardar Datos";
            this.btnGuardarDatos.UseVisualStyleBackColor = false;
            this.btnGuardarDatos.Click += new System.EventHandler(this.btnGuardarDatos_Click);
            // 
            // btnCalcularCantidadDePintura
            // 
            this.btnCalcularCantidadDePintura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCalcularCantidadDePintura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcularCantidadDePintura.Location = new System.Drawing.Point(179, 152);
            this.btnCalcularCantidadDePintura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcularCantidadDePintura.Name = "btnCalcularCantidadDePintura";
            this.btnCalcularCantidadDePintura.Size = new System.Drawing.Size(144, 47);
            this.btnCalcularCantidadDePintura.TabIndex = 6;
            this.btnCalcularCantidadDePintura.Text = "Calcular Cantidad De Pintura";
            this.btnCalcularCantidadDePintura.UseVisualStyleBackColor = false;
            this.btnCalcularCantidadDePintura.Click += new System.EventHandler(this.btnCalcularCantidadDePintura_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Location = new System.Drawing.Point(179, 207);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(144, 30);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(333, 254);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcularCantidadDePintura);
            this.Controls.Add(this.btnGuardarDatos);
            this.Controls.Add(this.txtApotema);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.lblApotema);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.grpHexagono);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Hexágonos";
            this.grpHexagono.ResumeLayout(false);
            this.grpHexagono.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpHexagono;
        private System.Windows.Forms.RadioButton radHexagonoRojo;
        private System.Windows.Forms.RadioButton radHexagonoVerde;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.Label lblApotema;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.TextBox txtApotema;
        private System.Windows.Forms.Button btnGuardarDatos;
        private System.Windows.Forms.Button btnCalcularCantidadDePintura;
        private System.Windows.Forms.Button btnSalir;
    }
}

