using System;
using System.Collections.Generic;
using System.Text;

namespace RandomCharactersGenerator
{
    /*The purpose of the Character class is to be an container of properties that may be copied.
     *  Essentially this is the "blank slate" on which we write values on later.
     *  A constructor shall make sure that we may copy the basic set of properties for later usage.*/
    internal class Character
    {
        //Here we shall put properties that may be inherited by other character classes.
        private string name;
        //Strength and dexterity shall be represented by integer values, just like in a typical RPG-stat block.
        private int strength;
        private int dexterity;
        /*In the typical RPG you could communicate health points with just the acronym 'HP',
         * but in this case I have chosen to write it in full as if someone that lacks experience of RPGs was reading my code.*/
        private int healthPoints;
        private string specialAbility;

        //Copying Constructor that shall fulfill the purpose of this class as a blank slate that contains the values of many individual characters.
    }
}
