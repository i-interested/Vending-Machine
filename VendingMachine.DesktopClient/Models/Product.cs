using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine.DesktopClient.Models
{
    using Interfaces;
    using Helpers;
    class Product : NotificationObject, IProduct
    {
        string _name;
        int _price;

        public Product(string name, int price)
        {
            _name = name;
            _price = price;
        }

        public string Name
        {
            get { return _name; }
        }

        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    RaisePropertyChanged();
                }
            }
        }
    }
}
