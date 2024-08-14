using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3_Opcion_B
{
    internal class ClienteRegular : Cliente
    {
        public ClienteRegular(string nombre, string correo, string telefono) : base(nombre, correo, telefono)
        {
        }
    }
}
