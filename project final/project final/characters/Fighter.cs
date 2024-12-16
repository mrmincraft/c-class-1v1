using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace project_final.characters
{
    internal class Fighter : Characters
    {
        public Fighter(string name, int hp, int ap, int ad, int speed, double dodge, double ward,_Tarmor armor ) : base(name, hp, ap, ad, speed, dodge, ward, armor)
        {

        }
        public Fighter() : base()
        {
            _name = "defaltFiter";
            _armor = _Tarmor.Plate;
            _hp = 100;
            _maxhp=_hp;
            _ap = 0;
            _ad = 50;
            _dodge = 5;
            _ward = 25;
            _MagicResist = 10;
            _bariercount = 0;

        }
        public void HeroImpact(Characters target )
        {
            target.defend(_ad, false);
        }
        public void WarCry() 
        {
            _ad = _ad * 2;
        }
    }
}
