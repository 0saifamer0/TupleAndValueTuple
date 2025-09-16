namespace ReturnMultipleValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Class Instance");
            var facilityInfo = FacilityDistanceCalculator.GetFacilityLocationInfo("Hospital");
            Console.WriteLine(facilityInfo);

            Console.WriteLine();

            Console.WriteLine("Using out Parameter");
            string name;
            double distanceInKM;
            FacilityDistanceCalculator.GetFacilityLocationInfo("Hospital", out name, out distanceInKM);
            Console.WriteLine($"{name}........{distanceInKM.ToString("F2")} Km");
           
            Console.ReadKey();
        }
    }
}
