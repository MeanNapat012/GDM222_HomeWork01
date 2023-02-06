using System;

class Program
{
    static void Main()
    {
        double XC = double.Parse(Console.ReadLine());
        double YC = double.Parse(Console.ReadLine());
        double XP = double.Parse(Console.ReadLine());
        double YP = double.Parse(Console.ReadLine());
        double Numloop = double.Parse(Console.ReadLine());
        MakeCircle(ref XC, ref YC, ref XP, ref YP,  Numloop);
        Console.WriteLine("{0:F2}", XC);
        Console.WriteLine("{0:F2}", YC);
        Console.WriteLine("{0:F2}", XP);
        Console.WriteLine("{0:F2}", YP);
    }

    static double MakeCircle(ref double XC, ref double YC, ref double XP, ref double YP,  double Numloop)
    {
        int i = 1;
        double XC1 = 0;
        double YC1 = 0;
        double AngleRadius = Math.Atan((YP-YC)/(XP-XC));
        double Distance = Math.Sqrt(Math.Pow(YP-YC,2)+Math.Pow(XP-XC,2));
        do
        {
            XC1 = XC;
            YC1 = YC;
            XC = XC + (Distance/(2*i)) * Math.Cos(AngleRadius + ((Math.PI/2)*i));
            YC = YC + (Distance/(2*i)) * Math.Sin(AngleRadius + ((Math.PI/2)*i));
            XP = XC1 + (Distance/Math.Pow(2,i-1)) * Math.Cos(AngleRadius + ((Math.PI/2)*i));
            YP = YC1 + (Distance/Math.Pow(2,i-1)) * Math.Sin(AngleRadius + ((Math.PI/2)*i));
            i++;
        }while(i <= Numloop);
        return XC;
        return YC;
        return XP;
        return YP;
        
    }
}