namespace Supermercado
{
    partial class ControlCajas
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgCajas = new System.Windows.Forms.DataGridView();
            this.btnCrearCaja = new System.Windows.Forms.Button();
            this.btnCerrarCaja = new System.Windows.Forms.Button();
            this.lbAtendidos = new System.Windows.Forms.Label();
            this.lbEspera = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCajas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCajas
            // 
            this.dgCajas.AllowUserToAddRows = false;
            this.dgCajas.AllowUserToDeleteRows = false;
            this.dgCajas.AllowUserToResizeColumns = false;
            this.dgCajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCajas.Location = new System.Drawing.Point(11, 11);
            this.dgCajas.Margin = new System.Windows.Forms.Padding(2);
            this.dgCajas.Name = "dgCajas";
            this.dgCajas.ReadOnly = true;
            this.dgCajas.RowTemplate.Height = 24;
            this.dgCajas.Size = new System.Drawing.Size(336, 270);
            this.dgCajas.TabIndex = 0;
            this.dgCajas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCajas_CellClick);
            // 
            // btnCrearCaja
            // 
            this.btnCrearCaja.Location = new System.Drawing.Point(374, 11);
            this.btnCrearCaja.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearCaja.Name = "btnCrearCaja";
            this.btnCrearCaja.Size = new System.Drawing.Size(91, 35);
            this.btnCrearCaja.TabIndex = 1;
            this.btnCrearCaja.Text = "Abrir Caja";
            this.btnCrearCaja.UseVisualStyleBackColor = true;
            this.btnCrearCaja.Click += new System.EventHandler(this.btnCrearCaja_Click);
            // 
            // btnCerrarCaja
            // 
            this.btnCerrarCaja.Location = new System.Drawing.Point(374, 50);
            this.btnCerrarCaja.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Size = new System.Drawing.Size(91, 35);
            this.btnCerrarCaja.TabIndex = 2;
            this.btnCerrarCaja.Text = "Cerrar Caja";
            this.btnCerrarCaja.UseVisualStyleBackColor = true;
            this.btnCerrarCaja.Click += new System.EventHandler(this.btnCerrarCaja_Click);
            // 
            // lbAtendidos
            // 
            this.lbAtendidos.AutoSize = true;
            this.lbAtendidos.Location = new System.Drawing.Point(371, 111);
            this.lbAtendidos.Name = "lbAtendidos";
            this.lbAtendidos.Size = new System.Drawing.Size(96, 13);
            this.lbAtendidos.TabIndex = 3;
            this.lbAtendidos.Text = "Clientes atendidos:";
            // 
            // lbEspera
            // 
            this.lbEspera.AutoSize = true;
            this.lbEspera.Location = new System.Drawing.Point(371, 140);
            this.lbEspera.Name = "lbEspera";
            this.lbEspera.Size = new System.Drawing.Size(97, 13);
            this.lbEspera.TabIndex = 4;
            this.lbEspera.Text = "Clientes en espera:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(11, 306);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 35);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar Cliente";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(127, 306);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(110, 35);
            this.btnSiguiente.TabIndex = 6;
            this.btnSiguiente.Text = "Atender Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(371, 167);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(82, 13);
            this.lbNombre.TabIndex = 7;
            this.lbNombre.Text = "Nombre Cliente:";
            // 
            // ControlCajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 365);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbEspera);
            this.Controls.Add(this.lbAtendidos);
            this.Controls.Add(this.btnCerrarCaja);
            this.Controls.Add(this.btnCrearCaja);
            this.Controls.Add(this.dgCajas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ControlCajas";
            this.Text = "Control Cajas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCajas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCajas;
        private System.Windows.Forms.Button btnCrearCaja;
        private System.Windows.Forms.Button btnCerrarCaja;
        private System.Windows.Forms.Label lbAtendidos;
        private System.Windows.Forms.Label lbEspera;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lbNombre;
    }
}

