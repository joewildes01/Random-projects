using System;
namespace RPGsimple
{
    public class Hero 
    {
        public string Name;
        public int Level = 0;
        public int Attack;
        public int Defence;
        public int Magic;
        public int HP;
        public string Gender;
        

        public Hero(string Nme, int Atk, int Def, int Mag, string Gen, int hp)
        {
            Name = Nme;
            Attack = Atk;
            Defence = Def;
            Magic = Mag;
            Gender = Gen;
            HP = hp;
        }

        

       
    }
}
