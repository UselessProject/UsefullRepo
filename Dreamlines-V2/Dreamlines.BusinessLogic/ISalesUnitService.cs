using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamlines.BusinessLogic
{
    public interface ISalesunitService
    {
        IEnumerable<SalesunitDto> Find();
    }
}
