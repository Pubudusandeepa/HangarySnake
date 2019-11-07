using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmSnake : Form
    {
        Random rand;
        enum GameBoardField
        {
            Free,
            Snake,
            Bonus
        };

        enum Direction
        {
            Up,
            Down,
            Left,
            Right
        };

        struct SnakeCoordinates
        {
            public int x;
            public int y;
        }

        GameBoardField[,] gameBoardField;
        SnakeCoordinates[] snakeXY;
        int snakeLenght;
        Direction direction;
        Graphics g;


        public frmSnake()
        {
            InitializeComponent();
            gameBoardField = new GameBoardField[11, 11];
            snakeXY = new SnakeCoordinates[100];
            rand = new Random();
        }

       

       

        private void frmSnake_Load_1(object sender, EventArgs e)
        {
            picGameBoard.Image = new Bitmap(420, 420);
            g = Graphics.FromImage(picGameBoard.Image);
            g.Clear(Color.White);


            for(int i=1; i <= 10; i++)
            {   //top to bottom wall
                g.DrawImage(imgList1.Images[6], i * 35, 0);
                g.DrawImage(imgList1.Images[6], i * 35, 385);
            }

            for(int i=0; i<=11; i++)
            {     //Left to right walls
                g.DrawImage(imgList1.Images[6], 0, i * 35);
                g.DrawImage(imgList1.Images[6], 385, i * 35);
            }

            //Initiate snake body and head
            snakeXY[0].x = 5;//head
            snakeXY[0].y = 5;
            snakeXY[1].x = 5;//first body part
            snakeXY[1].y = 6;
            snakeXY[2].x = 5;//second body part
            snakeXY[2].y = 7;

            g.DrawImage(imgList1.Images[5], 5 * 35, 5 * 35);//head
            g.DrawImage(imgList1.Images[4], 5 * 35, 6 * 35);//first body part
            g.DrawImage(imgList1.Images[4], 5 * 35, 7 * 35);// second body part

            gameBoardField[5, 5] = GameBoardField.Snake;
            gameBoardField[5, 6] = GameBoardField.Snake;
            gameBoardField[5, 7] = GameBoardField.Snake;

            direction = Direction.Up;
            snakeLenght = 3;

            for(int i=0; i<4; i++)
            {
                Bonus();
            }



        }

        private void Bonus()
        {
            int x, y;
            var imgIndex = rand.Next(0, 4);

            do
            {
                x = rand.Next(1, 10);
                y = rand.Next(1, 10);
            }
            while (gameBoardField[x, y] != GameBoardField.Free);

            gameBoardField[x, y] = GameBoardField.Bonus;
            g.DrawImage(imgList1.Images[imgIndex], x * 35, y * 35);


            
        }

    }
}
