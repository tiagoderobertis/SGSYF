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
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            LlenarComboBox llenar = new LlenarComboBox();
            llenar.llenarComboBoxProductos(cmb_categoria);
            llenar.llenarComboBoxProductos(cmb_subcategoria);
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
                
                cmb_unidadmedida.Text,
                
                txt_stock.Text
            //cmb_proveedor.Text
            );

            // VERIFICADORES DE CAMPOS
            if (string.IsNullOrEmpty(cmb_categoria.Text) ||
                string.IsNullOrEmpty(cmb_subcategoria.Text) ||
                string.IsNullOrEmpty(txt_nombre.Text) ||
                string.IsNullOrEmpty(cmb_unidadmedida.Text) ||
                
                string.IsNullOrEmpty(txt_stock.Text) ||
                
                string.IsNullOrEmpty(txt_codigobarra.Text))
            {
                MessageBox.Show("Completa el o los campos vacios");
            }
            else
            {
                // Actualizar el texto del label con la previsualización
                string previsualizacionText = $"Nombre: {txt_nombre.Text}\n" +
                                            $"Descripción: {txt_descripcion.Text}\n" +
                                            $"Categoría: {cmb_categoria.Text}\n" +
                                            $"Subcategoría: {cmb_subcategoria.Text}\n" +
                                            $"Código de Barra: {txt_codigobarra.Text}\n" +
                                            $"Unidad de Medida: {cmb_unidadmedida.Text}\n" +
                                            $"Stock: {txt_stock.Text}";

                // Confirmar si desea agregar el producto
                var confirmResult = MessageBox.Show($"¿Desea agregar este producto?\n" + previsualizacionText, "Confirmar Agregar Producto Nuevo", MessageBoxButtons.YesNo);
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
                    string unidadMedida = productosControlador.Unidad_medida;
                    int stock = Convert.ToInt32(productosControlador.Stock_total);
                    //string proveedor = productosControlador.Proveedores;

                    string query = "INSERT INTO productos (codigo_barra, categoria, subcategoria, nombre, descripcion, precio, unidad_medida, precio_compra, stock_total) " +
                                   "VALUES (" + codigoBarra + ", '" + categoria + "', '" + subCategoria + "', '" + nombre + "', '" + descripcion + "', " + ", '" + unidadMedida + "', " + ", " + stock + ");";

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

        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
