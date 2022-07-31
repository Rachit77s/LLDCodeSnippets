package Strategies.BotPlayingStrategies;

import Model.Board;
import Model.Cell;
import Model.Move;
import Model.Symbol;

public interface IBotPlayingStrategy {
    Move MakeMove(Board board, Symbol symbol);
}
