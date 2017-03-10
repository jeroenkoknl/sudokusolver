using System;
using NUnit.Framework;

namespace SudokuSolver.Tests
{
	[TestFixture]
	public class SolverTest
	{
		[Test]
		public void Solve()
		{
			var sudoku = new Sudoku(new[]
			{
				new[] {0, 0, 0, 0, 5, 0, 0, 0, 8},
				new[] {0, 5, 0, 2, 0, 8, 3, 4, 9},
				new[] {0, 0, 0, 3, 0, 0, 6, 0, 0},
				new[] {0, 3, 6, 0, 0, 0, 0, 0, 0},
				new[] {9, 0, 0, 0, 0, 0, 0, 0, 0},
				new[] {0, 8, 0, 4, 3, 0, 0, 0, 5},
				new[] {0, 9, 0, 0, 6, 4, 0, 2, 0},
				new[] {0, 0, 0, 8, 0, 0, 0, 9, 0},
				new[] {0, 0, 7, 0, 0, 0, 1, 0, 0},
			});
//			var sudoku = new Sudoku(new[]
//			{
//				new[] {5, 0, 9, 1, 0, 7, 0, 0, 4},
//				new[] {1, 6, 0, 8, 3, 4, 5, 0, 9},
//				new[] {0, 3, 0, 5, 0, 9, 1, 0, 7},
//				new[] {0, 0, 1, 9, 0, 0, 3, 4, 0},
//				new[] {9, 0, 6, 3, 4, 8, 0, 5, 0},
//				new[] {0, 0, 8, 2, 5, 1, 9, 7, 0},
//				new[] {6, 9, 5, 0, 1, 2, 0, 8, 0},
//				new[] {7, 1, 0, 0, 8, 3, 6, 9, 5},
//				new[] {0, 0, 3, 0, 9, 0, 7, 1, 2},
//			});
			var solver = new Solver();
			var solution = solver.Solve(sudoku);
			foreach (var row in solution.Values)
			{
				Console.WriteLine(String.Join(" ", row));
			}
		}
	}
}