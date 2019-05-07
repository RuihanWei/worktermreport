using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Implementation.Controllers
{
    public abstract class ControllerBase<T> where T:Enum
    {
        public abstract bool TrySetValue(string _value, out string _error)
		{
			DataContainerBase 
		}
    }
}
