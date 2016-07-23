using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine.DesktopClient.Models
{
    using Interfaces;
    using Helpers;
    public class Coin : NotificationObject, ICoin, IEquatable<Coin>
    {
        int _nominal;
        int _count;
        string _currency;
        public Coin(int nominal, string currency, int count)
        {
            _nominal = nominal;
            _currency = currency;
            _count = count;
        }

        public Coin(int nominal, int count) :
            this(nominal, "Р", count)
        {
        }

        public Coin(int nominal) :
            this(nominal, "Р", 1)
        {
        }


        public int Nominal { get { return _nominal; } }

        public String Currency { get { return _currency; } }

        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                if (_count != value)
                {
                    _count = value;
                    RaisePropertyChanged();
                }
            }
        }

        public int Amount { get { return Count * _nominal; } }

        public static Coin operator +(Coin c1, Coin c2)
        {
            c1.Count += c2.Count;
            return c1;

        }

        public static Coin operator -(Coin c1, Coin c2)
        {
            c1.Count -= c2.Count;
            return c1;
        }

        public bool Equals(Coin other)
        {
            return this.Nominal == other.Nominal && this.Currency == other.Currency;
        }
    }
}
