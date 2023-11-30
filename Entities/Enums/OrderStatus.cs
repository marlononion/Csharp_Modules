using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Course.Entities.Enums
{
    enum OrderStatus : int // Apagar a class e por enum
    {
        PendingPayment = 0,
        Processing = 1, 
        Shipped = 2, 
        Delivered = 3
    }
}
