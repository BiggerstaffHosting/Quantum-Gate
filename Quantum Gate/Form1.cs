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

        public void startGame()
        {
            mainVidPlayer.Visible = false;
            player = new Game_Objects.Player("west", deck2.buildRoom("drewQtrs"), 5, 1, 0);
            upButton.Visible = false;
            refreshView();
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            //put a story check in here, once the story class is written
            upButton.Visible = false;
            playLeftMovie();
            player.rotate("left");
            refreshView();
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            upButton.Visible = false;
            playRightMovie();
            player.rotate("right");
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
            mainVidPlayer.playlist.play();
        }

        private void refreshView()
        {
            imagePortal1.ImageLocation = player.getCurrentImagePath();
            //this.Text = player.currentDirection;
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
            upButton.Visible = player.doesCurrentViewHaveExit();
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            upButton.Visible = false;
            playUpMovie();
            player.walk();
            refreshView();
        }
    }
}
