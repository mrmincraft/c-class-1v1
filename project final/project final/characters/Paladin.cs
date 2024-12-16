using project_final.combat_system;
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
            _name = "defaltPaladin";
            _hp = 95;
            _maxhp = _hp;
            _ap = 40;
            _ad = 40;
            _dodge = 5;
            _ward = 10;
            _MagicResist = 20;
        }
        public Attack CrosedStrike(Characters target)
        {
            Attack crosedstrike = new Attack("crosed strike", _ad, false, false, target, this);
            return crosedstrike;
        }
        public Attack Jugement(Characters target)
        {
            Attack jugement = new Attack("judgement",target._ap, false, false, target, this);
            return jugement;
        }
        public void LightBolt()
        {
            this.heal((int)1.25*_ap);
        }
    }
}
