using System;
using System.Collections.Generic;
using System.Text;

namespace PinturasEverest.Datos
{
    public class Datos
    {        
    }
    public class Colores
    {
        public int Row { get; set; }
        public string Categoria { get; set; }
        public string Linea { get; set; }
        public Nullable<double> Rendimiento { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public Nullable<int> Presentacion { get; set; }
        public string Color { get; set; }
    }
    public class Selector
    {
        public string SelectorUno { get; set; }
        public string SelectorDos { get; set; }
    }
}
