using System;
using System.Collections.Generic;
using System.Text;

namespace Composition2.Entities.Enums
{
    enum OrderSatus : int
    {
        PENDING_PAYMENT = 0,
        PROCESSING = 1,
        SHIPPED = 2,
        DELIVERED = 3
    }
}
