public class ParameterDemo
{
    public void Increase(ref int number)
    {
        number += 10;
    }
    public void DisplayMessage(out string fullname)
    {
        fullname = "Tina Sitaula";
    }

    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}