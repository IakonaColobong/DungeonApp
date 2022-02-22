using CharacterClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
        public static void DoAttack(Character attacker, Character defender)
        {
            //get a random number from 1-100 as our dice roll. 
            int diceRoll = new Random().Next(1, 101);
            System.Threading.Thread.Sleep(30);//30 miliseconds pause
            if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                //if the attacker hits, calculate damage
                int damageDealt = attacker.CalcDamage();

                //assign damage to the defender
                defender.Life -= damageDealt;

                //write the result to the screen
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damageDealt} damage!");
                Console.ResetColor();
            }

            else
            {
                Console.WriteLine($"{attacker.Name} Missed!");
            }


        }//end DoAttack

        public static void DoBattle(Player player, Monster monster)
        {
            //player attacks first
            DoAttack(player, monster);


            //Monster attacks second if still alive
            if (monster.Life > 0)
            {
                DoAttack(monster, player);

            }
        }
    }
}
