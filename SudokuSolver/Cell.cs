using System.Collections.Generic;
using System.Linq;

namespace SudokuSolver
{
	public class Cell
	{
		private static readonly int[] AllValues = {1, 2, 3, 4, 5, 6, 7, 8, 9};

		private readonly Sudoku sudoku;
		private readonly int value;

		public Cell(Sudoku sudoku, int x, int y, int value)
		{
			this.sudoku = sudoku;
			this.X = x;
			this.Y = y;
			this.value = value;
		}

		public bool IsEmpty => this.value == 0;

		public IEnumerable<int> PossibleValues => AllValues.Except(this.Row).Except(this.Column).Except(this.Block);

		public int X { get; }

		public int Y { get; }

		public IEnumerable<int> Row => this.sudoku.Values[this.X];

		public IEnumerable<int> Column => this.sudoku.Values.Select(r => r[this.Y]);

		public IEnumerable<int> Block => this.sudoku.Values.Skip(this.X / 3 * 3).Take(3).SelectMany(row => row.Skip(this.Y / 3 * 3).Take(3));
	}
}