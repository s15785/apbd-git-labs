namespace apbd_git_labs;

public class MathUtils
{
    public static double Avg(int [] numbers)
    {
        double sumI = numbers.Sum();
        return sumI / numbers.Length;
    }
    
    public static int Max(int [] numbers)
    {
        return numbers.Max();
    }

}