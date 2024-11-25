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
        public Fighter(string name, int hp, int ap, int ad, int armor, double dodge, double ward) : base(name, hp, ap, ad, armor, dodge, ward)
        {

        }
        public Fighter() : base()
        {
            
            _hp = 100;
            _maxhp=_hp;
            _ap = 0;
            _ad = 50;
            _dodge = 5;
            _ward = 25;
            _MagicResist = 10;

        }
        public void HeroImpact(Characters target )
        {
            target.defend(_ad, false);
        }
        public void WarCry() 
        {
            _ad = _ad * 2;
        }
        public void defend(int damages, bool ismagic) 
        {
            if (ismagic)
            {
                
            }

        }
        public void pasive()
        {
            if (RNG(25))
            {
                Console.WriteLine("counter attack");


                
            }
        }
    }
}
