using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace presentacion
{
    public partial class FormAlta : Form
    {
        private Articulo articulo = null;
        public FormAlta()
        {
            InitializeComponent();
        }

        public FormAlta(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocioMarca = new MarcaNegocio();
            CategoriaNegocio negocioCategoria = new CategoriaNegocio();

            try
            {
                comboBoxMarca.DataSource = negocioMarca.listar();
                comboBoxCategoria.DataSource = negocioCategoria.listar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnAltaAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if(articulo == null)
                {
                    articulo = new Articulo();
                }

                articulo.Codigo = textBoxCodigo.Text;
                articulo.Nombre = textBoxNombre.Text;
                articulo.Descripcion = textBoxDescripcion.Text;
                articulo.ImagenUrl = textBoxImg.Text;
                articulo.Precio = decimal.Parse(textBoxPrecio.Text);

                articulo.Marca = (Marca)comboBoxMarca.SelectedItem;
                articulo.Categoria = (Categoria)comboBoxCategoria.SelectedItem;
                
                
                if (articulo.Id != 0)
                {
                    //negocio.modificarArticulo(articulo);
                    MessageBox.Show("¡Artículo Modificado!");
                }
                else
                {
                    negocio.agregarArticulo(articulo);
                    MessageBox.Show("Agregado!");

                }
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAltaCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxImg_Leave(object sender, EventArgs e)
        {
            cargarImagen(textBoxImg.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pictureBoxArticulo.Load("https://storage.googleapis.com/proudcity/mebanenc/uploads/2021/03/placeholder-image.png");
            }
        }
    }
}
