using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {

        Snake mySnake;
        Board mainBoard;
        Rewards apples;

        string mode = "REST";
        Timer clock;
        int duration; //How long the game has been running
        int speed = 500; //500ms

        public Form1()
        {
            InitializeComponent();

            //You don't have to worry about the auto-size
            this.AutoSize = true;       //The size of the Form will autoadjust.
            boardPanel.AutoSize = true; //The size of the panel grouping all the squares will auto-adjust

            //Set up the main board
            mainBoard = new Board(this);

            prepareForNewGame();

        }

        private void prepareForNewGame()
        {
            //Set up the snake, and associate the snake with the mainboard
            mySnake = new Snake(mainBoard);

            //Set up the game timer at the given speed
            clock = new Timer();
            clock.Interval = speed; //Set the clock to tick every 500ms
            clock.Tick += new EventHandler(refresh); //Call the refresh method at every tick to redraw the board and snake.


            modeLBL.Text = mode;

            duration = 0; //Initialised the duration to 0 to mark game start time.

            apples = new Rewards(5, mainBoard); //<--- Generate 5 apples at random positions in the board

        }

        private void upBTN_Click(object sender, EventArgs e)
        {
            mode = "UP";  //Just record the mode. The moving will be done in refresh method
        }

        private void downBTN_Click(object sender, EventArgs e)
        {
            mode = "DOWN";
        }

        private void leftBTN_Click(object sender, EventArgs e)
        {
            mode = "LEFT";
        }

        private void rightBTN_Click(object sender, EventArgs e)
        {
            mode = "RIGHT";
        }

        private void refresh(Object myObject, EventArgs myEventArgs)
        {
            mySnake.move(mode); //Move the snake based on mode
            modeLBL.Text = mode;

            mainBoard.draw();
            apples.draw();  //<----- draw apples
            mySnake.draw();

            //increment the duration by amount of time that has passed
            //this method is called every speed millisecond
            duration += speed;
            timerLBL.Text = Convert.ToString(duration / 1000); //Show time passed


            //Check if snke is biting itself. If so, call GameOver.
            if (mySnake.checkEatItself() == true)
            {
                GameOver();
            }
        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            clock.Start();
        }

        private void pauseBTN_Click(object sender, EventArgs e)
        {
            clock.Stop();
        }

        private void GameOver()
        {
            clock.Stop();
            MessageBox.Show("Your time taken is " + duration/1000 + " seconds. Bye Bye", "Game Over");
            this.Close();
        }
    }
}
