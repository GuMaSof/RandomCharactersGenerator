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
        /*I've chosen a minimal number of professions for the sake of simplicity,
         * at least right now. A project easily grows too big,
         * and impossible to complete by your deadline if you are ambitious in your goals from the start.*/

        //This property shall be more dexterity focused.
        private string thief = "thief";
        //This property shall be more strength focused.
        private string warrior = "warrior";
        private string inputString;
        private int inputInteger;

        //This method chooses a profession for the character.
        public string ChooseProfession(Character character)
        {
            
        }
    }
}
