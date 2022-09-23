using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3 {
    class Cadeteria {
        private string nombre;
        private long telefono;
        private List<Cadete> ListaCadetes;

        public Cadeteria(string nombre, long telefono, List<Cadete> listaCadetes1) {
            Nombre = nombre;
            Telefono = telefono;
            ListaCadetes1 = listaCadetes1;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public long Telefono { get => telefono; set => telefono = value; }
        internal List<Cadete> ListaCadetes1 { get => ListaCadetes; set => ListaCadetes = value; }
    }
}
