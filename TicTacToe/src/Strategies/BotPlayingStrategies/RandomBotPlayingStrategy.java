package Strategies.BotPlayingStrategies;

import Model.*;

import java.util.List;

public class RandomBotPlayingStrategy implements IBotPlayingStrategy{
    @Override
    public Move MakeNextMove(Board board, Player player) {

        // Whenever we find an empty cell, let's put a symbol there.
        // Go through the grid row by row, once we find a cell that is empty,
        // we will go and make a move on that cell.
        for(List<Cell> row : board.getBoard())
        {
            for (Cell cell: row) {
                if (cell.isEmpty()){
                    // If cell is empty, we will make a move
                    Move move = new Move();
                    move.setSymbol(player.getSymbol());
                    move.setCell(cell);
                    return move;
                }
            }
        }
        return null;
    }
}
