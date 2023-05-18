namespace ProjectPatterns;

public class ProductBuilder : IBuilder
{
    private string message = string.Empty;
    public IBuilder AddNumber(int num)
    {
        message += num.ToString();
        return this;
    }

    public IBuilder AddString(string text)
    {
        message += text;
        return this;
    }

    public Product Build()
        => new Product(message);
}
public class BetterProductBuilder : IBuilder
{
    private List<string> strings = new List<string>();
    public IBuilder AddNumber(int num)
    {
        strings.Add(num.ToString());
        return this;
    }

    public IBuilder AddString(string text)
    {
        strings.Add(text);
        return this;
    }

    public Product Build()
    {
        var stringSize = strings.Sum(e => e.Length);
        char[] message = new char[stringSize];

        int i = 0;
        foreach (var item in strings)
        {
            foreach (var c in item)
            {
                message[i] = c;
                i++;
            }
        }

        return new Product(new string(message));
    }
}

