using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameCore
{
    public class Program
    {
        public void Main(string[] args)
        {
			RenderWindow window = new RenderWindow(new SFML.Window.VideoMode(200, 300), "Test");

			while (window.IsOpen)
			{
				RectangleShape shape = new RectangleShape(new SFML.System.Vector2f(20, 20));
				shape.FillColor = Color.Red;
				window.Draw(shape);
			}
        }
    }
}
