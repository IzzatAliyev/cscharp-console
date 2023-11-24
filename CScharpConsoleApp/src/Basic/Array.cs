namespace CScharpConsoleApp.src.Basic
{
  public class Array
  {
    public static void Test()
    {
      int[] nums2 = new int[4] { 1, 2, 3, 5 };

      int[] nums3 = new int[] { 1, 2, 3, 5 };

      int[] nums4 = new[] { 1, 2, 3, 5 };

      int[] nums5 = { 1, 2, 3, 5 };

      int[] nums6 = [1, 2, 3, 5];

      System.Console.WriteLine(nums6[2]);
      nums6[2] = 10;
      foreach (var item in nums6)
      {
        System.Console.WriteLine(item);
      }

      System.Console.WriteLine(nums6.Length);
      var nums7 = nums6.Append(4);
      System.Console.WriteLine(nums7.Count());
    }

    public static void Indexx()
    {
      int[] nums = [1, 2, 3, 5];
      System.Console.WriteLine(nums[0]); // first elem
      System.Console.WriteLine(nums[^1]); // last elem
    }

    public static void Array2d()
    {
      int[] nums = [1, 2, 3, 4, 5, 6, 7, 8];

      int[,] nums2 = new int[2, 3];
      int[,] nums3 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
      int[,] nums4 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
      int[,] nums5 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
      int[,] nums6 = { { 0, 1, 2 }, { 3, 4, 5 } };

      System.Console.WriteLine(nums2.Length); // 6
      System.Console.WriteLine(nums6.Length); // 6
      System.Console.WriteLine(nums6.GetUpperBound(0));
      System.Console.WriteLine(nums6.GetLowerBound(0));


      int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };

      int rows = numbers.GetUpperBound(0) + 1;    // количество строк
      // int columns = numbers.Length / rows;        // количество столбцо
      int columns = numbers.GetUpperBound(1) + 1;

      for (int i = 0; i < rows; i++)
      {
        for (int j = 0; j < columns; j++)
        {
          Console.Write($"{numbers[i, j]} \t");
        }
        Console.WriteLine();
      }
    }

    public static void Array2()
    {
      int[][] arra = new int[4][];
      int[][] array = [[1,2,3], [4,5,6,7], [8,9,10,11,12]];
      System.Console.WriteLine(arra.Length); // 4
      System.Console.WriteLine(array.Length); // 3
    }

    public static void ArrayMethod()
    {
      int[] ints = [1,2,3,4,56,8];
      int[] ints2 = ints[1..6];
      foreach (var item in ints2)
      {
        System.Console.Write(item + "\t");
      }
      System.Array.Sort(ints);
      System.Console.WriteLine(ints.Min());
      System.Console.WriteLine(ints.GetLength(0));
    }
  }
}