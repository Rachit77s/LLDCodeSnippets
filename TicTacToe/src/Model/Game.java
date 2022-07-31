package Model;

import Exceptions.MultipleBotException;
import Strategies.GameWinningStrategies.IGameWinningStrategy;

import java.util.ArrayList;
import java.util.List;

public class Game {
    private Board board;
    private List<Player> players;
    private List<IGameWinningStrategy> gameWinningStrategies;
    int lastMovedPlayerIndex;
    // Get the latest move from the list of moves and undo it.
    List<Move> moves;
    GameStatus gameStatus;
    // Show who the winner is
    Player winner;

    public List<Player> getPlayers() {
        return players;
    }

    public Board getBoard() {
        return board;
    }

    public List<Move> getMoves() {
        return moves;
    }

    public List<IGameWinningStrategy> getGameWinningStrategies() {
        return gameWinningStrategies;
    }

    public int getLastMovedPlayerIndex() {
        return lastMovedPlayerIndex;
    }

    public GameStatus getGameStatus() {
        return gameStatus;
    }
    public Player getWinner() {
        return winner;
    }
    private Game() {
        this.players = new ArrayList<>();
        this.moves = new ArrayList<>();
        this.gameWinningStrategies = new ArrayList<>();
        this.lastMovedPlayerIndex = -1;
        this.gameStatus = GameStatus.INPROGRESS;
    }

    public void makeMove(){

    }

    public static class Builder
    {
        int dimension;
        private List<Player> players;
        private List<IGameWinningStrategy> gameWinningStrategies;

        public Builder()
        {
            this.players = new ArrayList<>();
            //this.winningStrategy = new ArrayList<Object>();
        }

        // Game.Builder.setPlayers({})
        // Game game = Game.Builder.addPlayer(new HumanPlayer())
        //                         .addPlayer(new Bot())
        //                         .build();

        public Builder AddPlayer(Player player){
            this.players.add(player);
            return this;
        }

        public Builder AddPlayers(List<Player> players){
            this.players.addAll(players);
            return this;
        }

        public Builder setDimension(int dimension) {
            this.dimension = dimension;
            return this;
        }


        public Builder addGameWinningStrategy(IGameWinningStrategy strategy) {
            this.gameWinningStrategies.add(strategy);
            return this;
        }

        public Builder addGameWinningStrategies(List<IGameWinningStrategy> strategies) {
            this.gameWinningStrategies.addAll(strategies);
            return this;
        }

        public Game Build() throws MultipleBotException {
            if (!CheckIfSingleBotExists()){
                throw new MultipleBotException();
            }

            Game game = new Game();
            game.players.addAll(this.players);
            game.gameWinningStrategies.addAll(this.gameWinningStrategies);
            game.board = new Board(dimension);

            return game;

            //if (players.size() < 2) {
//                //
//            }
//
//            if (gameWinningStrategies.size() < 1) {
//                //
//            }
//
//            if (dimension < 3) {
//
//            }
        }

        public boolean CheckIfSingleBotExists(){
            int count = 0;

            for (Player player: players) {
                if (player.getPlayerType().equals(PlayerType.BOT)){
                    count = count + 1;
                }
            }

            if(count <= 1)
                return true;

            return false;
        }
    }
}
