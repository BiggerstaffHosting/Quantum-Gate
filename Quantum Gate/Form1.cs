using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Quantum_Gate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            startGame();
        }

        private static Game_Objects.Player player;
        private static Game_Objects.RoomBuilder deck2 = new Game_Objects.RoomBuilder();
        private string formTitle = "Quantum Gate v0.0.1";

        public void startGame()
        {
            leftHotSpot.Parent = imagePortal1;
            rightHotSpot.Parent = imagePortal1;
            forwardsHotSpot.Parent = imagePortal1;
            bottomHotSpot.Parent = imagePortal1;
            leftHotSpot.BackColor = Color.Transparent;
            rightHotSpot.BackColor = Color.Transparent;
            forwardsHotSpot.BackColor = Color.Transparent;
            bottomHotSpot.BackColor = Color.Transparent;
            forwardsHotSpot.Visible = false;
            bottomHotSpot.Visible = false;
            mainVidPlayer.Visible = false;
            player = new Game_Objects.Player("south", deck2.buildRoom("drewQtrs"), 5, 1, 0);
            this.Text = formTitle + " - " + player.currentRoom.friendlyName;
            refreshView();
        }

        private void playLeftMovie()
        {
            string leftMovie = Directory.GetCurrentDirectory() + player.getLeftMoveMovie().Substring(1);
            var uri = new Uri(leftMovie);
            var convertedURI = uri.AbsoluteUri;

            mainVidPlayer.playlist.items.clear();
            mainVidPlayer.playlist.add(convertedURI, convertedURI, null);
            mainVidPlayer.playlist.play();
        }

        private void playRightMovie()
        {
            string rightMovie = Directory.GetCurrentDirectory() + player.getRightMoveMovie().Substring(1);
            var uri = new Uri(rightMovie);
            var convertedURI = uri.AbsoluteUri;

            mainVidPlayer.playlist.items.clear();
            mainVidPlayer.playlist.add(convertedURI, convertedURI, null);
            mainVidPlayer.playlist.play();
        }

        private void playUpMovie()
        {
            string upMovie = Directory.GetCurrentDirectory() + player.getUpMoveMovie();
            var uri = new Uri(upMovie);
            var convertedURI = uri.AbsoluteUri;

            mainVidPlayer.playlist.items.clear();
            mainVidPlayer.playlist.add(convertedURI, convertedURI, null);
            mainVidPlayer.playlist.playItem(0);
        }

        private void refreshView()
        {
            System.Threading.Thread.Sleep(20); //stops the new image appearing breifly before the move movie plays
            forwardsHotSpot.Visible = player.doesCurrentViewHaveExit();
            imagePortal1.ImageLocation = player.getCurrentImagePath();
            this.Text = formTitle + " - " + player.currentRoom.friendlyName + " " + player.currentDirection;

            //todo: handle lifts better!
            if (player.isPlayerInLift == true)
            {
                forwardsHotSpot.Visible = false;
                leftHotSpot.Visible = false;
                rightHotSpot.Visible = false;
                bottomHotSpot.Visible = true;
            }
        }

        private void mainVidPlayer_MediaPlayerPlaying(object sender, EventArgs e)
        {
            mainVidPlayer.Visible = true;
            imagePortal1.Visible = false;
        }

        private void mainVidPlayer_MediaPlayerEndReached(object sender, EventArgs e)
        {
            mainVidPlayer.Visible = false;
            imagePortal1.Visible = true;
        }

        private void rightHotSpot_Click(object sender, EventArgs e)
        {
            forwardsHotSpot.Visible = false;
            playRightMovie();
            player.rotate("right");
            refreshView();
        }

        private void leftHotSpot_Click(object sender, EventArgs e)
        {
            //put a story check in here, once the story class is written
            forwardsHotSpot.Visible = false;
            playLeftMovie();
            player.rotate("left");
            refreshView();
        }

        private void forwardsHotSpot_Click(object sender, EventArgs e)
        {
                forwardsHotSpot.Visible = false;
                playUpMovie();
                player.walk();
                refreshView();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (mainVidPlayer.playlist.isPlaying == true)
            {
                mainVidPlayer.playlist.stop();
                mainVidPlayer.playlist.items.remove(0);
                mainVidPlayer_MediaPlayerEndReached(null, null);
            }
            
        }
    }
}
