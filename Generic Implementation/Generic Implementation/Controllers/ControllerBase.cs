using Generic_Implementation.DataContainers;
using System;

namespace Generic_Implementation.Controllers
{
	public abstract class ControllerBase<T> where T:Enum
    {
		public DataContainerBase<T> Data { get; set; }

		/*public ControllerBase(DataContainerBase<T> _data)
		{
			Data = _data;
		} */

        public bool TrySetValue(T type, string _value, out string _error)
		{
			return Data.TrySetValue(type, _value, out _error);
		}
    }
}
