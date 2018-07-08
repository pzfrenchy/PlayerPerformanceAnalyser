using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyserLibrary
{
    /// <summary>
    /// Singleton class, exposes methods for getting and setting program options
    /// </summary>
    public class OptionSettings
    {
        private static OptionSettings instance;

        private OptionSettings() { }

        public static OptionSettings Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OptionSettings();
                }
                return instance;
            }
        }

        public string FileExtension { get; set; }
        public string Directory { get; set; }
    }
}
