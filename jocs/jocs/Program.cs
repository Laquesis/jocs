using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jocs
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcio;
            opcio = Convert.ToString(Console.ReadLine());

            switch (opcio)
            {
                case "buscaminas":
                    buscaminas();
                    break;
                case "ajedrez":
                    ajedrez();
                    break;

            }



        }

        private static void ajedrez()
        {
                  }

        private static void buscaminas()
        {
            Console.WriteLine("Modifico master");
        }
    }
}
