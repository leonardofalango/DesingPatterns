namespace ProjectPatterns;

public class Singleton
{
    private Singleton() { }

    private Singleton(string text)
        => this.SomeProperty = text;
    
    private static Singleton crr = new Singleton();

    public static Singleton Current => crr; // get without set

    public string? SomeProperty { get; set; }
    public string? OtherProperty { get; set; }

    public void SomeMethod()
        => System.Console.WriteLine($"{SomeProperty} and {OtherProperty}");
    
    public static void New()
        => crr = new Singleton();
    
    public static void New(string text)
        => crr = new Singleton(text);
}