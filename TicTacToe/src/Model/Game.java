package Model;

import Exceptions.EmptyMovesUndoOperationException;
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
    private int noOfFilledCells = 0;

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

    public static Builder create() {
        return new Builder();
    }

    public boolean undo() throws EmptyMovesUndoOperationException {
        // If the move size is 0, we can't undo.
        if (this.moves.size() == 0) {
            // Handle Edge Case
            throw new EmptyMovesUndoOperationException();
        }

        // Steps: Clear the last move cell, delete it from the move column,
        // reduce the turn by one, and we are done.
        //  0      1      2     3
        // [Cell1 Cell2 Cell3 Cell4]
        //  0      1      2
        // [Cell1 Cell2 Cell3]

        // Out of the list of last moves, get the last move.
        Move lastMove = this.moves.get(this.moves.size() - 1);
        // Get the cell of that last move.
        Cell relevantCell = lastMove.getCell();
        relevantCell.clearCell();
        // Reduce the move by 1.
        this.lastMovedPlayerIndex -= 1;
        // Subtracting 1 by modular arithmetic
        this.lastMovedPlayerIndex = (this.lastMovedPlayerIndex + this.players.size()) % this.players.size();
        this.moves.remove(lastMove);
        return true;
    }

    public void makeMove() {
        this.lastMovedPlayerIndex += 1;
        this.lastMovedPlayerIndex %= this.players.size();

        Move move = this.players.get(this.lastMovedPlayerIndex)
                .MakeMove(this.board);

        this.moves.add(move);

        move.getCell().setSymbol(move.getSymbol());

        for (IGameWinningStrategy strategy: gameWinningStrategies) {
            if (strategy.CheckIfWon(this.board, this.players.get(lastMovedPlayerIndex), move.getCell())) {
                gameStatus = GameStatus.WON;
                winner = this.players.get(lastMovedPlayerIndex);
                return;
            }
        }

        if (moves.size() == this.board.getDimension() * this.board.getDimension()) {
            gameStatus = GameStatus.DRAW;
            return;
        }
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
