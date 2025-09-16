using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTupleStruct
{
    public static class FacilityDistanceCalculator
    {
        private static Random random = new Random();

        // Implicit Names
        public static ValueTuple<string, string> CalculateFacilityDistanceV1(string facilityName)
        {
            return ValueTuple.Create(facilityName, $"{(random.NextDouble() * 10.0).ToString("F2")} Km");
        }

        // Implicit Names
        public static (string, string) CalculateFacilityDistanceV2(string facilityName)
        {
            return ValueTuple.Create(facilityName, $"{(random.NextDouble() * 10.0).ToString("F2")} Km");
        }

        // Explicit Names
        public static (string Name, string DistanceInKm) CalculateFacilityDistanceV3(string facilityName)
        {
            return ValueTuple.Create(facilityName, $"{(random.NextDouble() * 10.0).ToString("F2")} Km");
        }
    }
}
