
namespace E8_Cambio_Divisas
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
            this.lblPesos = new System.Windows.Forms.Label();
            this.txtPesos = new System.Windows.Forms.TextBox();
            this.btnConvertirADolares = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPesos
            // 
            this.lblPesos.AutoSize = true;
            this.lblPesos.Location = new System.Drawing.Point(25, 30);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(36, 13);
            this.lblPesos.TabIndex = 0;
            this.lblPesos.Text = "Pesos";
            // 
            // txtPesos
            // 
            this.txtPesos.Location = new System.Drawing.Point(77, 30);
            this.txtPesos.Name = "txtPesos";
            this.txtPesos.Size = new System.Drawing.Size(100, 20);
            this.txtPesos.TabIndex = 1;
            // 
            // btnConvertirADolares
            // 
            this.btnConvertirADolares.Location = new System.Drawing.Point(28, 67);
            this.btnConvertirADolares.Name = "btnConvertirADolares";
            this.btnConvertirADolares.Size = new System.Drawing.Size(75, 23);
            this.btnConvertirADolares.TabIndex = 2;
            this.btnConvertirADolares.Text = "Dolares";
            this.btnConvertirADolares.UseVisualStyleBackColor = true;
            this.btnConvertirADolares.Click += new System.EventHandler(this.btnConvertirADolares_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(135, 67);
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
            this.ClientSize = new System.Drawing.Size(236, 121);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConvertirADolares);
            this.Controls.Add(this.txtPesos);
            this.Controls.Add(this.lblPesos);
            this.Name = "Form1";
            this.Text = "Cambio de Divisas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPesos;
        private System.Windows.Forms.TextBox txtPesos;
        private System.Windows.Forms.Button btnConvertirADolares;
        private System.Windows.Forms.Button btnSalir;
    }
}

