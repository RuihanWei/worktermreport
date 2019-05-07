using System;
using System.Collections.Generic;
using Generic_Implementation.ConsoleProcessors;
using Generic_Implementation.DataWriters;

namespace LibraryApproach
{
	class Program
	{
		static void Main(string[] _args)
		{
			GenConfigCP genCP = new GenConfigCP();
			genCP.InitiateProcess();
			MoveBmpCP bmpDC = new MoveBmpCP();
			bmpDC.InitiateProcess();
			PopJsonCP popJsonDC = new PopJsonCP();
			popJsonDC.InitiateProcess();

			List<string> input = new List<string>
			{
				"fjdklsfjdlk",
				"fjdklsfjdlk",
				"fjdklsfjdlk",
				"fjdklsfjdlk",
				"fjdklsfjdlk",
				"fjdklsfjdlk",
				"fjdklsfjdlk",
				"fjdklsfjdlk",
				"fjdklsfjdlk",
				"fjdklsfjdlk",
				"fjdklsfjdlk",
				"fjdklsfjdlk",
			};

			GenConfigDW confdw = new GenConfigDW();
			confdw.Write(input);
			MoveBmpDW mvbmpdw = new MoveBmpDW();
			mvbmpdw.Write(input);
			PopJsonDW jsoinputnDw = new PopJsonDW();
			jsoinputnDw.Write(input);
		}
	}
}
