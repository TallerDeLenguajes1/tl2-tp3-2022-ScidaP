using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3 {
    class Persona {
        private int id;
        private string nombre;
        private string direccion;
        private long telefono;

        public Persona(int id, string nombre, string direccion, long telefono) {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
        }

        public virtual void MostrarDatos() {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Direccion: " + Direccion);
            Console.WriteLine("Telefono: " + Telefono);
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public long Telefono { get => telefono; set => telefono = value; }
    }
}
