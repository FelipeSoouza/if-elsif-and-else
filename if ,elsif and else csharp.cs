using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyCsharp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o hora atual: ");

            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia");
            }

            else if (hora < 18)
            {
                Console.WriteLine("boa tarde");
            }

            else 
            {
                Console.WriteLine("boa noite");
            }
        }
    }
}
