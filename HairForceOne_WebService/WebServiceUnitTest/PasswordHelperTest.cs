﻿using HairForceOne.WebService.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Transactions;

namespace WebServiceUnitTest
{
    internal class PasswordHelperTest
    {
        private TransactionScope scope;
        //private PasswordHelper passwordHelper;

        [TestInitialize]
        public void Setup()
        {
            scope = new TransactionScope();
        }

        [TestMethod]
        public void ShouldReturnRightSaltLenght()
        {
            var testsalt = PasswordHelper.GenerateSalt();
            Assert.IsTrue(testsalt.Length > 0);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            scope.Dispose();
        }
    }
}