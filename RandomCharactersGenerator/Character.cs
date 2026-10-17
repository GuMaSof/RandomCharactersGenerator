using System;
using System.Collections.Generic;
using System.Text;

namespace RandomCharactersGenerator
{
    /*The purpose of the Character class is to be an container of properties that may be copied.
     *  Essentially this is the "blank slate" on which we write values on later.
     *  A constructor shall make sure that we may copy the basic set of properties for later usage.
     
     This class would likely have been called a "character sheet" or "stat block" in a D&D-game,
    however I chose a more straightforward name that would be communicative for non-RPG-players.*/
    internal class Character
    {
        //Here we shall put properties that may be inherited by other character classes.

        /*The name-property will have it's own class for generating values, because there are far too much content for just this one class.
         * It would far more clean, and easy to read if I divide the code into various classes by category of process of generation of values.*/
        private string name;
        /*The profession-property shall have it's own class for generation and applying values to this property.
         * It would be far too much content for just one class to carry all of the logic.*/
        private string profession;
        private string specialAbility;
        //Strength and dexterity shall be represented by integer values, just like in a typical RPG-stat block.
        private int strength;
        private int dexterity;
        /*In the typical RPG you could communicate health points with just the acronym 'HP',
         * but in this case I have chosen to write it in full as if someone that lacks experience of RPGs was reading my code.*/
        private int healthPoints;

        //Copying Constructor that shall fulfill the purpose of this class as a blank slate that contains the values of many individual characters.
        public Character (string name, string profession, string specialAbility, int strength, int dexterity, int healthPoints )
        {

        }
    }
}
