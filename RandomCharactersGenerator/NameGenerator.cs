using System;
using System.Collections.Generic;
using System.Text;

namespace RandomCharactersGenerator
{
    //This class shall generate names for characters.
    internal class NameGenerator
    {
        /*By establishing a system where we have separate lists for prefixes,
         * and suffixes that we combine into names rather than just having one of list of finished names we may have high degree of variety.
         
        It will mean a slightly higher level of effort,
        but I believe it's a small price to pay.
        
        I got this idea from a suggestion by CoPilot.
        Granted CoPilot had a more extreme version of the idea where you also would have a list for the middle part.
        I decided to not be ambitious for ambitious projects often don't get done on time, from my experience.*/

        //Here we have prefixes for the various names that we may assign to characters.
        private List<string> prefixes = new List<string>();
        //Here we have the suffix list
        private List<string> suffixes = new List<string>();

        //Creation of an object of the Random class for establishing groundwork for randomly generated processes.
        Random random = new Random();
    }
}
