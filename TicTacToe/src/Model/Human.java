package Model;

public class Human extends Player{

    Human(PlayerType type, Symbol symbol) {
        super(type.HUMAN, symbol);
    }

    @Override
    public Move MakeMove(Board board) {
        return null;
    }
}
