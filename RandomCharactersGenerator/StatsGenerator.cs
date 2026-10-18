using System;
using System.Collections.Generic;
using System.Text;

namespace RandomCharactersGenerator
{
    internal class StatsGenerator
    {
        Random random = new Random();

        //Generator of strength. Both methods below have the same process, but produce values for different properties.
        public int GenerateStrength( )
        {
            int dice = random.Next(1, 7); //Fulfills the same purpose as a 6-sided dice.

            int strength = dice + dice + dice;

            return strength;
        }
        //Generator of dexterity.
        public int GenerateDexterity( )
        {
            int dice = random.Next(1, 7);

            int dexterity = dice + dice + dice; //Essentially the same as three dice rolls.

            return dexterity;
        }
    }
}
