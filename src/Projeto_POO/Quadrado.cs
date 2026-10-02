using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape {
    internal class Quadrado : PoligonoReto {
        private string _descricao;
        private double _lado;
        public Quadrado(string descricao, double lado) {
            _descricao = descricao;
            _lado = lado;
        }

        public override double Area() {
            return _base * _base;
        }
        public override double Perimetro() {
            return _base * 4;
        }
    }
}
