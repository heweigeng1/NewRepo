using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConsoleApp.Tests
{
    [TestClass()]
    public class SaveFileTests
    {
        [TestMethod()]
        public void SaveToTxtTest(string data, string path)
        {
            string msg = SaveFile.SaveToTxt(data,path);
            if (msg=="error")
            {
                Assert.Fail();
            }
        }
    }
}