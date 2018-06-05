using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSpace
{
    class Hero:Character
    {
        public Hero(string n, int h, int a, int d, int dr)
        {
            this.name = n;
            this.health = h;
            this.attack_ability = a;
            this.defense_ability = d;
            this.dodge_rate = dr;
            this.rnd = new Random();
        }

        public string Power_Attack(Character c)
        {
            int accuracy = this.rnd.Next(80, 121);
            string result = c.Defense(this.attack_ability * 2 * accuracy / 100, 3);
            return this.name + "強力攻擊" + c.getName() + "" + result;
        }

        public void Double_Dodge()
        {
            this.dodge_rate *= 2;
            this.defense_ability /= 2;
        }

        public void Half_Dodge()
        {
            this.dodge_rate /= 2;
            this.defense_ability *= 2;
        }
    }
}
