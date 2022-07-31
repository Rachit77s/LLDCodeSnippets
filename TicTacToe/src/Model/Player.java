package Model;

public abstract class Player {
    String Name;
    Symbol symbol;
    PlayerType playerType;

    Player(PlayerType type, Symbol symbol) {
        this.playerType = type;
        this.symbol = symbol;
    }

    public Symbol getSymbol() {
        return symbol;
    }

    public PlayerType getPlayerType() {
        return playerType;
    }

    public abstract Move MakeMove(Board board);
}
