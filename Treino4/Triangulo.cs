using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treino4 { 
    internal class Triangulo{ // criada a classe triangulo com os atributos que irão receber triangulo
        public double A; // atributo criado na classe triangulo
        public double B; // atributo criado na classe triangulo
        public double C; // atributo criado na classe triangulo

        public double Area(){
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
