using System;

namespace Aula02  {

    class Program {

        static void Main(string[] args) {
            TelaMenu();
        }
        static void TelaMenu() {
            while(true) {
                Console.Clear();
                Console.WriteLine("===== MENU =====");
                Console.WriteLine("(1) = Soma.");
                Console.WriteLine("(2) = Subtracao.");
                Console.WriteLine("(3) = Multiplicacao.");
                Console.WriteLine("(4) = Divisao.");
                Console.WriteLine("(0) = SAIR.");
                Console.Write("Selecione: ");

                int OpcaoSelecionada = int.Parse(Console.ReadLine());
                if(OpcaoSelecionada == 0)
                    break;
                if(OpcaoSelecionada == 1)
                    Soma();
                if(OpcaoSelecionada == 2)
                    Subtracao();
                if(OpcaoSelecionada == 3)
                    Multiplicacao();
                if(OpcaoSelecionada == 4)
                    Divisao();
            }
        }

        static void Soma() {
            Console.Clear();
            Console.Write("Primeiro Valor: ");
            float PrimeiroValor = float.Parse(Console.ReadLine());
            Console.Write("Segundo Valor: ");
            float SegundoValor = float.Parse(Console.ReadLine());
             float Resultado = PrimeiroValor + SegundoValor;
            Console.Write("Soma = " + Resultado);
        }

        static void Subtracao() {
            Console.Clear();
            Console.Write("Primeiro Valor: ");
            float PrimeiroValor = float.Parse(Console.ReadLine());
            Console.Write("Segundo Valor: ");
            float SegundoValor = float.Parse(Console.ReadLine());
             float Resultado = PrimeiroValor - SegundoValor;
            Console.Write("Subtracao = " + Resultado);
        }

        static void Divisao() {
            Console.Clear();
            Console.Write("Primeiro Valor: ");
            float PrimeiroValor = float.Parse(Console.ReadLine());
            Console.Write("Segundo Valor: ");
            float SegundoValor = float.Parse(Console.ReadLine());
            float Resultado = PrimeiroValor / SegundoValor;
            Console.Write("Divisao = " + Resultado);
        }

        static void Multiplicacao() {
            Console.Clear();
            Console.Write("Primeiro Valor: ");
            float PrimeiroValor = float.Parse(Console.ReadLine());
            Console.Write("Segundo Valor: ");
            float SegundoValor = float.Parse(Console.ReadLine());
            float Resultado = PrimeiroValor * SegundoValor;
            Console.Write("Multiplicacao = " + Resultado);
        }
    }
}

