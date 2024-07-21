using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SGSYF_conexion;

namespace SGSYF_clases
{
    public class ProductosControlador
    {

        private string codigo_barra;
        private string categoria;
        private string subcategoria;
        private string nombre;
        private string descripcion;
        //private string precio;
        private string unidad_medida;
        //private string precio_compra;
        private string stock_total;
       //private string proveedores;

        public ProductosControlador
            (
            string codigo_barra,
            string categoria,
            string subcategoria,
            string nombre,
            string descripcion,
            //string precio,
            string unidad_medida,
            //string precio_compra,
            string stock_total
            //string proveedores
            ) { 

            this.codigo_barra = codigo_barra;
            this.categoria = categoria;
            this.subcategoria = subcategoria;
            this.nombre = nombre;
            this.descripcion = descripcion;
            //this.precio = precio;
            this.unidad_medida = unidad_medida;
            //this.precio_compra = precio_compra;
            this.stock_total = stock_total;
            //this.proveedores = proveedores;

        }

        public string Codigo_barra { get => codigo_barra; set => Codigo_barra = value; }
        public string Categoria { get => categoria; set => Categoria = value; }
        public string Subcategoria { get => subcategoria; set => Subcategoria = value; }
        public string Nombre { get => nombre; set => Nombre = value; }
        public string Descripcion { get => descripcion; set => Descripcion = value; }
        //public string Precio { get => precio; set => Precio = value; }
        public string Unidad_medida { get => unidad_medida; set => Unidad_medida = value; }
        //public string Precio_compra { get => precio_compra; set => Precio_compra = value; }
        public string Stock_total { get => stock_total; set => Stock_total = value; }
        //public string Proveedores { get => proveedores; set => Proveedores = value; }


        
    }


}

