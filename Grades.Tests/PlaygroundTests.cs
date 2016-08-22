using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Grades.Tests
{
    [TestClass]
    public class PlaygroundTests
    {
        private string Name;

        [TestMethod]
        public void RandomTest()
        {
            string[] names = new string[3];
            names[1] = "Ordep";
            int counter = 0;

            foreach (var name in names)
            {
                Console.WriteLine(counter + " " + name);
                counter ++; 
            }

            SetName("John Smith");
            string test = GetName();

            Console.WriteLine(test);
        }

        [TestMethod]
        public void StructTest()
        {
            string name = "Billy";
            if(name == Something.someText2)
            {
                Assert.IsTrue(true);
            }
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public struct Something
        {
            public const string someText = "James";
            public const string someText2 = "Billy";
        }

    }
}
