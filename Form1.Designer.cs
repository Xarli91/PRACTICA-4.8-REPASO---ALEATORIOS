namespace PRACTICA_4._8_REPASO___ALEATORIOS
{
    partial class Form1
    {
        private int[] listaAleatorios = new int[20];

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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblAleatorios = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(247, 245);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(124, 95);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(455, 245);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(131, 95);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(325, 84);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(152, 26);
            this.txtBuscar.TabIndex = 2;
            // 
            // lblAleatorios
            // 
            this.lblAleatorios.AutoSize = true;
            this.lblAleatorios.Location = new System.Drawing.Point(489, 172);
            this.lblAleatorios.Name = "lblAleatorios";
            this.lblAleatorios.Size = new System.Drawing.Size(82, 20);
            this.lblAleatorios.TabIndex = 3;
            this.lblAleatorios.Text = "Resultado";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(269, 172);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(80, 20);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Aleatorios";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblAleatorios);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGenerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblAleatorios;
        private System.Windows.Forms.Label lblResultado;
    }
}

