using project_final.combat_system;
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
        public Fighter(string name, int hp, int ap, int ad, int speed, double dodge, double mr, double ward,_Tarmor armor ) : base(name, hp, ap, ad, speed, dodge, mr, ward, armor)
        {

        }
        public Fighter() : base()
        {
            _name = "defaltFighter";
            _armor = _Tarmor.ChainMail;
            _hp = 100;
            _maxhp=_hp;
            _ap = 0;
            _ad = 50;
            _speed = 4;
            _dodge = 5;
            _ward = 25;
            _MagicResist = 10;
            _bariercount = 0;

        }
        public Attack HeroImpact(Characters target )
        {
            Attack HeroImpact = new Attack("hero impact",_ad,false,false,target,this);
            return HeroImpact;
        }
        public void WarCry() 
        {
            _ad = _ad * 2;
        }
    }
}
