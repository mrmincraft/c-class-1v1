using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_final.combat_system
{
    class Attack
    {
        public string _name { get; set; }
        public int _damage {  get; set; }
        public bool _isMagic {  get; set; }
        public bool _ingroreArmor { get; set; }
        public int _target {  get; set; }
        public int _sender {  get; set; }
        public Attack(string name, int dmg, bool Magic, bool pirsing, int target, int sender) 
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
