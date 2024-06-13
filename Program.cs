using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1.Autosoluciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gestion_Clientes gestionClientes = new Gestion_Clientes(); // Inicializamos el arreglo

            while (true) // para evalaur 
            {
                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1. Añadir cliente");
                Console.WriteLine("2. Modificar cliente");
                Console.WriteLine("3. Eliminar cliente");
                Console.WriteLine("4. Consultar clientes");
                Console.WriteLine("5. Salir");
                string opcion = Console.ReadLine(); // Creo la variable opcion

                switch (opcion) // Lo uso para evaluar 
                {
                    case "1":
                        gestionClientes.Añadir();
                        break;
                    case "2":
                        gestionClientes.Modificar();
                        break;
                    case "3":
                        gestionClientes.Eliminar();
                        break;
                    case "4":
                        gestionClientes.Consultar();
                        break;
                    case "5":
                        return;
                    default: // Revisa las opciones del 1 al 4 y en la 5 salga
                        Console.WriteLine("Opción no válida.");
                        break; // sale del Swicth
                }
            }
        }
    }

    public class Gestion_Clientes // Se declara la clase Gestion_Clientes
    {
        string[][] clientes = new string[100][]; // Se inicializa  

        public Gestion_Clientes()
        {
            for (int i = 0; i < clientes.Length; i++) // Se crea los contadores y acumuladores 
            {
                clientes[i] = new string[4];
            }
        }

        /* Los métodos creados serán utilizados en el sistema para generar a la empresa un 
         sistema optimo que permita realizar cambios según consideren necesario 
        */
        

        public void Añadir() // procedo a crear el metodo añadir
        {
            Console.WriteLine("Digite el nombre del cliente:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Digite la direccion del cliente:");
            string direccion = Console.ReadLine();
            Console.WriteLine("Digite el telefono del cliente:");
            string telefono = Console.ReadLine();
            Console.WriteLine("Digite el Correo Electronico del cliente:");
            string correoElectronico = Console.ReadLine();

            for (int i = 0; i < clientes.Length; i++)  // Cantidad de filas en el arreglo
            {
                if (clientes[i][0] == null) // verifica que el nombre no sea null para segir el proceso
                {
                    clientes[i][0] = nombre; // establesco los valores de mi lista
                    clientes[i][1] = direccion;
                    clientes[i][2] = telefono;
                    clientes[i][3] = correoElectronico;
                    Console.WriteLine("Cliente añadido exitosamente.");
                    return;
                }
            }

            Console.WriteLine("No se pudo añadir el cliente. Lista llena.");
        }

        public void Modificar() // procedo a crear el metodo Modificar
        {
            Console.WriteLine("Digite el nombre del cliente a modificar:");
            string nombre = Console.ReadLine();

            for (int i = 0; i < clientes.Length; i++) // Cantidad de filas en el arreglo
            {
                if (clientes[i][0] != null && clientes[i][0].Equals(nombre, StringComparison.OrdinalIgnoreCase)) // verifica que el nombre no sea null para segir el proceso
                {
                    Console.WriteLine("Digite la nueva direccion del cliente:");
                    clientes[i][1] = Console.ReadLine(); // establesco los valores de mi lista
                    Console.WriteLine("Digite el nuevo telefono del cliente:");
                    clientes[i][2] = Console.ReadLine();
                    Console.WriteLine("Digite el nuevo Correo Electronico del cliente:");
                    clientes[i][3] = Console.ReadLine();
                    Console.WriteLine("Cliente modificado exitosamente.");
                    return;
                }
            }

            Console.WriteLine("Cliente no encontrado.");
        }

        public void Eliminar() // procedo a crear el metodo Eliminar
        {
            Console.WriteLine("Digite el nombre del cliente a eliminar:");
            string nombre = Console.ReadLine();

            for (int i = 0; i < clientes.Length; i++) // Cantidad de filas en el arreglo
            {
                if (clientes[i][0] != null && clientes[i][0].Equals(nombre, StringComparison.OrdinalIgnoreCase))  // verifica que el nombre no sea null para segir el proceso
                {
                    clientes[i][0] = null;  // establesco los valores de mi lista
                    clientes[i][1] = null;
                    clientes[i][2] = null;
                    clientes[i][3] = null;
                    Console.WriteLine("Cliente eliminado exitosamente.");
                    return;  // Termina la ejecucion 
                }
            }

            Console.WriteLine("Cliente no encontrado.");
        }

        public void Consultar() // procedo a crear el metodo consultar
        {
            Console.WriteLine("\nLista de clientes:");
            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i][0] != null)
                {
                    Console.WriteLine($"Nombre: {clientes[i][0]}, Direccion: {clientes[i][1]}, Telefono: {clientes[i][2]}, Correo Electronico: {clientes[i][3]}");
                }
            }
        }
    }
}


