namespace Penguin_Encounter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu mainMenu = new Menu(new List<string>());
            Orca mainNPC = new Orca(1000, 12, 12000, 0, new List<string>());
            EmperorPenguin character = new EmperorPenguin(80, 180, 180, "handful of diamonds", new List<string>());
            MacaroniPenguin character2 = new MacaroniPenguin(43, 89, 15, "two smooth black stones", new List<string>());
            GalapagosPenguin character3 = new GalapagosPenguin(64, 120, 95, "a piece of an Alien headstone", new List<string>());
            List<string> penguinSpecies = new List<string>() { "Emperor", "Macaroni", "Galapagos" };
            Console.WriteLine("Welcome to the Sea World Geauga Lake Penguin Adventure!");
            Console.WriteLine("Through a strange magical event you have been tranformed into a Penguin!");
            Console.WriteLine("You do get to pick what species you are though!");
            Console.WriteLine("Please pick from: ");
            for (int i = 0; i < penguinSpecies.Count; i++)
            {

                Console.WriteLine(i +1+" " + penguinSpecies[i]);

            }
           
            string userInput = Console.ReadLine();
            int characterSelection = int.Parse(userInput);

            Console.WriteLine("You have selected: " + penguinSpecies[characterSelection- 1]);
            
            Console.WriteLine("The world arounds you shimmers, and the world starts to appear around you in the form of a dirty street");
            Console.WriteLine("The air is full of smoke and fog, there is coal dust on everything you touch and modern technology has disappeared.");
            Console.WriteLine("There is a mix of anthropormophized marine life in dirty coal covered clothes and humans in clean and neat clothing");
            Console.WriteLine("The Streets are lit with gas lamps and lots of Horse traffic through the streets, some of which is in covered carrages with gas head lamps");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("An Orca walks up to you ");
            Console.WriteLine("\"Hello fellow traveler, You appear to be new here.\"");
            //character.SpeakToOrca();
            Console.WriteLine();
            mainNPC.SpeakToCharacter(character);
            Console.WriteLine();
            character.CheckStats();
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}