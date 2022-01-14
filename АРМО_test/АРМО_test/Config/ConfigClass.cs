using System;
using System.Text;
using Microsoft.Win32;
using System.Linq;

namespace ARMO_test.Config
{
    class ConfigClass
    {
        private RegistryKey atk = Registry.CurrentUser.OpenSubKey("SOFTWARE", true).CreateSubKey("ARMO_test");

        public struct ConfigStr
        {
            public string SearchStartPath;
            public string SearchTemplate;
        }


        public ConfigClass()
        {
            string[] values = atk.GetValueNames();
            if (!values.Contains("SearchStartPath"))
                atk.SetValue("SearchStartPath", "");
            if (!values.Contains("SearchTemplate"))
                atk.SetValue("SearchTemplate", "");
        }

        public ConfigStr GetConfig()
        {
            ConfigStr ret = new ConfigStr()
                {
                    SearchStartPath = atk.GetValue("SearchStartPath").ToString(),
                    SearchTemplate = atk.GetValue("SearchTemplate").ToString()
                };
            return ret;
        }

        public void SetConfig(ConfigStr m_conf)
        {
            atk.SetValue("SearchStartPath", m_conf.SearchStartPath);
            atk.SetValue("SearchTemplate", m_conf.SearchTemplate);
        }
    }
}
