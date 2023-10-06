using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguin_Encounter
{
    public class Menu
    {
        public List<String> Penguins = new List<string>();
        public Menu(List<string> penguins)
        {
            Penguins = penguins;
            penguins.Add("Emperor");
            penguins.Add("Macaroni");
            penguins.Add("Galopagos");
        }

        public void ChoosePenguin()
        {

        }

    }
}
