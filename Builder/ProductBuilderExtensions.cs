namespace ProjectPatterns;

public static class ProductBuilderExtensions
{
    public static IBuilder AddMany(this IBuilder builder, string text, int times)
    {
        for (int i = 0; i < times; i++)
            builder.AddString(text);
        return builder;
    }
}