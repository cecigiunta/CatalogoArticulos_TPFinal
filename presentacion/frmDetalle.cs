using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace presentacion
{
    public partial class frmDetalle : Form
    {
        private Articulo articulo = null;

        public frmDetalle()
        {
            InitializeComponent();
        }

        public frmDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;

        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            labelDetalleCodigo.Text = "Código: " + articulo.Codigo;
            labelDetalleNombre.Text = articulo.Nombre;
            labelDetalleDescripcion.Text = articulo.Descripcion;
            labelDetallePrecio.Text = "$" + articulo.Precio.ToString();
            labelDetalleMarca.Text = articulo.Marca.Descripcion.ToString();
            labelDetalleCategoria.Text = articulo.Categoria.Descripcion.ToString();

            cargarImagen(articulo.ImagenUrl);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxDetalle.Load(imagen);
            }
            catch (Exception ex)
            {

                pictureBoxDetalle.Load("https://storage.googleapis.com/proudcity/mebanenc/uploads/2021/03/placeholder-image.png");
            }
        }

        private void btnModificarDet_Click(object sender, EventArgs e)
        {
            frmAltaArticulo modificar = new frmAltaArticulo(articulo);
            modificar.ShowDialog();

        }

        private void btnCerrarDet_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelDetalleCategoria_Click(object sender, EventArgs e)
        {

        }

        private void labelDetallePrecio_Click(object sender, EventArgs e)
        {

        }
    }
}
