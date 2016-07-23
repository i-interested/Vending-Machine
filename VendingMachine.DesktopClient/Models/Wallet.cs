using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine.DesktopClient.Models
{
    using Helpers;

    public class Wallet : NotificationObject
    {
        List<Coin> _coins;
        int _index;
        Dictionary<Coin, int> _coinsD;
        public Wallet()
            : this(new List<Coin>())
        {

        }

        public Wallet(List<Coin> coins)
        {
            _coins = coins;
        }

        public static Wallet CreateDefaulUserWallet()
        {
            List<Coin> coins = new List<Coin>();
            //Dictionary<Coin, int> coinsD = new Dictionary<Coin, int>();
            coins.Add(new Coin(1, "Р", 10));
            coins.Add(new Coin(2, "Р", 30));
            coins.Add(new Coin(5, "Р", 20));
            coins.Add(new Coin(10, "Р", 15));
            Wallet defaultWallet = new Wallet(coins);
            return defaultWallet;
        }

        public static Wallet CreateDefaulVMWallet()
        {
            List<Coin> coins = new List<Coin>();
            coins.Add(new Coin(1, "Р", 100));
            coins.Add(new Coin(2, "Р", 100));
            coins.Add(new Coin(5, "Р", 100));
            coins.Add(new Coin(10, "Р", 100));
            Wallet defaultWallet = new Wallet(coins);
            return defaultWallet;
        }

        public void AddCoin(int nominal)
        {
            AddCoins(nominal, 1);
        }

        public void AddCoins(int nominal, int count)
        {
            Coin coins = new Coin(nominal, count);
            AddCoins(coins);
        }

        public void AddCoins(Coin coins)
        {
            if (IsContaintCoin(coins))
                _coins[_index] += coins;
            else
                _coins.Add(coins);
        }

        public bool TakeCoin(int nominal)
        {
            return TakeCoins(nominal, 1);
        }

        public bool TakeCoins(int nominal, int count)
        {
            Coin coins = new Coin(nominal, count);
            return TakeCoins(coins);
        }

        public bool TakeCoins(Coin coins)
        {
            if (mayTakeCoins(coins))
            {
                _coins[_index] -= coins;
                return true;
            }

            return false;
        }

        private bool mayTakeCoins(Coin coins)
        {
            if (IsContaintCoin(coins))
                return _coins[_index].Count >= coins.Count;
            return false;
        }

        private bool IsContaintCoin(Coin coins)
        {
            _index = _coins.IndexOf(coins);
            return _index > 0;
        }
    }
}
