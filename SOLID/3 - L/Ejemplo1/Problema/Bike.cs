using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3___L.Problema
{
    internal class Bike : Vehicle
    {
        public override void SpeedUp()
        {
            base.SpeedUp();
        }
        public override void Brake()
        {
            base.Brake();
        }
        public override void Park()
        {
            base.Park();
        }
        public override void TakeOff()
        {
            throw new NotImplementedException();
        }
        public override void Land()
        {
            throw new NotImplementedException();
        }
    }
}
