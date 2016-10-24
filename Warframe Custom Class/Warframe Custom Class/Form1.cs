using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warframe_Custom_Class
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Warframe[] Allwarframes = new Warframe[5];
            Allwarframes[0] = new Warframe { Name = "Excalibur", Health = 100, Shield = 100, Energy = 100, Armor = 225, Ability1 = "Slash Dash", Ability2 = "Radial Bilind", Ability3 = "Radial Javelin", Ability4 = "Exalted Blade" };
            Allwarframes[1] = new Warframe { Name = "Ash", Health = 150, Shield = 100, Energy = 100, Armor = 65, Ability1 = "Shuriken", Ability2 = "Smoke Screen", Ability3 = "Teleport", Ability4 = "Blade Storm" };
            Allwarframes[2] = new Warframe { Name = "Loki", Health = 75, Shield = 75, Energy = 150, Armor = 65, Ability1 = "Decoy", Ability2 = "Invisibility", Ability3 = "Switch Teleport", Ability4 = "Radial Disarm" };
            Allwarframes[3] = new Warframe { Name = "Mag", Health = 75, Shield = 150, Energy = 100, Armor = 65, Ability1 = "Pull", Ability2 = "Magnetize", Ability3 = "Polarise", Ability4 = "Crush" };
            Allwarframes[4] = new Warframe { Name = "Saryn", Health = 125, Shield = 100, Energy = 150, Armor = 175, Ability1 = "Venom", Ability2 = "Molt", Ability3 = "Contagion", Ability4 = "Miasma" };

            //Make Combobox display all names from array.
            foreach (Warframe n in Allwarframes)
            {
                comboBox1.Items.Add(n);

            }

        }
    }
}

