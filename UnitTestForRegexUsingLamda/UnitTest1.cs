﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexUsingLamda;
using System;

namespace UnitTestForRegexUsingLamda
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("FirstName")]
        public void FistNameValidationReturnTrue()
        {
            //Arrange
            string firstName = "Sai";
            //Act
            bool result = RegexValidation.ValidatingFirstName(firstName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [TestCategory("FirstName")]
        public void FistNameValidationReturnFalse()
        {
            //Arrange
            string firstName = "sai";
            //Act
            bool result = RegexValidation.ValidatingFirstName(firstName);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        [TestCategory("LastName")]
        public void LastNameValidationReturnTrue()
        {
            //Arrange
            string lastName = "Kumar";
            //Act
            bool result = RegexValidation.ValidatingLastName(lastName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [TestCategory("LastName")]
        public void LastNameValidationReturnFalse()
        {
            //Arrange
            string lastName = "kumar";
            //Act
            bool result = RegexValidation.ValidatingLastName(lastName);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        [TestCategory("Email")]
        public void EmailIdValidationReturnTrue()
        {
            //Arrange
            string email = "abc@gmail.com";
            //Act
            bool result = RegexValidation.ValidatingEmail(email);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [TestCategory("Email")]
        public void EmailIdValidationReturnFalse()
        {
            //Arrange
            string email = "abc@gmail.com.1a";
            //Act
            bool result = RegexValidation.ValidatingEmail(email);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        [TestCategory("MobileNumber")]
        public void MobileNumberValidationReturnTrue()
        {
            //Arrange
            string mobileNumber = "91 9866201448";
            //Act
            bool result = RegexValidation.ValidatingMobileNumber(mobileNumber);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [TestCategory("MobileNumber")]
        public void MobileNumberValidationReturnFalse()
        {
            //Arrange
            string mobileNumber = "91 70958212634";
            //Act
            bool result = RegexValidation.ValidatingMobileNumber(mobileNumber);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        [TestCategory("Password")]
        public void PasswordValidationReturnTrue()
        {
            //Arrange
            string password = "awsvWf&2";
            //Act
            bool result = RegexValidation.ValidatingPassword(password);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [TestCategory("Password")]
        public void PasswordValidationReturnFalse()
        {
            //Arrange
            string password = "Bran*raf";
            //Act
            bool result = RegexValidation.ValidatingPassword(password);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        [TestCategory("Parameterised Testing")]
        [DataRow("abc@gmail.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc.100@abc.com.au")]
        public void MultipleEmailIdValidationReturnTrue(string email)
        {
            Assert.IsTrue(RegexValidation.ValidatingEmail(email));
        }
        [TestMethod]
        [TestCategory("Parameterised Testing")]
        [DataRow("abc@gmail.com.aa.au")]
        [DataRow("abc@gmail.com.1a")]
        [DataRow("abc@abc@gmail.com")]
        [DataRow("abc.@gmail.com")]
        public void MultipleEmailIdValidationReturnFalse(string email)
        {
            Assert.IsFalse(RegexValidation.ValidatingEmail(email));
        }
    }
}
