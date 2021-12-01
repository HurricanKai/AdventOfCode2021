namespace Implementation;

public static class Day1
{
    public static int Part1(string input)
    {
        return 
            input
                .Split('\n')
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Select(int.Parse)
                .Aggregate((0, int.MaxValue),
                    (state, val) => 
                        val > state.MaxValue 
                            ? (state.Item1 + 1, val)
                            : (state.Item1, val))
                .Item1;
    }
}
