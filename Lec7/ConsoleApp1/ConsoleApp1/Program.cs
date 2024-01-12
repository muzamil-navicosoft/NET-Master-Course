using System;

class MainClass
{

    public static int FirstFactorial(int num)
    {
        int temp = 1;
        for (int i = 1; i <= num; i++)
        {
            temp *= i;
        }
        num = temp;
        // code goes here  
        return num;

    }

    static void Main()
    {

    //    int FirstFactorial;
    //  // keep this function call here
    //Console.WriteLine(FirstFactorial(Console.ReadLine()));
        var num = int.Parse(Console.ReadLine());
        Console.WriteLine(FirstFactorial(num));
        Console.ReadKey();
       


    }

}