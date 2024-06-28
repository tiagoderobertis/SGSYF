using MySql.Data.MySqlClient;
using SGSYF_clases;
using SGSYF_conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGSYF
{
    public partial class AgregarProductoNuevo : Form
    {
        public AgregarProductoNuevo()
        {
            InitializeComponent();
            SGSYF_UI ui = new SGSYF_UI();
            ui.Mover();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            LlenarComboBoxCategorias();
            LlenarComboBoxSubCategorias();
        }

        private void LlenarComboBoxCategorias()
        {
            Conexion conexion = new Conexion();
            MySqlConnection mySqlConnection = conexion.Establecer_Conexion();

            if (mySqlConnection == null)
            {
                MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                return;
            }

            string query = "SELECT * FROM categorias";
            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmb_categoria.Items.Add(reader["nombre"].ToString());
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void LlenarComboBoxSubCategorias()
        {
            Conexion conexion = new Conexion();
            MySqlConnection mySqlConnection = conexion.Establecer_Conexion();

            if (mySqlConnection == null)
            {
                MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                return;
            }

            string query = "SELECT * FROM subcategorias";
            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmb_subcategoria.Items.Add(reader["nombre"].ToString());
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            ProductosControlador productosControlador = new ProductosControlador
            (
                txt_codigobarra.Text,
                cmb_categoria.Text,
                cmb_subcategoria.Text,
                txt_nombre.Text,
                txt_descripcion.Text,
                txt_precio.Text,
                cmb_unidadmedida.Text,
                txt_preciocompra.Text,
                txt_stock.Text
            //cmb_proveedor.Text
            );

            // VERIFICADORES DE CAMPOS
            if (string.IsNullOrEmpty(cmb_categoria.Text) ||
                string.IsNullOrEmpty(cmb_subcategoria.Text) ||
                string.IsNullOrEmpty(txt_nombre.Text) ||
                string.IsNullOrEmpty(cmb_unidadmedida.Text) ||
                string.IsNullOrEmpty(txt_precio.Text) ||
                string.IsNullOrEmpty(txt_stock.Text) ||
                string.IsNullOrEmpty(txt_preciocompra.Text) ||
                string.IsNullOrEmpty(txt_codigobarra.Text))
            {
                MessageBox.Show("Completa el o los campos vacios");
            }
            else
            {
                // Actualizar el texto del label con la previsualización
                lbl_previsualizacion.Text = $"Código de Barra: {txt_codigobarra.Text}\n" +
                                            $"Categoría: {cmb_categoria.Text}\n" +
                                            $"Subcategoría: {cmb_subcategoria.Text}\n" +
                                            $"Nombre: {txt_nombre.Text}\n" +
                                            $"Descripción: {txt_descripcion.Text}\n" +
                                            $"Precio: {txt_precio.Text}\n" +
                                            $"Unidad de Medida: {cmb_unidadmedida.Text}\n" +
                                            $"Precio de Compra: {txt_preciocompra.Text}\n" +
                                            $"Stock: {txt_stock.Text}";

                // Confirmar si desea agregar el producto
                var confirmResult = MessageBox.Show("¿Desea agregar este producto?", "Confirmar Agregar Producto", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // - AGREGAR PRODUCTOS A LA BASE DE DATOS
                    Conexion conexion = new Conexion();
                    MySqlConnection mySqlConnection = conexion.Establecer_Conexion();

                    if (mySqlConnection == null)
                    {
                        MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                        return;
                    }

                    int codigoBarra = Convert.ToInt32(productosControlador.Codigo_barra);
                    string categoria = productosControlador.Categoria;
                    string subCategoria = productosControlador.Subcategoria;
                    string nombre = productosControlador.Nombre;
                    string descripcion = productosControlador.Descripcion;
                    int precio = Convert.ToInt32(productosControlador.Precio);
                    string unidadMedida = productosControlador.Unidad_medida;
                    int precioCompra = Convert.ToInt32(productosControlador.Precio_compra);
                    int stock = Convert.ToInt32(productosControlador.Stock_total);
                    //string proveedor = productosControlador.Proveedores;

                    string query = "INSERT INTO productos (codigo_barra, categoria, subcategoria, nombre, descripcion, precio, unidad_medida, precio_compra, stock_total) " +
                                   "VALUES (" + codigoBarra + ", '" + categoria + "', '" + subCategoria + "', '" + nombre + "', '" + descripcion + "', " + precio + ", '" + unidadMedida + "', " + precioCompra + ", " + stock + ");";

                    MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Producto agregado exitosamente.");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        mySqlConnection.Close();
                    }
                }
            }
        }


    }
}
