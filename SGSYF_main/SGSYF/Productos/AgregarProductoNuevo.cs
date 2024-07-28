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
            
            cmb_categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_subcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            LlenarComboBoxCategorias();
            cmb_categoria.SelectedIndexChanged += new EventHandler(cmb_categoria_SelectedIndexChanged);
        }

        private void LlenarComboBoxCategorias()
        {
            Conexion conexion = new Conexion();
            MySqlConnection conex = conexion.Establecer_Conexion();
            string query = "SELECT id_categoria, nombre FROM categorias";

            using (conex)
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(query, conex);
                    MySqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    cmb_categoria.DataSource = dataTable;
                    cmb_categoria.DisplayMember = "nombre";
                    cmb_categoria.ValueMember = "id_categoria"; // Usamos ValueMember para obtener el id de la categoría seleccionada
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conex.Close();
                }
            }
        }

        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_categoria.SelectedValue != null && cmb_categoria.SelectedValue is int)
            {
                int categoriaId = (int)cmb_categoria.SelectedValue;
                LlenarComboBoxSubcategorias(categoriaId);
            }
        }

        private void LlenarComboBoxSubcategorias(int categoriaId)
        {
            Conexion conexion = new Conexion();
            MySqlConnection conex = conexion.Establecer_Conexion();
            string query = "SELECT nombre FROM subcategorias WHERE id_categoria = @categoriaId";

            using (conex)
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(query, conex);
                    command.Parameters.AddWithValue("@categoriaId", categoriaId);
                    MySqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    cmb_subcategoria.DataSource = dataTable;
                    cmb_subcategoria.DisplayMember = "nombre";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conex.Close();
                }
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
                cmb_unidadmedida.Text,
                txt_stock.Text
            );

            // VERIFICADORES DE CAMPOS
            if (string.IsNullOrEmpty(cmb_categoria.Text) ||
                string.IsNullOrEmpty(cmb_subcategoria.Text) ||
                string.IsNullOrEmpty(txt_nombre.Text) ||
                string.IsNullOrEmpty(cmb_unidadmedida.Text) ||
                string.IsNullOrEmpty(txt_stock.Text) ||
                string.IsNullOrEmpty(txt_codigobarra.Text))
            {
                MessageBox.Show("Completa el o los campos vacíos");
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

                    // Convertir y obtener los valores de los controles
                    string codigoBarra = productosControlador.Codigo_barra;
                    string categoria = productosControlador.Categoria;
                    string subCategoria = productosControlador.Subcategoria;
                    string nombre = productosControlador.Nombre;
                    string descripcion = productosControlador.Descripcion;
                    string unidadMedida = productosControlador.Unidad_medida;
                    int stock = Convert.ToInt32(productosControlador.Stock_total);

                    // Consulta SQL con parámetros
                    string query = "INSERT INTO productos (codigo_barra, categoria, subcategoria, nombre, descripcion, unidad_medida, stock_total) " +
                                   "VALUES (@codigoBarra, @categoria, @subCategoria, @nombre, @descripcion, @unidadMedida, @stock)";

                    MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                    cmd.Parameters.AddWithValue("@codigoBarra", codigoBarra);
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                    cmd.Parameters.AddWithValue("@subCategoria", subCategoria);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@unidadMedida", unidadMedida);
                    cmd.Parameters.AddWithValue("@stock", stock);

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




        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
