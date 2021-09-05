
namespace E11_Costo_Auntomovil
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
            this.lblCostoDelVehiculo = new System.Windows.Forms.Label();
            this.txtCostoDelVehiculo = new System.Windows.Forms.TextBox();
            this.btnCalcularCostoTotal = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCostoDelVehiculo
            // 
            this.lblCostoDelVehiculo.AutoSize = true;
            this.lblCostoDelVehiculo.Location = new System.Drawing.Point(24, 29);
            this.lblCostoDelVehiculo.Name = "lblCostoDelVehiculo";
            this.lblCostoDelVehiculo.Size = new System.Drawing.Size(95, 13);
            this.lblCostoDelVehiculo.TabIndex = 0;
            this.lblCostoDelVehiculo.Text = "Costo del Vehiculo";
            // 
            // txtCostoDelVehiculo
            // 
            this.txtCostoDelVehiculo.Location = new System.Drawing.Point(125, 26);
            this.txtCostoDelVehiculo.Name = "txtCostoDelVehiculo";
            this.txtCostoDelVehiculo.Size = new System.Drawing.Size(92, 20);
            this.txtCostoDelVehiculo.TabIndex = 1;
            // 
            // btnCalcularCostoTotal
            // 
            this.btnCalcularCostoTotal.Location = new System.Drawing.Point(27, 65);
            this.btnCalcularCostoTotal.Name = "btnCalcularCostoTotal";
            this.btnCalcularCostoTotal.Size = new System.Drawing.Size(120, 24);
            this.btnCalcularCostoTotal.TabIndex = 2;
            this.btnCalcularCostoTotal.Text = "Calcular Costo Total";
            this.btnCalcularCostoTotal.UseVisualStyleBackColor = true;
            this.btnCalcularCostoTotal.Click += new System.EventHandler(this.btnCalcularCostoTotal_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(153, 65);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 125);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcularCostoTotal);
            this.Controls.Add(this.txtCostoDelVehiculo);
            this.Controls.Add(this.lblCostoDelVehiculo);
            this.Name = "Form1";
            this.Text = "Costo Automovil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCostoDelVehiculo;
        private System.Windows.Forms.TextBox txtCostoDelVehiculo;
        private System.Windows.Forms.Button btnCalcularCostoTotal;
        private System.Windows.Forms.Button btnSalir;
    }
}

