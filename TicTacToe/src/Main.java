import Controllers.GameController;
import Model.*;
import Strategies.GameWinningStrategies.IGameWinningStrategy;
import Strategies.GameWinningStrategies.OrderOneGameWinningStrategy;

import java.util.List;

public class Main {
    public static void main(String[] args) {
        int dimension = 3;
        Player p1 = new HumanPlayer(new Symbol('X'));
        Player p2 = new Bot(new Symbol('O'), BotDifficultyLevel.EASY);
        IGameWinningStrategy strategy = new OrderOneGameWinningStrategy();
        GameController gameController = new GameController();

        Game game = gameController.createGame(dimension, List.of(p1, p2), List.of(strategy));

        while (gameController.getGameStatus(game).equals(GameStatus.INPROGRESS)) {
            System.out.println("Please Make the Next Move. This is current Status");
            gameController.display(game);
            gameController.makeMove(game);
        }

        if (gameController.getGameStatus(game).equals(GameStatus.WON)) {
            System.out.println("WINNER WINNER CHICKEN DINNER");
            gameController.display(game);
        }

        if (gameController.getGameStatus(game).equals(GameStatus.DRAW)) {
            System.out.println("UH OH. Try Again. No one won");
            gameController.display(game);
        }
    }
}