using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace project_final.characters
{
    internal class Characters
    {
        private Random rnd = new Random();
        public string _name { get; set; }
        public int _hp { get; set; }
        public int _maxhp { get; set; }
        public int _ap { get; set; }
        public int _ad {  get; set; }
        public double _MagicResist { get; set; }
        public enum _armor
        {
            Plate,
            ChainMail,
            Leather,
            Cloth
        };
        public double _dodge { get; set; }
        public double _ward { get; set; }
        public Characters(string name, int hp, int ap, int ad, int armor, double dodge, double ward)
        { 
            _name = name;
            _hp = hp;
            _maxhp = hp;
            _ap = ap;
            _ad = ad;
            _dodge = dodge;
            _ward = ward;
            _armor=armor;

        }
        public Characters() 
        {
            _name = "Charbase";
        }
        public void attack (Characters target) 
        {
            
            target.defend(0,false);
        }
        virtual public void defend(int damage, bool ismagic) { }

        public void damage(int damage) 
        {
            _hp -= damage;

        }
        public void heal(int hp) 
        {
            this._hp = +hp;
        }
        virtual public void pasive()
        {

        }
        public bool RNG(double persent) 
        {
            int roll= rnd.Next(101);
            if (roll <= persent)
            {
                return true;
            }
            return false;
        }
    }
}
