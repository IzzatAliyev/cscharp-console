using System.ComponentModel;
// Izzat Aliyev

namespace CScharpConsoleApp.src.Basic
{
  /* The above code defines a basic class in C#. */
  public class Basic
  {

    public static void ConsoleReadAndWrite()
    {
      /* The code `var name = Console.ReadLine();` is reading input from the console and storing it in
      a variable called `name`. */
      var name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}");
    }
    public static void Statement()
    {
      /* The code `System.Console.WriteLine("Helli");` is printing the string "Helli" to the console. */
      System.Console.WriteLine("Helli");
      {
        System.Console.WriteLine("1");
        System.Console.WriteLine("2");
      }
    }

    public static void BinDezHex()
    {
      int bin10 = 0b1010;
      int hex10 = 0xA;
      System.Console.WriteLine(bin10);
      System.Console.WriteLine(hex10);
    }

    public static void Numbers()
    {
      double num = 3.2e3;
      System.Console.WriteLine(num); // 3200
    }

    public static void Chars()
    {
      char sym = 'S';
      System.Console.WriteLine(sym);
    }

    public static void StringWithThings()
    {
      string text = "Hello \nHello2 \tHello3 \\";
      System.Console.WriteLine(text);
    }

    public static void AsciiAndUnicode()
    {
      char ascii = '\x65';
      char unicode = '\u0065';
      System.Console.WriteLine(ascii); // e
      System.Console.WriteLine(unicode); // e
    }

    public static void Decim()
    {
      decimal ex = 10 / 3;
      System.Console.WriteLine(ex);
    }

    public static void Consoles()
    {
      string name = "Izzat";
      System.Console.WriteLine("I'm {0}, age = {2}, height = {1}", name, 160, 18);
      System.Console.WriteLine($"I'm {name}");
    }

    public static void Converts()
    {
      int num1 = Convert.ToInt32(Console.ReadLine());
      int num2 = Convert.ToInt32(true);
      System.Console.WriteLine(num1);
      System.Console.WriteLine(num2);
    }

    public static void IncrementAndDecrement()
    {
      int num = 5;
      num++;
      System.Console.WriteLine(num);
      ++num;
      System.Console.WriteLine(num);
    }

    public static void AndOr()
    {
      int num1 = 5; // 0101
      int num2 = 7; // 0111
      System.Console.WriteLine(num1 & num2); // 5 and
      System.Console.WriteLine(num1 | num2); // 7 or
      System.Console.WriteLine(num1 ^ num2); // 2 xor mostly use for encrypt and decrypt
      System.Console.WriteLine(~num2); // -8 
    }

    public static void BinMove()
    {
      int num1 = 5;
      int num2 = num1 >> 1;
      System.Console.WriteLine(num2); // 2
      num2 <<= 2;
      System.Console.WriteLine(num2); // 8
    }

    public static void ManyTimeInitial()
    {
      int a, b, c, d;
      a = b = c = d = 5;
      System.Console.WriteLine(a + b + c + d); // 20
    }

    public static void NumbType()
    {
      byte num1 = 5;
      byte num2 = (byte)(num1 + 20);
      int x = num1 + Convert.ToInt32("42");
      System.Console.WriteLine(x);
      System.Console.WriteLine(num2);
    }

    public static void Implicit()
    {
      byte x = 5;
      short y = x;
      int z = y;
      long w = z;
      decimal h = w;
      System.Console.WriteLine(h);
    }

    public static void Emplicit()
    {
      float x = 3.2f;
      double y = x;
      System.Console.WriteLine(y);
    }

    public static void LostBytes()
    {
      int a = 5;
      int b = 500;
      byte c = (byte)(a + b);
      System.Console.WriteLine(c); // 249
    }

    public static void WithoutLostBytes()
    {
      try
      {
        int a = 5;
        int b = 500;
        byte c = checked((byte)(a + b)); // when number more then can be will be a throwed an exception
        System.Console.WriteLine(c);
      }
      catch (Exception e)
      {
        System.Console.WriteLine(e.Message);
      }
    }

    public static void CheckDiff()
    {
      int x = 5;
      int b = 3;
      bool check1 = x >= b && x==b;  // if first ist false then second will not execute
      bool check2 = x >= b & x==b;  // both will execute
    }

    public static void Loop()
    {
      for(int i = 1; i<4; i++)
      {
        System.Console.WriteLine(i);
      }

      int j = 0;

      for(System.Console.WriteLine("Hello"); j<4; System.Console.WriteLine("num = {0}", j))
      {
        j++;
      }

      for(int k = 1, d = 1; k<4; k++, d++) System.Console.WriteLine(k+d);

      for(;;) // infinity
      {
        System.Console.WriteLine("Hello");
      }
    }
  }
}