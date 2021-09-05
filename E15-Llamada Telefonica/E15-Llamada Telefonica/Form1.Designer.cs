
namespace E15_Llamada_Telefonica
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
            this.lblCantidadDeMinutos = new System.Windows.Forms.Label();
            this.txtCantidadDeMinutos = new System.Windows.Forms.TextBox();
            this.btnCalcularCosto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCantidadDeMinutos
            // 
            this.lblCantidadDeMinutos.AutoSize = true;
            this.lblCantidadDeMinutos.Location = new System.Drawing.Point(37, 32);
            this.lblCantidadDeMinutos.Name = "lblCantidadDeMinutos";
            this.lblCantidadDeMinutos.Size = new System.Drawing.Size(103, 13);
            this.lblCantidadDeMinutos.TabIndex = 0;
            this.lblCantidadDeMinutos.Text = "Cantidad de minutos";
            // 
            // txtCantidadDeMinutos
            // 
            this.txtCantidadDeMinutos.Location = new System.Drawing.Point(141, 29);
            this.txtCantidadDeMinutos.Name = "txtCantidadDeMinutos";
            this.txtCantidadDeMinutos.Size = new System.Drawing.Size(75, 20);
            this.txtCantidadDeMinutos.TabIndex = 1;
            // 
            // btnCalcularCosto
            // 
            this.btnCalcularCosto.Location = new System.Drawing.Point(36, 66);
            this.btnCalcularCosto.Name = "btnCalcularCosto";
            this.btnCalcularCosto.Size = new System.Drawing.Size(95, 23);
            this.btnCalcularCosto.TabIndex = 2;
            this.btnCalcularCosto.Text = "Calcular Costo";
            this.btnCalcularCosto.UseVisualStyleBackColor = true;
            this.btnCalcularCosto.Click += new System.EventHandler(this.btnCalcularCosto_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(141, 66);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 116);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcularCosto);
            this.Controls.Add(this.txtCantidadDeMinutos);
            this.Controls.Add(this.lblCantidadDeMinutos);
            this.Name = "Form1";
            this.Text = "Llamada Telefonica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantidadDeMinutos;
        private System.Windows.Forms.TextBox txtCantidadDeMinutos;
        private System.Windows.Forms.Button btnCalcularCosto;
        private System.Windows.Forms.Button btnSalir;
    }
}

