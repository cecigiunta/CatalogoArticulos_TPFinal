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
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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
                articulo.Descripcion = textBoxDescrip.Text;
                articulo.Precio = decimal.Parse(textBoxPrecio.Text);
                articulo.Marca = (Marca)comboBoxMarca.SelectedItem;
                articulo.Categoria = (Categoria)comboBoxCategoria.SelectedItem;
                articulo.ImagenUrl = textBoxImg.Text;

                if(articulo.Id != 0)
                {
                negocio.modificarArticulo(articulo);
                MessageBox.Show("¡Artículo Modificado!");
                }
                else
                {
                negocio.agregarArticulo(articulo);
                MessageBox.Show("¡Agregado!");
                }

                Close();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                comboBoxMarca.DataSource = marcaNegocio.listar();
                comboBoxMarca.ValueMember = "Id";
                comboBoxMarca.DisplayMember = "Descripcion";

                comboBoxCategoria.DataSource = categoriaNegocio.listar();
                comboBoxCategoria.ValueMember = "Id";
                comboBoxCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    textBoxCodigo.Text = articulo.Codigo;
                    textBoxNombre.Text = articulo.Nombre;
                    textBoxDescrip.Text = articulo.Descripcion;
                    textBoxPrecio.Text = articulo.Precio.ToString();
                    textBoxImg.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    comboBoxMarca.SelectedValue = articulo.Marca.Id;
                    comboBoxCategoria.SelectedValue = articulo.Categoria.Id;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void textBoxImg_Leave(object sender, EventArgs e)
        {
            cargarImagen(textBoxImg.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxImg.Load(imagen);
            }
            catch (Exception ex)
            {

                pictureBoxImg.Load("https://storage.googleapis.com/proudcity/mebanenc/uploads/2021/03/placeholder-image.png");
            }
        }
    }
}
