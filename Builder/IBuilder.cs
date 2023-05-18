namespace ProjectPatterns;

public interface IBuilder
{
    IBuilder AddNumber(int num);
    IBuilder AddString(string text);
    Product Build();
}