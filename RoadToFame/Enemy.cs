using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRoadtoFameGame
{
    internal class Enemy
    {
        public string EnemyName;

        public bool Alive;

        public int EnemyHP;

        public const int MaxEnemyHP = 100;

        public Enemy(string enemyname)
        {
            EnemyName = enemyname;
            Alive = true;
            EnemyHP = 100;
        }

        public void Death()
        {
            Alive = false;
            EnemyHP = 0;
        }

        public void Heal()
        {
            EnemyHP = EnemyHP + 50;
        }

        public string EnemyInfo()
        {
            string info = $"Имя врага: {EnemyName} \nСостояние здоровья: {EnemyHP}.";
            return info;
        }
    }
}
