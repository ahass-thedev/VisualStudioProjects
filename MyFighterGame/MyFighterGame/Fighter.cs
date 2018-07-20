using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MyFighterGame
{
    public abstract class Fighter
    {
        //Accessors
        public abstract Image getImage();
        public abstract string getName();
        public abstract string getType();
        public abstract string getAbility1();
        public abstract string getAbility2();
        public abstract string getAbility3();
        public abstract string getAbility4();
        public abstract int getHP();
        public abstract int getAttack();
        public abstract int getDefense();
        public abstract int getSpecialAttack();
        public abstract int getSpecialDefense();
        public abstract string getVictoryMusic();
        public abstract void SetHP(int Health);

        //Abilities
        public abstract int Fight(int Def);
        public abstract void Charge();
        public abstract void Heal();
        public abstract int BigWave(int EnemySpecialDefense);
        public abstract int FireBlast(int EnemySpecialDefense);
        public abstract int VineGrowth(int EnemySpecialDefense);
        public abstract void isHit(int EnemyDamage);
        public abstract void isHit(int EnemyDamage, string EnemyType);

    }
}
