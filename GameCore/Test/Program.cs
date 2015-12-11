using GameCore.Core;
using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	class Program
	{
		static void Main(string[] args)
		{
			RenderWindow window = new RenderWindow(new SFML.Window.VideoMode(800, 600), "Test");

			Game game = new Game(window);
			game.Start();
		}
	}
}
