using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3 {
    class Cadete {
        private int id;
        private string nombre;
        private string direccion;
        private long telefono;
        private List<Pedido> ListaPedidos;
        private double TotalACobrar;

        public Cadete(int id, string nombre, string direccion, long telefono, double totalACobrar1, List<Pedido> listaPedidos1) {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            TotalACobrar1 = totalACobrar1;
            ListaPedidos1 = listaPedidos1;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public long Telefono { get => telefono; set => telefono = value; }
        public double TotalACobrar1 { get => TotalACobrar; set => TotalACobrar = value; }
        internal List<Pedido> ListaPedidos1 { get => ListaPedidos; set => ListaPedidos = value; }
    }
}
