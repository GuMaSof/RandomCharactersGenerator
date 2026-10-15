using System;
using System.Collections.Generic;
using System.Text;

namespace RandomCharactersGenerator
{
    //This will be an upper class from which other classes, like 'profession' will inherit.
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
    }
}
