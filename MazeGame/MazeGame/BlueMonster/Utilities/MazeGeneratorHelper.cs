namespace BlueMonster.Utilities
{
	internal static class MazeGeneratorHelper
	{
		#region --- Remove Wall ---
		/// <summary>
		/// Removes the wall in the given direction from the given cell.
		/// Example Usage:
		/// <code>Maze[Index] = RemoveWall(Maze[Index], ref Direction.Up);</code>
		/// </summary>
		/// <param name="Cell">The Cell from which the wall will be removed.</param>
		/// <param name="dir">The Direction of the wall that will be removed.</param>
		/// <returns>The byte value of the cell after the wall has been removed.</returns>
		public static byte RemoveWall(byte Cell, MazeDirection dir)
		{
			if (HasWall(Cell, dir))
				return Cell -= (byte)dir;
			else
				return Cell;
		}
		#endregion

		#region --- Has Wall ---
		/// <summary>
		/// Checks to see if the cell provided has a cell in the direction provided.
		/// </summary>
		/// <param name="cell"></param>
		/// <param name="dir"></param>
		/// <returns></returns>
		public static bool HasWall(byte cell, MazeDirection dir)
		{
			return (cell & (int)dir) == (int)dir;
		}
		#endregion

		#region --- Get Neightbour ---

		/// <summary>
		/// Gets you an index for a neighbour in the given direction from the given cell.
		/// </summary>
		/// <param name="CurrentCell">The cell that you want to get the Neighbour of.</param>
		/// <param name="MazeWidth">The width of the maze</param>
		/// <param name="Dir">The direction of the neighbour you want.</param>
		/// <returns>The index of the neighbour.</returns>
		public static int GetIndexForDir(int CurrentCell, int MazeWidth, MazeDirection Dir)
		{
			switch (Dir)
			{
				case MazeDirection.North:
					CurrentCell -= MazeWidth;
					break;
				case MazeDirection.East:
					CurrentCell += 1;
					break;
				case MazeDirection.South:
					CurrentCell += MazeWidth;
					break;
				case MazeDirection.West:
					CurrentCell -= 1;
					break;
				default:
					return CurrentCell;
			}
			return CurrentCell;
		}

		#endregion

		#region --- Get Direction from Neighbours ---

		/// <summary>
		/// This will find the direction from Cell 1 to Cell 2.
		/// </summary>
		/// <param name="Cell1Index">The cell index of the cell that you want to start in.</param>
		/// <param name="Cell2Index">The cell index of the cell you want to get the direction to.</param>
		/// <param name="MazeWidth">The width of the maze.</param>
		/// <returns>The direction from cell 1 to cell 2.</returns>
		public static MazeDirection GetDirFromNeighbours(int Cell1Index, int Cell2Index, int MazeWidth)
		{
			int x = Cell2Index - Cell1Index;
			switch (x)
			{
				case 1: return MazeDirection.East;
				case -1: return MazeDirection.West;
				default:
					if (x == -MazeWidth) return MazeDirection.North;
					else if (x == MazeWidth) return MazeDirection.South;
					else return MazeDirection.None;
			}
		}

		#endregion
	}
}
