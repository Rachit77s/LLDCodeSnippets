package Model;

import Strategies.GameWinningStrategies.IGameWinningStrategy;

public class NormalWinningStrategy implements IGameWinningStrategy {
    @Override
    public boolean CheckIfWon(Board board, Player player, Cell cell) {
        return false;
    }
}
