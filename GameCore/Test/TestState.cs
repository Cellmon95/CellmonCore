using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using GameCore.Core;
using GameCore.Handlers;
using GameCore.States;

namespace Test
{
	public class TestState : GameState
	{
		private GameObjectPool<TestGameObject> testPool = new GameObjectPool<TestGameObject>(() => new TestGameObject(), 100);
		private TestGameObject testGameObject = new TestGameObject();

		public TestState(Game game) : base(game)
		{

		}

		public override void Update()
		{
			testGameObject.Update();
		}

		public override void Dispose()
		{
			throw new NotImplementedException();
		}

		public override void Draw(RenderTarget target, RenderStates states)
		{
			target.Draw(testGameObject);
		}
	}
}
