namespace aoc2023;

internal class d6
{
    internal static long solve()
    {
        // part 1
        //var foo = input.lines().Select(x => x.Split(' ', StringSplitOptions.RemoveEmptyEntries).Skip(1).Select(x => x.Trim().integer()));
        //var records = foo.Take(1).SelectMany(x => x).Zip(foo.Skip(1).SelectMany(y => y)).ToArray();

        // part 2
        var bar = input.lines()
            .Select(x => string.Join("", x.Split(' ', StringSplitOptions.RemoveEmptyEntries).Skip(1).Select(x => x.Trim().integer())))
            .ToArray();

        var records = new[] {
            (bar[0].integer(), bar[1].integer()),
        };

        var wins = new List<long>();

        foreach (var (time, distance) in records)
        {
            long w = 0;
            for (long i = 0; i < time; i++)
            {
                var d = i * (time - i);
                if (d > distance)
                {
                    w++;
                }
            }
            wins.Add(w);
        }


        return wins.Aggregate(1L, (agg, x) => agg * x);
    }

    private static readonly string test = @"Time:      7  15   30
Distance:  9  40  200";

    private static readonly string input = @"Time:        48     87     69     81
Distance:   255   1288   1117   1623";
}
