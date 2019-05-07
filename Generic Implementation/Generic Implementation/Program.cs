using Generic_Implementation.ConsoleProcessors;
using Generic_Implementation.Controllers;

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
			MoveBmpCon mov = new MoveBmpCon();
			PopJsonCon json = new PopJsonCon();

			GenConfigCP genCP = new GenConfigCP(InputOutput);
			genCP.InitiateProcess();
			MoveBmpCP bmpDC = new MoveBmpCP(InputOutput);
			bmpDC.InitiateProcess();
			PopJsonCP popJsonDC = new PopJsonCP(InputOutput);
			popJsonDC.InitiateProcess();

			gen.TrySetValue(ConfigP.stuff, "", out string _error);
			mov.TrySetValue(MoveBmpP.stuff, "", out string _error2);
			json.TrySetValue(JsonCreatorP.stuff, "", out string _error3);

			gen.TrySetValue(ConfigP.stuff, "", out _error);
			mov.TrySetValue(MoveBmpP.stuff, "", out _error2);
			json.TrySetValue(JsonCreatorP.stuff, "", out _error3);

			gen.TrySetValue(ConfigP.stuff, "", out _error);
			mov.TrySetValue(MoveBmpP.stuff, "", out _error2);
			json.TrySetValue(JsonCreatorP.stuff, "", out _error3);

			gen.TrySetValue(ConfigP.stuff, "", out _error);
			mov.TrySetValue(MoveBmpP.stuff, "", out _error2);
			json.TrySetValue(JsonCreatorP.stuff, "", out _error3);
		}
	}
}
