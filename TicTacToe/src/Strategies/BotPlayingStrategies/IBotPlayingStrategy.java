package Strategies.BotPlayingStrategies;

import Model.*;

public interface IBotPlayingStrategy {
    Move MakeNextMove(Board board, Player player);
}
