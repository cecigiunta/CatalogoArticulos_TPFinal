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
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo nuevoArticulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            
            try
            {
                nuevoArticulo.Codigo = textBoxCodigo.Text;
                nuevoArticulo.Nombre = textBoxNombre.Text;
                nuevoArticulo.Descripcion = textBoxDescrip.Text;
                nuevoArticulo.Precio = decimal.Parse(textBoxPrecio.Text);
                nuevoArticulo.Marca = (Marca)comboBoxMarca.SelectedItem;
                nuevoArticulo.Categoria = (Categoria)comboBoxCategoria.SelectedItem;



                negocio.agregarArticulo(nuevoArticulo);
                MessageBox.Show("¡Agregado!");
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
                comboBoxCategoria.DataSource = categoriaNegocio.listar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
