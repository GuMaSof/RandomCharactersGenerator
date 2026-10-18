using System;
using System.Collections.Generic;
using System.Text;

namespace RandomCharactersGenerator
{
    /*The Profession class is designed for the purpose of assigning a value to the profession property of the Character class.
     * 
     * This would have been called 'class' if this were an actual RPG,
     * but we must avoid confusion in our naming habits, for the word "class" is already used in a different context in C#.*/
    internal class Profession
    {
        /*We choose a minimal number of professions for the sake of simplicity,
         * at least right now. A project easily grows too big,
         * and impossible to complete by your deadline if you are ambitious in your goals from the start.*/

        //This profession shall be more dexterity focused.
        private string thief = "thief";
        //This profession shall be more strength focused.
        private string warrior = "warrior";
        //Special abilities.
        private string warriorAbility = "Shield bash";
        private string thiefAbility = "Lockpick";
        
        Random random = new Random();

        //This method chooses a profession for the character.
        public string ChooseProfession(int strength, int dexterity)
        {
            string profession;
            //We will choose profession by looking at which property is higher.
            if (strength > dexterity)
            {
                profession = warrior;

                return profession;
            }
            else if (dexterity > strength)
            {
                profession = thief;

                return profession;
            }
            else
            {
                //If dexterity and strength happen to be tied then we shall profession be randomly selected.
                int i = random.Next(1, 2);
                if (i > 1)
                {
                    profession = warrior;
                    return profession;
                }
                else
                {
                    profession = thief;
                    return profession;
                }
            }
        }

        //Chooses special ability for the character.
        public string ChooseSpecialAbility(string profession)
        {
            string specialAbility;
            if ( profession == thief)
            {
                specialAbility = thiefAbility;
                return specialAbility;
            }
            else if (profession == warrior)
            {
                specialAbility = warriorAbility;
                return specialAbility;
            }
            else
            {
                specialAbility = "Error! Property not found.";
                return specialAbility;
            }
        }

        //Chooses number of health points based on profession. We are going with the old-school rules that gives less health points.
        public int ChooseHP(string profession)
        {
            int healthPoints;

            if (profession == thief)
            {
                healthPoints = random.Next(1, 5);
                return healthPoints;
            }
            else if (profession == warrior)
            {
                healthPoints = random.Next(1, 7);
                return healthPoints;
            }
            else
            {
                Console.WriteLine("Error! Property not found.");
                return healthPoints;
            }
        }
    }
}
