using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRoadtoFameGame
{
    internal class Hero
    {
        public string Name;

        public bool Alive;

        public int HP;

        public const int MaxHP = 100;

        public Hero(string name)
        {
            Name = name;
            Alive = true;
            HP = 100;
        }

        public void Death()
        {
            Alive = false;
            HP = 0;
        }

        public void Heal()
        {
            HP = HP + 50;
        }

        public string HeroInfo()
        {
            string info = $"Имя героя: {Name} \nСостояние здоровья: {HP}.";
            return info;
        }
    }
}
