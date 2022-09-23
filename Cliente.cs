using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3 {
    class Cliente {
        private int id;
        private string nombre;
        private string direccion;
        private long telefono;
        private string referenciasDireccion;

        public Cliente(int id, string nombre, string direccion, long telefono, string referenciasDireccion) {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            ReferenciasDireccion = referenciasDireccion;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public long Telefono { get => telefono; set => telefono = value; }
        public string ReferenciasDireccion { get => referenciasDireccion; set => referenciasDireccion = value; }
    }
}
