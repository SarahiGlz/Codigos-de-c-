
namespace E6_Articulo
{
    partial class Supermercado
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
            this.grpArticulos = new System.Windows.Forms.GroupBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnCalcularIva = new System.Windows.Forms.Button();
            this.grpArticulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpArticulos
            // 
            this.grpArticulos.Controls.Add(this.btnCalcularIva);
            this.grpArticulos.Controls.Add(this.txtDescripcion);
            this.grpArticulos.Controls.Add(this.txtCantidad);
            this.grpArticulos.Controls.Add(this.txtPrecio);
            this.grpArticulos.Controls.Add(this.txtClave);
            this.grpArticulos.Controls.Add(this.lblDescripcion);
            this.grpArticulos.Controls.Add(this.lblCantidad);
            this.grpArticulos.Controls.Add(this.lblPrecio);
            this.grpArticulos.Controls.Add(this.lblClave);
            this.grpArticulos.Location = new System.Drawing.Point(12, 28);
            this.grpArticulos.Name = "grpArticulos";
            this.grpArticulos.Size = new System.Drawing.Size(223, 225);
            this.grpArticulos.TabIndex = 0;
            this.grpArticulos.TabStop = false;
            this.grpArticulos.Text = "Articulo";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(7, 31);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(7, 65);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio";
            this.lblPrecio.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(7, 95);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 125);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(106, 31);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 4;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(106, 62);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(106, 95);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(0, 141);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(223, 20);
            this.txtDescripcion.TabIndex = 7;
            // 
            // btnCalcularIva
            // 
            this.btnCalcularIva.Location = new System.Drawing.Point(7, 180);
            this.btnCalcularIva.Name = "btnCalcularIva";
            this.btnCalcularIva.Size = new System.Drawing.Size(216, 23);
            this.btnCalcularIva.TabIndex = 8;
            this.btnCalcularIva.Text = "Calcular Iva";
            this.btnCalcularIva.UseVisualStyleBackColor = true;
            this.btnCalcularIva.Click += new System.EventHandler(this.btnCalcularIva_Click);
            // 
            // Supermercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 255);
            this.Controls.Add(this.grpArticulos);
            this.Name = "Supermercado";
            this.Text = "Form1";
            this.grpArticulos.ResumeLayout(false);
            this.grpArticulos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpArticulos;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Button btnCalcularIva;
    }
}

