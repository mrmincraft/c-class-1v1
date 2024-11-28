using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_final.characters
{
    internal class Mage : Characters
    {
        public int _bariercount {  get; set; }
        public Mage() : base()
        {
            _name = "defaltFiter";
            _hp = 60;
            _maxhp = _hp;
            _ap = 75;
            _ad = 0;
            _speed = 0;
            _dodge = 5;
            _ward = 5;
            _MagicResist = 25;
        }
        public void FrostFlash(Characters target)
        {
            target.defend(_ap, true);
        }
        public void FrostBarier()
        {
            _bariercount = 2;
        }
    }
}
