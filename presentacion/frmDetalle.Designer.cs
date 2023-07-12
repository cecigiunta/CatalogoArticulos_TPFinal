namespace presentacion
{
    partial class frmDetalle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDetalleNombre = new System.Windows.Forms.Label();
            this.labelDetalleCodigo = new System.Windows.Forms.Label();
            this.labelDetalleDescripcion = new System.Windows.Forms.Label();
            this.labelDetallePrecio = new System.Windows.Forms.Label();
            this.labelDetalleMarca = new System.Windows.Forms.Label();
            this.labelDetalleCategoria = new System.Windows.Forms.Label();
            this.pictureBoxDetalle = new System.Windows.Forms.PictureBox();
            this.btnModificarDet = new System.Windows.Forms.Button();
            this.btnCerrarDet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDetalleNombre
            // 
            this.labelDetalleNombre.AutoSize = true;
            this.labelDetalleNombre.Location = new System.Drawing.Point(75, 24);
            this.labelDetalleNombre.Name = "labelDetalleNombre";
            this.labelDetalleNombre.Size = new System.Drawing.Size(56, 16);
            this.labelDetalleNombre.TabIndex = 0;
            this.labelDetalleNombre.Text = "Nombre";
            // 
            // labelDetalleCodigo
            // 
            this.labelDetalleCodigo.AutoSize = true;
            this.labelDetalleCodigo.Location = new System.Drawing.Point(215, 24);
            this.labelDetalleCodigo.Name = "labelDetalleCodigo";
            this.labelDetalleCodigo.Size = new System.Drawing.Size(51, 16);
            this.labelDetalleCodigo.TabIndex = 1;
            this.labelDetalleCodigo.Text = "Código";
            // 
            // labelDetalleDescripcion
            // 
            this.labelDetalleDescripcion.AutoSize = true;
            this.labelDetalleDescripcion.Location = new System.Drawing.Point(32, 96);
            this.labelDetalleDescripcion.Name = "labelDetalleDescripcion";
            this.labelDetalleDescripcion.Size = new System.Drawing.Size(79, 16);
            this.labelDetalleDescripcion.TabIndex = 2;
            this.labelDetalleDescripcion.Text = "Descripción";
            // 
            // labelDetallePrecio
            // 
            this.labelDetallePrecio.AutoSize = true;
            this.labelDetallePrecio.Location = new System.Drawing.Point(32, 172);
            this.labelDetallePrecio.Name = "labelDetallePrecio";
            this.labelDetallePrecio.Size = new System.Drawing.Size(46, 16);
            this.labelDetallePrecio.TabIndex = 3;
            this.labelDetallePrecio.Text = "Precio";
            // 
            // labelDetalleMarca
            // 
            this.labelDetalleMarca.AutoSize = true;
            this.labelDetalleMarca.Location = new System.Drawing.Point(33, 231);
            this.labelDetalleMarca.Name = "labelDetalleMarca";
            this.labelDetalleMarca.Size = new System.Drawing.Size(45, 16);
            this.labelDetalleMarca.TabIndex = 4;
            this.labelDetalleMarca.Text = "Marca";
            // 
            // labelDetalleCategoria
            // 
            this.labelDetalleCategoria.AutoSize = true;
            this.labelDetalleCategoria.Location = new System.Drawing.Point(104, 231);
            this.labelDetalleCategoria.Name = "labelDetalleCategoria";
            this.labelDetalleCategoria.Size = new System.Drawing.Size(66, 16);
            this.labelDetalleCategoria.TabIndex = 5;
            this.labelDetalleCategoria.Text = "Categoría";
            // 
            // pictureBoxDetalle
            // 
            this.pictureBoxDetalle.Location = new System.Drawing.Point(246, 57);
            this.pictureBoxDetalle.Name = "pictureBoxDetalle";
            this.pictureBoxDetalle.Size = new System.Drawing.Size(228, 217);
            this.pictureBoxDetalle.TabIndex = 6;
            this.pictureBoxDetalle.TabStop = false;
            // 
            // btnModificarDet
            // 
            this.btnModificarDet.Location = new System.Drawing.Point(12, 308);
            this.btnModificarDet.Name = "btnModificarDet";
            this.btnModificarDet.Size = new System.Drawing.Size(140, 36);
            this.btnModificarDet.TabIndex = 7;
            this.btnModificarDet.Text = "Modificar Articulo";
            this.btnModificarDet.UseVisualStyleBackColor = true;
            this.btnModificarDet.Click += new System.EventHandler(this.btnModificarDet_Click);
            // 
            // btnCerrarDet
            // 
            this.btnCerrarDet.Location = new System.Drawing.Point(181, 308);
            this.btnCerrarDet.Name = "btnCerrarDet";
            this.btnCerrarDet.Size = new System.Drawing.Size(140, 36);
            this.btnCerrarDet.TabIndex = 8;
            this.btnCerrarDet.Text = "Cerrar";
            this.btnCerrarDet.UseVisualStyleBackColor = true;
            this.btnCerrarDet.Click += new System.EventHandler(this.btnCerrarDet_Click);
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 383);
            this.Controls.Add(this.btnCerrarDet);
            this.Controls.Add(this.btnModificarDet);
            this.Controls.Add(this.pictureBoxDetalle);
            this.Controls.Add(this.labelDetalleCategoria);
            this.Controls.Add(this.labelDetalleMarca);
            this.Controls.Add(this.labelDetallePrecio);
            this.Controls.Add(this.labelDetalleDescripcion);
            this.Controls.Add(this.labelDetalleCodigo);
            this.Controls.Add(this.labelDetalleNombre);
            this.Name = "frmDetalle";
            this.Text = "frmDetalle";
            this.Load += new System.EventHandler(this.frmDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDetalleNombre;
        private System.Windows.Forms.Label labelDetalleCodigo;
        private System.Windows.Forms.Label labelDetalleDescripcion;
        private System.Windows.Forms.Label labelDetallePrecio;
        private System.Windows.Forms.Label labelDetalleMarca;
        private System.Windows.Forms.Label labelDetalleCategoria;
        private System.Windows.Forms.PictureBox pictureBoxDetalle;
        private System.Windows.Forms.Button btnModificarDet;
        private System.Windows.Forms.Button btnCerrarDet;
    }
}