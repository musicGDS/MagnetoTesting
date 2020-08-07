using System;
using MagnetoTesting.Infrastructure;

namespace MagnetoTesting
{
    public class Test3 : TestBase
    {
        private AdminLoginPage _adminLoginPage;

        public Test3()
        {
            _adminLoginPage = new AdminLoginPage(Driver);

        }
    }
}
