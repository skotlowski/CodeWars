public class Kata
{
    public static bool is_divide_by(int number, int a, int b)
    {
        double modA = number % a;
        double modB = number % b;
        
        if (( modA == 0 ) && (modB == 0))
        return true;
        else 
        return false;
    }
}