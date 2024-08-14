using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3_Opcion_B
{
    internal class Reservas
    {
        public int Numero { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public List<Platos> Platos { get; set; }
        public Cliente Cliente { get; set; }

        public Reservas(int numero, string fecha, string hora, Cliente cliente)
        {
            Numero = numero;
            Fecha = fecha;
            Hora = hora;
            Cliente = cliente;
            Platos = new List<Platos>();
        }
        public static void Registar(List<Reservas> listaReservas, List<Cliente> listaClientes)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del cliente.");
            string clienteReserva = Console.ReadLine();
            Cliente cliente = listaClientes.Find(p => p.Nombre == clienteReserva);
            if (cliente == null)
            {
                Console.WriteLine("No se ha encontrado al cliente.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ingrese en el número de la reserva.");
                int numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la fecha de la reserva.");
                string fecha = Console.ReadLine();
                Console.WriteLine("Ingrese la hora de la reserva.");
                string hora = Console.ReadLine();
                Reservas reserva = new Reservas(numero, fecha, hora, cliente);
                Console.WriteLine("Ingrese cuántos platos va a reservar.");
                int cantidadPlatos = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < cantidadPlatos; i++)
                {
                    Console.WriteLine($"Ingrese el nombre del plato {i + 1}.");
                    string nombrePlato = Console.ReadLine();
                    Console.WriteLine($"Ingrese el precio del plato {i + 2}.");
                    double precio = Convert.ToDouble(Console.ReadLine());
                    Platos plato = new Platos(nombrePlato, precio);
                    reserva.Platos.Add(plato);
                }
                listaReservas.Add(reserva);
            }
        }
    }
}
