namespace aoc2023;

internal static class halp
{
    public static string[] lines(this string text) => text.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
    public static long integer(this string text) => long.Parse(text);
}

