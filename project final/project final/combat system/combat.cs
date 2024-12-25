using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_final.characters;

namespace project_final.combat_system
{
    internal class Combat
    {
        private List<Characters> combatent = new List<Characters>();
        private _fight _type;
        public enum _fight
        {
            solo=2,
            duo=4,
            trio=6,
            squad=8,
        }

        public Combat(_fight type) 
        {
            _type = type;
            Console.WriteLine("what are you adding in this fight");
            for (int i=0 ; i < (int)type ;i++)
            { 
                AddChars(i);
            }

        }
        public void AddChars(int cid)
        {
            Console.WriteLine("what class are you adding");
            Console.Write(" 1 - Fighter \n 2 - Mage \n 3 - Paladin \n 4 - Rogue \n else - noCharacter");
            int in_csase;
            if (int.TryParse(Console.ReadLine(), out in_csase))
            {
                switch (in_csase)
                {
                    case 1:
                        combatent.Add(new Fighter());
                        break;
                    case 2:
                        combatent.Add(new Mage());
                        break;
                    case 3:
                        combatent.Add(new Paladin());
                        break;
                    case 4:
                        combatent.Add(new Rogue());
                        break;
                    default:
                        Console.WriteLine("invalid imput retry");
                        AddChars(cid);
                        break;

                }
            }
            else
            {
                Console.WriteLine("invalid imput retry");
            }
            
        } 
        public void show()
        {
            switch (_type)
            {
                case _fight.solo :
                    combatent[0].status();
                    Console.WriteLine("\n---------------------\n");
                    combatent[1].status();
                    break;
                case _fight.duo :
                    combatent[0].status();
                    combatent[1].status();
                    Console.WriteLine("\n---------------------\n");
                    combatent[2].status();
                    combatent[3].status();
                    break;
                case _fight.trio :
                    combatent[0].status();
                    combatent[1].status();
                    combatent[2].status();
                    Console.WriteLine("\n---------------------\n");
                    combatent[3].status();
                    combatent[4].status();
                    combatent[5].status();
                    break;
                case _fight.squad :
                    combatent[0].status();
                    combatent[1].status();
                    combatent[2].status();
                    combatent[3].status();
                    Console.WriteLine("\n---------------------\n");
                    combatent[4].status();
                    combatent[5].status();
                    combatent[6].status();
                    combatent[7].status();
                    break;
                default:
                    break;
            }
        }
    }
}
