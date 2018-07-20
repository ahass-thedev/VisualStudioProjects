using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFighterGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserAttack = "";
            Random r = new Random(); 

            FighterHassanein fighter1 = new FighterHassanein(r);
            FighterHassanein fighter2 = new FighterHassanein(r);

            Console.WriteLine("Welcome to my fighting game");
            while (fighter1.getHP() > 0 && fighter2.getHP() > 0)
            {
            Console.WriteLine("Fighter 1 Goes First");
            Console.WriteLine("Enter Your Attack");
            Console.WriteLine("1: " + fighter1.getAbility1());
            Console.WriteLine("2: " + fighter1.getAbility2());
            Console.WriteLine("3: " + fighter1.getAbility3());
            Console.WriteLine("4: " + fighter1.getAbility4());
            Console.WriteLine("Choose Ability");

            UserAttack = Console.ReadLine();

            if (UserAttack == "Fight" && (fighter1.getAbility1() == "Fight" || fighter1.getAbility2() == "Fight" || fighter1.getAbility3() == "Fight"|| fighter1.getAbility4() == "Fight"))
            {
                int enemydef = fighter2.getDefense();
                int damage = fighter1.Fight(enemydef);
                fighter2.isHit(damage);
                Console.WriteLine(fighter1.getName() + " hit for " + damage + " points");
                Console.WriteLine(fighter2.getStats());
            }
            else if (UserAttack == "Charge")
            {
                fighter1.Charge();
                Console.WriteLine(fighter1.getName() + " Has been hit " + fighter1.getName());
            }
            else if (UserAttack == "Heal")
            {
                int health = fighter1.getHP();
                fighter1.Heal();
                int regen = fighter1.getHP() - health;
                Console.WriteLine(fighter1.getName() + " healed for " + regen + " point(s) " + fighter1.getHP());
            }
            else if (UserAttack == "Vine Growth" && (fighter1.getAbility1() == "Vine Growth" || fighter1.getAbility2() == "Vine Growth" || fighter1.getAbility3() == "Vine Growth" || fighter1.getAbility4() == "Vine Growth"))
            {
                int enemyspecialdef = fighter2.getSpecialDefense();
                int damage = fighter1.VineGrowth(enemyspecialdef);
                int health = fighter2.getHP();
                fighter2.isHit(damage, "Grass");
                damage = damage - fighter2.getHP();
                Console.WriteLine(fighter1.getName() + " has been hit for " + damage + " points");
                Console.WriteLine(fighter2.getStats());
            }
            else if (UserAttack == "Fire Blast" && (fighter1.getAbility1() == "Fire Blast" || fighter1.getAbility2() == "Fire Blast" || fighter1.getAbility3() == "Fire Blast" || fighter1.getAbility4() == "Fire Blast"))
            {
                int enemyspecialdef = fighter2.getSpecialDefense();
                int damage = fighter1.FireBlast(enemyspecialdef);
                int health = fighter2.getHP();
                fighter2.isHit(damage, "Fire");
                damage = damage - fighter2.getHP();
                Console.WriteLine(fighter1.getName() + " has been hit for " + damage + "points");
                Console.WriteLine(fighter2.getStats());
            }
            else if (UserAttack == "BigWave" && (fighter1.getAbility1() == "BigWave" || fighter1.getAbility2() == "BigWave" || fighter1.getAbility3() == "BigWave" || fighter1.getAbility4() == "BigWave"))
            {
                int enemyspecialdef = fighter2.getSpecialDefense();
                int damage = fighter1.BigWave(enemyspecialdef);
                int health = fighter2.getHP();
                fighter2.isHit(damage, "Water");
                damage = damage - fighter2.getHP();
                Console.WriteLine(fighter1.getName() + " has been hit for " + damage + "points");
                Console.WriteLine(fighter2.getStats());
            }
            if (fighter2.getHP() > 0)
            {
                Console.WriteLine("Enter Your Attack");
                Console.WriteLine("1: " + fighter1.getAbility1());
                Console.WriteLine("2: " + fighter1.getAbility2());
                Console.WriteLine("3: " + fighter1.getAbility3());
                Console.WriteLine("4: " + fighter1.getAbility4());
                Console.WriteLine("Choose Ability");

                UserAttack = Console.ReadLine();

                if (UserAttack == "Fight" && (fighter2.getAbility1() == "Fight" || fighter2.getAbility2() == "Fight" || fighter2.getAbility3() == "Fight" || fighter2.getAbility4() == "Fight"))
                {
                    int enemydef = fighter1.getDefense();
                    int damage = fighter2.Fight(enemydef);
                    fighter1.isHit(damage);
                    Console.WriteLine(fighter2.getName() + " hit for " + damage + " points");
                    Console.WriteLine(fighter1.getStats());
                }
                else if (UserAttack == "Charge")
                {
                    fighter2.Charge();
                    Console.WriteLine(fighter2.getName() + " Has hit " + fighter2.getName());
                }
                else if (UserAttack == "Heal")
                {
                    int health = fighter2.getHP();
                    fighter2.Heal();
                    int regen = fighter2.getHP() - health;
                    Console.WriteLine(fighter2.getName() + " healed for " + regen + " point(s) " + fighter2.getHP());
                }
                else if (UserAttack == "Vine Growth" && (fighter2.getAbility1() == "Vine Growth" || fighter2.getAbility2() == "Vine Growth" || fighter2.getAbility3() == "Vine Growth" || fighter2.getAbility4() == "Vine Growth"))
                {
                    int enemyspecialdef = fighter1.getSpecialDefense();
                    int damage = fighter2.VineGrowth(enemyspecialdef);
                    int health = fighter1.getHP();
                    fighter1.isHit(damage, "Grass");
                    damage = damage - fighter1.getHP();
                    Console.WriteLine(fighter2.getName() + " has been hit for " + damage + "points");
                    Console.WriteLine(fighter1.getStats());
                }
                else if (UserAttack == "Fire Blast" && (fighter2.getAbility1() == "Fire Blast" || fighter2.getAbility2() == "Fire Blast" || fighter2.getAbility3() == "Fire Blast" || fighter2.getAbility4() == "Fire Blast"))
                {
                    int enemyspecialdef = fighter1.getSpecialDefense();
                    int damage = fighter2.FireBlast(enemyspecialdef);
                    int health = fighter1.getHP();
                    fighter1.isHit(damage, "Fire");
                    damage = damage - fighter1.getHP();
                    Console.WriteLine(fighter2.getName() + " has been hit for " + damage + "points");
                    Console.WriteLine(fighter1.getStats());
                }
                else if (UserAttack == "BigWave" && (fighter1.getAbility2() == "BigWave" || fighter2.getAbility2() == "BigWave" || fighter2.getAbility3() == "BigWave" || fighter2.getAbility4() == "BigWave"))
                {
                    int enemyspecialdef = fighter1.getSpecialDefense();
                    int damage = fighter2.BigWave(enemyspecialdef);
                    int health = fighter1.getHP();
                    fighter1.isHit(damage, "Water");
                    damage = damage - fighter1.getHP();
                    Console.WriteLine(fighter2.getName() + "has been hit for" + damage + "points");
                    Console.WriteLine(fighter1.getStats());
                }
                }
            }
            if (fighter1.getHP() < 0)
            {
                Console.WriteLine(fighter2.getName() + " Wins");
            }
            else
            {
                Console.WriteLine(fighter1.getName() + " Wins");
            }
            Console.ReadLine();
        }
    }
}
