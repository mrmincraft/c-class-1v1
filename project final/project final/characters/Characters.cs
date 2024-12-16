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
        public int _bariercount { get; set; }
        public enum _Tarmor
        {
            Plate = 0,
            ChainMail = 1,
            Leather = 2,
            Cloth = 3,
        }
        public _Tarmor _armor {  get; set; }
        public int _speed { get; set; }
        public double _dodge { get; set; }
        public double _MagicResist { get; set; }
        public double _ward { get; set; }

        public Characters(string name, int hp, int ap, int ad, int speed, double dodge,double mr, double ward,_Tarmor armor)
        { 
            _name = name;
            _hp = hp;
            _maxhp = hp;
            _ap = ap;
            _ad = ad;
            _speed = speed;
            _dodge = dodge;
            _ward = ward;
            _armor = armor;
            _MagicResist = mr;
            _bariercount = 0;

        }
        public Characters() 
        {
            _name = "Charbase";

        }
        public void attack (Characters target) 
        {
            
            target.defend(0,false);
        }
        public void defend(int damage, bool ismagic) 
        {
            if (_bariercount > 0)
            {
                Console.WriteLine("had barier");
                _bariercount--;
                if (ismagic)
                {
                    damage = (int) (damage * 0.6);
                }
                else
                {
                    damage = (int) (damage * 0.5);
                }

            }
            double mr = 0;
            double pr = 0;
            switch (_armor)
            {
                case _Tarmor.Plate:
                    pr = 0.45;
                    break;
                case _Tarmor.ChainMail:
                    pr = 0.3;
                    mr = 0.1;
                    break;
                case _Tarmor.Leather:
                    pr = 0.15;
                    mr = 0.2;
                    break;
                case _Tarmor.Cloth:
                    mr = 0.3;
                    break;
            }
            if (ismagic)
            {
                if (RNG(_MagicResist))
                {
                    Console.WriteLine("attack nulified");
                    this.damage(0);
                    return; 
                }
                damage = (int)(damage * (1 - mr));
                this.damage(damage);
                return;
            }
            else
            {
                if (RNG(_dodge))
                {
                    Console.WriteLine("attack doged");
                    this.damage(0);
                    return;
                }else if (RNG(_ward))
                {
                    Console.WriteLine("attack warded");
                    damage = (int)(damage * (1 - pr)*(1-0.5));
                    fightback(damage);
                }
                else
                {

                    damage = (int)(damage * (1 - pr));
                    fightback(damage);
                }
                this.damage(damage);
                return;
            }
        }

        public void fightback(int damage)
        {
            if (this.GetType().Name == "Fighter")
            {

                if (RNG(25))
                {
                    Console.WriteLine("fight back");
                    int fightback = (int)(damage * 0.5);
                    Console.WriteLine(fightback);
                }
            }
        }
        public void damage(int damage) 
        {
            _hp -= damage;
        }
        public void heal(int hp) 
        {
            this._hp = +hp;
        }
        virtual public void status() 
        {
            Console.WriteLine($"{_name} - {GetType().Name} - {_hp}/{_maxhp}HP - {_speed}SP");
        }

        virtual public void acction() { }
        public bool RNG(double persent)
        {
            return rnd.Next(101) < persent;
        }
    }
}
