using System.Runtime.Intrinsics.Arm;

namespace CScharpConsoleApp.src.Basic
{
  public class Funk
  {
    public static void Test()
    {
      System.Console.WriteLine("select 1-5: ");
      var number = Convert.ToInt32(Console.ReadLine());

      switch (number)
      {
        case 1:
          System.Console.WriteLine(number);
          break;
        case 2:
          System.Console.WriteLine(number);
          break;
        default:
          System.Console.WriteLine("Nix");
          break;
      }
    }

    public static void Test2() => System.Console.WriteLine("Test2");

    public static void Test3(string name, int age) => System.Console.WriteLine($"name is {name}, age is {age}");
    public static void DefaultTest3(string name = "Test", int age = 20, int height = 170) => System.Console.WriteLine($"name is {name}, age is {age}, height is {height}");

    public static void NullVal(string? name, int age) => System.Console.WriteLine("name is {0}, age is {1}, is name null = {2}", name, age, name is null);

    public static int Sum(int num1, int num2) => num1 + num2;

    public static void PrintName(string name)
    {
      System.Console.WriteLine(name);
      return;
      System.Console.WriteLine(name);
    }

    public static void Increment(int num)
    {
      num += 1;
      Console.WriteLine($"{num}");
    }

    public static void IncrementRef(ref int num)
    {
      num += 1;
      Console.WriteLine($"{num}");
    }

    public static void SumOut(int num1, int num2, out int result)
    {
      result = num1 + num2;
    }

    public static void SumOutError(int num1, int num2, out int result)
    {
      int num3 = num1 + num2;
      // result should be used
      result = num1;
    }

    public static void SumIn(in int num1, in int num2, out int result)
    {
      result = num1 + num2; // can either one or two in params use
      // num1 = 10; // cannot be changed
    }

    public static void SumWithParams(params int[] numbers)
    {
      int sum0 = numbers.Sum();
      int sum = 0;
      foreach (var number in numbers)
      {
        sum += number;
      }

      System.Console.WriteLine(sum0);
      System.Console.WriteLine(sum);
    }

    public static void ParamTrue(int num1, params int[] ints) => System.Console.WriteLine("hello");
    // public static void ParamFalse(params int[] ints, int num1) => System.Console.WriteLine("hello"); // error

    public static int Factorial(int num)
    {
      if (num == 1) return num;

      return num * Factorial(num - 1);
    }

    public static void Operation(int operation, params int[] nums)
    {
      int sum = 0;
      switch (operation)
      {
        case 1:
          System.Console.WriteLine(Sum(nums));
          break;
        case 2:
          System.Console.WriteLine(Sum2(nums));
          break;
        default:
          System.Console.WriteLine("Nix");
          break;
      }

      static int SumRES(int[] nums, out int result)
      {
        result = nums.Sum();
        return result;
      }

      static int Sum(int[] nums)
      {
        // sum // cannot use
        return nums.Sum();
      }

      int Sum2(int[] nums)
      {
        sum = nums.Sum();
        return sum;
      }
    }

    public static void TestSwitch()
    {
      System.Console.Write("Write your name and I will generate for you number: ");
      string? name = Console.ReadLine();
      switch (name)
      {
        case "Tom": System.Console.WriteLine("123"); break;
        case "Kiril": System.Console.WriteLine("234"); break;
        case "Izzat": System.Console.WriteLine("321"); break;
        case "Anton": System.Console.WriteLine("421"); break;
        default: System.Console.WriteLine("Nix"); break;
      }
    }

    public static void TestSwitchGotoCase()
    {
      System.Console.Write("Write number: ");
      int num = Convert.ToInt32(Console.ReadLine());
      switch (num)
      {
        case 1: System.Console.WriteLine("123"); goto case 3;
        case 2: System.Console.WriteLine("234"); break;
        case 3: System.Console.WriteLine("321"); break;
        case 4: System.Console.WriteLine("421"); break;
        default: System.Console.WriteLine("Nix"); break;
      }
    }

    public static int SumSwitch(int oper, int num1, int num2)
    {
      switch (oper)
      {
        case 1: return num1 + num2;
        case 2: return num1 * num2;
        case 3: return num1 & num2;
        case 4: return num1 ^ num2;
        default: return num1 - num2;
      }
    }

    public static int SumSwitch2(int oper, int num1, int num2)
    {
      return oper switch
      {
        1 => num1 + num2,
        2 => num1 * num2,
        3 => num1 & num2,
        4 => num1 ^ num2,
        _ => 0,
      };
    }

    public static int SumSwitch3(int oper, int num1, int num2) => oper switch
    {
      1 => num1 + num2,
      2 => num1 * num2,
      3 => num1 & num2,
      4 => num1 ^ num2,
      _ => 0,
    };
  
    public static void SwitchEnum(Month month)
    {
      int num = (int)month;
      switch (month){
        case Month.Jan: Console.WriteLine("Jan is {0}", num); break;
        case Month.Feb: Console.WriteLine("Feb is {0}", num); break;
        case Month.Mar: Console.WriteLine("Mar is {0}", num); break;
        case Month.Apr: Console.WriteLine("Apr is {0}", num); break;
        default: System.Console.WriteLine("Nix is {0}", num); break;
      }
    }
  }
}