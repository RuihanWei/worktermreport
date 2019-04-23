using System;

namespace Script_Implementation
{
	class ConsoleIO : IInputOutput
	{
		public string ReadLine()
		{
			return Console.ReadLine();
		}

		public void Write(string _input)
		{
			Console.Write(_input);
		}

		public void WriteLine(string _input)
		{
			Console.WriteLine(_input);
		}
	}
}
