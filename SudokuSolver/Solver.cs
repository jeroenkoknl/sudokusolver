using System.Collections.Generic;
using System.Linq;

namespace SudokuSolver
{
	public class Solver
	{
		public Sudoku Solve(Sudoku sudoku)
		{
			return this.SolveInternal(sudoku).FirstOrDefault();
		}

		private IEnumerable<Sudoku> SolveInternal(Sudoku sudoku)
		{
			var emptyCell = sudoku.Cells.FirstOrDefault(c => c.IsEmpty);
			if (emptyCell == null)
			{
				return new []{sudoku};
			}
			return emptyCell.PossibleValues.Select(value => sudoku.WithValue(emptyCell.X, emptyCell.Y, value)).SelectMany(this.SolveInternal);
		}
	}
}