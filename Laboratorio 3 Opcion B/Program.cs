using Laboratorio_3_Opcion_B;

List<Platos> listaPlatos= new List<Platos>();
List <Reservas> listaReservas= new List<Reservas>();
List <Cliente> listaClientes= new List<Cliente>();
bool menu = true;
int opcion;
while (menu)
{
    MostrarMenu();
    opcion=Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            {
                ClienteRegular.Registrar(listaClientes);
                break;
            }
        case 2:
            {
                ClienteVIP.Registrar(listaClientes);
                break;
            }
        case 3:
            {
                Reservas.Registar(listaReservas, listaClientes);
                break;
            }
        case 4:
            {
                Cliente.MostrarDetalles(listaClientes);
                break;
            }
        case 5:
            {
                Reservas.MostrarDetalles(listaReservas,listaClientes);
                break;
            }
        case 6:
            {
                Cliente.Buscar(listaClientes);
                break;
            }
        case 7:
            {
                Reservas.Buscar(listaReservas,listaClientes);
                break;
            }
        case 8:
            {
                menu = false;
                break;
            }
    }
}
static void MostrarMenu()
{
    Console.Clear();
    Console.WriteLine("1. Registrar cliente regular.");
    Console.WriteLine("2. Registrar cliente VIP.");
    Console.WriteLine("3. Registrar reserva.");
    Console.WriteLine("4. Mostrar detalles de clientes.");
    Console.WriteLine("5. Mostrar detalles de reservas.");
    Console.WriteLine("6. Buscar cliente por nombre.");
    Console.WriteLine("7. Buscar reserva por número.");
    Console.WriteLine("8. Salir.");
}