package Strategies.GameWinningStrategies;

import Model.Board;
import Model.Cell;
import Model.Player;

public interface IGameWinningStrategy {
    boolean CheckIfWon(Board board, Player player, Cell cell);
}
