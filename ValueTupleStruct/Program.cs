namespace ValueTupleStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using ValueTuple.Create:");
            ValueTuple<string, double> t1 = ValueTuple.Create("Hospital", 2.4);
            Console.WriteLine(t1);

            Console.WriteLine();

            Console.WriteLine("Using ValueTuple Constructor:");
            ValueTuple<string, double> t2 = new ValueTuple<string, double>("Hospital", 2.4);
            Console.WriteLine(t2);

            Console.WriteLine();

            Console.WriteLine("Using Implicit Names");
            var t3 = FacilityDistanceCalculator.CalculateFacilityDistanceV2("Hospital");
            Console.WriteLine(t3.Item1);
            Console.WriteLine(t3.Item2);

            Console.WriteLine();

            Console.WriteLine("Using Explicit Names");
            var t4 = FacilityDistanceCalculator.CalculateFacilityDistanceV3("Hospital");
            Console.WriteLine(t4.Name);
            Console.WriteLine(t4.DistanceInKm);

            Console.WriteLine();
            Console.WriteLine("Using ValueTuple Deconstruction");
            (string name, string distanceInKm) = t4;
            Console.WriteLine(name);
            Console.WriteLine(distanceInKm);
        }
    }
}
