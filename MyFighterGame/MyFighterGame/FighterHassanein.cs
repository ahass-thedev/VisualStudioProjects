using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace MyFighterGame
{
    class FighterHassanein : Fighter
    {
        Random r;
        Image I;
        int HP, Attack, Defense, SpecialAttack, SpecialDefense, Max_HP, chargemultiplier = 1;
        String Name, type, Ability1, Ability2, Ability3, Ability4, VictoryMusic;

        public FighterHassanein(Random rand)
        {
            VictoryMusic = "H:\\MyFighterGame";
            r = rand;
            HP = 150;
            Max_HP = HP;
            Attack = 5;
            Defense = 7;
            SpecialAttack = 7;
            SpecialDefense = 1;
            Name = "Tea Spoon";
            type = "Grass";
            Ability1 = "Fight";
            Ability2 = "Charge";
            Ability3 = "Heal";
            Ability4 = "Vine Growth";
            VictoryMusic = "";
            I = Properties.Resources.mifighter;
        }
        public override void Heal()
        {
            int heal = r.Next(1, 11);
            HP = heal + HP;
            if (HP > Max_HP)
            {
                HP = Max_HP;
            }
        }
        public override string getName()
        {
            return Name;
        }
        public override int Fight(int Def)
        {
            int damage = Attack + r.Next(1, chargemultiplier + (Attack + 1));

            if (r.Next(1, 11) > 0) 
            {
                damage = 2 * damage;
            }
            damage = damage - (int)(.5 * Defense);
            if (damage <= 0)
                damage = 1;
            chargemultiplier = 1;
            return damage;
        }
        public override void Charge()
        {
            chargemultiplier = 2;
        }
        public override string getType()
        {
            return type;
        }
        public override string getAbility1()
        {
            return Ability1;
        }
        public override string getAbility2()
        {
            return Ability2;
        }
        public override string getAbility3()
        {
            return Ability3;
        }
        public override string getAbility4()
        {
            return Ability4;
        }
        public override int getHP()
        {
            return HP;
        }
        public override int getAttack()
        {
            return Attack;
        }
        public override int getDefense()
        {
            return Defense;
        }
        public override int getSpecialAttack()
        {
            return SpecialAttack;
        }
        public override int getSpecialDefense()
        {
            return SpecialDefense;
        }
        public override string getVictoryMusic()
        {
            return VictoryMusic;
        }
        public override int BigWave(int EnemySpecialDefense)
        {
            int attack;
            if (type == "Water")
            {
                attack = (int)(1.5 * (SpecialAttack + r.Next(1, chargemultiplier * SpecialAttack + 1))) - (int)(.5 * EnemySpecialDefense);
            }
            else
            {
                attack = SpecialAttack + r.Next(1, chargemultiplier * SpecialAttack + 1) - (int)(.5 * EnemySpecialDefense);
            }
            if (attack < 0)
            {
                attack = 1;
            }
            chargemultiplier = 1;
            return attack;
        }
        public override int FireBlast(int EnemySpecialDefense)
        {
            int attack;
            if (type == "Fire")
            {
                attack = (int)(1.5 * (SpecialAttack + r.Next(1, chargemultiplier * SpecialAttack + 1))) - (int)(.5 * EnemySpecialDefense);
            }
            else
            {
                attack = SpecialAttack + r.Next(1, chargemultiplier * SpecialAttack + 1) - (int)(.5 * EnemySpecialDefense);
            }
            if (attack < 0)
            {
                attack = 1;
            }
            chargemultiplier = 1;
            return attack;
        }
        public override int VineGrowth(int EnemySpecialDefense)
        {
            int attack;
            if (type == "Grass")
            {
                attack = (int)(1.5 * (SpecialAttack + r.Next(1, chargemultiplier * SpecialAttack + 1))) - (int)(.5 * EnemySpecialDefense);
            }
            else
            {
                attack = SpecialAttack + r.Next(1, chargemultiplier * SpecialAttack + 1) - (int)(.5 * EnemySpecialDefense);
            }
            if (attack < 0)
            {
                attack = 1;
            }
            chargemultiplier = 1;
            return attack;
        }
        public override Image getImage()
        {
            return I;
        }
        public override void SetHP(int Health)
        {
        }
        public string getStats()
        {
            string stats = "Hp: " + HP + "/" + Max_HP + "\nAttack: " + Attack + "\nDefense " + Defense + "\nSpecial Attack: "  + SpecialAttack + "\nSpecial Defense: " + SpecialDefense;
            return stats;
        }
        public override void isHit(int EnemyDamage)
        {
            HP = HP - EnemyDamage;
        }
        public override void isHit(int EnemyDamage, string EnemyType)
        {
            if (type == "Fire" && EnemyType == "Grass")
            {
                HP -= (int)(.5 * EnemyDamage);
            }
            if (type == "Fire" && EnemyType == "Water")
            {
                HP -= (int)(1.5 * EnemyDamage);
            }
            if (type == "Grass" && EnemyType == "Fire")
            {
                HP -= (int)(1.5 * EnemyDamage);
            }
            if (type == "Grass" && EnemyType == "Water")
            {
                HP -= (int)(.5 * EnemyDamage);
            }
            if (type == "Water" && EnemyType == "Grass")
            {
                HP -= (int)(1.5 * EnemyDamage);
            }
            if (type == "Water" && EnemyType == "Fire")
            {
                HP -= (int)(.5 * EnemyDamage);
            }
            if ((((((((type == EnemyType))))))))
            {
                HP -= EnemyDamage;
            }
        }
    }
}
