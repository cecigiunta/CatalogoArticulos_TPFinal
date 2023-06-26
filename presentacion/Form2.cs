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
        public FormAlta()
        {
            InitializeComponent();
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
            Articulo nuevoArticulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                nuevoArticulo.Codigo = textBoxCodigo.Text;
                nuevoArticulo.Nombre = textBoxNombre.Text;
                nuevoArticulo.Descripcion = textBoxDescripcion.Text;
                nuevoArticulo.Marca = (Marca)comboBoxMarca.SelectedItem;
                nuevoArticulo.Categoria = (Categoria)comboBoxCategoria.SelectedItem;
                nuevoArticulo.ImagenUrl = textBoxImg.Text;

                negocio.agregarArticulo(nuevoArticulo);
                MessageBox.Show("Agregado!");
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
