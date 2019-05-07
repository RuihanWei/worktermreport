using Generic_Implementation.ConsoleProcessors;
using Generic_Implementation.Controllers;
using Generic_Implementation.DataContainers;
using Generic_Implementation.DataWriters;

namespace Generic_Implementation
{
    public enum JsonCreatorP
    {
        stuff
    }

    public enum MoveBmpP
    {
        stuff
    }

    public enum ConfigP
    {
        stuff
    }

    public class Program
    {
		public static IInputOutput InputOutput;

        static void Main(string[] _args)
        {
			GenConfigCon gen = new GenConfigCon();
			gen.Data = new GenConfigDC();
			MoveBmpCon mov = new MoveBmpCon();
			mov.Data = new MoveBmpDC();
			PopJsonCon json = new PopJsonCon();
			json.Data = new PopJsonDC();

			GenConfigCP genCP = new GenConfigCP(InputOutput);
			genCP.InitiateProcess();
			MoveBmpCP bmpDC = new MoveBmpCP(InputOutput);
			bmpDC.InitiateProcess();
			PopJsonCP popJsonDC = new PopJsonCP(InputOutput);
			popJsonDC.InitiateProcess();

			string _error = "";

			gen.TrySetValue(ConfigP.stuff, "", out _error);
			mov.TrySetValue(MoveBmpP.stuff, "", out _error);
			json.TrySetValue(JsonCreatorP.stuff, "", out _error);

			gen.TrySetValue(ConfigP.stuff, "", out _error);
			mov.TrySetValue(MoveBmpP.stuff, "", out _error);
			json.TrySetValue(JsonCreatorP.stuff, "", out _error); gen.TrySetValue(ConfigP.stuff, "", out _error);
			mov.TrySetValue(MoveBmpP.stuff, "", out _error);
			json.TrySetValue(JsonCreatorP.stuff, "", out _error); gen.TrySetValue(ConfigP.stuff, "", out _error);
			mov.TrySetValue(MoveBmpP.stuff, "", out _error);
			json.TrySetValue(JsonCreatorP.stuff, "", out _error); gen.TrySetValue(ConfigP.stuff, "", out _error);
			mov.TrySetValue(MoveBmpP.stuff, "", out _error);
			json.TrySetValue(JsonCreatorP.stuff, "", out _error); gen.TrySetValue(ConfigP.stuff, "", out _error);
			mov.TrySetValue(MoveBmpP.stuff, "", out _error);
			json.TrySetValue(JsonCreatorP.stuff, "", out _error); gen.TrySetValue(ConfigP.stuff, "", out _error);
			mov.TrySetValue(MoveBmpP.stuff, "", out _error);
			json.TrySetValue(JsonCreatorP.stuff, "", out _error);


			GenConfigDW confdw = new GenConfigDW();
			confdw.Write(gen.Data);
			MoveBmpDW mvbmpdw = new MoveBmpDW();
			mvbmpdw.Write(mov.Data);
			PopJsonDW jsonDw = new PopJsonDW();
			jsonDw.Write(json.Data);
		}
	}
}
