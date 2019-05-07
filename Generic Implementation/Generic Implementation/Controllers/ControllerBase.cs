using Generic_Implementation.DataContainers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Implementation.Controllers
{
    public abstract class ControllerBase<T> where T:Enum
    {
		DataContainerBase<T> Data;
        public bool TrySetValue(T type, string _value, out string _error)
		{
			return Data.TrySetValue(type, _value, out _error);
		}
    }
}
