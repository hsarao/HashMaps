using Assignment2;
using NUnit.Framework;

namespace StringKeyTest
{
    [TestFixture]
    public class StringKeyTest
    {
        /// <summary>
        /// Tests the StringKey constructor.
        /// </summary>
        [Test]
        public static void StringKeyConstructorTest()
        {
            string name = "Name";
            StringKey stringKey = new StringKey(name);

            Assert.AreEqual(stringKey.KeyName, name);
        }

        /// <summary>
        /// Test CompareTo using the same object.
        /// </summary>
        [Test]
        public static void CompareToSameObjectTest()
        {
            int expectedResult = 0;
            StringKey stringKey = new StringKey("Name");

            Assert.AreEqual(expectedResult, stringKey.CompareTo(stringKey));
        }

        /// <summary>
        /// Test CompareTo on two StringKeys with the same name.
        /// </summary>
        [Test]
        public static void CompareToSameNameTest()
        {
            int expectedResult = 0;
            StringKey stringKey1 = new StringKey("A");
            StringKey stringKey2 = new StringKey("A");

            Assert.AreEqual(expectedResult, stringKey1.CompareTo(stringKey2));

        }

        /// <summary>
        /// Test CompareTo with a stringKey with a name that comes aphabetically before the instance.
        /// </summary>
        [Test]
        public static void CompareToAphabeticallyBeforeNameTest()
        {
            StringKey stringKey1 = new StringKey("B");
            StringKey stringKey2 = new StringKey("A");

            Assert.IsTrue(stringKey1.CompareTo(stringKey2) > 0);
        }

        /// <summary>
        /// Test CompareTo with a StringKey with a name that comes aphabetically after the instance.
        /// </summary>
        [Test]
        public static void CompareToAphabeticallyAfterNameTest()
        {
            StringKey stringKey1 = new StringKey("A");
            StringKey stringKey2 = new StringKey("B");

            Assert.IsTrue(stringKey1.CompareTo(stringKey2) < 0);
        }


        /// <summary>
        /// Test that the GetHashCode method returns differnt values for words with same letters in different orders.
        /// </summary>
        [Test]
        public static void GetHashCodeVarietyTest()
        {
            StringKey stringKey1 = new StringKey("stop");
            StringKey stringKey2 = new StringKey("pots");

            Assert.AreNotEqual(stringKey1.GetHashCode(), stringKey2.GetHashCode());
        }


        /// <summary>
        /// Test that the GetHashCode method returns positive values for large words.
        /// </summary>
        [Test]
        public static void GetHashCode_is_not_negative_Test()
        {
            StringKey stringKey1 = new StringKey("A REALLY BIG STRING SHOULD NOT OVERFLOW TO NEGATIVE! ALWAYS ABSOLUTE VALUE YOUR HASHCODE!");

            Assert.GreaterOrEqual(stringKey1.GetHashCode(), 0);
        }

        /// <summary>
        /// Test that GetHashCode returns 0 on an empty name.
        /// </summary>
        [Test]
        public static void GetHashCodeEmptyNameTest()
        {
            int expectedResult = 0;
            StringKey stringKey = new StringKey("");
            Assert.AreEqual(expectedResult, stringKey.GetHashCode());
        }

        /// <summary>
        /// Test that Equals returns true when the same object is checked against itself.
        /// </summary>
        [Test]
        public static void EqualsSameObjectTest()
        {
            StringKey stringKey = new StringKey("A");

            Assert.IsTrue(stringKey.Equals(stringKey));
        }

        /// <summary>
        /// Test that Equals returns false when a null object is passed in.
        /// </summary>
        [Test]
        public static void EqualsNullObjectTest()
        {
            StringKey stringKey = new StringKey("A");

            Assert.IsFalse(stringKey.Equals(null));
        }

        /// <summary>
        /// Test that Equals returns false when a non StringKey object is passed in.
        /// </summary>
        [Test]
        public static void EqualsNonStringKeyObjectTest()
        {
            StringKey stringKey = new StringKey("A");

            Assert.IsFalse(stringKey.Equals("Not a string key"));
        }

        /// <summary>
        /// Test that Equals returns true when a StringKey with a matching name is compared.
        /// </summary>
        [Test]
        public static void EqualsDifferentObjectsWithMatchingNameTest()
        {
            StringKey stringKey1 = new StringKey("A");
            StringKey stringKey2 = new StringKey("A");

            Assert.IsTrue(stringKey1.Equals(stringKey2));
        }

        /// <summary>
        /// Test that Equals returns false when a StringKey with a mismatching name is compared.
        /// </summary>
        [Test]
        public static void EqualsMisMatchedObjectsTest()
        {
            StringKey stringKey1 = new StringKey("A");
            StringKey stringKey2 = new StringKey("B");

            Assert.IsFalse(stringKey1.Equals(stringKey2));
        }

        /// <summary>
        /// Test GetHashCode to ensure it returns expected result.
        /// </summary>
        [Test]
        public static void GetHashCodeTest()
        {
            int expectedResult = 3446974;
            StringKey stringKey = new StringKey("stop");

            // NOTE: this may differ from your tests, you may ignore this test!
            Assert.AreEqual(expectedResult, stringKey.GetHashCode());
        }

        /// <summary>
        /// Test that ToString returns the expected string.
        /// </summary>
        [Test]
        public static void ToStringTest()
        {
            string expectedString = "KeyName: stop HashCode: 3446974";
            StringKey stringKey = new StringKey("stop");

            // NOTE: this may differ from your tests, you may ignore this test!
            // THIS IS A GOOD IDEA FOR TESTING HOWEVER, YOU *SHOULD* DO IT ANYWAY.
            Assert.AreEqual(expectedString, stringKey.ToString());
        }

    }
}