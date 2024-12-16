using project_final.characters;
using project_final.combat_system;

Characters char1 = new Fighter();
Characters char2 = new Paladin();

char1.status();
char2.status();

char1.defend(100, false, false,char2);
char2.defend(100, false, false, char1);

char1.status();
char2.status();


