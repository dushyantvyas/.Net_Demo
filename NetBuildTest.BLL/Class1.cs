using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBuildTest.BLL
{
    public class Class1
    {
        public Class1()
        {

        }

        public string HelloWorld(string input)
        {
            return input;
        }

        public string Jsonify(object input)
        {
            return JsonConvert.SerializeObject(input);
        }

    }
}
