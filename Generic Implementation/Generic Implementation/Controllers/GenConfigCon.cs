using Generic_Implementation.DataContainers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Implementation.Controllers
{
	class GenConfigCon : ControllerBase<ConfigP>
	{
		GenConfigDC genDC = new GenConfigDC();
	}
}
