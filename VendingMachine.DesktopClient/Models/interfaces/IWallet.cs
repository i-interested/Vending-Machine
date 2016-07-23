using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine.DesktopClient.Models.Interfaces
{
    interface IWallet
    {
        bool TakeCoins(ICoin coins);
        void AddCoins(ICoin coins);
    }
}
