using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usando variáveis
            string nome = "Milena";
            string sobrenome = "Rufini";
            //Concatenação e exibição dos valores
            Console.WriteLine(nome + " " + sobrenome);
            Console.WriteLine(sobrenome + " " + nome);
            //aguarda usuário precionar uma tecla para encerrar a rotina
            Console.ReadKey();

        }
    }
}
