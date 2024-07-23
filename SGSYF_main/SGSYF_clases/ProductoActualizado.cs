using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGSYF_clases
{
    public class ProductoActualizado
    {
        private string nombre_ac;
        private string descripcion_ac;
        private string codigobarra_ac;
        private string stock_ac;

        public ProductoActualizado(string nombre_ac, string descripcion_ac, string codigobarra_ac, string stock_ac)
        {
            this.Nombre_ac = nombre_ac;
            this.Descripcion_ac = descripcion_ac;
            this.Codigobarra_ac = codigobarra_ac;
            this.Stock_ac = stock_ac;
        }

        public string Nombre_ac { get => nombre_ac; set => nombre_ac = value; }
        public string Descripcion_ac { get => descripcion_ac; set => descripcion_ac = value; }
        public string Codigobarra_ac { get => codigobarra_ac; set => codigobarra_ac = value; }
        public string Stock_ac { get => stock_ac; set => stock_ac = value; }
    }
}
