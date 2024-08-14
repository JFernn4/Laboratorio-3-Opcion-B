using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3_Opcion_B
{
    internal class Reservas
    {
        public int Numero {  get; set; }
        public string Fecha { get; set;}
        public string Hora { get; set; }
        public List<Platos> Platos { get; set; }
        public Cliente Cliente { get; set; }

        public Reservas(int numero, string fecha, string hora, Cliente cliente)
        {
            Numero = numero;
            Fecha = fecha;
            Hora = hora;
            Cliente = cliente;
        }
    }
}
