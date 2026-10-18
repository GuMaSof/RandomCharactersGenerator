namespace RandomCharactersGenerator
{
    public class Program
    {
        public static void Main (string[] args )
        {
            //List of characters here.
            List<Character> characterList = new List<Character>();

            //Creation of necessary objects for later.
            StatsGenerator stats = new StatsGenerator();
            Profession profession = new Profession();
            NameGenerator naming = new NameGenerator();

            bool menuBool = true; //This one manages our while-loop furhter down.

            //Here we keep input variables.
            string unConvertedInput;
            int convertedInput;

            //Containers of strings for adding values to characters.
            string newName = null;
            string newProfession = null;
            string newSpecialAbility = null;

            //Containers of integers for adding values to characters.
            int newStrength = 0;
            int newDexterity = 0;
            int healthPoints = 0;

            //Here we begin to establish our menu structure.
            while (menuBool == true)
            {
                //It eventually gets messy when you have a menu structure unless you clear the console regularly.
                Console.Clear();

                Console.WriteLine("Välkommen till karaktärsgeneratorn!");
                Console.WriteLine("Tryck [1] För att generera en ny karaktär.");

                Console.WriteLine("Tryck [2] För att välja en karaktär.");
                Console.WriteLine("Tryck [3] För att stänga av menyn.");
                //Here we insert the user input.
                unConvertedInput = Console.ReadLine();
                if (int.TryParse(unConvertedInput, out convertedInput) )
                {
                    switch (convertedInput)
                    {
                        case 1:
                            naming.GenerateName(newName);

                            stats.GenerateStrength(newStrength);
                            stats.GenerateDexterity(newDexterity);

                            profession.ChooseProfession()
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error! Du måste skriva en siffra!");
                }
            }
        }
    }
}