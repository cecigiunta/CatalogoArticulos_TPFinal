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
            this.labelDetalleNombre.BackColor = System.Drawing.SystemColors.Window;
            this.labelDetalleNombre.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetalleNombre.ForeColor = System.Drawing.Color.Black;
            this.labelDetalleNombre.Location = new System.Drawing.Point(20, 39);
            this.labelDetalleNombre.Name = "labelDetalleNombre";
            this.labelDetalleNombre.Size = new System.Drawing.Size(106, 29);
            this.labelDetalleNombre.TabIndex = 0;
            this.labelDetalleNombre.Text = "Nombre";
            // 
            // labelDetalleCodigo
            // 
            this.labelDetalleCodigo.AutoSize = true;
            this.labelDetalleCodigo.Font = new System.Drawing.Font("Microsoft YaHei", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetalleCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDetalleCodigo.Location = new System.Drawing.Point(20, 102);
            this.labelDetalleCodigo.Name = "labelDetalleCodigo";
            this.labelDetalleCodigo.Size = new System.Drawing.Size(78, 25);
            this.labelDetalleCodigo.TabIndex = 1;
            this.labelDetalleCodigo.Text = "Código";
            // 
            // labelDetalleDescripcion
            // 
            this.labelDetalleDescripcion.AutoSize = true;
            this.labelDetalleDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetalleDescripcion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDetalleDescripcion.Location = new System.Drawing.Point(20, 164);
            this.labelDetalleDescripcion.Name = "labelDetalleDescripcion";
            this.labelDetalleDescripcion.Size = new System.Drawing.Size(114, 25);
            this.labelDetalleDescripcion.TabIndex = 2;
            this.labelDetalleDescripcion.Text = "Descripción";
            // 
            // labelDetallePrecio
            // 
            this.labelDetallePrecio.AutoSize = true;
            this.labelDetallePrecio.Font = new System.Drawing.Font("Microsoft YaHei", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetallePrecio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDetallePrecio.Location = new System.Drawing.Point(85, 327);
            this.labelDetallePrecio.Name = "labelDetallePrecio";
            this.labelDetallePrecio.Size = new System.Drawing.Size(71, 26);
            this.labelDetallePrecio.TabIndex = 3;
            this.labelDetallePrecio.Text = "Precio";
            this.labelDetallePrecio.Click += new System.EventHandler(this.labelDetallePrecio_Click);
            // 
            // labelDetalleMarca
            // 
            this.labelDetalleMarca.AutoSize = true;
            this.labelDetalleMarca.Font = new System.Drawing.Font("Microsoft YaHei", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetalleMarca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDetalleMarca.Location = new System.Drawing.Point(21, 231);
            this.labelDetalleMarca.Name = "labelDetalleMarca";
            this.labelDetalleMarca.Size = new System.Drawing.Size(58, 21);
            this.labelDetalleMarca.TabIndex = 4;
            this.labelDetalleMarca.Text = "Marca";
            // 
            // labelDetalleCategoria
            // 
            this.labelDetalleCategoria.AutoSize = true;
            this.labelDetalleCategoria.Font = new System.Drawing.Font("Microsoft YaHei", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetalleCategoria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDetalleCategoria.Location = new System.Drawing.Point(21, 280);
            this.labelDetalleCategoria.Name = "labelDetalleCategoria";
            this.labelDetalleCategoria.Size = new System.Drawing.Size(84, 21);
            this.labelDetalleCategoria.TabIndex = 5;
            this.labelDetalleCategoria.Text = "Categoría";
            this.labelDetalleCategoria.Click += new System.EventHandler(this.labelDetalleCategoria_Click);
            // 
            // pictureBoxDetalle
            // 
            this.pictureBoxDetalle.Location = new System.Drawing.Point(237, 24);
            this.pictureBoxDetalle.Name = "pictureBoxDetalle";
            this.pictureBoxDetalle.Size = new System.Drawing.Size(301, 339);
            this.pictureBoxDetalle.TabIndex = 6;
            this.pictureBoxDetalle.TabStop = false;
            // 
            // btnModificarDet
            // 
            this.btnModificarDet.BackColor = System.Drawing.Color.MistyRose;
            this.btnModificarDet.FlatAppearance.BorderSize = 0;
            this.btnModificarDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarDet.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificarDet.Location = new System.Drawing.Point(25, 378);
            this.btnModificarDet.Name = "btnModificarDet";
            this.btnModificarDet.Size = new System.Drawing.Size(206, 42);
            this.btnModificarDet.TabIndex = 7;
            this.btnModificarDet.Text = "Modificar Artículo";
            this.btnModificarDet.UseVisualStyleBackColor = false;
            this.btnModificarDet.Click += new System.EventHandler(this.btnModificarDet_Click);
            // 
            // btnCerrarDet
            // 
            this.btnCerrarDet.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCerrarDet.FlatAppearance.BorderSize = 0;
            this.btnCerrarDet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCerrarDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarDet.Font = new System.Drawing.Font("Yu Gothic", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarDet.Location = new System.Drawing.Point(332, 378);
            this.btnCerrarDet.Name = "btnCerrarDet";
            this.btnCerrarDet.Size = new System.Drawing.Size(206, 41);
            this.btnCerrarDet.TabIndex = 8;
            this.btnCerrarDet.Text = "Cerrar";
            this.btnCerrarDet.UseVisualStyleBackColor = false;
            this.btnCerrarDet.Click += new System.EventHandler(this.btnCerrarDet_Click);
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(587, 452);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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