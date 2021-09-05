
namespace E12_Distancia
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
            this.grpCoordenadas = new System.Windows.Forms.GroupBox();
            this.lblCoordenadaX = new System.Windows.Forms.Label();
            this.lblCoordenadaY = new System.Windows.Forms.Label();
            this.txtCoordenadaX = new System.Windows.Forms.TextBox();
            this.txtCoordenadaY = new System.Windows.Forms.TextBox();
            this.grpPunto = new System.Windows.Forms.GroupBox();
            this.radPuntoUno = new System.Windows.Forms.RadioButton();
            this.radPuntoDos = new System.Windows.Forms.RadioButton();
            this.btnCapturarCoordenada = new System.Windows.Forms.Button();
            this.btnCalcularDistancia = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpCoordenadas.SuspendLayout();
            this.grpPunto.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCoordenadas
            // 
            this.grpCoordenadas.Controls.Add(this.txtCoordenadaY);
            this.grpCoordenadas.Controls.Add(this.txtCoordenadaX);
            this.grpCoordenadas.Controls.Add(this.lblCoordenadaY);
            this.grpCoordenadas.Controls.Add(this.lblCoordenadaX);
            this.grpCoordenadas.Location = new System.Drawing.Point(12, 26);
            this.grpCoordenadas.Name = "grpCoordenadas";
            this.grpCoordenadas.Size = new System.Drawing.Size(200, 100);
            this.grpCoordenadas.TabIndex = 0;
            this.grpCoordenadas.TabStop = false;
            this.grpCoordenadas.Text = "Coordenadas del punto";
            // 
            // lblCoordenadaX
            // 
            this.lblCoordenadaX.AutoSize = true;
            this.lblCoordenadaX.Location = new System.Drawing.Point(7, 31);
            this.lblCoordenadaX.Name = "lblCoordenadaX";
            this.lblCoordenadaX.Size = new System.Drawing.Size(75, 13);
            this.lblCoordenadaX.TabIndex = 0;
            this.lblCoordenadaX.Text = "Coordenada X";
            // 
            // lblCoordenadaY
            // 
            this.lblCoordenadaY.AutoSize = true;
            this.lblCoordenadaY.Location = new System.Drawing.Point(7, 62);
            this.lblCoordenadaY.Name = "lblCoordenadaY";
            this.lblCoordenadaY.Size = new System.Drawing.Size(75, 13);
            this.lblCoordenadaY.TabIndex = 1;
            this.lblCoordenadaY.Text = "Coordenada Y";
            // 
            // txtCoordenadaX
            // 
            this.txtCoordenadaX.Location = new System.Drawing.Point(88, 31);
            this.txtCoordenadaX.Name = "txtCoordenadaX";
            this.txtCoordenadaX.Size = new System.Drawing.Size(71, 20);
            this.txtCoordenadaX.TabIndex = 2;
            // 
            // txtCoordenadaY
            // 
            this.txtCoordenadaY.Location = new System.Drawing.Point(88, 62);
            this.txtCoordenadaY.Name = "txtCoordenadaY";
            this.txtCoordenadaY.Size = new System.Drawing.Size(71, 20);
            this.txtCoordenadaY.TabIndex = 3;
            // 
            // grpPunto
            // 
            this.grpPunto.Controls.Add(this.radPuntoDos);
            this.grpPunto.Controls.Add(this.radPuntoUno);
            this.grpPunto.Location = new System.Drawing.Point(12, 152);
            this.grpPunto.Name = "grpPunto";
            this.grpPunto.Size = new System.Drawing.Size(200, 100);
            this.grpPunto.TabIndex = 1;
            this.grpPunto.TabStop = false;
            this.grpPunto.Text = "Seleccione un punto";
            // 
            // radPuntoUno
            // 
            this.radPuntoUno.AutoSize = true;
            this.radPuntoUno.Location = new System.Drawing.Point(7, 31);
            this.radPuntoUno.Name = "radPuntoUno";
            this.radPuntoUno.Size = new System.Drawing.Size(62, 17);
            this.radPuntoUno.TabIndex = 0;
            this.radPuntoUno.TabStop = true;
            this.radPuntoUno.Text = "Punto 1";
            this.radPuntoUno.UseVisualStyleBackColor = true;
            // 
            // radPuntoDos
            // 
            this.radPuntoDos.AutoSize = true;
            this.radPuntoDos.Location = new System.Drawing.Point(10, 64);
            this.radPuntoDos.Name = "radPuntoDos";
            this.radPuntoDos.Size = new System.Drawing.Size(62, 17);
            this.radPuntoDos.TabIndex = 1;
            this.radPuntoDos.TabStop = true;
            this.radPuntoDos.Text = "Punto 2";
            this.radPuntoDos.UseVisualStyleBackColor = true;
            // 
            // btnCapturarCoordenada
            // 
            this.btnCapturarCoordenada.Location = new System.Drawing.Point(229, 63);
            this.btnCapturarCoordenada.Name = "btnCapturarCoordenada";
            this.btnCapturarCoordenada.Size = new System.Drawing.Size(75, 34);
            this.btnCapturarCoordenada.TabIndex = 2;
            this.btnCapturarCoordenada.Text = "Capturar Coordenada";
            this.btnCapturarCoordenada.UseVisualStyleBackColor = true;
            this.btnCapturarCoordenada.Click += new System.EventHandler(this.btnCapturarCoordenada_Click);
            // 
            // btnCalcularDistancia
            // 
            this.btnCalcularDistancia.Location = new System.Drawing.Point(229, 126);
            this.btnCalcularDistancia.Name = "btnCalcularDistancia";
            this.btnCalcularDistancia.Size = new System.Drawing.Size(75, 42);
            this.btnCalcularDistancia.TabIndex = 3;
            this.btnCalcularDistancia.Text = "Calcular Distancia";
            this.btnCalcularDistancia.UseVisualStyleBackColor = true;
            this.btnCalcularDistancia.Click += new System.EventHandler(this.btnCalcularDistancia_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(229, 197);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 273);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcularDistancia);
            this.Controls.Add(this.btnCapturarCoordenada);
            this.Controls.Add(this.grpPunto);
            this.Controls.Add(this.grpCoordenadas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpCoordenadas.ResumeLayout(false);
            this.grpCoordenadas.PerformLayout();
            this.grpPunto.ResumeLayout(false);
            this.grpPunto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCoordenadas;
        private System.Windows.Forms.TextBox txtCoordenadaY;
        private System.Windows.Forms.TextBox txtCoordenadaX;
        private System.Windows.Forms.Label lblCoordenadaY;
        private System.Windows.Forms.Label lblCoordenadaX;
        private System.Windows.Forms.GroupBox grpPunto;
        private System.Windows.Forms.RadioButton radPuntoDos;
        private System.Windows.Forms.RadioButton radPuntoUno;
        private System.Windows.Forms.Button btnCapturarCoordenada;
        private System.Windows.Forms.Button btnCalcularDistancia;
        private System.Windows.Forms.Button btnSalir;
    }
}

