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
        public static void Registrar(List<Cliente> listaClientes)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del cliente.");
            string nombre= Console.ReadLine(); 
            Console.WriteLine("Ingrese el correo del cliente.");
            string correo= Console.ReadLine();  
            Console.WriteLine("Ingrese el número de teléfono del cliente.");
            string telefono= Console.ReadLine();
            ClienteRegular clienteRegular = new ClienteRegular(nombre, correo, telefono);
            listaClientes.Add(clienteRegular);
        }
    }
}
