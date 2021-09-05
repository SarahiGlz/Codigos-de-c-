
namespace e9_gasolineria
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
            this.lblGalones = new System.Windows.Forms.Label();
            this.txtGalones = new System.Windows.Forms.TextBox();
            this.btnCapurarGalones = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCalcularImporte = new System.Windows.Forms.Button();
            this.btnCalcularLitros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGalones
            // 
            this.lblGalones.AutoSize = true;
            this.lblGalones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblGalones.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGalones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblGalones.Location = new System.Drawing.Point(96, 48);
            this.lblGalones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGalones.Name = "lblGalones";
            this.lblGalones.Size = new System.Drawing.Size(78, 21);
            this.lblGalones.TabIndex = 0;
            this.lblGalones.Text = "Galones:";
            // 
            // txtGalones
            // 
            this.txtGalones.Location = new System.Drawing.Point(34, 77);
            this.txtGalones.Margin = new System.Windows.Forms.Padding(4);
            this.txtGalones.Name = "txtGalones";
            this.txtGalones.Size = new System.Drawing.Size(188, 27);
            this.txtGalones.TabIndex = 1;
            // 
            // btnCapurarGalones
            // 
            this.btnCapurarGalones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCapurarGalones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapurarGalones.ForeColor = System.Drawing.Color.Teal;
            this.btnCapurarGalones.Location = new System.Drawing.Point(34, 115);
            this.btnCapurarGalones.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapurarGalones.Name = "btnCapurarGalones";
            this.btnCapurarGalones.Size = new System.Drawing.Size(188, 35);
            this.btnCapurarGalones.TabIndex = 2;
            this.btnCapurarGalones.Text = "Capturar &Galones";
            this.btnCapurarGalones.UseVisualStyleBackColor = false;
            this.btnCapurarGalones.Click += new System.EventHandler(this.btnCapurarGalones_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Olive;
            this.btnSalir.Location = new System.Drawing.Point(255, 163);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(162, 37);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCalcularImporte
            // 
            this.btnCalcularImporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCalcularImporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularImporte.ForeColor = System.Drawing.Color.Navy;
            this.btnCalcularImporte.Location = new System.Drawing.Point(255, 115);
            this.btnCalcularImporte.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcularImporte.Name = "btnCalcularImporte";
            this.btnCalcularImporte.Size = new System.Drawing.Size(162, 33);
            this.btnCalcularImporte.TabIndex = 4;
            this.btnCalcularImporte.Text = "Calcular &Importe";
            this.btnCalcularImporte.UseVisualStyleBackColor = false;
            this.btnCalcularImporte.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalcularLitros
            // 
            this.btnCalcularLitros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCalcularLitros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularLitros.ForeColor = System.Drawing.Color.Purple;
            this.btnCalcularLitros.Location = new System.Drawing.Point(255, 48);
            this.btnCalcularLitros.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcularLitros.Name = "btnCalcularLitros";
            this.btnCalcularLitros.Size = new System.Drawing.Size(162, 56);
            this.btnCalcularLitros.TabIndex = 5;
            this.btnCalcularLitros.Text = "&Conversion de galones a litros";
            this.btnCalcularLitros.UseVisualStyleBackColor = false;
            this.btnCalcularLitros.Click += new System.EventHandler(this.btnCalcularLitros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(442, 220);
            this.Controls.Add(this.btnCalcularLitros);
            this.Controls.Add(this.btnCalcularImporte);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCapurarGalones);
            this.Controls.Add(this.txtGalones);
            this.Controls.Add(this.lblGalones);
            this.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Gasolinera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGalones;
        private System.Windows.Forms.TextBox txtGalones;
        private System.Windows.Forms.Button btnCapurarGalones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCalcularImporte;
        private System.Windows.Forms.Button btnCalcularLitros;
    }
}

