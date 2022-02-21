using DungeonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterClasses
{
    public class Player : Character

    {
        public Race CharacterRace { get; set; }



        public Player(string name, int hitChance, int block, int life, int maxLife,
          Race characterRace)
        {
            //ASSIGNMENTS: PascalCase = camelCase;
            MaxLife = maxLife;
            Name = name;
            HitChance = hitChance;
            Life = life;
            CharacterRace = characterRace;
            Block = block;

            switch (CharacterRace)
            {
                case Race.Elf:
                    HitChance += 5;
                    break;
            }

            switch (CharacterRace)
            {
                case Race.Human:
                    MaxLife += 5;
                    break;
            }

            switch (CharacterRace)
            {
                case Race.Dwarf:
                    Block += 5;
                    break;
            }
        
        }
        public override string ToString()
        {
            string description = "";

            switch (CharacterRace)
            {
                case Race.Dwarf:
                    description = "Dwarf";
                    break;

                case Race.Elf:
                    description = "Elf";
                    break;
            }//end Switch


            return $"-=-= {Name} =-=-\n" +
                $"Life: {Life} / {MaxLife}\n" +
                $"Hit Chance: {HitChance}%\n" +
                $"Block: {Block}\n" +
                $"Description: {description}";

        }//end ToString() Override
    }//end class
}//end namespace