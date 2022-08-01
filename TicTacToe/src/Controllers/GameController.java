package Controllers;

import Exceptions.EmptyMovesUndoOperationException;
import Exceptions.MultipleBotException;
import Model.*;
import Strategies.GameWinningStrategies.IGameWinningStrategy;

import java.util.List;

public class GameController {

    public Game createGame(int dimensionOfBoard, List<Player> players,
                           List<IGameWinningStrategy> strategies)
    {
        Game game = null;
        try
        {
            game = Game.create()
                    .setDimension(dimensionOfBoard)
                    .AddPlayers(players)
                    .addGameWinningStrategies(strategies)
                    .Build();
        } catch (Exception | MultipleBotException exception) {
            System.out.println("We did something wrong");
            exception.printStackTrace();
        }

        return game;
    }

    public void makeMove(Game game) {
        game.makeMove();
    }

    public boolean undo(Game game) throws EmptyMovesUndoOperationException {
        return game.undo();
    }

    public Player getWinner(Game game) {
        return game.getWinner();
    }

    public GameStatus getGameStatus(Game game) {
        return game.getGameStatus();
    }

    public void display(Game game) {
        game.getBoard().printBoard();
    }
}
