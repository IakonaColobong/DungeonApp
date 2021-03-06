using DungeonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMonsters
{
    public class Orc : Monster
    {
        //Frugal / Fields  --- this is the order you generally find them in class  Files. 
        //we will have a business rule on MinDamage, we need a full prop and full field

        private int _minDamage;
        //People / Properties
        //auto props go first
        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }

            //can't be more than MaxDamage and can't be less than 1
            set
            {
                _minDamage = (value > 0 && value <= MaxDamage) ? value : 1;
            }//end MinDamage
        }
        public Orc() { }

        public Orc(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description)
        {
            //PascalCase - camelCase
            MaxDamage = maxLife;
            Name = name;
            Life = life;
            HitChance = hitChance;
            Block = block;
            MaxDamage = maxDamage;
            Description = description;
            MinDamage = minDamage;

            
        }
     


        //Collect / Constructors (ctors)

        //Money / Methods
        public override string ToString()
        {
            return $"\n******** MONSTER *******\n" +
            $"{Name}\n" +
            $"Life: {Life} / {MaxLife}\n" +
            $"Damage: {MinDamage} - {MaxDamage}\n" +
            $"Block: {Block}\n" +
            $"Description: {Description}.\n";

        }// end ToString()

        //we are overrriding the CalcDamage to use the props MinDamage and MaxDamage
        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
       


        }
        }//END class
    }//END namespace