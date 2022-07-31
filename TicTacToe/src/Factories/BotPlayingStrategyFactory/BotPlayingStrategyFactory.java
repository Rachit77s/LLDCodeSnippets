package Factories.BotPlayingStrategyFactory;

import Model.BotDifficultyLevel;
import Strategies.BotPlayingStrategies.IBotPlayingStrategy;
import Strategies.BotPlayingStrategies.RandomBotPlayingStrategy;

public class BotPlayingStrategyFactory {

    public IBotPlayingStrategy CreateBotPlayingStrategyFactoryForDifficultyLevel(BotDifficultyLevel difficultyLevel)
    {
        return switch (difficultyLevel)
                {
                    case EASY, MEDIUM, HARD -> new RandomBotPlayingStrategy();
                };
    }
}
