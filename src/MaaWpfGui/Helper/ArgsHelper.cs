using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;

namespace MaaWpfGui
{
    public class ArgsHelper
    {
        private static MaaGuiArgOptions _options { get; set; }

        public static MaaGuiArgOptions ParseArgs(string[] args)
        {
            Parser.Default.ParseArguments<MaaGuiArgOptions>(args)
                   .WithParsed(o => { _options = o; });
            return _options;
        }

        public static MaaGuiArgOptions GetOptions()
        {
            return _options;
        }
    }
}
