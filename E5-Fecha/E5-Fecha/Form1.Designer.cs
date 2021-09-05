
namespace E5_Fecha
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
            this.lblDia = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.btnCapturarFecha = new System.Windows.Forms.Button();
            this.btnMostrarFechaDMA = new System.Windows.Forms.Button();
            this.btnFechaEnLetra = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(20, 36);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(23, 13);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "Dia";
            this.lblDia.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(20, 61);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(27, 13);
            this.lblMes.TabIndex = 1;
            this.lblMes.Text = "Mes";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(20, 84);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(26, 13);
            this.lblAño.TabIndex = 2;
            this.lblAño.Text = "Año";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(73, 32);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(40, 20);
            this.txtDia.TabIndex = 3;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(73, 58);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(40, 20);
            this.txtMes.TabIndex = 4;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(73, 84);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(40, 20);
            this.txtAño.TabIndex = 5;
            // 
            // btnCapturarFecha
            // 
            this.btnCapturarFecha.Location = new System.Drawing.Point(12, 116);
            this.btnCapturarFecha.Name = "btnCapturarFecha";
            this.btnCapturarFecha.Size = new System.Drawing.Size(101, 34);
            this.btnCapturarFecha.TabIndex = 6;
            this.btnCapturarFecha.Text = "Capturar Fecha";
            this.btnCapturarFecha.UseVisualStyleBackColor = true;
            // 
            // btnMostrarFechaDMA
            // 
            this.btnMostrarFechaDMA.Location = new System.Drawing.Point(134, 31);
            this.btnMostrarFechaDMA.Name = "btnMostrarFechaDMA";
            this.btnMostrarFechaDMA.Size = new System.Drawing.Size(107, 34);
            this.btnMostrarFechaDMA.TabIndex = 7;
            this.btnMostrarFechaDMA.Text = "Mostrar Fecha D/M/A";
            this.btnMostrarFechaDMA.UseVisualStyleBackColor = true;
            // 
            // btnFechaEnLetra
            // 
            this.btnFechaEnLetra.Location = new System.Drawing.Point(134, 71);
            this.btnFechaEnLetra.Name = "btnFechaEnLetra";
            this.btnFechaEnLetra.Size = new System.Drawing.Size(107, 45);
            this.btnFechaEnLetra.TabIndex = 8;
            this.btnFechaEnLetra.Text = "Mostrar fecha en letra";
            this.btnFechaEnLetra.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(134, 122);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 162);
            this.Controls.Add(this.btnCapturarFecha);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.btnFechaEnLetra);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.btnMostrarFechaDMA);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtAño);
            this.Name = "Form1";
            this.Text = "fecha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Button btnCapturarFecha;
        private System.Windows.Forms.Button btnMostrarFechaDMA;
        private System.Windows.Forms.Button btnFechaEnLetra;
        private System.Windows.Forms.Button btnSalir;
    }
}

