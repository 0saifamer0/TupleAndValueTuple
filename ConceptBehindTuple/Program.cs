using System.Collections;

namespace ConceptBehindTuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fixed Size, Strongly Typed, Mutable
            int[] array = { 1, 2, 3, 4, 5 };

            // Dynamic Size, Strongly Typed, Mutable
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            list.AddRange(list);

            // Dynamic Size, Weakly Typed, Mutable
            ArrayList arrayList = new ArrayList { 1, "saif", 3.5, true, DateTime.Now };

            // Tuple = Strongly Typed, Immutable
            Tuple<int, int, int, int, int> tuple1 = new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5);
            Tuple<int, int, int, int, int> tuple2 = Tuple.Create(1, 2, 3, 4, 5);
        }
    }
}
