using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlasmidDatabase2
{
    class Controller
    {
        Model model = new Model();

        public bool TestMethode()
        {
            bool a = false;
            Console.WriteLine("Test");
            Console.ReadLine();
            Console.Write("Eingabe zum Beenden Y/N: ");
            string eingabe = Convert.ToString(Console.ReadLine());
            Console.ReadLine();
            if (eingabe.ToLower() == "y")
            {
                a = true;
            }

            return a;
        }

        public void CreatePlasmidSaveToDB()
        {
            // create new plasmid
            // start model.METHOD that gets input from view and puts it into plasmid
            // save plasmid to database (maybe in model?
        }
    }
}
