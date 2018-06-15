using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void ArrayEqualToList()
        {
            List<int> intList = new List<int>();
            int[] intArray = new int[4];

            GradeBook bookA = new GradeBook();
            GradeBook bookB = new GradeBook();
            bookA.Age = 10;
            bookB.Age = 11;
              
            intArray[1] = bookA.Age;
            AddToList(intList, 10);
            AddToArray(intArray, 10);

            Assert.AreEqual(intList[0], 10);
            Assert.AreEqual(intArray[0], 10);
            Assert.AreEqual(intList[0], intArray[0]);

        }

        private void AddToList(List<int> intList, int a)
        {
            intList.Add(a);
        }

        private void AddToArray(int[] intArray, int b)
        {
            intArray[0] = b;
        }

        [TestMethod]
        public void GradeBookListCheck()
        {
            List<float> gradesList;
            gradesList = new List<float>();
            gradesList.Add(99.9f);
            gradesList.Add(10f);
            gradesList.Add(100.9f);

            Assert.AreEqual(gradesList[2], 100.9f);
        }

        [TestMethod]
        public void AddElementsToGradeBooks()
        {
            GradeBook bookA = new GradeBook();
            GradeBook bookB = new GradeBook();
            bookA.Age = 10;
            bookB.Age = 11;
            bookA.Level = "intermediate";
            bookB.Level = bookA.Level;
            bookA = new GradeBook();
            bookA.Age = 19;
            bookA.Level = "intermediate";

            Assert.AreEqual(bookA.Name, bookB.Name);
            Assert.AreNotEqual(bookA.Age, bookB.Age);
            Assert.AreEqual(bookA.Level, bookB.Level);
        }

        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void UppercaseString()
        {
            string name = "scott";
            name.ToUpper();

            Assert.AreEqual(name, "scott");
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2015, 1, 1);
            date = date.AddDays(1);

            Assert.AreEqual(date.Day, 2);
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(x);

            Assert.AreEqual(46, x);
        }

        private void IncrementNumber(int number)
        {
            number += 1;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;
            
            GiveBookAName(book1);
            Assert.AreEqual("A GradeBook", book2.Name);
        }

        private void GiveBookAName(GradeBook book)
        {
        book.Name = "A GradeBook";
        }


        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Scott";
            string name2 = "scott";

            bool result = String.Equals(name1, name2, StringComparison.CurrentCultureIgnoreCase);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            Int32 x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1 = new GradeBook();
            g1.Name = "Scott's grade book";
            g2.Name = "Scott's grade book";
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
