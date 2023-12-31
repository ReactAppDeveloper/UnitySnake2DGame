﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();


        public Form1()
        {
            InitializeComponent();

            
            new Settings();


            timer1.Interval = 2000 / Settings.Speed;
            timer1.Tick += UpdateScreen;
            timer1.Start();
            

           
            StartGame();
        }

        private void StartGame()
        {
            lblGameOver.Visible = false;


            
            new Settings();

            
            Snake.Clear();
            
            Circle head = new Circle();
            head.X = 5;
            head.Y = 5;
            Snake.Add(head);

            lblScore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblScore.Text = Settings.Score.ToString();
            GenerateFood();

        }

        
        private void GenerateFood()
        {
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            food = new Circle();
            food.X = random.Next(0, maxXPos);
            food.Y = random.Next(0, maxYPos);
        }


        private void UpdateScreen(object sender, EventArgs e)
        {
            
            if (Settings.GameOver)
            {
               
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                    Settings.direction = Direction.Right;
                else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                    Settings.direction = Direction.Left;
                else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                    Settings.direction = Direction.Up;
                else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                    Settings.direction = Direction.Down;

                MovePlayer();
            }

            pbCanvas.Invalidate();

        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if(!Settings.GameOver)
            {
                //Set colour of snake
                Brush snakeColour;

                //Draw snake
                for(int i = 0; i< Snake.Count; i++ )
                {

                    if (i == 0)
                        snakeColour = Brushes.Black;    //Draw head
                    else
                        snakeColour = Brushes.Blue;    //Rest of body
                     
                    //Draw snake
                    canvas.FillEllipse(snakeColour,
                        new Rectangle(Snake[i].X * Settings.Width,
                                      Snake[i].Y * Settings.Height,
                                      Settings.Width, Settings.Height));


                    //Draw Food
                    canvas.FillRectangle(Brushes.Orange,
                        new Rectangle(food.X * Settings.Width,
                             food.Y * Settings.Height, Settings.Width, Settings.Height));

                }
            }
            else
            {
               

                string gameOver = "OOPS--!-- \nONLY: " + Settings.Score + "\nha ha ha ";
                lblGameOver.Text = gameOver;
                lblGameOver.Visible = true;
            }
        }

        
        private void MovePlayer()
        {
            for(int i = Snake.Count -1; i >= 0; i--)
            {
                //Move head
                if(i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                    }


                    //Get maximum X and Y Pos
                    int maxXPos = pbCanvas.Size.Width/Settings.Width;
                    int maxYPos = pbCanvas.Size.Height/Settings.Height;

                    //Detect collission with game borders.
                    if (Snake[i].X < 0 || Snake[i].Y < 0
                        || Snake[i].X >= maxXPos || Snake[i].Y >= maxYPos)
                    {
                        Die();
                    }


                    //Detect collission with body
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if(Snake[i].X == Snake[j].X && 
                           Snake[i].Y == Snake[j].Y )
                        {
                            Die();
                        }
                    }

                    //Detect collision with food piece
                    if(Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        Eat();
                    }

                }
                else
                {
                    //Move body
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }
 private void Eat()
        {
            //Add circle to body
            Circle circle = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(circle);

            //Update Score
            Settings.Score += Settings.Points;
            lblScore.Text = Settings.Score.ToString();

            GenerateFood();
        }

        private void Die()
        {
            Settings.GameOver = true;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            StartGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.label4.Text = "HIGHEST SCORE IS 3010 \n YOU CAN'T REACH";
        }

        private void pbCanvas_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.label3.Text = " ASSIGHNMENT ON SNAKE GAME \n MUHAMMAD WAQAS IRFAN \n BS6 \n SECTION B \n ROLL NO 23 \n ";
            this.label3.BackColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.label3.ForeColor = Color.White;
           
        }

        private void lblGameOver_Click(object sender, EventArgs e)
        {

        }

        private void fASTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set game speed and start timer
            
            timer1.Interval = 1000 / Settings.Speed;
            timer1.Tick += UpdateScreen;
            timer1.Start();
        }

        private void mEDIUMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set game speed and start timer
            timer1.Interval = 2000 / Settings.Speed;
            timer1.Tick += UpdateScreen;
            timer1.Start();
        }

        private void sLOWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set game speed and start timer
            timer1.Interval = 4000 / Settings.Speed;
            timer1.Tick += UpdateScreen;
            timer1.Start();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pAUSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
