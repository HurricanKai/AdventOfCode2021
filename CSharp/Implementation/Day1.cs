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
    
    public static int Part2(string input)
    {
        return 
            input
                .Split('\n')
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Select(int.Parse)
                .Aggregate((Count: 0, Last: double.PositiveInfinity, List: new List<int>(3)), (state, val) =>
                {
                    if (state.List.Count == state.List.Capacity)
                        state.List.RemoveAt(0);
                    state.List.Add(val);
                    
                    if (state.List.Count < state.List.Capacity)
                        return state;
                    var avg = state.List.Average();
                    return avg > state.Last
                        ? (state.Count + 1, avg, state.List)
                        : (state.Count, avg, state.List);
                }).Count;
    }
}
