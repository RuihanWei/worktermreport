using Generic_Implementation.Controllers;
using System;

namespace Generic_Implementation.ConsoleProcessors
{
    public abstract class ConsoleProcessorBase<T> where T:Enum
    {
        public ConsoleProcessorBase(IInputOutput _inputOutput)
        {
            InputOutput = _inputOutput;
        }
        
        private IInputOutput InputOutput;
        private ControllerBase<T> Controller;
        protected abstract void InitiateProcess();
    }
}
