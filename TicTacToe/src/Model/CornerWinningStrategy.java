package Model;

import Strategies.GameWinningStrategies.IGameWinningStrategy;

public class CornerWinningStrategy implements IGameWinningStrategy {
    @Override
    public boolean CheckIfWon(Board board, Player player, Cell cell) {
        return false;
    }
}
