using System;
using System.Collections.Generic;
using System.Text;

namespace Checkout.Entities.Enums {
    enum OrderStatus {
        PENDING_PAYMENT,
        PROCESSING,
        SHIPPED,
        DELIVERED
    }
}
