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

            loginManager.RegisterNewUser("Username", "Password", DateTime.Today);
        }
    }
}
