using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();

            Assert.AreEqual(90, result.HighestGrade);
        }

        [TestMethod]
        public void ComputeLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();

            Assert.AreEqual(10, result.LowestGrade);
        }

        [TestMethod]
        public void ComputeAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics result = book.ComputeStatistics();

            Assert.AreEqual(85.16, result.AverageGrade, 0.01);
        }

        [TestMethod]
        public void LetterGradeATest()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(93.5f);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();

            Assert.AreEqual("A", result.LetterGrade);
        }

        [TestMethod]
        public void LetterGradeBTest()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(81);
            book.AddGrade(86.2f);
            book.AddGrade(88.4f);

            GradeStatistics result = book.ComputeStatistics();

            Assert.AreEqual("B", result.LetterGrade);
        }

        [TestMethod]
        public void LetterGradeCTest()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(70);
            book.AddGrade(73.6f);
            book.AddGrade(77.4f);

            GradeStatistics result = book.ComputeStatistics();

            Assert.AreEqual("C", result.LetterGrade);
        }

        [TestMethod]
        public void LetterGradeDTest()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(62.5f);
            book.AddGrade(66);
            book.AddGrade(68.2f);

            GradeStatistics result = book.ComputeStatistics();

            Assert.AreEqual("D", result.LetterGrade);
        }

        [TestMethod]
        public void LetterGradeFTest()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(52.3f);
            book.AddGrade(55);
            book.AddGrade(58.5f);

            GradeStatistics result = book.ComputeStatistics();

            Assert.AreEqual("F", result.LetterGrade);
        }
    }
}
