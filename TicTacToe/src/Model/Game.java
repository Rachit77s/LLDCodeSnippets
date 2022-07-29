package Model;

import java.util.List;

public class Game {
    private Board board;
    private List<Player> players;
    private IGameWinningStrategy winningStrategy;
    int lastPlayerMovedIndex;
    // Get the latest move from the list of moves and undo it.
    List<Move> moves;
    GameStatus gameStatus;
    // Show who the winner is
    Player winner;
}
