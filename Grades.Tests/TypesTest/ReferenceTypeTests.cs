using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Grades.Tests.TypesTest
{
    [TestClass]
    public class ReferenceTypeTests
    {
        [TestMethod]
        public void UppercaseString()
        {
            string name = "alex";
            name = name.ToUpper();

            Assert.AreEqual("ALEX", name);
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(ref book2);
            Assert.AreEqual("A Gradebook", book2.Name);
        }

        [TestMethod]
        public void StringComparisons()
        {
            string person1 = "Bob";
            string person2 = "bob";

            bool result = string.Equals(person1, person2, StringComparison.InvariantCultureIgnoreCase);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GradeBookVariablesHoldReference()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            book1.Name = "Grade Book";

            Assert.AreEqual(book1.Name, book2.Name);
        }

        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        private void GiveBookAName(ref GradeBook book)
        {
            book = new GradeBook();
            book.Name = "A Gradebook";
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }
    }
}
