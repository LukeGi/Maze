namespace BlueMonster.Utilities
{
	/// <summary>
	/// Enum used for generating the maze, and movement logic.
	/// </summary>
	enum MazeDirection
	{
		None = 0,
		North = 1,
		Up = 1,
		East = 2,
		Right = 2,
		Side = 2,
		South = 4,
		Down = 4,
		West = 8,
		Left = 8,
		OtherSide = 8
		//, BOMB = 16... etc
	}
}
