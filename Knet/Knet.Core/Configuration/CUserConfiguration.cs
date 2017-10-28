using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knet.Core.Configuration
{
    public class CUserConfiguration
    {
        

        public string Name { get; private set; }
        public string CertificateData { get; private set; }
        public string KeyData { get; private set; }

        private CUserConfiguration(string name, string certData, string keyData)
        {
            Name = name;
            CertificateData = certData;
            KeyData = keyData;
        }

        public CUserConfiguration()
        {
        }
    }
}
