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
    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cargarForm();
                comboBoxCampo.Items.Add("Precio");
                comboBoxCampo.Items.Add("Nombre");
                comboBoxCampo.Items.Add("Código");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridViewArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dataGridViewArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);

            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pictureBoxArticulo.Load("https://storage.googleapis.com/proudcity/mebanenc/uploads/2021/03/placeholder-image.png");
            }
        }


        private void cargarForm()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulos = negocio.listar(); 

                dataGridViewArticulos.DataSource = listaArticulos;
                dataGridViewArticulos.Columns["ImagenUrl"].Visible = false;
                dataGridViewArticulos.Columns["Id"].Visible = false;
                cargarImagen(listaArticulos[0].ImagenUrl);  
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargarForm(); 
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dataGridViewArticulos.CurrentRow.DataBoundItem;

            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargarForm();
        }


        //Filtro rápido, con el textbox
        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = textBoxFiltro.Text;

            if(filtro != "")
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToLower().Contains(textBoxFiltro.Text.ToLower()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }
            dataGridViewArticulos.DataSource = null;
            dataGridViewArticulos.DataSource = listaFiltrada;
            dataGridViewArticulos.Columns["ImagenUrl"].Visible = false;
            dataGridViewArticulos.Columns["Id"].Visible = false;
        }

        private void comboBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = comboBoxCampo.SelectedItem.ToString();

            if(opcion == "Precio")  //si es precio, entonces sólo son numeros
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Mayor a");
                comboBoxCriterio.Items.Add("Menor a");
                comboBoxCriterio.Items.Add("Igual a");
            } else
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Empieza con");
                comboBoxCriterio.Items.Add("Termina con");
                comboBoxCriterio.Items.Add("Contiene");
            }
        }

        private void btnFiltroAv_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                {
                    return;
                }
                string campo = comboBoxCampo.SelectedItem.ToString();
                string criterio = comboBoxCriterio.SelectedItem.ToString();
                string filtro = textBoxFiltroAv.Text;
                dataGridViewArticulos.DataSource = negocio.filtrarConDB(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Realmente deseas eliminar este artículo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dataGridViewArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminarArticulo(seleccionado.Id);

                    cargarForm();
                }     
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dataGridViewArticulos.CurrentRow.DataBoundItem;
            frmDetalle detalle = new frmDetalle(seleccionado);  
            detalle.ShowDialog();

        }

        //Función para validar el ingreso de sólo numeros
        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }
                return true;
        }

        private bool validarFiltro()
        {
            if (comboBoxCampo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el campo");
                return true;
            }
            if (comboBoxCriterio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el criterio");
                return true;
            }
            if (comboBoxCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(textBoxFiltroAv.Text))
                {
                    MessageBox.Show("Ingrese un precio para filtrar");
                    return true;
                }

                if (!soloNumeros(textBoxFiltroAv.Text))
                {
                    MessageBox.Show("Por favor, ingrese sólo números");
                    return true;
                }
            }
            return false;
        }
        }
}
