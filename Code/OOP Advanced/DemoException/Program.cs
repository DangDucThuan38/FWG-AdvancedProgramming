using System;
//try
//{
//    System.Console.Write("Enter A:");
//    int a=int.Parse(Console.ReadLine());
//    System.Console.Write("Enter B:");
//    int b=int.Parse(Console.ReadLine());
//    int c= a/b;
//    System.Console.WriteLine("Result: "+c);
//}
//catch (FormatException)
//{
//    System.Console.WriteLine("Invalid Input");
//}
//catch(DivideByZeroException)
//{
//    System.Console.WriteLine("Divide by zero");
//}



try
{
    System.Console.WriteLine("Enter length of array:");
    int n = int.Parse(Console.ReadLine());
    int[] a = new int[n];
    int sum = 0; //Chưa khai báo kiểu
    for (int i = 0; i < n; i++) // Erro IndexOutOfRangException.
    {
        System.Console.WriteLine("Enter a[{0}]: ", i);
        a[i] = int.Parse(Console.ReadLine());
        sum += a[i];
    }
    System.Console.WriteLine("Enter lower: ");
    int lower = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Enter upper: ");
    int upper = int.Parse(Console.ReadLine());
    int partialSum = 0;
    for (int i = lower; i <= upper; i++)// <=upper để lấy số
    {
        partialSum += a[i];

    }
    double rate = partialSum * 1.0 / sum;
    System.Console.WriteLine("Rate: " + rate);
}
catch (FormatException)
{
    System.Console.WriteLine("Input Invaild");
}catch(DivideByZeroException)
{
    System.Console.WriteLine("Divide By Zero");
}catch(IndexOutOfRangeException)
{
    System.Console.WriteLine("Index Out Range");
}