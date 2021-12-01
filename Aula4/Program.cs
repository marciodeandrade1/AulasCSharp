using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração das variáveis do tipo inteiro
            int a, b, c;
            //exibe mensagem
            Console.WriteLine("Digite um número: ");
            //Leitura do valor formato de texto precisa ser convertido para o mesmo tipo da variável
            //variável a recebe o valor
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            b = int.Parse(Console.ReadLine());
            //executa a operação soma dos valores recebidos e armazena na variável c
            c = a + b;
            //Exibe resultado da soma
            Console.WriteLine("A soma é:  " + c);
            Console.WriteLine("A soma é: " + (a + b));
            //Aguarda leitura de uma tecla para encerrar
            Console.ReadKey();

        }
    }
}
