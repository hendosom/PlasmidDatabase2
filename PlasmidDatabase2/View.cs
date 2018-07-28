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
    public partial class View : Form
    {
        Controller controller = new Controller();
        public string StringPlasmidName { get; set; }
        public string StringPlasmidSequenz { get; set; }

        public View()
        {
            InitializeComponent();
        }

        private void CmdEnterPlasmid_Click(object sender, EventArgs e)
        {
            // start method to create and save new plasmid in controller
            
            controller.CreatePlasmidSaveToDB();
            
        }

        private void InputPlasmidName_TextChanged(object sender, EventArgs e)
        {
            // Input Name
            StringPlasmidName = ((TextBox)sender).Text; // so muss das formuliert werden damit die Property: Text aus dem Objekt "sender" ausgelesen werden kann
            LblOutputPlasmidName.Text = ((TextBox)sender).Text; // Syntax: ((ELEMENTTYP)OBJEKTNAME).PROPERTY; oder: (OBJEKTNAME as ELEMENTTYP).PROPERTY;

        }

        private void InputPlasmidSequenz_TextChanged(object sender, EventArgs e)
        {
            // Input Sequenz
            StringPlasmidSequenz = ((TextBox)sender).Text;
            LblOutputPlasmidSequenz.Text = ((TextBox)sender).Text;
        }

        private void View_Load(object sender, EventArgs e)
        {

        }

        private void LblOutputPlasmidName_Click(object sender, EventArgs e)
        {
           
        }

        private void LblOutputPlasmidSequenz_Click(object sender, EventArgs e)
        {
            
        }
    }
}
