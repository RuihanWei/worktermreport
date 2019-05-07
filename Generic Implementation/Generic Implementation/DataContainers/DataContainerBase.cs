using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Implementation.DataContainers
{
    public abstract class DataContainerBase<T> where T:Enum
    {
        public Dictionary<Enum, string> Values;
        public bool TrySetValue(T type, string _IValue, out string _error)
		{
			_error = "";
			Values[type] = _IValue;
			return true;
		}
        public bool IsComplete(out string _error)
		{
			_error = "";
			return true;
		}
    }
}
