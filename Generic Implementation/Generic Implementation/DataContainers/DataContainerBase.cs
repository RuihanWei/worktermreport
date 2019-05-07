using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Implementation.DataContainers
{
    public abstract class DataContainerBase<T> where T:Enum
    {
		public DataContainerBase()
		{
		}

        public Dictionary<Enum, string> Values = new Dictionary<Enum, string>();
        public bool TrySetValue(T type, string _Value, out string _error)
		{
			_error = "";
			if (Values.ContainsKey(type))
			{
				Values[type] = _Value;
			}
			else
			{
				Values.Add(type, _Value);
			}

			return true;
		}
        public bool IsComplete(out string _error)
		{
			_error = "";
			return true;
		}
    }
}
