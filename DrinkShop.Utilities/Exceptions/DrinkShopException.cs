using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkShop.Utilities.Exceptions
{
    public class DrinkShopException : Exception
    {
        public DrinkShopException()
        {
        }

        public DrinkShopException(string message)
            : base(message)
        {
        }

        public DrinkShopException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }