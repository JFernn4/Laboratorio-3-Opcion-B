using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
                int numero = 0;
                bool trycatch = true;
                int cantidadPlatos = 0;
                string fecha= "vacío";
                string hora = "vacío";
                while (trycatch)
                {
                    try
                    {
                        if (numero == 0)
                        {
                            Console.WriteLine("Ingrese en el número de la reserva.");
                            numero = Convert.ToInt32(Console.ReadLine());
                        }
                        if (fecha == "vacío")
                        {
                            Console.WriteLine("Ingrese la fecha de la reserva.");
                            fecha = Console.ReadLine();
                        }
                        if (hora == "vacío")
                        {
                            Console.WriteLine("Ingrese la hora de la reserva.");
                            hora = Console.ReadLine();
                        }
                        Reservas reserva = new Reservas(numero, fecha, hora, cliente);
                        if (cantidadPlatos == 0)
                        {
                            Console.WriteLine("Ingrese cuántos platos va a reservar.");
                            cantidadPlatos = Convert.ToInt32(Console.ReadLine());
                        }
                        double precio = 0;
                        for (int i = 0; i < cantidadPlatos; i++)
                        {
                            bool precioValido = true;
                            while (precioValido)
                            {
                                try
                                {
                                    Console.WriteLine($"Ingrese el precio del plato {i + 1}.");
                                    precio = Convert.ToDouble(Console.ReadLine());
                                    precioValido = false;
                                }
                                catch (Exception ex)
                                {
                                    Console.Clear(); Console.WriteLine("Ingrese un valor válido."); Console.ReadKey();
                                }
                            }
                            Console.WriteLine($"Ingrese el nombre del plato {i + 1}.");
                            string nombrePlato = Console.ReadLine();
                            Platos plato = new Platos(nombrePlato, precio);
                            reserva.Platos.Add(plato);
                        }
                        listaReservas.Add(reserva);
                        trycatch = false;
                    }
                    catch (Exception ex) { Console.Clear(); Console.WriteLine(ex.Message); Console.ReadKey(); }
                }
            }
        }
        public static double CalcularTotal(Reservas reservas)
        {
            double descuento = 0;
            double total = reservas.Platos.Sum(platos => platos.Precio);
            if (reservas.Cliente is ClienteVIP)
            {
                descuento = total * 0.15;
                total = total - descuento;
            }
            else if (reservas.Cliente is ClienteRegular)
            {
                total = total;
            }
            return total;
        }
        public static void MostrarDetalles(List<Reservas> listaReservas, List<Cliente> listaClientes)
        {
            Console.Clear();
            foreach (Reservas reserva in listaReservas)
            {
                Console.WriteLine($"Cliente: {reserva.Cliente.Nombre}. Número de pedido: {reserva.Numero}. Fecha: {reserva.Fecha}. Hora: {reserva.Hora}.");
   
                Console.WriteLine("Lista de productos");
                foreach (Platos platos in reserva.Platos)
                {
                    Console.WriteLine($"Nombre: {platos.NombrePlato}. Precio: {platos.Precio}.");
                }
                    if (reserva.Cliente is ClienteVIP)
                    {
                        Console.WriteLine($"Total: Q.{CalcularTotal(reserva)} (15% de descuento).");
                    }
                    else
                    {
                        Console.WriteLine($"Total: Q.{CalcularTotal(reserva)}.");
                    }              
            }
            Console.ReadKey();
        }
        public static void Buscar(List<Reservas> listaReservas, List<Cliente> listaClientes)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el número de reserva que desea buscar.");
            int buscarReservas=Convert.ToInt32(Console.ReadLine());
            Reservas buscar= listaReservas.Find(p=>p.Numero==buscarReservas);
            if (buscar == null)
            {
                Console.WriteLine("No se ha encontrado el pedido.");
                Console.ReadKey();
            }
            else
            {
                if (buscar.Cliente is ClienteRegular clienteRegular)
                {
                    Console.WriteLine($"Cliente: {buscar.Cliente.Nombre}. Número de pedido: {buscar.Numero}. Fecha: {buscar.Fecha}. Hora: {buscar.Hora}.");
                    Console.WriteLine($"Lista de productos");
                    foreach (Platos platos in buscar.Platos)
                    {
                        Console.WriteLine($"Nombre: {platos.NombrePlato}. Precio: {platos.Precio}.");
                    }    
                        if (buscar.Cliente is ClienteVIP)
                        {
                            Console.WriteLine($"Total: Q.{CalcularTotal(buscar)} (15% de descuento).");
                        }
                        else if (buscar.Cliente is ClienteRegular)
                        {
                            Console.WriteLine($"Total: Q.{CalcularTotal(buscar)}.");
                        }
                }
            }
            Console.ReadKey ();
        }
    }
}
