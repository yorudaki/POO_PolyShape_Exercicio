using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape {
    internal class Circulo : Forma {
        private string _descricao;
        private double _raio;
        public Circulo(string descricao, double raio) {
            _descricao = descricao;
            _raio = raio;
        }

        public override double Area() {
            // area = pi * r²
            return Math.PI * Math.Pow(_raio, 2);
        }

        public override double Perimetro() {
            //  perimetro = 2pi * r
            return 2 * Math.PI * _raio;
        }
    }
}
