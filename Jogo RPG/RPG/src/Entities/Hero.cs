using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.src.Entities
{
    public  abstract class Hero
    {

        public Hero(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

        public Hero()
        {

        }
        public int Level { get; set; }
        public string Name { get; set; }
        public string HeroType { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;

        }
        public virtual string Attack()
        {
            return this.Name + " Atacou com a sua espada";
        }

        public virtual string Heal()
        {
            return this.Name + " Usou um pote de cura";
        }
    }
}
