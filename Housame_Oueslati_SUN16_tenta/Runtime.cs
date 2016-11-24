using Housame_Oueslati_SUN16_tenta.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housame_Oueslati_SUN16_tenta
{
    class Runtime
    {

        public void Start()
        {
            while (true)
            {
                var gui = new GUI();
                gui.MainMenu();
            }
        }
    }
}
