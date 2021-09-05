
namespace E1_Circunferencia
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
            this.lblRadio = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.grpObjetos = new System.Windows.Forms.GroupBox();
            this.radMoneda = new System.Windows.Forms.RadioButton();
            this.radRueda = new System.Windows.Forms.RadioButton();
            this.btnCapturarRadio = new System.Windows.Forms.Button();
            this.btnCalcularArea = new System.Windows.Forms.Button();
            this.btnCalcularPerimetro = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpObjetos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(24, 22);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(35, 13);
            this.lblRadio.TabIndex = 0;
            this.lblRadio.Text = "Radio";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(66, 22);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 20);
            this.txtRadio.TabIndex = 1;
            // 
            // grpObjetos
            // 
            this.grpObjetos.Controls.Add(this.radRueda);
            this.grpObjetos.Controls.Add(this.radMoneda);
            this.grpObjetos.Location = new System.Drawing.Point(27, 78);
            this.grpObjetos.Name = "grpObjetos";
            this.grpObjetos.Size = new System.Drawing.Size(139, 100);
            this.grpObjetos.TabIndex = 2;
            this.grpObjetos.TabStop = false;
            this.grpObjetos.Text = "Objetos";
            // 
            // radMoneda
            // 
            this.radMoneda.AutoSize = true;
            this.radMoneda.Location = new System.Drawing.Point(7, 20);
            this.radMoneda.Name = "radMoneda";
            this.radMoneda.Size = new System.Drawing.Size(64, 17);
            this.radMoneda.TabIndex = 0;
            this.radMoneda.TabStop = true;
            this.radMoneda.Text = "Moneda";
            this.radMoneda.UseVisualStyleBackColor = true;
            // 
            // radRueda
            // 
            this.radRueda.AutoSize = true;
            this.radRueda.Location = new System.Drawing.Point(7, 44);
            this.radRueda.Name = "radRueda";
            this.radRueda.Size = new System.Drawing.Size(57, 17);
            this.radRueda.TabIndex = 1;
            this.radRueda.TabStop = true;
            this.radRueda.Text = "Rueda";
            this.radRueda.UseVisualStyleBackColor = true;
            // 
            // btnCapturarRadio
            // 
            this.btnCapturarRadio.Location = new System.Drawing.Point(186, 18);
            this.btnCapturarRadio.Name = "btnCapturarRadio";
            this.btnCapturarRadio.Size = new System.Drawing.Size(75, 40);
            this.btnCapturarRadio.TabIndex = 3;
            this.btnCapturarRadio.Text = "Capturar Radio";
            this.btnCapturarRadio.UseVisualStyleBackColor = true;
            this.btnCapturarRadio.Click += new System.EventHandler(this.btnCapturarRadio_Click);
            // 
            // btnCalcularArea
            // 
            this.btnCalcularArea.Location = new System.Drawing.Point(186, 64);
            this.btnCalcularArea.Name = "btnCalcularArea";
            this.btnCalcularArea.Size = new System.Drawing.Size(75, 37);
            this.btnCalcularArea.TabIndex = 4;
            this.btnCalcularArea.Text = "Calcular Area";
            this.btnCalcularArea.UseVisualStyleBackColor = true;
            this.btnCalcularArea.Click += new System.EventHandler(this.btnCalcularArea_Click);
            // 
            // btnCalcularPerimetro
            // 
            this.btnCalcularPerimetro.Location = new System.Drawing.Point(186, 107);
            this.btnCalcularPerimetro.Name = "btnCalcularPerimetro";
            this.btnCalcularPerimetro.Size = new System.Drawing.Size(75, 42);
            this.btnCalcularPerimetro.TabIndex = 5;
            this.btnCalcularPerimetro.Text = "Calcular Perimetro";
            this.btnCalcularPerimetro.UseVisualStyleBackColor = true;
            this.btnCalcularPerimetro.Click += new System.EventHandler(this.btnCalcularPerimetro_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(186, 155);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 201);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcularPerimetro);
            this.Controls.Add(this.btnCalcularArea);
            this.Controls.Add(this.btnCapturarRadio);
            this.Controls.Add(this.grpObjetos);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.lblRadio);
            this.Name = "Form1";
            this.Text = "Circunferencia";
            this.grpObjetos.ResumeLayout(false);
            this.grpObjetos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.GroupBox grpObjetos;
        private System.Windows.Forms.RadioButton radRueda;
        private System.Windows.Forms.RadioButton radMoneda;
        private System.Windows.Forms.Button btnCapturarRadio;
        private System.Windows.Forms.Button btnCalcularArea;
        private System.Windows.Forms.Button btnCalcularPerimetro;
        private System.Windows.Forms.Button btnSalir;
    }
}

