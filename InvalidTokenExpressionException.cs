using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brainfuck.NET
{
    class InvalidTokenExpressionException : InvalidOperationException
    {
        public string Msg { get; private set; }

        public InvalidTokenExpressionException(string msg) : base()
        {
            Msg = msg;
        }
    }
}
