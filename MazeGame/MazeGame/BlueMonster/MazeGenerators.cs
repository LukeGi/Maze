using System;
using System.Collections.Generic;
using BlueMonster.Utilities;
using System.Windows.Forms;

namespace BlueMonster
{
	static class MazeGenerators
	{
		/// <summary>
		/// Uses the Recursive-Backtrack method for generatoring a maze.
		/// </summary>
		/// <param name="Data">The data that will be used to generate the maze.</param>
		/// <returns>A byte[] that holds the maze.</returns>
		public static byte[] GenerateMazeRecursiveBacktracker(ref MazeData Data)
		{
			// Initialize the byte array for the maze.
			byte[] Maze = new byte[Data.Height * Data.Width];
			for (int i = 0; i < Maze.Length; i++)
				Maze[i] = 15;

			// Initialize the variables needed for creating the maze.
			Random Rand = new Random(Data.Seed);
			Stack<int> CellsToCheck = new Stack<int>();
			int Visited = 0;
			int CurrentIndex = Data.StartPosition;

			// Create the maze.
			while (Visited < Maze.Length)
			{
				// Has the current cell been visited?
				if ((Maze[CurrentIndex] & 128) == 0)
				{
					Maze[CurrentIndex] += 128; // Mark this cell as visited.
					Visited++; // Increment the visited counter.
				}

				// Create and populate the neighbours array.
				int[] Neighbours = {
					CurrentIndex < Data.Width ? -1 : MazeGeneratorHelper.GetIndexForDir(CurrentIndex, Data.Width, MazeDirection.North),
					CurrentIndex % Data.Width == Data.Width - 1 ? -1 : MazeGeneratorHelper.GetIndexForDir(CurrentIndex, Data.Width, MazeDirection.East),
					CurrentIndex >= Maze.Length - Data.Width ? -1 : MazeGeneratorHelper.GetIndexForDir(CurrentIndex, Data.Width, MazeDirection.South),
					CurrentIndex % Data.Width == 0 ? -1 : MazeGeneratorHelper.GetIndexForDir(CurrentIndex, Data.Width, MazeDirection.West)
				};

				// Check for visited neighbours and remove them from the array.
				for (int i = 0; i < Neighbours.Length; i++)
				{
					if (Neighbours[i] != -1 && (Maze[Neighbours[i]] & 128) == 128)
						Neighbours[i] = -1;
				}
				Neighbours = Array.FindAll(Neighbours, i => (i >= 0 && i < Maze.Length));

				// If has neighbours, choose one.
				if (Neighbours.Length > 0)
				{
					int NeighbourIndex = Neighbours[Rand.Next(Neighbours.Length)];

					// Add the current cell to the stack.
					CellsToCheck.Push(CurrentIndex);

					// Now lets remove the walls between these two cells.
					Maze[CurrentIndex] = MazeGeneratorHelper.RemoveWall(Maze[CurrentIndex], MazeGeneratorHelper.GetDirFromNeighbours(CurrentIndex, NeighbourIndex, Data.Width));
					Maze[NeighbourIndex] = MazeGeneratorHelper.RemoveWall(Maze[NeighbourIndex], MazeGeneratorHelper.GetDirFromNeighbours(NeighbourIndex, CurrentIndex, Data.Width));

					// Make the neighbour become the current.
					CurrentIndex = NeighbourIndex;
				}
				else if (CellsToCheck.Count != 0) // If the Stack is not empty.
					CurrentIndex = CellsToCheck.Pop(); // Pop a value from the stack and check it.
				else break;
			}
			for (int i = 0; i < Maze.Length; i++)
				Maze[i] -= 128;

			CellsToCheck = null;
			Rand = null;
			return Maze;
		}
	}
}
