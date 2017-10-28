using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Knet.Core.Configuration;

namespace Knet.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CConfigurationParser parser = new CConfigurationParser();
            parser.ParseForCurrentUser();
        }
    }
}
