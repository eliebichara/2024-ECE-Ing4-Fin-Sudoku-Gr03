using Sudoku.Shared;

namespace Sudoku.DancingLinks;
public class DlxLibSolverrrrrrrrrrrrrr : ISudokuSolver
{
    public SudokuGrid Solve(SudokuGrid s)
    {
        MatrixList dlxList = new MatrixList(s.Cells);
        dlxList.search();
        s.Cells = dlxList.convertMatrixSudoku();
        return s;
    }
}
