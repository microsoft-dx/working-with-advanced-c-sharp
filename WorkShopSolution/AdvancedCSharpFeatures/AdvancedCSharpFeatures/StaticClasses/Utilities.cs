using System.Collections.Generic;

namespace AdvancedCSharpFeatures.StaticClasses
{
    // Extension Methods are Awesome Also
    public static class Utilities
    {
        public static List<LINQ.DummyObject> GiveMe(this LINQ.DummyObjectGenerator generator, int numberOfInstances)
        {
            List<LINQ.DummyObject> toReturn = new List<LINQ.DummyObject>();

            foreach (int instanceIndex in numberOfInstances.Range())
            {
                toReturn.Add(new LINQ.DummyObject());
            }

            return toReturn;
        }

        public static int[] Range(this int count)
        {
            int[] generatedRange = new int[count];

            for (int i = 0; i < count; i++)
            {
                generatedRange[i] = i;
            }

            return generatedRange;
        }

        public static IEnumerable<int> LazyRange(this int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return i;
            }
        }
    }
}
