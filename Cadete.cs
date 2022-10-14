using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3 {
    class Cadete : Persona {
        private List<Pedido> ListaPedidos;
        private double TotalACobrar;

        public Cadete(int id, string nombre, string direccion, long telefono, double totalACobrar1, List<Pedido> listaPedidos1) : base(id, nombre, direccion, telefono) {
            TotalACobrar1 = totalACobrar1;
            ListaPedidos1 = listaPedidos1;
        }
        public double TotalACobrar1 { get => TotalACobrar; set => TotalACobrar = value; }
        internal List<Pedido> ListaPedidos1 { get => ListaPedidos; set => ListaPedidos = value; }
    }
}
