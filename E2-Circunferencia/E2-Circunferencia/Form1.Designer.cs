
namespace E2_Circunferencia
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
            this.radRueda = new System.Windows.Forms.RadioButton();
            this.RadMoneda = new System.Windows.Forms.RadioButton();
            this.btnCalcularArea = new System.Windows.Forms.Button();
            this.btnCalcularPerimetro = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblFigura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(51, 38);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(38, 13);
            this.lblRadio.TabIndex = 0;
            this.lblRadio.Text = "Radio:";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(111, 31);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 20);
            this.txtRadio.TabIndex = 1;
            // 
            // radRueda
            // 
            this.radRueda.AutoSize = true;
            this.radRueda.Location = new System.Drawing.Point(32, 97);
            this.radRueda.Name = "radRueda";
            this.radRueda.Size = new System.Drawing.Size(57, 17);
            this.radRueda.TabIndex = 2;
            this.radRueda.TabStop = true;
            this.radRueda.Text = "Rueda";
            this.radRueda.UseVisualStyleBackColor = true;
            // 
            // RadMoneda
            // 
            this.RadMoneda.AutoSize = true;
            this.RadMoneda.Location = new System.Drawing.Point(134, 97);
            this.RadMoneda.Name = "RadMoneda";
            this.RadMoneda.Size = new System.Drawing.Size(64, 17);
            this.RadMoneda.TabIndex = 3;
            this.RadMoneda.TabStop = true;
            this.RadMoneda.Text = "Moneda";
            this.RadMoneda.UseVisualStyleBackColor = true;
            // 
            // btnCalcularArea
            // 
            this.btnCalcularArea.Location = new System.Drawing.Point(12, 138);
            this.btnCalcularArea.Name = "btnCalcularArea";
            this.btnCalcularArea.Size = new System.Drawing.Size(93, 23);
            this.btnCalcularArea.TabIndex = 4;
            this.btnCalcularArea.Text = "Calcular Area";
            this.btnCalcularArea.UseVisualStyleBackColor = true;
            this.btnCalcularArea.Click += new System.EventHandler(this.btnCalcularArea_Click);
            // 
            // btnCalcularPerimetro
            // 
            this.btnCalcularPerimetro.Location = new System.Drawing.Point(111, 138);
            this.btnCalcularPerimetro.Name = "btnCalcularPerimetro";
            this.btnCalcularPerimetro.Size = new System.Drawing.Size(106, 23);
            this.btnCalcularPerimetro.TabIndex = 5;
            this.btnCalcularPerimetro.Text = "Calcular Perimetro";
            this.btnCalcularPerimetro.UseVisualStyleBackColor = true;
            this.btnCalcularPerimetro.Click += new System.EventHandler(this.btnCalcularPerimetro_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 177);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(205, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblFigura
            // 
            this.lblFigura.AutoSize = true;
            this.lblFigura.Location = new System.Drawing.Point(63, 72);
            this.lblFigura.Name = "lblFigura";
            this.lblFigura.Size = new System.Drawing.Size(100, 13);
            this.lblFigura.TabIndex = 7;
            this.lblFigura.Text = "Seleccione la figura";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 277);
            this.Controls.Add(this.lblFigura);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcularPerimetro);
            this.Controls.Add(this.btnCalcularArea);
            this.Controls.Add(this.RadMoneda);
            this.Controls.Add(this.radRueda);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.lblRadio);
            this.Name = "Form1";
            this.Text = "Circunferencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.RadioButton radRueda;
        private System.Windows.Forms.RadioButton RadMoneda;
        private System.Windows.Forms.Button btnCalcularArea;
        private System.Windows.Forms.Button btnCalcularPerimetro;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblFigura;
    }
}

