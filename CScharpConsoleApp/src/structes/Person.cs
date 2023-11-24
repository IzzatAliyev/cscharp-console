namespace CScharpConsoleApp.src.structes
{
  public struct Person(string name, int age) // no need to create obj with calling constructor
  {
    public string name = name;
    public int age = age;

    public void PrintPerson()
    {
      System.Console.WriteLine($"name is {name}, age is {age}");
    }

    // Person two = one with { name = "Anton" }; copy values
  }
}