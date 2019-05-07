using Generic_Implementation.DataContainers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Implementation.DataWriters
{
    public abstract class DataWriterBase<T> where T:Enum
    {
        public abstract void Write(DataContainerBase<T> _dataContainer);
    }  
}
