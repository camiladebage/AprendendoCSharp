using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7");

            int idadeCamila = 16;
            int qtdPessoas = 2;

            if (idadeCamila >= 18)
            {
                Console.WriteLine("Camila possui + de 18 anos");
            }
            else
            {
                if(qtdPessoas >= 2)
                {
                    Console.WriteLine("Camila está acompanhada");
                }
                else
                {
                    Console.WriteLine("Camila não possui + de 18 anos");
                }
               
            }
            Console.ReadLine();
        }
    }
}
