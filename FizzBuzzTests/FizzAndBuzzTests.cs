using FizzBuzzEmbedded;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzAndBuzzTests
    {
        // Test whether a list of 15 values returns the correct values.

        #region TestFizzAndBuzzValues
        [TestMethod]
        public void TestFizzAndBuzzValues()
        {

            List<string> expected = new();
            expected.Add("1");
            expected.Add("2");
            expected.Add("Fizz");
            expected.Add("4");
            expected.Add("Buzz");
            expected.Add("Fizz");
            expected.Add("7");
            expected.Add("8");
            expected.Add("Fizz and Jazz");
            expected.Add("Buzz and Razz");
            expected.Add("Razzmatazz");
            expected.Add("Fizz");
            expected.Add("13");
            expected.Add("14");
            expected.Add("Fizz and Buzz");

            //Fill pairsList
            List<ValueNamePairs> pairsList = new();

            pairsList.Add(new ValueNamePairs(11, "Razzmatazz"));
            pairsList.Add(new ValueNamePairs(3, "Fizz"));
            pairsList.Add(new ValueNamePairs(5, "Buzz"));
            pairsList.Add(new ValueNamePairs(9, "Jazz"));
            pairsList.Add(new ValueNamePairs(10, "Razz"));

            List<string> actual = FizzBuzzEmbedded.FizzBuzzEmbedded.WordListOrFizzBuzzResult(pairsList, 15);

            CollectionAssert.AreEqual(expected, actual);
        }

        #endregion

        // Test whether a list of 15 values returns the correct values when an empty pairsList value is passed.

        #region TestFizzAndBuzzWithEmptyPairsList
        [TestMethod]
        public void TestFizzAndBuzzWithEmptyPairsList()
        {

            List<string> expected = new();
            expected.Add("1");
            expected.Add("2");
            expected.Add("3");
            expected.Add("4");
            expected.Add("5");
            expected.Add("6");
            expected.Add("7");
            expected.Add("8");
            expected.Add("9");
            expected.Add("10");
            expected.Add("11");
            expected.Add("12");
            expected.Add("13");
            expected.Add("14");
            expected.Add("15");

            //Fill pairsList
            List<ValueNamePairs> pairsList = new();

            List<string> actual = FizzBuzzEmbedded.FizzBuzzEmbedded.WordListOrFizzBuzzResult(pairsList, 15);

            CollectionAssert.AreEqual(expected, actual);
        }
        #endregion

        // Test whether a list of 15 values returns the correct values when only 3 - Fizz and 5 - Buzz are passed in to the pairs list.

        #region TestFizzAndBuzzWith3And5AsValues
        [TestMethod]
        public void TestFizzAndBuzzWith3And5AsValues()
        {

            List<string> expected = new();
            expected.Add("1");
            expected.Add("2");
            expected.Add("Fizz");
            expected.Add("4");
            expected.Add("Buzz");
            expected.Add("Fizz");
            expected.Add("7");
            expected.Add("8");
            expected.Add("Fizz");
            expected.Add("Buzz");
            expected.Add("11");
            expected.Add("Fizz");
            expected.Add("13");
            expected.Add("14");
            expected.Add("Fizz and Buzz");

            //Fill pairsList
            List<ValueNamePairs> pairsList = new();

            pairsList.Add(new ValueNamePairs(3, "Fizz"));
            pairsList.Add(new ValueNamePairs(5, "Buzz"));

            List<string> actual = FizzBuzzEmbedded.FizzBuzzEmbedded.WordListOrFizzBuzzResult(pairsList, 15);

            CollectionAssert.AreEqual(expected, actual);
        }

        #endregion

        // Test whether a list of 15 values returns the correct values when a record with a zero is passed in to the pairs list.

        #region TestFizzAndBuzzWithAZeroInPairsList
        [TestMethod]
        public void TestFizzAndBuzzWithAZeroInPairsList()
        {

            List<string> expected = new();
            expected.Add("1");
            expected.Add("2");
            expected.Add("Fizz");
            expected.Add("4");
            expected.Add("Buzz");
            expected.Add("Fizz");
            expected.Add("7");
            expected.Add("8");
            expected.Add("Fizz and Jazz");
            expected.Add("Buzz and Razz");
            expected.Add("Razzmatazz");
            expected.Add("Fizz");
            expected.Add("13");
            expected.Add("14");
            expected.Add("Fizz and Buzz");

            //Fill pairsList
            List<ValueNamePairs> pairsList = new();

            pairsList.Add(new ValueNamePairs(11, "Razzmatazz"));
            pairsList.Add(new ValueNamePairs(3, "Fizz"));
            pairsList.Add(new ValueNamePairs(5, "Buzz"));
            pairsList.Add(new ValueNamePairs(9, "Jazz"));
            pairsList.Add(new ValueNamePairs(10, "Razz"));
            pairsList.Add(new ValueNamePairs(0, "Bombazzle"));

            List<string> actual = FizzBuzzEmbedded.FizzBuzzEmbedded.WordListOrFizzBuzzResult(pairsList, 15);

            CollectionAssert.AreEqual(expected, actual);
        }

        #endregion
    }
}