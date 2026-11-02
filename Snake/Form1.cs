using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		List<Circle> snake = new List<Circle>();
		Circle food = new Circle(11, 11, Color.Red);
		Graphics graphics;
		bool left = false, right = false, up = false, down = false;
		int score = 0;

		private void Form1_Load(object sender, EventArgs e)
		{
			MessageBox.Show("Welcome to snake! \nGet the red food and try not to hit your borders or yourself! \nGood luck!");
			lblStart.Visible = false;
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			left = false;
			right = false;
			down = false;
			up = false; 
			int x = rnd.Next(10 / 20 + 2, 450 / 20 - 2), y = rnd.Next(10 / 20 + 2, 430 / 20 - 2);
			score = 0;
			lblScore.Text = "Score: " + score + "";

			Circle head = new Circle(2, 2, Color.Blue);
			snake.Clear();

			snake.Add(head);
			food.x = x;
			food.y = y;

			timerGame.Start();
			btnStart.Enabled = false;
			lblStart.Visible = true;
		}

		private void pBoxGame_Paint(object sender, PaintEventArgs e)
		{
			graphics = e.Graphics;

			for (int i = 0; i < snake.Count; i++)
			{
				snake[i].drawCircle(graphics);
			}


			if (timerGame.Enabled)
			{
				food.drawCircle(graphics);
			}
			
		}

		private void checkDirection()
		{
			if (left == true)
			{
				if (snake[0].x > 0)
					snake[0].x--;	
			}

			if (right == true)
			{
				if (snake[0].x <= 500 / 20 - 1)
					snake[0].x++;
			}

			if (down == true)
			{
				if (snake[0].y <= 450 / 20 - 1)
					snake[0].y++;
			}

			if (up == true)
			{
				if (snake[0].y >= 0)
					snake[0].y--;
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void checkIntersection()
		{
			if (snake[0].x == food.x && snake[0].y == food.y)
			{
				Random rnd = new Random();
				int x = rnd.Next(10 / 20 + 2, 500 / 20 - 2), y = rnd.Next(10 / 20 + 2, 450 / 20 - 2);
				food.x = x;
				food.y = y;
				score++;
				lblScore.Text = "Score: " + score.ToString();
				Circle circle = new Circle(snake[snake.Count - 1].x - 1, snake[snake.Count - 1].y, Color.Pink);
				snake.Add(circle);
			}
		}

		private void timerGame_Tick(object sender, EventArgs e)
		{
			
			for (int i = snake.Count - 1; i >= 0; i--)
			{

				if (snake[i].x <= 0 || snake[i].y >= 450 / 20 - 1 || snake[i].y <= 0 || snake[i].x >= 500 / 20 - 1)
				{
					timerGame.Stop();
					MessageBox.Show("You died with a score of " + score.ToString() +"! Press start to try again!");
					snake.Clear();
					btnStart.Enabled = true;
					return;
				}

				if (i == 0)
				{
					checkDirection();

					for (int j = 1; j < snake.Count; j++)
					{
						if (snake[i].x == snake[j].x && snake[i].y == snake[j].y)
						{
							timerGame.Stop();
							MessageBox.Show("You died with a score of " + score.ToString() + "! Press start to try again!");
							snake.Clear();
							btnStart.Enabled = true;
							return;
						}
					}
				}
				else
				{
					snake[i].x = snake[i - 1].x;
					snake[i].y = snake[i - 1].y;
				}
				
			}
			checkIntersection();
			pBoxGame.Invalidate();

		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			lblStart.Visible = false;
			if (e.KeyCode == Keys.A && right == false)
			{ left = true; right = false; up = false; down = false; }

			if (e.KeyCode == Keys.D && left == false)
			{ left = false; right = true; up = false; down = false; }

			if (e.KeyCode == Keys.S && up == false)
			{ left = false; right = false; up = false; down = true; }

			if (e.KeyCode == Keys.W && down == false)
			{ left = false; right = false; up = true; down = false; }

		}
	}
}
