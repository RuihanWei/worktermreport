﻿using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace Generic_Implementation.DataWriters
{
	public class PopJsonDW
	{
		public void Write(List<string> dd_input)
		{
			string directory = @"C:\ProgramData\hardware";

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
				return JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
			}
		}
	}
}
