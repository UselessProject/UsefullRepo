using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamlines.BusinessLogic
{
    public interface ISalesUnitService
    {
        IEnumerable<SalesUnitDto> Find();
    }
}
