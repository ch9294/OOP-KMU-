using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overridng
{
    class Base
    {
        public virtual void SealMe()
        {

        }
    }

    class Drived : Base
    {
        public override void SealMe()
        {
            base.SealMe();
        }
    }

    class WantToOverridie : Drived
    {
        public override void SealMe()
        {

        }
    }
    class SealedOverriding
    {
        static void Main(string[] args)
        {

        }
    }
}
