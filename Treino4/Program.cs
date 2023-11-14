using System;
using System.Globalization;
using Treino4;

namespace Treino{
    class Programa{
        static void Main(string[] args){
            //colocando exercicio do triangulo, ler o dado de duas pessoas e fazer um programa para ler nome, salario de funcionarios e mostrar a media do salario médio
            int menu;
            do{
                Console.WriteLine("digite o que você deseja fazer");
                Console.WriteLine("1-Calculo triangulo.");
                Console.WriteLine("2-Segunda atividade pegar info pessoas");
                Console.WriteLine("3-terceira atividade, media salarial");
                Console.WriteLine("0-Sair.");
                menu = int.Parse(Console.ReadLine());
                if (menu == 1){ 
                    Triangulo x, y; // não basta declarar variaveis do tipo de classe, tem que instanciar
                    x = new Triangulo(); // instanciando as variaveis declaradas
                    y = new Triangulo(); // instanciando as variaveis compostas

                    Console.WriteLine("Coloque as medidas do Primeiro Triangulo: ");
                    x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("Coloque as medidas do Segundo Triangulo: ");
                    y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    double p = (x.A + x.B + x.C) / 2.0;
                    double areaA = Math.Sqrt(p * p);

                    double q = (y.A + y.B + y.C) / 2.0;
                    double areaB = Math.Sqrt(q * (q - y.A) * (q - y.B) * (q - y.C));

                    Console.WriteLine("Área do primeiro triangulo = " + areaA.ToString("F4", CultureInfo.InvariantCulture));
                    Console.WriteLine("Área do segundo triangulo = " + areaB.ToString("F4", CultureInfo.InvariantCulture));

                    if ((areaA > areaB)){
                        Console.WriteLine("Maior área é o primeiro triangulo");
                    }
                    else{
                        Console.WriteLine("Maior área é o segundo Triangulo");
                    }
                } else if (menu == 2){
                    Pessoa individuo1, individuo2;
                    individuo1 = new Pessoa();
                    individuo2 = new Pessoa();

                    Console.WriteLine("Coloque o nome da primeira pessoa: ");
                    individuo1.nome = Console.ReadLine();
                    Console.WriteLine("Coloque a idade da primeira pessoa: ");
                    individuo1.idade = int.Parse(Console.ReadLine());

                    Console.WriteLine("Coloque o nome da segunda pessoa: ");
                    individuo2.nome = Console.ReadLine();
                    Console.WriteLine("Coloque a idade da segunda pessoa: ");
                    individuo2.idade = int.Parse(Console.ReadLine());

                    Console.WriteLine("o nome da primeira pessoa é " + individuo1.nome + " e a idade é " + individuo1.idade);
                    Console.WriteLine("O nome da segunda pessoa é " + individuo2.nome + " e a idade é " + individuo2.idade);

                } else if (menu == 3){
                    salariado trabalhador1, trabalhador2;
                    trabalhador1 = new salariado();
                    trabalhador2 = new salariado();

                    Console.WriteLine("Digite o nome do primeiro trabalhador: ");
                    trabalhador1.nome = Console.ReadLine();
                    Console.WriteLine("Digite o salario do primeiro trabalhador: ");
                    trabalhador1.salario = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o nome do segundo trabalhador: ");
                    trabalhador2.nome = Console.ReadLine();
                    Console.WriteLine("Digite o salario do primeiro trabalhador: ");
                    trabalhador2.salario = float.Parse(Console.ReadLine());

                    Console.WriteLine("O nome do primeiro trabalhador é " + trabalhador1.nome + " e o quanto ele ganha é " + trabalhador1.salario);
                    Console.WriteLine("O nome do segundo trabalhador é " + trabalhador2.nome + " e o quanto ele ganha é " + trabalhador2.salario);

                    float media = (trabalhador1.salario + trabalhador2.salario) / 2;

                    Console.WriteLine("A media salarial entre os 2 é: {0}", media );

                } else {

                }

            } while(menu != 0);
        }
    }

}