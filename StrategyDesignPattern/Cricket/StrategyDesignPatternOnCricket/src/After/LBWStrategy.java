package After;

public class LBWStrategy implements IOutStrategy{
    @Override
    public boolean GetModeOfOut() {
        System.out.println("Batsmen got out via LBW");
        return false;
    }
}
