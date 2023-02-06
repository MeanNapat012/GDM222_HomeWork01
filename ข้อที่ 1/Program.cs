using System;

class Program
{
    static void Main()
    {
        Console.Write("Please Input for funtion : ");
        double i = double.Parse(Console.ReadLine());
        Console.WriteLine(funtion(i));
    }

    static double funtion(double i)
    {
        double answer = 0;
        if(i*i > 4)
        {
            answer = 1 + funtion(i - ((4 * Math.Abs(i)) / i));
            return answer;
        }
        else
        {
            answer = 2;
            return answer;
        }
    }
}