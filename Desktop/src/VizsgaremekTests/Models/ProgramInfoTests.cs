using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Vizsgaremek.Models;

namespace Vizsgaremek.Models.Tests
{
    [TestClass()]
    public class ProgramInfoTests
    {
        [TestMethod()]
        public void ProgramInfoTestVersion()
        {
            // arrange
            ProgramInfo programInfo = new ProgramInfo();
            Version expected = new Version(0,0,3,0);

            // act
            Version actual = programInfo.Version;

            // assert
            Assert.AreEqual(expected, actual, "Version is not 0.0.3.0");
        }

        [TestMethod()]
        public void ProgramInfoTestAuthors()
        {
            // arrange
            ProgramInfo programInfo = new ProgramInfo();
            string expected = new string("Bélteki Balázs");

            // act
            string actual = programInfo.Authors;

            // assert
            Assert.AreEqual(expected, actual, "The author is not this person!");
        }

        [TestMethod()]
        public void ProgramInfoTestTitle()
        {
            // arrange
            ProgramInfo programInfo = new ProgramInfo();
            string expected = new string("Vizsgaremek");

            // act
            string actual = programInfo.Title;

            // assert
            Assert.AreEqual(expected, actual, "This is not the title!");
        }

        [TestMethod()]
        public void ProgramInfoTestDescription()
        {
            // arrange
            ProgramInfo programInfo = new ProgramInfo();
            string expected = new string("Program verzió navigáció működik");

            // act
            string actual = programInfo.Description;

            // assert
            Assert.AreEqual(expected, actual, "This is not the description!");
        }

        [TestMethod()]
        public void ProgramInfoTestCompany()
        {
            // arrange
            ProgramInfo programInfo = new ProgramInfo();
            string expected = new string("Vasvári");

            // act
            string actual = programInfo.Company;

            // assert
            Assert.AreEqual(expected, actual, "This is not the company!");
        }
    }


}