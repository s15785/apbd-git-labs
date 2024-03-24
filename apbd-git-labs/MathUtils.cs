namespace apbd_git_labs;

public class MathUtils
{
    public static double Avg(int [] numbers)
    {
        double sum = numbers.Sum();
        return sum / numbers.Length;
    }
}