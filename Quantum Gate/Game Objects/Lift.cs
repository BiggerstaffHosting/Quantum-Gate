using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum_Gate.Game_Objects
{
    class Lift
    {
        private string northImage;
        private string northToSouthMov;
        public string friendlyName;


        public Lift(int deckNumber, int liftNumber)
        {
            String basePath = (@".\content\atrium\");

            if (deckNumber == 2 || liftNumber == 1)
            {
                northImage = basePath + "NAS2S2.png";
                northToSouthMov = basePath + "exit1.png";
                friendlyName = "Lift1, Deck 2";
            }
        }

        public String getCurrentImage()
        {
            return northImage;
        }

        public String getexitMovie()
        {
            return northToSouthMov;
        }

    }

}
