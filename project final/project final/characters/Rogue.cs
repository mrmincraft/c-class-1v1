using project_final.combat_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace project_final.characters
{
    internal class Rogue : Characters
    {
        public Rogue() : base()
        {
            _name = "defaltRogue";
            _armor = _Tarmor.Leather;
            _hp = 80;
            _maxhp = _hp;
            _ap = 0;
            _ad = 55;
            _speed = 6;
            _dodge = 15;
            _ward = 25;
            _MagicResist = 25;
        }
        public Attack CheepShot(Characters target)
        {
            if (target._hp<target._maxhp/2)
            {
                Attack cheapshot = new Attack("cheap shot", _ad, false, false, target, this);
                return cheapshot;
            }
            else
            {
                int attackdamage = (int)(_ad * 1.5);
                Attack cheapshot = new Attack("cheap shot", attackdamage, false, false, target, this);
                return cheapshot;
            }
        }
        public void Evasion()
        {
            if (_dodge > 50 || _MagicResist > 50)
            {
                Console.WriteLine("you are ass quick as it gets");
            }
            else
            {
                Console.WriteLine("you are now faster");
                _MagicResist = +20;
                _dodge = +20;
                if (_MagicResist > 50) { _MagicResist = 50; }
                if (_dodge > 50) { _dodge = 50; }
            }
        }

    }
}
