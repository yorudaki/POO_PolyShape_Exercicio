using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape {
    internal class TrianguloRetangulo : PoligonoReto {
        private string _descricao;
        private double _base;
        private double _altura;
        public TrianguloRetangulo(string descricao, double baseTriangulo, double altura) {
            _descricao = descricao;
            _base = baseTriangulo;
            _altura = altura;
        }
        public override double Area() {
            return (_base * _altura) / 2;
        }
        public override double Perimetro(){
            double hipotenusa = Math.Sqrt( Math.Pow(_base, 2) + Math.Pow(_altura, 2) );

            return _base + _altura + hipotenusa;
        }
    }
}
