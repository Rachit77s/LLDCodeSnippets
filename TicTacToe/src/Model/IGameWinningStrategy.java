package Model;

public interface IGameWinningStrategy {
    boolean CheckIfWon(Board board, Player player, Cell cell);
}
