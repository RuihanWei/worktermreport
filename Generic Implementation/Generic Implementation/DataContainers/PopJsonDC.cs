﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Implementation.DataContainers
{
	public class PopJsonDC : DataContainerBase<JsonCreatorP>
	{
		public PopJsonDC()
		{
		}

		public override bool IsComplete(out string _error)
		{
			throw new NotImplementedException();
		}

		public override bool TrySetValue(string _IValue, out string _error)
		{
			throw new NotImplementedException();
		}
	}
}
