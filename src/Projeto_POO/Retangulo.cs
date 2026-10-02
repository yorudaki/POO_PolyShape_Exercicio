using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape {
    internal class Retangulo : PoligonoReto {
        private string _descricao;
        private double _base;
        private double _altura;
        public Retangulo(string descricao, double baseRetangulo, double altura) {
            _descricao = descricao;
            _base = baseRetangulo;
            _altura = altura;
        }
        public override double Area() {
            return _base * _altura;
        }
        public override double Perimetro() {
            return 2 * (_base * _altura);
        }
    }
}
