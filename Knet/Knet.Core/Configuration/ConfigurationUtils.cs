using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knet.Core.Configuration
{
    internal class CConfigurationUtils
    {
        public static string GetValue(string keyValueStr)
        {
            var pairs = keyValueStr.Split(':');
            if (pairs.Length < 2) throw new Exception("Key:Value pair wrong format");

            string value = pairs[1];
            return value.Trim(' ');
        }
    }
}
