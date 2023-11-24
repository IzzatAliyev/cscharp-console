// See https://aka.ms/new-console-template for more information

using LibraryApp;

namespace CScharpConsoleApp;
public class Program
{
  public static void Main(string[] args)
  {
    Class1 class1 = new Class1();
    class1.PrintLibrary();
  }

  public static void TEstParams()
  {
    int[] nums = { 1, 3, 4, 5, 6 };
    Funk.SumWithParams(1, 2, 3, 4, 5);
    // Funk.SumWithParams(1,2,3, nums); // not working 
    Funk.SumWithParams(nums);
  }

  public static void TestRefOutIn()
  {
    // int num = 5;
    // Funk.Increment(num); // 6
    // System.Console.WriteLine(num); // 5

    // Funk.IncrementRef(ref num); // 6
    // System.Console.WriteLine(num); // 6

    int result;
    // Funk.SumOut(5, 10, out result);
    // System.Console.WriteLine(result);
    Funk.SumIn(3, 10, out result);
    System.Console.WriteLine(result);
  }
}
