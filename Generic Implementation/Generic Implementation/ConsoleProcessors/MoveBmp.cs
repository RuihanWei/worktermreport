using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Implementation.ConsoleProcessors
{
	public class MoveBmp : ConsoleProcessorBase<MoveBmpP>
	{
		public MoveBmp(IInputOutput _inputOutput) : base(_inputOutput)
		{

		}

		protected override void InitiateProcess()
		{
			throw new NotImplementedException();
		}
	}
}
