using CharacterClasses;
using DungeonLibrary; // added for all dungeon library features. 
using DungeonMonsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Dungeon
{
    public class DungeonGame
    {

        static void Main(string[] args)
        {

            //Current test phase has incorporated 
            // - A single monster
            // - No loot
            // - a copy of the free attack from class


            //future updates that were removed for IMMEDIATE functionality but will be re-instated as quirks are fixed
            // - loot
            // - exp / leveling system
            // - inventory system
            // - magic casting system
            // - healing system
            // - placement of stats window within console. 

       


         
            //Console.Beep (1200, 400);
            //Console.Beep (1100, 400);
            //Console.Beep (1000, 300);
            //Console.Beep (900, 300);
            //Console.Beep (700, 300);//lowest, up from here
            //Console.Beep (900, 300);
            //Console.Beep (1000, 300);
            //Console.Beep (1100, 400);
            //Console.Beep (1200, 900);

            //TODO When player dies, play sound meh, meh, meeeeeh.
            //DRAW GUI

            //STATS
            /*

            Console.SetCursorPosition(0, 0);
       Console.WriteLine(" ______________________________________________________________________________________________________________________");
       Console.SetCursorPosition(5, 1);
       Console.WriteLine("Name: {0}", playerName);
       Console.SetCursorPosition(45, 1);
       Console.WriteLine("HP: {0}/{1}", CharHpCurrent, CharHpFull);
       Console.SetCursorPosition(85, 1);
       Console.WriteLine("Experience: {0}/{1}", CharXpCurrent, CharXpFull);
       Console.WriteLine("|______________________________________________________________________________________________________________________|");
       Console.SetCursorPosition(0, 1);
       Console.WriteLine("|");
       Console.SetCursorPosition(119, 1);
       Console.WriteLine("|");
       //GAME SCREEN

       for (int a = 3; a <= 27; a++)
       {
           Console.SetCursorPosition(0, a);
           Console.Write("|");
           Console.SetCursorPosition(119, a);
           Console.Write("|");
       }
       Console.WriteLine("|______________________________________________________________________________________________________________________|");*/

            Console.WriteLine("***** Dungeon Crawl *****");
            Console.WriteLine("Welcome adventurer to a harrowing adventure!");
            Console.WriteLine("Steel yourself as you prepare to explore these");
            Console.WriteLine("monster filled ruins! These hallways shall test \n" +
                "Your courage while certainly causing you to \n" +
                "soil your nicely pressed breeches. Apparently \n" +
                "made of the finest silks... Why are you wearing \n" +
                "silk clothes to a dungeon anyway? I mean shiny \n" +
                "armour sure, tooled leathers even yes...but silk?\n" +
                "Well, to each their own. Ownward andventurer, \n" +
                "chose your fate!\n\n");

            Console.WriteLine("To begin, tell me brave adventurer, what is your name? \n");
            string playerName = Console.ReadLine();
            //insert delay
            Console.WriteLine($"\n{playerName} Is a proud name, wear it well!!...However, I shall call you Steve!\n");



            //collect player name - add writeline which says "{playerName} is a proud name! I'll call you Steve though."
            //Throughout the game the "narrator will fluctuate between names, correcting himself as he does so.
            bool rComplete = false;
            do
            {
                Console.WriteLine(@"Steve, what is your race?
               
H) Human
E) Elf
D) Dwarf
");
                string playerRace = Console.ReadLine().ToUpper();
                Console.Clear();


                switch (playerRace)
                {

                    case "H":
                    case "HUMAN":
                        Console.WriteLine("The average Human! Not great at anything.... But, not terrible at anything either. Medicore!");
                        break;

                    case "E":
                    case "ELF":
                    case "ELVEN":
                        Console.WriteLine("Ahh the proud, lithe, squishy elf. Great choice for moving quickly through forests\n" +
                            "harassing enemies with the grace and agility.... not so much in caves, mines, etc... Good luck!");
                        break;

                    case "D":
                    case "Dwarf":
                    case "Dwarven":
                        Console.WriteLine("The stout dwarf! At home in the depths of the earth. Short in stature you fit in small\n" +
                            "spaces.... can't move very fast...no range... but you sure can fit places!");
                        break;


                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }//end switch
                Console.WriteLine("\nAre you satisfied with your choice of race? Y/N\n");
                string rAnswer = Console.ReadLine().ToUpper();
                if (rAnswer == "Y")
                {
                    Console.Clear();
                    rComplete = true;
                }

            } while (!rComplete);//restarts do while loop
            bool cComplete = false;
            do
            {


                Console.WriteLine("\n\nVery well then, on to the next step young adventurer, choose your class.\n");
                Console.WriteLine(@"
W) Warrior
T) Thief
S) SpellCaster
P) Priest
");
                string playerCharacterClass = Console.ReadLine().ToUpper();
                switch (playerCharacterClass)
                {

                    case "W":
                    case "WARRIOR":
                        Console.WriteLine("\nOh, the trusty warrior! The backbone for any adventure! Also requires no\n" +
                            " imagination, skill, or ability.");
                        break;

                    case "T":
                    case "THIEF":
                        Console.WriteLine("\nThe Thief! Honor amonst thieves, the noble protagonist with a shady past \n" +
                            "and any other notable quotes which make this lowlife scoundrel seem like anything" +
                            " but a crook.");
                        break;






                    case "S":
                    case "SPELLCASTER":
                        Console.WriteLine(" \nWizard! Yes, now there is power! Rending the skies, tearing lighting from the very heavens! \n" +
                            " Commanding the earth to spew forth fire and lava, moving space and time with but a few gestures! So frail \n" +
                            " even stubbing your toe puts you in bed for a week. Ahhh, but the power! Also, conjuring a cup of tea when \n" +
                            " needed is nifty.");
                        break;

                    case "P":
                    case "Priest":
                        Console.WriteLine("\nWhere would an adventure be without their vocie to the heavens? The priest, wielder of holy magic \n" +
                            "granted unto them by the gods! With daily devotions they are able to heal, protect, and even raise the dead! \n" +
                            "A worthy profession indeed!.... What, did you expect a snarky quipp or something? No way, I can't afford to risk \n" +
                            "offending any gods or anything, I need all the help I can get getting into Heaven! Ahem.... Onward brave Priest! \n" +
                            "Your desitny calls!");
                        break;

                    default:
                        Console.WriteLine("\nFeeble minded one! That is not a choice!!");
                        break;

                }//end switch
                Console.WriteLine("\nAre you satisfied with your choice of profession? Y/N\n");
                string cAnswer = Console.ReadLine().ToUpper();
                if (cAnswer == "Y")
                {
                    cComplete = true;
                    Console.WriteLine("Let us begin your adventure then shall we....");
                }
            } while (!cComplete);


            //Player player = new Player(); added customized development for later

            Player player = new Player("Steve", 70, 5, 25, 25, Race.Elf);//default for testing

            int score = 0;
            bool exit = false;

            do
            {
              



                Console.WriteLine(GetRoom()); 


                //Create a monster in the room for the Player to battle.
              

                Orc r1 = new Orc(); // uses default CTOR for ORC

                //Orc r2 = new Orc("A white Rabbit", 25, 25, 50, 20, 2, 8,
                //    "That's no ordinary Rabbit! Look at the bones!", true);
                //WereRabbit wr1 = new WereRabbit();

                //Since all of our child monsters are all of the type Monster, we 
                //can store them in an array of type monster. 

                Monster[] monsters = { r1, r1, r1, null };
                //once loot is implemented, use this format


                int randomINdex = new Random().Next(monsters.Length);
                Monster monster = monsters[randomINdex]; //right now, just one monster for testing

           


                Console.WriteLine("\nIn this room, " + monster.Name);

                bool reload = false;
                do
                {
                    
                    Console.WriteLine(@"
PLease choose an action:
A) Attack
R) Run Away
P) Player Info
M) Monster Info
X) Exit
");
                    

                    string userChoice = Console.ReadKey(true).Key.ToString();


                    Console.Clear();
                    
                    switch (userChoice)
                    {
                        case "A":
                            
                            Combat.DoBattle(player, monster);//calls combat

                  

                            if (monster.Life <= 0)
                            {
                                // future expansion --- LOOT random loot reward here
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nYou Killed the {0}\n", monster.Name);
                                Console.ResetColor();
                                reload = true; //new room and monster
                                score++;
                            }
                          
                            break;

                        case "R":
                          
                            Console.WriteLine("Run Away!!");
                            Console.WriteLine($"{monster.Name} attacks as you flee!");
                            Combat.DoAttack(monster, player);
                            Console.WriteLine();
                            reload = true; //reload a new room
                            break;

                        case "P":
                            Console.WriteLine("CHARACTER SHEET");
                          
                            Console.WriteLine(player);
                            Console.WriteLine("Monster Slain: " + score);
                            break;

                        case "M":
                            Console.WriteLine("Monster info");
                            
                            Console.WriteLine(monster);//
                            
                            break;

                        case "X":
                        case "E":
                        case "Escape":
                            Console.WriteLine("No one likes a quitter...");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Thou hast chosen an invalid option");

                            break;
                    }//end switch

                    //16. Hp check
                    if (player.Life <= 0)

                    {
                        Console.WriteLine("\n YOU DIED!\n");
                    }

                } while (!reload && !exit);


            } while (!exit);//continue loop while exit is not selected

            Console.WriteLine($"" +
             //   $"You defeated {monsters} {score:n0} monster{(score == 1 ? "." : "s.")}");//****WHY ISNT THIS SELECTING THE MONSTER??
            $"You defeated {score:n0} monster{(score == 1 ? "." : "s.")}");

        }//end main()


        private static string GetRoom()
        {
            String[] rooms =
                {
                "The room is dark and musty.",
                "The room is dimly lit by only several candles.",
                "A stone encased room lit by torches looms before you. The torches frame an empty alcove is on the wall in front of you. " +
                "Drag marks on the floor indicate something had slid from the are recently. ",
                "The stone walls of the room are covered in moisture. Soft sounds of running water can be heard as small rivulets of water run down the walls."

            };
    
            Random rand = new Random();
            int indexNbr = rand.Next(rooms.Length);
            string room = rooms[indexNbr];
            return room;
          
        }//end GetRoom()main
    }//end class
}//end namespace
