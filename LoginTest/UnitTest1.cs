using System;
using Logic;
using Xunit;

namespace LoginTest
{
    public class UnitTest1
    {

        [Fact]
        public void LogIn()
        {
            Loginmanager loginManager = new Loginmanager();

            loginManager.RegisterNewUser("Username", "aA_-056hJt%&12", DateTime.Today);

            Assert.True(loginManager.RegisterNewUser("Username", "aA_-056hJt%&12", DateTime.Today));
            Assert.False(loginManager.RegisterNewUser("Username", "password", DateTime.Today));
        }

        [Fact]
        public void CheckCorrectUsernameTest()
        {
            Loginmanager loginManager = new Loginmanager();

            Assert.True(loginManager.RegisterNewUser("Username", "aA_-056hJt", DateTime.Today));
            Assert.False(loginManager.RegisterNewUser("Username2", "aA-056hJtnsifdjisenr", DateTime.Today));
            Assert.False(loginManager.RegisterNewUser("Username3", "aA-056%&", DateTime.Today));

        }
    }
}