using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum_Gate.Game_Objects
{
    class RoomExit
    {
        public String exitDirection; //direction this exit exits in, North, South, East or West
        public String nextRoom; //where does this room lead?
        public String exitMovie;
        public String directionOverride; //override the player's current direction (if the exit goes round a corner)


        public RoomExit(string exitDirection, String nextRoom, string exitMovie, string baseDir, String directionOverride)
        {
            this.exitDirection = exitDirection;
            this.nextRoom = nextRoom;
            this.exitMovie = baseDir + "/" + exitMovie + ".mov";
            this.directionOverride = directionOverride;
        }
    }
}
