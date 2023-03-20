using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crosser
{
    public partial class GameScreen : UserControl
    {
        public int score = 0;
        SolidBrush yellowBrush = new SolidBrush(Color.Gold);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        Crosser crosser;
        public static Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown;
        Random randGen = new Random();
        List<Enemy> enemies = new List<Enemy>();

        public GameScreen()
        {
            InitializeComponent();
            crosser = new Crosser(50, 100);
        }

        public void initializeGame()
        {
            
        }

        public void newEnemy()
        {
            int x = randGen.Next(10, this.Width - 30);
            int y = randGen.Next(10, this.Height - 30);
            int xSpeed = randGen.Next(1, 10);
            Enemy newEnemy = new Enemy(x, y, xSpeed);
            enemies.Add(newEnemy);
        }

        private void engine_Tick(object sender, EventArgs e)
        {
            #region shmovement
            if (leftArrowDown && crosser.x > 0)
            {
                crosser.Move("left");
            }
            if (rightArrowDown && crosser.x < this.Width - crosser.width)
            {
                crosser.Move("right");
            }
            if (upArrowDown && crosser.y > 0)
            {
                crosser.Move("up");
            }
            if (downArrowDown && crosser.y < this.Height - crosser.height)
            {
                crosser.Move("down");
            }
            #endregion

            #region fundamentals
            /* if (leftArrowDown && crosser.x > 0)
            {
                crosser.x -= crosser.speed;
            }
            if (rightArrowDown && crosser.x < this.Width - crosser.width)
            {
                crosser.x += crosser.speed;
            }
            if (upArrowDown && crosser.y > 0)
            {
                crosser.y -= crosser.speed;
            }
            if (downArrowDown && crosser.x < this.Height - crosser.height)
            {
                crosser.y += crosser.speed;
            } */
            #endregion

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(yellowBrush, crosser.x, crosser.y, crosser.width, crosser.height);
            //e.Graphics.FillRectangle(redBrush,)
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
            }
        }
    }
}
