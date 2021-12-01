namespace Implementation;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Day1.Part1(File.ReadAllText("../../inputs/day1part1.input")));
        Console.WriteLine(Day1.Part2(File.ReadAllText("../../inputs/day1part2.input")));
    }
}
