using Bank_app;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bank_app.DAL;
using Bank_app.DAL.Context;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Bank_appDB db = new Bank_appDB(@"Data Source = DESKTOP - 55KITNB; Initial Catalog = Bank_app; Integrated Security = True");
        }
    }
}