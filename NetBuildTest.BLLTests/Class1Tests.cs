using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetBuildTest.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBuildTest.BLL.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void HelloWorldTest()
        {
            const string input = "test";
            string output = null;
            BLL.Class1 instance = null;

            instance = new Class1();
            output = instance.HelloWorld(input);

            Assert.AreEqual(input, output);
        }

        [TestMethod()]
        public void JsonifyTest()
        {
            const string input = "test";
            const string validate = @"[""test""]";
            string output = null;
            BLL.Class1 instance = null;
            List<string> lst = null;

            lst = new List<string>();
            lst.Add(input);
            instance = new Class1();
            output = instance.Jsonify(lst);

            Assert.AreEqual(validate, output);
        }
    }
}