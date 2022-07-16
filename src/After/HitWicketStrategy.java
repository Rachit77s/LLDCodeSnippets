package After;

public class HitWicketStrategy implements IOutStrategy{
    @Override
    public boolean GetModeOfOut() {
        System.out.println("Batsmen got out via HitWicket");
        return false;
    }
}
