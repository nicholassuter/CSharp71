using System;

namespace CSharp71Demo
{
    public class Defaulting
    {
        public T Defaults<T>()
        {
            //Variable assignment
            T someValue = default;

            // Explicit initializer
            var container = new Container<int, string>
            {
                Item1 = default,
                Item2 = default
            };

            // Implicit initializer
            var array = new[] { default, 2 };

            // Return value
            return default;
        }

        // Lambda
        Func<int> _getDefaultInt = () => default;

        // Default parameter
        public void DoSomething<T>(T param = default)
        {
            // is operator
            int i = 0;
            if (i is default)
            {
                Console.WriteLine($"i is default : {i}");
            }


            Console.WriteLine(param.ToString());
        }

        //Ternary operator
        void Ternary()
        {
            int? result = TestSomething() ? 1 : default; // change to default
        }

        private bool TestSomething()
        {
            return default; // return value
        }
    }

    public class Container<T1, T2>
    {
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
    }
}
