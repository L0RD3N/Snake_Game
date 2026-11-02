using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	internal class Circle
	{
		public int x { get; set; }
		public int y { get; set; }
		public Color color { get; set; }
		public Circle(int x, int y, Color color)
		{
			this.x = x;
			this.y = y;
			this.color = color;
		}

		public void drawCircle(Graphics g)
		{
			SolidBrush brush = new SolidBrush(color);
			Rectangle rectangle = new Rectangle(x * 20, y * 20, 20, 20);
			g.FillEllipse(brush, rectangle);
		}
	}
}
