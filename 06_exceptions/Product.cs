using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_exceptions
{
    internal class Product
    {
        string name;
        double price;
        DateTime dataIn;

        public string Name
        {
            get => name;
            set
            {
                if(string.IsNullOrWhiteSpace(value)) 
                {
                    throw new Exception("Name must be not null or whitespace");
                }
                if(!value.All(e=>char.IsLetter(e)))
                {
                    Exception ex = new Exception("Bad name :: must have all letters");
                    ex.Data.Add("Value", value);
                    ex.Data["Expiry data"] = DateTime.Now;
                    ex.HelpLink = @"https://google.com.ua";
                    throw ex;
                }
                name = value;
            }
        }
        public DateTime DateIn { get => dataIn;
            set
            {
                dataIn = value > DateTime.Now ? value : throw new BadDateProductException("Bad date of product ", value);
            }
        }
    }
}
