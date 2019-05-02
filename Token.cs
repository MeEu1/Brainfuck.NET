using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Brainfuck.NET
{
    class Token
    {
        #region Global vars

        private char[] Pointers = new char[60]; // Simulate pointers. Every pointer has a maximum value of 255 and a minimum value of 0.
                                                //They also have an overflow possibility( if it's value is 255 and 1 is added to it, it becomes 0).

        private char Input;

        #endregion

        public Token(char input = ' ')
        {
            Input = input;//Get the input

            for (int i = 0; i < Pointers.Length; i++)
                Pointers[i] = (char)0; //Set all values on pointers to 0.
        }

        #region public

        public string SetOutput(char[] code, int currentPos = 0)
        {
            string output = "";

            for(int i = 0; i < code.Length; i++)
            {
                switch (code[i])
                { 
                    case '>':
                        if (currentPos < 60)
                            currentPos++;
                        else
                           currentPos = 0;
                        break;//Go to the next pointer
                    case '<':
                        if (currentPos >= 0)
                            currentPos--;
                        else
                            currentPos = 60;
                        break;//Got to the posterior pointer
                    case '+':
                        if (Pointers[currentPos] < 255)
                            Pointers[currentPos]++;
                        else
                            Pointers[currentPos] = (char)0;
                        break;//Add one to the current pointer's value
                    case '-':
                        if (Pointers[currentPos] > 0)
                            Pointers[currentPos]--;
                        else
                            Pointers[currentPos] = (char)255;
                        break;//Subtract one to the current pointer's value
                    case '.':
                        output += Pointers[currentPos];
                        break;//Print on screen the current pointer.
                    case ',':
                        Pointers[currentPos] = Input == 0 ? ' ' : Input;
                        break;//Read a given key.
                    case '[':

                        int endLoopPos = 0;

                        if(code.Contains(']'))
                        {
                           endLoopPos = code.ToList<char>().IndexOf(']');
                        }
                        else
                        {
                            throw new InvalidTokenExpressionException("Where's the ']'?");
                        }

                        int startLoopPos = code[i];//Get the position of '[' and ']'
                        Stack<char> loop = new Stack<char>();
                        loop.Push((char)startLoopPos);

                        char j = (char)startLoopPos;
                        while (j < (char)endLoopPos)
                        {
                            loop.Push(j++);
                        }
                        loop.Push((char)endLoopPos);//Create the loop

                        while (Pointers[currentPos] > 0)
                        {
                            foreach(char c in loop)
                            {
                                if (c == '[' || c == ']')
                                    continue;

                                output += SetOutput(c, currentPos);
                            }
                        }
                        break;//Decrement a pointer until it's 0

                    case ']':
                        break;

                    default:
                        throw new TokenNotValidException($"Invalid token '{code[i]}'");
                }
            }

            return output;
        }

        public string SetOutput(char token, int currentPos)
        {
            string output = "";

            switch (token)
            {
                case '>':
                    if (currentPos < 60)
                        currentPos++;
                    else
                        currentPos = 0;
                    break;//Go to the next pointer
                case '<':
                    if (currentPos >= 0)
                        currentPos--;
                    else
                        currentPos = 60;
                    break;//Got to the posterior pointer
                case '+':
                    if (Pointers[currentPos] < 255)
                        Pointers[currentPos]++;
                    else
                        Pointers[currentPos] = (char)0;
                    break;//Add one to the current pointer's value
                case '-':
                    if (Pointers[currentPos] > 0)
                        Pointers[currentPos]--;
                    else
                        Pointers[currentPos] = (char)255;
                    break;//Subtract one to the current pointer's value
                case '.':
                    output += Pointers[currentPos];
                    break;//Print on screen the current pointer.
                case ',':
                    Pointers[currentPos] = Input == 0 ? ' ' : Input;
                    break;//Read a given key.

                default:
                    throw new TokenNotValidException($"Invalid token '{token}'");
            }

            return output;
        }//Read a single token. Can't be a loop

        #endregion
    }
}
