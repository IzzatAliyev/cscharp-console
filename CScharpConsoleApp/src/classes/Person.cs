namespace CScharpConsoleApp.src.classes
{
  public class Person(string name, int age) // primary constructor right after class
  {
    public Person() : this("Test")
    {
    }

    public Person(string name) : this(name, 20)
    {
      this.name = name;
    }

    public string name = name;
    public int age = age;

    public void Deconstruct(out string name, out int age) // (string name, int age) = person2; ||| (_, int age1) = person1; 
    {
      name = this.name;
      age = this.age;
    }

    public void PrintPerson()
    {
      string name = "Test"; // it will rewrite name
      System.Console.WriteLine($"Person is {name} and age is {age}");
    }
  }
}