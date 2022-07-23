using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.src.Entities
{
    public class Paladin : Hero
    {
        public Paladin(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

        public override string Attack()
        {
            return this.Name + " Lançou uma flecha";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 100)
            {
                return this.Name + " Lançou uma flecha crítica com bonus de ataque de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou uma flecha com bonus de ataque de " + Bonus;
            }

        }
    }
}