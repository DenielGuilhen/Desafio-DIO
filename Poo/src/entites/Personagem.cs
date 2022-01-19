using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio.src.entites
{
    public abstract class Personagem
    {
        public Personagem(string name, int level, int hp, int mp)
        {
            this.Name = name;
            this.Level = level;
            this.Hp = hp;
            this.Mp = mp;
        }

        public Personagem()
        {
        }

        public string Name;
        public int Level;
        public string HeroType;

        public int Hp;

        public int Mp;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou: ";
        }

    }
}