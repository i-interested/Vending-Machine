using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine.DesktopClient.Models.Interfaces
{
    interface IProduct
    {
        string Name { get; }
        int Price { get; set; } 
    }
}
