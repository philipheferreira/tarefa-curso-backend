using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treino4{
    internal class salariado{
        public string? nome;
        public float salario;

        public float media (float salario1, float salario2){
            return (salario1 + salario2) / 2;
        }
    }
}
