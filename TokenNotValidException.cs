using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brainfuck.NET
{
    class TokenNotValidException : ArgumentException
    {
        public string Msg { get; private set; }

        public TokenNotValidException(string msg) : base()
        {
            Msg = msg;
        }
    }
}
