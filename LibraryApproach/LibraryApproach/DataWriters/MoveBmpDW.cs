using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Generic_Implementation.DataWriters
{
	class MoveBmpDW
	{
		public void Write(List<string> dd_input)
		{
			string[] _input = new string[2];
			_input[0] = @"C:\ProgramData\hardware\hardware1\firmware\version2.0\Bitmap.bmp";
			_input[1] = @"C:\ProgramData\hardware\hardware1\firmware\Bitmap.bmp";

			MoveBmp(_input);
		}

		private static void MoveBmp(string[] input)
		{
			if (System.IO.File.Exists(input[1]))
			{
				System.IO.File.Delete(input[1]);
			}

			File.Move(input[0], input[1]);
			System.IO.File.Copy(input[1], input[0], true);
		}
	}
}
