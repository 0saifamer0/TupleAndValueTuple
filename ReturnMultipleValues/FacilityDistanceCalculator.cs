using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnMultipleValues
{
    public static class FacilityDistanceCalculator
    {
        private static Random random = new Random();

        public static Location GetFacilityLocationInfo(string facilityName)
        {
            return new Location
            {
                Name = facilityName,
                DistanceInKM = random.NextDouble() * 10.0
            };
        }

        public static void GetFacilityLocationInfo(string facilityName, out string name, out double distanceInKM)
        {
            name = facilityName;
            distanceInKM = random.NextDouble() * 10.0;
        }
    }
}
