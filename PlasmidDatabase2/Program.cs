using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlasmidDatabase2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            View view = new View();
            Application.Run(view);

            Console.WriteLine("Name: {0}, Sequenz: {1}", view.StringPlasmidName, view.StringPlasmidSequenz);



            Console.ReadLine();
        }
    }
}
