namespace _09._04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 4, 6, 8, 12, 15, 20, -5, 25, 30 };
            bool allEven = array.All(x => x % 2 == 0);
            Console.WriteLine($"All elements are even: {allEven}");
            bool allBetween10And45 = array.All(x => x > 10 && x < 45);
            Console.WriteLine($"All elements are between 10 and 45: {allBetween10And45}");
            bool anyNegative = array.Any(x => x < 0);
            Console.WriteLine($"Any negative element exists: {anyNegative}");
            bool anyOddNegative = array.Any(x => x % 2 != 0 && x < 0);
            Console.WriteLine($"Any odd negative element exists: {anyOddNegative}");
            bool containsSeven = array.Contains(7);
            Console.WriteLine($"Array contains 7: {containsSeven}");
            int? firstGreaterThan723 = array.FirstOrDefault(x => x > 723);
            Console.WriteLine($"First element greater than 723: {firstGreaterThan723}");
            int? lastNegative = array.LastOrDefault(x => x < 0);
            Console.WriteLine($"Last negative element: {lastNegative}");
        }
    }
}
