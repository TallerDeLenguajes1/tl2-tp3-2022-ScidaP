using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TP3 {
    class Program {
        List<Cadeteria> ListaCadeterias = LoadCadeteria();
        List<Cadete> ListaCadetes = LoadCadetes();
        public static List<Cliente> ListaClientes = LoadClientes();
        static void Main(string[] args) {
            Console.WriteLine("Cargando cadeterias y cadetes...");
            int accion;
            do {
                accion = CargarInterfaz();
                AccionInterfaz(accion);
            } while (accion != 9);
            
        }
        public static void AccionInterfaz(int accion) { // Aqui voy llenando lo que se hará con la acción
            switch (accion) {
                case 1:
                    Pedido NuevoPedido = CargarPedido(ListaClientes);
                    break;
            }
        }
        public static int CargarInterfaz() {
            Console.WriteLine("Ingrese {1} para cargar pedidos");
            Console.WriteLine("Ingrese {2} para asignar el pedido a un cadete");
            Console.WriteLine("Ingrese {3} para cambiar el estado de un pedido");
            Console.WriteLine("Ingrese {4} para cambiar el cadete de un pedido");
            Console.WriteLine("Ingrese {5} para crear un cadete");
            Console.WriteLine("Ingrese {9} para cerrar");
            int decision = Convert.ToInt32(Console.ReadLine());
            return decision;
        }

        public static Pedido CargarPedido(List<Cliente> ListaClientes) {
            Console.WriteLine("Crear nuevo pedido");
            Console.WriteLine("Ingrese el numero del pedido");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese las obs del pedido");
            string obs = Console.ReadLine();
            Console.WriteLine("Estado del pedido");
            string estado = Console.ReadLine();
            Cliente ClienteBuscado;
            int flag = 1;
            do {
                if (flag == 0) {
                    Console.WriteLine("Cliente no encontrado. Intente nuevamente");
                }
                Console.WriteLine("Nombre del cliente");
                string NombreBuscado = Console.ReadLine();
                ClienteBuscado = ListaClientes.Find(cliente => cliente.Nombre.Contains(NombreBuscado));
                if (ClienteBuscado == null) {
                    flag = 0;
                } else {
                    flag = 1;
                }
            } while (ClienteBuscado == null);
            var NuevoPedido = new Pedido(numero, obs, estado, ClienteBuscado);
            return NuevoPedido;
        }

        public void DecidirPedido() {

        }

        public static List<Cadeteria> LoadCadeteria() { 
            List<Cadeteria> ListaCadeterias = new List<Cadeteria>();
            string nombreArhivoCadeteria = "datosCadeteria.csv";
            var leerDatos = File.ReadAllLines(nombreArhivoCadeteria).ToList();
            foreach (var item in leerDatos) { // Esta no puede ser la mejor manera de pasar un csv a lista...
                string[] datos = item.Split(';'); 
                var nuevaCadeteria = new Cadeteria(datos[0], Convert.ToInt64(datos[1]), null);
                ListaCadeterias.Add(nuevaCadeteria);
            }
            return ListaCadeterias;
        }

        public static List<Cadete> LoadCadetes() {
            List<Cadete> ListaCadetes = new List<Cadete>();
            string nombreArchivoCadetes = "datosCadetes.csv";
            var leerDatos = File.ReadAllLines(nombreArchivoCadetes).ToList();
            foreach (var item in leerDatos) {
                string[] datos = item.Split(';');
                var nuevoCadete = new Cadete(Convert.ToInt32(datos[0]), datos[1], datos[2], Convert.ToInt64(datos[3]), Convert.ToDouble(datos[4]), null);
                ListaCadetes.Add(nuevoCadete);
            }
            return ListaCadetes;
        }

        public static List<Cliente> LoadClientes() {
            List<Cliente> ListaClientes = new List<Cliente>();
            string nombreArchivoCadetes = "datosClientes.csv";
            var leerDatos = File.ReadAllLines(nombreArchivoCadetes).ToList();
            foreach (var item in leerDatos) {
                string[] datos = item.Split(';');
                var nuevoCliente = new Cliente(Convert.ToInt32(datos[0]), datos[1], datos[2], Convert.ToInt64(datos[3]), datos[4]);
                ListaClientes.Add(nuevoCliente);
            }
            return ListaClientes;
        }
    }
}
