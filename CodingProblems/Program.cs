namespace CodingProblems;

class Program
{
    static void Main(string[] args)
    {
        int[] result = TwoSum.NestedLoops(new int[] {2, 7, 11, 15 }, 9);
        Console.WriteLine("The indexes are {0} and {1}", result[0], result[1]);

        result = TwoSum.NestedLoops(new int[] {3, 2, 4}, 6);
        Console.WriteLine("The indexes are {0} and {1}", result[0], result[1]);

        result = TwoSum.NestedLoops(new int[] {3, 3}, 6);
        Console.WriteLine("The indexes are {0} and {1}", result[0], result[1]);

        result = TwoSum.Dictionary(new int[] { 2, 7, 11, 15 }, 9);
        Console.WriteLine("The indexes are {0} and {1}", result[0], result[1]);

        result = TwoSum.Dictionary(new int[] { 3, 2, 4 }, 6);
        Console.WriteLine("The indexes are {0} and {1}", result[0], result[1]);

        result = TwoSum.Dictionary(new int[] { 3, 3 }, 6);
        Console.WriteLine("The indexes are {0} and {1}", result[0], result[1]);

        Console.ReadKey();
    }
}