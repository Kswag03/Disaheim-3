using System.Globalization;
using static Microsoft.TestPlatform.AdapterUtilities.HierarchyConstants;
using Disaheim1;

namespace UtilityTest
{
    [TestClass]
    public class UnitTest2
    {
        Book b1, b2, b3;
        Amulet a1, a2, a3;
        Course c1, c2, c3;


        Utility utility;

        [TestInitialize]
        public void Init()
        {
            // Forcing the culture to be the one we use in the tests
            Thread.CurrentThread.CurrentCulture = new CultureInfo("da-DK");

            // Arrange
            b1 = new Book("1");
            b2 = new Book("2", "Falling in Love with Yourself");
            b3 = new Book("3", "Spirits in the Night", 123.55);

            a1 = new Amulet("11");
            a2 = new Amulet("12", Level.High);
            a3 = new Amulet("13", Level.Low, "Capricorn");

            c1 = new Course("Spådomskunst for nybegyndere");
            c2 = new Course("Magi – når videnskaben stopper", 157);
            c3 = new Course("Et indblik i Helleristning", 180);



            utility = new Utility();
        }

        [TestMethod]
        public void TestGetValueForBook1()
        {
            // Assert
            Assert.AreEqual(0.0, utility.GetValueOfBook(b1));
        }
        [TestMethod]
        public void TestGetValueForBook2()
        {
            // Assert
            Assert.AreEqual(0.0, utility.GetValueOfBook(b2));
        }
        [TestMethod]
        public void TestGetValueForBook3()
        {
            // Assert
            Assert.AreEqual(123.55, utility.GetValueOfBook(b3));
        }

        [TestMethod]
        public void TestGetValueForAmulet1()
        {
            // Assert
            Assert.AreEqual(20.0, utility.GetValueOfAmulet(a1));
        }
        [TestMethod]
        public void TestGetValueForAmulet2()
        {
            // Assert
            Assert.AreEqual(27.5, utility.GetValueOfAmulet(a2));
        }
        [TestMethod]
        public void TestGetValueForAmulet3()
        {
            // Assert
            Assert.AreEqual(12.5, utility.GetValueOfAmulet(a3));
        }

        [TestMethod]
        public void CourseConstructorWithOneParameter()
        {
            // Assert
            Assert.AreEqual("Name: Spådomskunst for nybegyndere, Duration in Minutes: 0", c1.ToString());
        }
        [TestMethod]
        public void CourseConstructorWithTwoParameters1()
        {
            // Assert
            Assert.AreEqual("Name: Magi – når videnskaben stopper, Duration in Minutes: 157", c2.ToString());
        }
        [TestMethod]
        public void CourseConstructorWithTwoParameters2()
        {
            // Assert
            Assert.AreEqual("Name: Et indblik i Helleristning, Duration in Minutes: 180", c3.ToString());
        }

        [TestMethod]
        public void AmuletSetPropertiesWorks()
        {
            // Act
            a3.ItemId = "X";
            a3.Quality = Level.High;
            a3.Design = "Dolphin";

            // Assert
            Assert.AreEqual("ItemId: X, Quality: High, Design: Dolphin", a3.ToString());
        }
        [TestMethod]
        public void BookSetPropertiesWorks()
        {
            // Act
            b3.ItemId = "Y";
            b3.Title = "Smoke on the Water";
            b3.Price = 376.45;

            // Assert
            Assert.AreEqual("ItemId: Y, Title: Smoke on the Water, Price: 376,45", b3.ToString());
        }


        [TestMethod]
        public void TestGetValueForCourse1()
        {
            // Assert
            Assert.AreEqual(0.0, utility.GetValueOfCourse(c1));
        }
        [TestMethod]
        public void TestGetValueForCourse2()
        {
            // Assert
            Assert.AreEqual(2625.0, utility.GetValueOfCourse(c2));
        }
        [TestMethod]
        public void TestGetValueForCourse3()
        {
            // Assert
            Assert.AreEqual(2625.0, utility.GetValueOfCourse(c3));
        }



    }


}
