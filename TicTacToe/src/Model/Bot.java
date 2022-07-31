package Model;

import Factories.BotPlayingStrategyFactory.BotPlayingStrategyFactory;
import Strategies.BotPlayingStrategies.IBotPlayingStrategy;

public class Bot extends Player{
    BotDifficultyLevel difficultyLevel;
    IBotPlayingStrategy botPlayingStrategy;

    Bot(Symbol symbol, BotDifficultyLevel botDifficultyLevel) {
        super(PlayerType.BOT, symbol);

        // We need Bot playing strategy
        this.difficultyLevel = botDifficultyLevel;
        this.botPlayingStrategy = new BotPlayingStrategyFactory()
                .CreateBotPlayingStrategyFactoryForDifficultyLevel(botDifficultyLevel);
    }

    @Override
    public Move MakeMove(Board board) {
        return null;
    }
}
