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

                            Console.WriteLine(newName);
                            Console.WriteLine(newProfession);
                            Console.WriteLine(newSpecialAbility);

                            Console.WriteLine(newStrength);
                            Console.WriteLine(newDexterity);
                            Console.WriteLine(newHP);
                            break;

                        case 2:
                            //Security measure to prevent the loop from running if there are no elements in the list.
                            if (characterList.Count > 0)
                            {
                                //Loop that goes through the entire list of characters.
                                foreach (var Character in characterList)
                                {
                                    Console.WriteLine(Character.GetName() );
                                    Console.WriteLine(Character.GetProfession() );
                                    Console.WriteLine(Character.GetSpecialAbility() );

                                    Console.WriteLine(Character.GetStrength() );
                                    Console.WriteLine(Character.GetDexterity() );
                                    Console.WriteLine(Character.GetHealthPoints() );
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