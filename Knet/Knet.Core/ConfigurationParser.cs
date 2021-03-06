﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using Knet.Model;

namespace Knet.Core.Configuration
{
    public class CConfigurationParser
    {
        public CConfigurationParser()
        {

        }

        public CKubernatesConfig ParseForCurrentUser()
        {
            var userDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            var kubernetesUserCfg = string.Format(@"{0}\.kube\config", userDir);
            using (FileStream stream = File.OpenRead(kubernetesUserCfg))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string cfgStr = reader.ReadToEnd();
                    return CKubernatesConfig.Desirialize(cfgStr);
                }
            }
        }
    }
}
