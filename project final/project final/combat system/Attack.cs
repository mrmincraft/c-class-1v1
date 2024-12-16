using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_final.characters;

namespace project_final.combat_system
{
    class Attack
    {
        public string _name { get; set; }
        public int _damage {  get; set; }
        public bool _isMagic {  get; set; }
        public bool _ingroreArmor { get; set; }
        public Characters _target {  get; set; }
        public Characters _sender {  get; set; }
        public Attack(string name, int dmg, bool Magic, bool pirsing, Characters target, Characters sender) 
        { 
            _damage = dmg;
            _isMagic = Magic;
            _ingroreArmor = pirsing;
            _target = target;
            _sender = sender;
            _name = name;
        }
    }
}
