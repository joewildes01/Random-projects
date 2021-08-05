using System;
namespace RPGsimple
{
    public class Enemy
    {
        public string Name;
        public int Attack;
        public int Defence;
        public int Magic;
        public int Level;
        public int HP;

        public Enemy(string name, int attack, int defence, int magic, int level, int hp)
        {
            Name = name;
            Attack = attack;
            Defence = defence;
            Magic = magic;
            Level = level;
            HP = hp;

        }


    }
}
