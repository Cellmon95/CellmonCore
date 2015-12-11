using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;
using GameCore.Core;
using SFML.Window;

namespace GameCore.States
{
	public class TestGameObject : GameObject
	{
		private Vector2f position = new Vector2f(0, 0);
		private RectangleShape graphics = new RectangleShape(new Vector2f(32, 32));

		public new Vector2f Position
		{
			get
			{
				return position;
			}
			set
			{
				position = value;
				graphics.Position = position;
			}
		}

		public TestGameObject()
		{
			Bounds = new FloatRect(Position.X, Position.Y, 32, 32);
		}

		public override void Draw(RenderTarget target, RenderStates states)
		{
			target.Draw(graphics);
		}

		public override void OnCollision(GameObject target)
		{
			target.Destroyed = true;
		}

		public override void Update()
		{
			if (Input.Key((int)Keyboard.Key.Right))
			{
				Move(100 * Game.TimeBetweenFrames.AsSeconds(), 0);
			}
		}

		public override void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}
