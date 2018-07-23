using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlasmidDatabase2
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            View view = new View();

            // vorrübergehender Runtime Check
            bool exit = false;

            while (exit == false) 
            {
                exit = controller.TestMethode();
            }

            Console.ReadLine();
        }
    }
}
