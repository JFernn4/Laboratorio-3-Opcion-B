using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3_Opcion_B
{
    internal class Cliente
    {
        public  string  Nombre { get; set; }
        public string  Correo { get; set; }
        public string Telefono { get; set; }

        public Cliente(string nombre, string correo, string telefono)
        {
            Nombre = nombre;
            Correo = correo;
            Telefono = telefono;
        }
        public static void MostrarDetalles(List<Cliente> listaClientes)
        {
            Console.Clear();
            foreach (Cliente cliente in listaClientes)
            {
                if (cliente is ClienteRegular clienteRegular)
                {
                    Console.WriteLine("Cliente regular");
                    Console.WriteLine($"Nombre: {clienteRegular.Nombre}. Correo: {clienteRegular.Correo}. Teléfono: {clienteRegular.Telefono}.");
                }
                else if (cliente is ClienteVIP clienteVIP)
                {
                    Console.WriteLine("Cliente VIP");
                    Console.WriteLine($"Nombre: {clienteVIP.Nombre}. Correo: {clienteVIP.Correo}. Teléfono: {clienteVIP.Telefono}.");
                }
            }
            Console.ReadKey();  
        }
        public static void Buscar(List<Cliente> listaClientes)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del cliente que desea buscar.");
            string clienteBuscar= Console.ReadLine();
            Cliente buscar= listaClientes.Find(p=>p.Nombre==clienteBuscar);
            if ( buscar == null)
            {
                Console.WriteLine("No se ha encontrado al cliente.");
                Console.ReadKey();
            }
            else
            {
                if (buscar is ClienteRegular clienteRegular)
                {
                    Console.WriteLine("CLIENTE REGULAR");
                    Console.WriteLine($"Nombre: {clienteRegular.Nombre}. Correo: {clienteRegular.Correo}. Teléfono: {clienteRegular.Telefono}.");
                }
                else if (buscar is ClienteVIP clienteVIP)
                {
                    Console.WriteLine("CLIENTE VIP");
                    Console.WriteLine($"Nombre: {clienteVIP.Nombre}. Correo: {clienteVIP}. Teléfono: {clienteVIP}.");
                }
            }
        }
    }
}
