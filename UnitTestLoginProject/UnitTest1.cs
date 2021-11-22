using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestLoginProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LogIn()
        {
            Loginmanager loginManager = new Loginmanager();

            loginManager.RegisterNewUser("Username", "aA_-056hJt%&12", DateTime.Today);

            Assert.IsTrue(loginManager.RegisterNewUser("Username", "aA_-056hJt%&12", DateTime.Today));
            Assert.IsFalse(loginManager.RegisterNewUser("Username", "password", DateTime.Today));
        }
    }
}
