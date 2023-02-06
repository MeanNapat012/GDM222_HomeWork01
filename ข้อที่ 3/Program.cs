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
        if(i <= 0 && i > -1)
        {
            answer = Math.Sqrt(1 - Math.Pow(i,2));
            return answer;
        }

        else if(i <= 1 && i > 0)
        {
            answer = -Math.Sqrt(1 - Math.Pow(i,2));
            return answer;
        }
        else if(i <= -1)
        {
            answer = funtion(i+2);
            return answer;
        }
        else
        {
            answer = funtion(i-2);
            return answer;
        }
    }
}