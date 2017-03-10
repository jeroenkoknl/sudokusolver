using System;
using System.Collections.Generic;
using System.Linq;

namespace SudokuSolver
{
	public class Sudoku
	{
		private readonly int[][] values;

		public Sudoku(IEnumerable<IEnumerable<int>> cells)
			: this(cells.Select(row => row.ToArray()).ToArray())
		{
		}

		public Sudoku(int[][] values)
		{
			this.values = values;
		}

		public IEnumerable<Cell> Cells => this.values.SelectMany((row, x) => row.Select((v, y) => new Cell(this, x, y, v)));
		
		public Sudoku WithValue(int x, int y, int value)
		{
			return new Sudoku(this.values.Select((row, x1) => row.Select((value1, y1) => x == x1 && y == y1 ? value : value1)));
		}

		public IReadOnlyList<IReadOnlyList<int>> Values => this.values;
	}
}