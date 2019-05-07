using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Implementation.Controllers
{
	class GenConfigCon : ControllerBase<ConfigP>
	{
		public override bool TrySetValue(string _value, out string _error)
		{
			throw new NotImplementedException();
		}
	}
}
