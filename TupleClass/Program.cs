namespace TupleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Tuple.Create:");
            var facilityInfoV1 = FacilityDistanceCalculator.CalculateFacilityDistanceV1("Hospital");
            Console.WriteLine(facilityInfoV1);

            Console.WriteLine();

            Console.WriteLine("Using Tuple Constructor:");
            var facilityInfoV2 = FacilityDistanceCalculator.CalculateFacilityDistanceV2("Hospital");
            Console.WriteLine(facilityInfoV2);

            Console.WriteLine();

            Console.WriteLine("Tuple Properties:");
            Tuple<int, int> tuple = Tuple.Create(3, 4);
            Console.WriteLine($"Itme1: {tuple.Item1} , Itme2: {tuple.Item2}");

            Console.WriteLine();

            Console.WriteLine("Tuple Equality:");
            var tuple1 = new Tuple<int, string>(1, "Saif");
            var tuple2 = new Tuple<int, string>(1, "Saif");
            Console.WriteLine($"Equals: {tuple1.Equals(tuple2)}"); // True = Compare content
            Console.WriteLine($"==: {tuple1 == tuple2}"); // False = Compare reference
        }
    }
}
