
namespace E6._2_Fecha
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
            this.btnMostrarFormatoDMA = new System.Windows.Forms.Button();
            this.btnFechaEnLetra = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(25, 37);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(23, 13);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "Dia";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(25, 64);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(27, 13);
            this.lblMes.TabIndex = 1;
            this.lblMes.Text = "Mes";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(25, 95);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(26, 13);
            this.lblAño.TabIndex = 2;
            this.lblAño.Text = "Año";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(80, 37);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(62, 20);
            this.txtDia.TabIndex = 3;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(80, 64);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(62, 20);
            this.txtMes.TabIndex = 4;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(80, 92);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(62, 20);
            this.txtAño.TabIndex = 5;
            // 
            // btnMostrarFormatoDMA
            // 
            this.btnMostrarFormatoDMA.Location = new System.Drawing.Point(160, 37);
            this.btnMostrarFormatoDMA.Name = "btnMostrarFormatoDMA";
            this.btnMostrarFormatoDMA.Size = new System.Drawing.Size(114, 20);
            this.btnMostrarFormatoDMA.TabIndex = 7;
            this.btnMostrarFormatoDMA.Text = "Mostrar D/M/A";
            this.btnMostrarFormatoDMA.UseVisualStyleBackColor = true;
            this.btnMostrarFormatoDMA.Click += new System.EventHandler(this.btnMostrarFormatoDMA_Click);
            // 
            // btnFechaEnLetra
            // 
            this.btnFechaEnLetra.Location = new System.Drawing.Point(160, 66);
            this.btnFechaEnLetra.Name = "btnFechaEnLetra";
            this.btnFechaEnLetra.Size = new System.Drawing.Size(114, 45);
            this.btnFechaEnLetra.TabIndex = 8;
            this.btnFechaEnLetra.Text = "Mostrar fecha en letra";
            this.btnFechaEnLetra.UseVisualStyleBackColor = true;
            this.btnFechaEnLetra.Click += new System.EventHandler(this.btnFechaEnLetra_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(28, 123);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(246, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 166);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFechaEnLetra);
            this.Controls.Add(this.btnMostrarFormatoDMA);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblDia);
            this.Name = "Form1";
            this.Text = "Fecha";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btnMostrarFormatoDMA;
        private System.Windows.Forms.Button btnFechaEnLetra;
        private System.Windows.Forms.Button btnSalir;
    }
}

