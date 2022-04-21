using System.Collecitons.Generic;

namespace Tetris
{
	public abstract class Block
	{
		protected abstract Position[][] Tiles { get; }
		
		protected abstract Position StartOffset { get; }

		public abstract int Id { get; }

		private int rotationState;
		private Position offset;

	}
}