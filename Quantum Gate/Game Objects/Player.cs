using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum_Gate.Game_Objects
{
    class Player
    { 
        public string currentDirection; //the direction the player is currently facing (should have made this an int)
        public Room currentRoom; //what room the player is in
        private int currentMood; //5 is nuteral, 1 is angry, 10 is happy
        private int chapterNumber; //what chapter is the player in? 1 though to 3
        private int moveCount; //how many moves has this player made?

        public Player(String currentDirection, Room currentRoom, int currentMood, int chapterNumber, int moveCount)
        {
            this.currentDirection = currentDirection;
            this.currentRoom = currentRoom;
            this.currentMood = currentMood;
            this.chapterNumber = chapterNumber;
            this.moveCount = moveCount;
        }

        public String getCurrentImagePath()
        {
            return currentRoom.getCurrentImage(currentDirection);
        }

        public String getLeftMoveMovie()
        {
            return currentRoom.getLeftMoveMovie(currentDirection);
        }

        public String getRightMoveMovie()
        {
            return currentRoom.getRightMoveMovie(currentDirection);
        }

        public String getUpMoveMovie()
        {
            return currentRoom.getExitMovie(currentDirection);
        }

        public bool doesCurrentViewHaveExit()
        {
            return currentRoom.directionHasExit(currentDirection);
        }

        public void walk()
        {
            //Room currentRoom = this.currentRoom;
            foreach (RoomExit roomExit in currentRoom.roomExits)
            {
                if(roomExit.exitDirection == currentDirection)
                {
                    currentDirection = roomExit.directionOverride;
                    Game_Objects.RoomBuilder deck2 = new Game_Objects.RoomBuilder();
                    currentRoom = deck2.buildRoom(roomExit.nextRoom);
                }
            }
        }

        public void rotate(string direction)
        {
            if(direction == "left")
            {
                switch (currentDirection)
                {
                    case "north":
                        currentDirection = "west";
                        break;
                    case "west":
                        currentDirection = "south";
                        break;
                    case "south":
                        currentDirection = "east";
                        break;
                    case "east":
                        currentDirection = "north";
                        break;
                    default:
                        break;
                }
            }

            if (direction == "right")
            {
                switch (currentDirection)
                {
                    case "north":
                        currentDirection = "east";
                        break;
                    case "east":
                        currentDirection = "south";
                        break;
                    case "south":
                        currentDirection = "west";
                        break;
                    case "west":
                        currentDirection = "north";
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
