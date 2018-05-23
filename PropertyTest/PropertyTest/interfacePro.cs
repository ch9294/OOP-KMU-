using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTest
{
    interface IProduct
    {
        string ProductName
        {
            get; set;
        }
    }

    class interfacePro : IProduct
    {
        public string ProductName
        {
            get; set;
        }
    }
}
