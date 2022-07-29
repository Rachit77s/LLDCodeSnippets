package Model;

public class NormalWinningStrategy implements IGameWinningStrategy {
    @Override
    public boolean CheckIfWon(Board board, Player player, Cell cell) {
        return false;
    }
}
