using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnMultipleValues
{
    public class Location
    {
        public string Name { get; set; }
        public double DistanceInKM { get; set; }

        public override string ToString()
        {
            return $"{Name}........{DistanceInKM.ToString("F2")} Km";
        }
    }
}
