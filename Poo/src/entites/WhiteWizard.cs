using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio.src.entites
{
    public class WhiteWizard : Personagem
    {
        public WhiteWizard(string name, int level, int hp, int mp)
        {

            this.Name = name;
            this.Level = level;
            this.HeroType = "White Wizard";
            this.Hp = hp;
            this.Mp = mp;

        }

        public override string Attack()
        {
            return this.Name + " Lançou magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lançou uma magia super efetiva com bonus de: " + Bonus;
            }
            else
            {
                return this.Name + " Lançou uma magia fraca de: " + Bonus;
            }
        }

    }
}