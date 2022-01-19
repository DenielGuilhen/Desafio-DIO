using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio.src.entites
{
    public class Knight : Personagem
    {
        public Knight(string name, int level, int hp, int mp)
        {

            this.Name = name;
            this.Level = level;
            this.HeroType = "Knight";
            this.Hp = hp;
            this.Mp = mp;
        }
        public override string Attack()
        {
            return this.Name + " Atacou com a espada";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Acertou um golpe critico com a espada de: " + Bonus;
            }
            else
            {
                return this.Name + " Acertou um golpe fraco com a espada de: " + Bonus;
            }

        }
    }
}