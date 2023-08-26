using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MifirDesktop.Models
{
    internal class ErrorLine
    {
        public string Line { get; set; }

        public ErrorLine(string line)
        {
            Line = line;
        }
    }
}
