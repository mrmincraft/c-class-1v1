using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_final.characters
{
    internal class Paladin : Characters
    {
        public Paladin() : base()
        {
            _hp = 95;
            _maxhp = _hp;
            _ap = 40;
            _ad = 40;
            _dodge = 5;
            _ward = 10;
            _MagicResist = 20;
        }
        public void CrosedStrike(Characters target)
        {
            target.defend(_ad,false);
        }
        public void Jugement(Characters target)
        {
            target.defend(target._ap, false);
        }
        public void LightBolt()
        {
            this.heal((int)1.25*_ap);
        }
    }
}
