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
            string newName;
            string newProfession;
            string newSpecialAbility;

            //Containers of integers for adding values to characters.
            int newStrength;
            int newDexterity;
            int newHP;

            //Here we begin to establish our menu structure.
            while (menuBool == true)
            {
                Console.WriteLine("___________________________________");
                Console.WriteLine("Välkommen till karaktärsgeneratorn!");
                Console.WriteLine("Tryck [1] För att generera en ny karaktär.");

                Console.WriteLine("Tryck [2] För att se alla karaktärer.");
                Console.WriteLine("Tryck [3] För att stänga av menyn.");
                Console.WriteLine("___________________________________");

                //Here we insert the user input.
                unConvertedInput = Console.ReadLine();

                if (int.TryParse(unConvertedInput, out convertedInput) )
                {
                    switch (convertedInput)
                    {
                        case 1:
                            newName = naming.GenerateName(); //Making name.

                            //Stats.
                            newStrength = stats.GenerateStrength();
                            newDexterity = stats.GenerateDexterity();

                            //Choosing profession based on stats.
                            newProfession = profession.ChooseProfession(newStrength, newDexterity);

                            //Choosing special ability and health points based on profession.
                            newSpecialAbility = profession.ChooseSpecialAbility(newProfession);
                            newHP = profession.ChooseHP(newProfession);

                            Character character = new Character(newName, newProfession, newSpecialAbility, newStrength, newDexterity, newHP);
                            characterList.Add(character);

                            Console.WriteLine("Karaktärens namn är " + newName + ".");
                            Console.WriteLine(newName + "s yrke är " + newProfession + ".");
                            Console.WriteLine(newName + "s specialförmåga är " + newSpecialAbility + ".");

                            Console.WriteLine(newName + "s styrka är " + newStrength + ".");
                            Console.WriteLine(newName + "s snabbhet är " +  newDexterity + ".");
                            Console.WriteLine(newName + "s hälsopoäng är " + newHP + ".");
                            break;

                        case 2:
                            //Security measure to prevent the loop from running if there are no elements in the list.
                            if (characterList.Count > 0)
                            {
                                //Loop that goes through the entire list of characters.
                                foreach (var Character in characterList)
                                {
                                    Console.WriteLine("Karaktärens namn är " + Character.GetName() + ".");
                                    Console.WriteLine(Character.GetName() + "s yrke är " + Character.GetProfession() + ".");
                                    Console.WriteLine(Character.GetName() + "s specialförmåga är " + Character.GetSpecialAbility() + ".");

                                    Console.WriteLine(Character.GetName() + "s styrka är " + Character.GetStrength() + ".");
                                    Console.WriteLine(Character.GetName() + "s snabbhet är " + Character.GetDexterity() + ".");
                                    Console.WriteLine(Character.GetName() + "s hälsopoäng är " + Character.GetHealthPoints() + ".");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Erorr! Listan är tom!");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Hejdå!");
                            menuBool = false;
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