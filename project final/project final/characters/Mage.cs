using project_final.combat_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project_final.characters
{
    internal class Mage : Characters
    {
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
        public Attack FrostFlash(Characters target)
        {
            Attack frostflash = new Attack("frost flash",_ap,true,false,target,this);
            return frostflash;
        }
        public void FrostBarier()
        {
            _bariercount = 2;
        }
    }
}
