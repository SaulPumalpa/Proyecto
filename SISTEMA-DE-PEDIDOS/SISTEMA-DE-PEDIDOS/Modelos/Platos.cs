using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SISTEMA_DE_PEDIDOS.Modelos
{
    [Table ("PLATOS")]
    public class Plato
{
        [PrimaryKey]
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Categoria { get; set; }
       
        public string Descripcion { get; set; }
        public Type Imagen { get; set; }
    }
}
