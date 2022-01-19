using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio.src.entites
{
    public class Ninja : Personagem
    {
        public Ninja(string name, int level, int hp, int mp)
        {

            this.Name = name;
            this.Level = level;
            this.HeroType = "Ninja";
            this.Hp = hp;
            this.Mp = mp;
        }

        public override string Attack()
        {
            return this.Name + " Atacou com a katana";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Invocando sua shuriken usou um ataque critico de: " + Bonus;
            }
            else
            {
                return this.Name + " Acertou um ataque leve com a katana de: " + Bonus;
            }

        }
    }
}