using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Implementation
{
    public interface IInputOutput
    {
        void WriteLine(string _input);
        void Write(string _input);
        string ReadLine();
    }
}
