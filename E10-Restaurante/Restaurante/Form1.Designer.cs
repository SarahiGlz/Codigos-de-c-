
namespace Restaurante
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
            this.grpAlimentos = new System.Windows.Forms.GroupBox();
            this.txtPostre = new System.Windows.Forms.TextBox();
            this.txtRefresco = new System.Windows.Forms.TextBox();
            this.txtPapas = new System.Windows.Forms.TextBox();
            this.txtHamburguesa3 = new System.Windows.Forms.TextBox();
            this.txtHamburguesa2 = new System.Windows.Forms.TextBox();
            this.txtHamburguesa1 = new System.Windows.Forms.TextBox();
            this.lblPostre = new System.Windows.Forms.Label();
            this.lblRefresco = new System.Windows.Forms.Label();
            this.lblPapas = new System.Windows.Forms.Label();
            this.lblHamburguesa3 = new System.Windows.Forms.Label();
            this.lblHamburguesa2 = new System.Windows.Forms.Label();
            this.lblHamburguesa1 = new System.Windows.Forms.Label();
            this.cboMesas = new System.Windows.Forms.ComboBox();
            this.btnCapturarOrden = new System.Windows.Forms.Button();
            this.btnCalcularCuenta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpAlimentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAlimentos
            // 
            this.grpAlimentos.Controls.Add(this.txtPostre);
            this.grpAlimentos.Controls.Add(this.txtRefresco);
            this.grpAlimentos.Controls.Add(this.txtPapas);
            this.grpAlimentos.Controls.Add(this.txtHamburguesa3);
            this.grpAlimentos.Controls.Add(this.txtHamburguesa2);
            this.grpAlimentos.Controls.Add(this.txtHamburguesa1);
            this.grpAlimentos.Controls.Add(this.lblPostre);
            this.grpAlimentos.Controls.Add(this.lblRefresco);
            this.grpAlimentos.Controls.Add(this.lblPapas);
            this.grpAlimentos.Controls.Add(this.lblHamburguesa3);
            this.grpAlimentos.Controls.Add(this.lblHamburguesa2);
            this.grpAlimentos.Controls.Add(this.lblHamburguesa1);
            this.grpAlimentos.Location = new System.Drawing.Point(12, 55);
            this.grpAlimentos.Name = "grpAlimentos";
            this.grpAlimentos.Size = new System.Drawing.Size(270, 205);
            this.grpAlimentos.TabIndex = 0;
            this.grpAlimentos.TabStop = false;
            this.grpAlimentos.Text = "Cantidad de alimentos";
            // 
            // txtPostre
            // 
            this.txtPostre.Location = new System.Drawing.Point(178, 159);
            this.txtPostre.Name = "txtPostre";
            this.txtPostre.Size = new System.Drawing.Size(64, 20);
            this.txtPostre.TabIndex = 11;
            // 
            // txtRefresco
            // 
            this.txtRefresco.Location = new System.Drawing.Point(178, 133);
            this.txtRefresco.Name = "txtRefresco";
            this.txtRefresco.Size = new System.Drawing.Size(64, 20);
            this.txtRefresco.TabIndex = 10;
            // 
            // txtPapas
            // 
            this.txtPapas.Location = new System.Drawing.Point(178, 107);
            this.txtPapas.Name = "txtPapas";
            this.txtPapas.Size = new System.Drawing.Size(64, 20);
            this.txtPapas.TabIndex = 9;
            // 
            // txtHamburguesa3
            // 
            this.txtHamburguesa3.Location = new System.Drawing.Point(178, 81);
            this.txtHamburguesa3.Name = "txtHamburguesa3";
            this.txtHamburguesa3.Size = new System.Drawing.Size(64, 20);
            this.txtHamburguesa3.TabIndex = 8;
            // 
            // txtHamburguesa2
            // 
            this.txtHamburguesa2.Location = new System.Drawing.Point(178, 55);
            this.txtHamburguesa2.Name = "txtHamburguesa2";
            this.txtHamburguesa2.Size = new System.Drawing.Size(64, 20);
            this.txtHamburguesa2.TabIndex = 7;
            // 
            // txtHamburguesa1
            // 
            this.txtHamburguesa1.Location = new System.Drawing.Point(178, 29);
            this.txtHamburguesa1.Name = "txtHamburguesa1";
            this.txtHamburguesa1.Size = new System.Drawing.Size(64, 20);
            this.txtHamburguesa1.TabIndex = 6;
            // 
            // lblPostre
            // 
            this.lblPostre.AutoSize = true;
            this.lblPostre.Location = new System.Drawing.Point(6, 166);
            this.lblPostre.Name = "lblPostre";
            this.lblPostre.Size = new System.Drawing.Size(160, 13);
            this.lblPostre.TabIndex = 5;
            this.lblPostre.Text = "Postre                                   ($6)";
            // 
            // lblRefresco
            // 
            this.lblRefresco.AutoSize = true;
            this.lblRefresco.Location = new System.Drawing.Point(6, 140);
            this.lblRefresco.Name = "lblRefresco";
            this.lblRefresco.Size = new System.Drawing.Size(158, 13);
            this.lblRefresco.TabIndex = 4;
            this.lblRefresco.Text = "Refresco                              ($5)";
            // 
            // lblPapas
            // 
            this.lblPapas.AutoSize = true;
            this.lblPapas.Location = new System.Drawing.Point(6, 114);
            this.lblPapas.Name = "lblPapas";
            this.lblPapas.Size = new System.Drawing.Size(158, 13);
            this.lblPapas.TabIndex = 3;
            this.lblPapas.Text = "Papas fritas                          ($8)";
            // 
            // lblHamburguesa3
            // 
            this.lblHamburguesa3.AutoSize = true;
            this.lblHamburguesa3.Location = new System.Drawing.Point(6, 88);
            this.lblHamburguesa3.Name = "lblHamburguesa3";
            this.lblHamburguesa3.Size = new System.Drawing.Size(163, 13);
            this.lblHamburguesa3.TabIndex = 2;
            this.lblHamburguesa3.Text = "Hamburguesa especial        ($20)";
            // 
            // lblHamburguesa2
            // 
            this.lblHamburguesa2.AutoSize = true;
            this.lblHamburguesa2.Location = new System.Drawing.Point(6, 62);
            this.lblHamburguesa2.Name = "lblHamburguesa2";
            this.lblHamburguesa2.Size = new System.Drawing.Size(162, 13);
            this.lblHamburguesa2.TabIndex = 1;
            this.lblHamburguesa2.Text = "Hamburguesa con queso    ($18)";
            // 
            // lblHamburguesa1
            // 
            this.lblHamburguesa1.AutoSize = true;
            this.lblHamburguesa1.Location = new System.Drawing.Point(6, 36);
            this.lblHamburguesa1.Name = "lblHamburguesa1";
            this.lblHamburguesa1.Size = new System.Drawing.Size(162, 13);
            this.lblHamburguesa1.TabIndex = 0;
            this.lblHamburguesa1.Text = "Hamburguesa sencilla         ($15)";
            this.lblHamburguesa1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboMesas
            // 
            this.cboMesas.FormattingEnabled = true;
            this.cboMesas.Items.AddRange(new object[] {
            "Mesa 1",
            "Mesa 2",
            "Mesa 3",
            "Mesa 4",
            "Mesa 5"});
            this.cboMesas.Location = new System.Drawing.Point(21, 287);
            this.cboMesas.Name = "cboMesas";
            this.cboMesas.Size = new System.Drawing.Size(121, 21);
            this.cboMesas.TabIndex = 1;
            // 
            // btnCapturarOrden
            // 
            this.btnCapturarOrden.Location = new System.Drawing.Point(288, 108);
            this.btnCapturarOrden.Name = "btnCapturarOrden";
            this.btnCapturarOrden.Size = new System.Drawing.Size(106, 23);
            this.btnCapturarOrden.TabIndex = 2;
            this.btnCapturarOrden.Text = "Capturar Orden";
            this.btnCapturarOrden.UseVisualStyleBackColor = true;
            this.btnCapturarOrden.Click += new System.EventHandler(this.btnCapturarOrden_Click);
            // 
            // btnCalcularCuenta
            // 
            this.btnCalcularCuenta.Location = new System.Drawing.Point(288, 144);
            this.btnCalcularCuenta.Name = "btnCalcularCuenta";
            this.btnCalcularCuenta.Size = new System.Drawing.Size(106, 23);
            this.btnCalcularCuenta.TabIndex = 3;
            this.btnCalcularCuenta.Text = "Calcular Cuenta";
            this.btnCalcularCuenta.UseVisualStyleBackColor = true;
            this.btnCalcularCuenta.Click += new System.EventHandler(this.btnCalcularCuenta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(288, 180);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 327);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcularCuenta);
            this.Controls.Add(this.btnCapturarOrden);
            this.Controls.Add(this.cboMesas);
            this.Controls.Add(this.grpAlimentos);
            this.Name = "Form1";
            this.Text = "Restaurante";
            this.grpAlimentos.ResumeLayout(false);
            this.grpAlimentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAlimentos;
        private System.Windows.Forms.Label lblHamburguesa1;
        private System.Windows.Forms.TextBox txtPostre;
        private System.Windows.Forms.TextBox txtRefresco;
        private System.Windows.Forms.TextBox txtPapas;
        private System.Windows.Forms.TextBox txtHamburguesa3;
        private System.Windows.Forms.TextBox txtHamburguesa2;
        private System.Windows.Forms.TextBox txtHamburguesa1;
        private System.Windows.Forms.Label lblPostre;
        private System.Windows.Forms.Label lblRefresco;
        private System.Windows.Forms.Label lblPapas;
        private System.Windows.Forms.Label lblHamburguesa3;
        private System.Windows.Forms.Label lblHamburguesa2;
        private System.Windows.Forms.ComboBox cboMesas;
        private System.Windows.Forms.Button btnCapturarOrden;
        private System.Windows.Forms.Button btnCalcularCuenta;
        private System.Windows.Forms.Button btnSalir;
    }
}

