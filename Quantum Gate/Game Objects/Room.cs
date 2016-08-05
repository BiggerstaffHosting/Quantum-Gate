using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum_Gate.Game_Objects
{
    class Room
    {
        private string northImage;
        private string eastImage;
        private string southImage;
        private string westImage;

        private string northToEastMov;
        private string eastToSouthMov;
        private string southToWestMov;
        private string westToNorthMov;

        private string northToWestMov;
        private string westToSouthMov;
        private string southToEastMov;
        private string eastToNorthMov;

        private string friendlyName;


        public List<RoomExit> roomExits = new List<RoomExit>();

        public Room(List<String> imageList, List<String> movieList, List<RoomExit> roomExits, String basePath, string friendlyName)
        {
            northImage = basePath + imageList[0] + ".png";
            eastImage  = basePath + imageList[1] + ".png";
            southImage = basePath + imageList[2] + ".png";
            westImage  = basePath + imageList[3] + ".png";

            northToEastMov = basePath + movieList[0] + ".mov";
            eastToSouthMov = basePath + movieList[1] + ".mov";
            southToWestMov = basePath + movieList[2] + ".mov";
            westToNorthMov = basePath + movieList[3] + ".mov";

            northToWestMov = basePath + movieList[4] + ".mov";
            westToSouthMov = basePath + movieList[5] + ".mov";
            southToEastMov = basePath + movieList[6] + ".mov";
            eastToNorthMov = basePath + movieList[7] + ".mov";

            this.roomExits = roomExits;
            this.friendlyName = friendlyName;
        }

        public string getCurrentImage(string direction)
        {
            if(direction == "north")
            {
                return northImage;
            }
            if (direction == "east")
            {
                return eastImage;
            }
            if (direction == "south")
            {
                return southImage;
            }
            if (direction == "west")
            {
                return westImage;
            }
            else
            {
                return null;
            }
        }

        public String getLeftMoveMovie(String direction)
        {
            switch (direction)
            {
                case "north":
                    return northToWestMov;
                case "west":
                    return westToSouthMov;
                case "south":
                    return southToEastMov;
                case "east":
                    return eastToNorthMov;
                default:
                    return null;
            }
        }

        public String getRightMoveMovie(String direction)
        {
            switch (direction)
            {
                case "north":
                    return northToEastMov;
                case "east":
                    return eastToSouthMov;
                case "south":
                    return southToWestMov;
                case "west":
                    return westToNorthMov;
                default:
                    return null;
            }
        }

        public String getExitMovie(String direction)
        {
            foreach (RoomExit exit in roomExits)
            {
                if (direction == exit.exitDirection)
                {
                    return exit.exitMovie;
                }
            }
                return null;
        }

        public bool directionHasExit(string direction)
        {
            foreach (RoomExit exit in roomExits)
            {
                if (exit.exitDirection == direction)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
