using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasslarNedenKullanilir
{
    public class Mart : AY
    {
        public override int kacAyCekiyor()
        {
            return 31;
        }

        public override int kacinciAy()
        {
            return 3;
        }
    }
}
