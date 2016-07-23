using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine.DesktopClient.Models.Interfaces
{
    interface ICoin
    {
        int Nominal { get; }
        String Currency { get; }
        int Count { get; set; }
        int Amount { get; }
    }
}
