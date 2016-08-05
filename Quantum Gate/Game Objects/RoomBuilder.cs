using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum_Gate.Game_Objects
{
    class RoomBuilder
    {
        private List<String> imageList = new List<string>();
        private List<String> movieList = new List<string>();
        private List<RoomExit> exitList = new List<RoomExit>();

        public Room buildRoom(String roomName)
        {
            if(roomName == "drewQtrs") //Drew's quarters
            {
                imageList.Add("n3c"); //north (door)
                imageList.Add("n3b"); //east (militerm)
                imageList.Add("n3a"); //south (desk)
                imageList.Add("n3d"); //west (bed)

                
                movieList.Add("N3C_3B"); //north to east
                movieList.Add("N3B_3A"); //east to south
                movieList.Add("N3A_3D"); //south to west
                movieList.Add("N3D_3C"); //west to north

                movieList.Add("N3C_3D"); //north to east
                movieList.Add("N3D_3A"); //west to south
                movieList.Add("N3A_3B"); //south to west
                movieList.Add("N3B_3C"); //west to north

                String basePath = (@".\content\drewqtrs\");

                RoomExit northExit = new RoomExit("north", "enlistedQtrs", "N3C_2C", basePath, "north");
                exitList.Add(northExit);

                Room drewQtrs = new Room(imageList, movieList, exitList, basePath, "Drew's Quarters");

                return drewQtrs;
            }

            if (roomName == "enlistedQtrs") //Enlisted Men's quarters
            {
                imageList.Add("n2c"); //north
                imageList.Add("n2b"); //east
                imageList.Add("n2a"); //south
                imageList.Add("n2d"); //west

                movieList.Add("N2C_2B"); //north to east
                movieList.Add("N2B_2A"); //east to south
                movieList.Add("N2A_2D"); //south to west
                movieList.Add("N2D_2C"); //west to north

                movieList.Add("N2C_2D"); //north to west
                movieList.Add("N2D_2A"); //west to south
                movieList.Add("N2A_2B"); //south to east
                movieList.Add("N2B_2C"); //east to north

                String basePath = (@".\content\drewqtrs\");

                RoomExit northExit = new RoomExit("east", "drewQtrs", "N2B_3A", basePath, "south");
                exitList.Add(northExit);

                Room enlistedQtrs = new Room(imageList, movieList, exitList, basePath, "Corporate Quarters");

                return enlistedQtrs;
            }

            return null;
        }
    }
}
