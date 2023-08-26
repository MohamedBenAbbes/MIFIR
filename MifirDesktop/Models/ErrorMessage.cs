using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MifirDesktop.Models
{
    internal class ErrorMessage
    {
        public string Message { get; set; }
        public List<ErrorLine> ErrorLines { get; set; }

        public ErrorMessage(string message, List<ErrorLine> errorLines)
        {
            Message = message;
            ErrorLines = errorLines;
        }
    }
}
