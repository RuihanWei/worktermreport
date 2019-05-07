using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Generic_Implementation.DataWriters
{
	class GenConfigDW
	{
		public void Write(List<string> _input)
		{
			List<string> values = new List<string>{
				"Brachiosaurus",
				"Amargasaurus",
				"Mamenchisaurus" ,
				"Mamenchisaurus" ,
				"Mamenchisaurus" ,
				"Mamenchisaurus" ,
				"Mamenchisaurus" ,
				"Mamenchisaurus" ,
				"Mamenchisaurus" ,
				"Mamenchisaurus" ,
				"Mamenchisaurus" ,
				"Mamenchisaurus" ,
				"Mamenchisaurus" ,
				"Mamenchisaurus"
			};

			var myDictionary = new Dictionary<string, string>
			{
				{"a", values[0]},
				{"f", values[1]},
				{"s", values[2]},
				{"r", values[3]},
				{"d", values[4]},
				{"v", values[5]},
				{"ds", values[6]},
				{"vc", values[7]},
				{"ew", values[8]}
			};

			using (StreamWriter file = new StreamWriter(@"C:\ProgramData\hardware\ini.txt"))
				foreach (var entry in myDictionary)
					file.WriteLine("[{0} {1}]", entry.Key, entry.Value);
		}
	}
}
