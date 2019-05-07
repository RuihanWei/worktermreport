using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Script_Implementation
{
	public class Program
	{
		public static IInputOutput InputOutput;

		static void Main(string[] args)
		{
			InputOutput = new ConsoleIO();


			// json population
			InputOutput.WriteLine("stuff");

			string directory = @"C:\ProgramData\hardware";

			// Create a new DirectoryInfo object.
			DirectoryInfo dir = new DirectoryInfo(directory);

			if (!dir.Exists)
			{
				throw new DirectoryNotFoundException("The directory does not exist.");
			}

			// Call the GetFileSystemInfos method.
			FileSystemInfo[] infos = dir.GetFileSystemInfos();
			List<DynatreeItem> dynatreeItem = new List<DynatreeItem>();

			foreach (var info in infos)
			{
				dynatreeItem.Add(new DynatreeItem(info));
			}

			string writingstr = "";
			foreach (var VARIABLE in dynatreeItem)
			{
				writingstr += VARIABLE.JsonToDynatree();
			}

			using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\ProgramData\hardware\writeHere\newjson.json"))
			{
				file.WriteLine(writingstr);
			}

			List<string> input = new List<string>{
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

			GenerateConfiguration(input);

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

		static void GenerateConfiguration(List<string> values)
		{
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

	class DynatreeItem
	{
		public string title { get; set; }
		public bool isFolder { get; set; }
		public string key { get; set; }
		public List<DynatreeItem> children;

		public DynatreeItem(FileSystemInfo fsi)
		{
			title = fsi.Name;
			children = new List<DynatreeItem>();

			if (fsi.Attributes == FileAttributes.Directory)
			{
				isFolder = true;
				foreach (FileSystemInfo f in (fsi as DirectoryInfo).GetFileSystemInfos())
				{
					children.Add(new DynatreeItem(f));
				}
			}
			else
			{
				isFolder = false;
			}
			key = title.Replace(" ", "").ToLower();

		}

		public string JsonToDynatree()
		{
			return JsonConvert.SerializeObject(this, Formatting.Indented);
		}
	}
}
