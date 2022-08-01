package Strategies.GameWinningStrategies;

import Model.Board;
import Model.Cell;
import Model.Player;

public class NormalGameWinningStrategy implements IGameWinningStrategy{
    @Override
    public boolean CheckIfWon(Board board, Player player, Cell moveCell) {

        int row = moveCell.getRow();
        int col = moveCell.getColumn();

        //Check for row
        for (int r = 0; r < row; r++)
        {
            // Get the symbol and compare it with others.
            Cell rowSymbol = board.getCell(r,0);

            for(int c = 0; c < col; c++)
            {
                // Means symbols in the cells are not equal
                if (board.getCell(r, c) != rowSymbol)
                    return false;
            }
        }

        // Check for col

        // Check for 2 diagonal
        return true;
    }
}
