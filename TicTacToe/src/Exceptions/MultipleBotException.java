package Exceptions;

public class MultipleBotException extends Throwable {
    public MultipleBotException() {
        super("A game cannot have more than one bot.");
    }
}
