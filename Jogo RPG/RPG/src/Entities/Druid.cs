using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.src.Entities
{
    public class Druid : Hero
    {

        public Druid(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

        public override string Attack()
        {
            return this.Name + " Lançou magia";
        }

        public string Heal(int Heal)
        {
            if (Heal > 50)
            {
                return this.Name + " Lançou uma cura suprema de " + Heal;
            }
            else
            {
                return this.Name + " Lançou uma cura de " + Heal;
            }
            
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 100)
            {
                return this.Name + " Lançou magia crítica com bonus de ataque de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou magia com bonus de ataque de " + Bonus;
            }

        }
    }
}
