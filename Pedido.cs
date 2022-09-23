using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3 {
    class Pedido {
        private int numero;
        private string obs;
        private Cliente datosCliente;
        private string estado;

        public Pedido(int numero, string obs, string estado, Cliente datosCliente) {
            Numero = numero;
            Obs = obs;
            Estado = estado;
            DatosCliente = datosCliente;
        }

        public int Numero { get => numero; set => numero = value; }
        public string Obs { get => obs; set => obs = value; }
        public string Estado { get => estado; set => estado = value; }
        internal Cliente DatosCliente { get => datosCliente; set => datosCliente = value; }
    }
}
