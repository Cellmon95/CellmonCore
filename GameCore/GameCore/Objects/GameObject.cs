﻿using GameCore.Interfaces;
using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;

namespace GameCore.Objects
{
	public abstract class GameObject : IUpdatable, Drawable, IDisposable
	{
		private Vector2f position;

		public FloatRect Bounds { get; protected set; }

		public Vector2f Position
		{
			get
			{
				return position;
			}

			set
			{
				//Om vi upptäcket att det börjar bli lagg. Ändra till något bättre.
				position = value;
				Vector2f tmpWidthHeight = new Vector2f(Bounds.Width, Bounds.Height);
				Bounds = new FloatRect(value.X, value.Y, tmpWidthHeight.X, tmpWidthHeight.Y);
			}
		}
		
		public List<string> Tags { get; protected set; }

		public bool Destroyed { get; set; }

		public void Move(Vector2f offset) => Position += offset;

		public void Move(float offsetX, float offsetY) => Position += new Vector2f(offsetX, offsetY);

		public virtual void OnCollision(GameObject target) { }

		public abstract void Draw(RenderTarget target, RenderStates states);

		public abstract void Update();

		public abstract void Dispose();
	}
}