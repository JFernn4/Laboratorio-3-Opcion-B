using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3_Opcion_B
{
    internal class Platos
    {
        public string NombrePlato { get; set; }
        public double Precio {  get; set; }

        public Platos(string nombrePlato, double precio)
        {
            NombrePlato = nombrePlato;
            Precio = precio;
        }
    }
}
