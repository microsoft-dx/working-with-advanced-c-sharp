using AdvancedCSharpFeatures.StaticClasses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace AdvancedCSharpFeatures.LINQ
{
    public class LinqDemo
    {
        // HERE THE MAGIC STARTS
        private void LazyProcessing()
        {
            // We want to take only the first 20 ints of a 30 int lazy generated list
            // Let's debug and see what happens
            // HINT: use Take

            IEnumerable<int> doesNothing = 5.LazyRange().Take(3);

            List<int> doesSomething = doesNothing.ToList();
        }

        private void WeHaveLambdasHere()
        {
            // We have lambda functions here
            // Let's generate a list of 20 numbers and take only the ones that are a multiple of 5
            // Using Lambdas

            List<int> ceva = 20.Range().Where(x => (x % 5 == 0)).ToList();

            // Let's make a dictionary out of our data
            List<string> attributes = new List<string> { "Nume = Petrescu", "Prenume = Alexandru", "Ocupatie = Din pacate ce facem acum" };
            Dictionary<string, string> myData = attributes.ToDictionary(x => x.Split('=').First().Trim(), y => y.Split('=').Last().Trim());
        }

        private void LetsGoAnonymous()
        {
            // Let's watch the generator in action
            List<DummyObject> victim = new DummyObjectGenerator().GiveMe(7);

            // With Those objects we want to take only the sting and the int value into a new list
            // Use Anonymous Types
            // You can take only somethink like
            List<object> example = 5.Range().Select(x => new object()).ToList();

            // Here's an Anon, he's a nice guy
            var annonObject = new { WhatAmI = "An Anonymous Object", WhatIDo = "torture developers" };
            Console.WriteLine("Hi, I am {0} and I {1}!", annonObject.WhatAmI, annonObject.WhatIDo);


            // Let's get them
            var numeVariabila = (from x in victim
                                 select new { x.IntValue, x.PropperString });

            var query = victim.Select(x => new { x.IntValue, x.PropperString });
        }

        private void QuerriesInDotNet()
        {
            // We can write LINQ in natural language also
            // Let generate 10 Dummy objects
            // Take the ones that have an odd int
            // And Get a new object that has only that value
            // Sorted descending by value
            var masina = (new DummyObjectGenerator()).GiveMe(10).
                Where(x => (x.IntValue % 2 == 1)).
                Select(x => new { x.IntValue }).
                OrderBy(x => x.IntValue).FirstOrDefault(x => 3 == 2);

            var frumos = from x in (new DummyObjectGenerator()).GiveMe(10)
                         where x.IntValue % 2 == 1
                         orderby x.IntValue
                         select new { x.IntValue };

            // List<int> querry = 

            // We can also get the first element that does something
            // Let's get the first number from our new list that is both a multiple of 5
            // And has 3 odd digits
            // What do we get if we have none ?

            // int desidedNumber = 
        }

        public LinqDemo()
        {
            LazyProcessing();
            WeHaveLambdasHere();
            LetsGoAnonymous();
            QuerriesInDotNet();
        }
    }

    public class DummyObject
    {
        // Regions are awesome
        #region . MEMBERS .
        /// <summary>
        /// Use "3 * /"  in order to generate a summary comment, it can be colapsed
        /// </summary>
        private readonly int _readOnlyIntValue;
        public int IntValue => _readOnlyIntValue;

        private string _propperString;
        public string PropperString
        {
            get
            {
                return _propperString;
            }

            set
            {
                _propperString = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(value.Trim());
            }
        }

        public bool BoolValue { get; set; }

        // Just for internal Use
        private static Random _randomGenerator = new Random();
        private readonly int _lowerLimit = Math.Min((int)'a', (int)'A');
        private readonly int _upperLimit = Math.Max((int)'z', (int)'Z');
        #endregion

        public DummyObject()
        {
            StringBuilder randomStringBuilder = new StringBuilder();

            _readOnlyIntValue = _randomGenerator.Next();

            // Use Ctrl + R + R to rename this to something nice
            for (int i = 0; i < _randomGenerator.Next(35); i++)
            {
                randomStringBuilder.Append(Convert.ToChar(_randomGenerator.Next(_lowerLimit, _upperLimit)));
            }

            PropperString = randomStringBuilder.ToString();

            BoolValue = _randomGenerator.Next(0, 1) == 0 ? true : false;

            Console.WriteLine(this);
        }

        public override string ToString()
        {
            // String Interpolation is also amazing
            return $"{PropperString} says " +
                (BoolValue ? string.Join(",", (_readOnlyIntValue % 5).Range()) : $"{_randomGenerator.NextDouble(): 00.00}") +
                Environment.NewLine;
        }
    }

    public class DummyObjectGenerator
    {
    }
}
