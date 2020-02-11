using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace StudentUnitTestOpgave.Tests
{
    [TestClass()]
    public class UnitTest
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void StudentNameTest()
        {
            //Arrange
            Student s1 = new Student();

            //Act
            s1.Name = "B";
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentAddressTest()
        {
            //Arrange
            Student s1 = new Student();

            //Act
            s1.Address = null;

        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentSemesterTooHighTest()
        {
            //Arrange
            Student s1 = new Student();

            //Act
            s1.Semester = 111;
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentSemesterTooLowTest()
        {
            //Arrange
            Student s1 = new Student();

            //Act
            s1.Semester = 0;
        }

        [TestMethod()]
        public void StudentGenderMaleTest()
        {
            //Arrange
            Student s1 = new Student();

            //Act
            s1.Gender = Student.GenderType.Male;
        }

        [TestMethod()]
        public void StudentGenderFemaleTest()
        {
            //Arrange
            Student s1 = new Student();

            //Act
            s1.Gender = Student.GenderType.Female;
        }





    }
}