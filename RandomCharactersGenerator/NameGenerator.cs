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
        private string[] prefixes = new string[] { "Ke", "Sa", "Nyr", "Yra", "Bel", "Ul", "Mar", "Yni", "Or", "Era"};
        //Here we have the suffix array
        private string[] suffixes = new string[] { "naron", "kar", "ildar", "varon", "xar", "diel", "mir", "gon"};

        //Creation of an object of the Random class for establishing groundwork for randomly generated processes.
        Random random = new Random();
        //Method for creating names by combining prefixes and suffixes.
        public string GenerateName(string name, int i, int j)
        {
            //Usage of the random object for the purpose of randomly selecting elements in the arrays.
            i = random.Next(prefixes.Length);
            j = random.Next(suffixes.Length);

            //Here we actually combine the prefixes and suffixes, as Copilot suggested.
            name = prefixes[i] + suffixes[j];
            
            return name;//Here we finally return the name after the process is done.
        }
    }
}
