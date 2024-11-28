using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_final.characters
{
    internal class Rogue : Characters
    {
        public Rogue() : base()
        {
            _name = "defaltRogue";
            _hp = 80;
            _maxhp = _hp;
            _ap = 0;
            _ad = 55;
            _dodge = 15;
            _ward = 25;
            _MagicResist = 25;
        }
        public void CheepShot(Characters target)
        {
            if (target._hp<target._maxhp/2)
            {
                target.defend(_ad,false);
            }
            else
            {
                int attackdamage = (int)(_ad * 1.5);
                target.defend(attackdamage, false);
            }
        }
        public void Evasion()
        {
            if (_dodge > 50 || _ward > 50)
            {
                Console.WriteLine("you are ass quick as it gets");
            }
            else
            {
                _ward = +20;
                _dodge = +20;
                if (_ward > 50) { _ward = 50; }
                if (_dodge > 50) { _dodge = 50; }
            }
        }

    }
}
