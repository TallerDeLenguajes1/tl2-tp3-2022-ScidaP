using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3 {
    class Cliente : Persona {
        private string referenciasDireccion;

        public Cliente(int id, string nombre, string direccion, long telefono, string referenciasDireccion) : base(id, nombre, direccion, telefono) {
            ReferenciasDireccion = referenciasDireccion;
        } 

        public string ReferenciasDireccion { get => referenciasDireccion; set => referenciasDireccion = value; }
    }
}
