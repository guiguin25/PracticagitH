namespace ConAppListasDobles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaDoble lista = new ListaDoble();
            Console.WriteLine("* * * MENU LISTAS DOBLES * * *");
            int opcion;
            do {
                Console.WriteLine("1.AGREGAR NODO AL INICIO");
                Console.WriteLine("2.AGREGAR NODO AL FINAL");
                Console.WriteLine("3.VER LISTA DOBLE");
                Console.WriteLine("4.BUSCAR DATOS DE UN NODO");
                Console.WriteLine("5.ELIMINAR NODO AL INICIO");
                Console.WriteLine("6.ELIMINAR NODO AL FINAL");
                Console.WriteLine("7.SALIR");
                Console.Write("INGRESE UNA OPCION: ");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        Console.Write("INGRESE UN DATO: ");
                        int datoIni = int.Parse(Console.ReadLine());
                        lista.agregaIni(datoIni);
                        break;
                    case 2:
                        Console.Write("INGRESE UN DATO: ");
                        int datoFin = int.Parse(Console.ReadLine());
                        lista.agregaFin(datoFin);
                        break;
                    case 3:
                        lista.verListaDoble();
                        break;
                    case 4:
                        Console.Write("INGRESE EL DATO A BUSCAR: ");
                        int datoBus = int.Parse(Console.ReadLine());
                        lista.buscar(datoBus);
                        break;
                    case 5:
                        lista.eliminarInicio();
                        break;
                    case 6:
                        lista.eliminarFin();
                        break;
                    case 7:
                        Console.WriteLine("SALIENDO DEL PROGRAMA...");
                        break;
                    default:
                        Console.WriteLine("OPCION NO VALIDA");
                        break;
                }
            } while (opcion!=7);
        }
    }
}
