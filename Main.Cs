// This is the newer, more concise main class now.

class Program
{
    static void Main()
    {
        CharacterManager manager = new CharacterManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Display all characters");
            Console.WriteLine("2. Add a new character");
            Console.WriteLine("3. Exit");
            
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                manager.DisplayCharacters();
            }
            else if (choice == "2")
            {
                Console.WriteLine("Enter character details:");
                
                Console.Write("ID: ");
                string id = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Description: ");
                string description = Console.ReadLine();

                Console.Write("Species: ");
                string species = Console.ReadLine();

                Console.Write("First Appearance: ");
                string firstAppearance = Console.ReadLine();

                Console.Write("Year Created: ");
                string yearCreated = Console.ReadLine();

                Character newCharacter = new Character(id, name, description, species, firstAppearance, yearCreated);
                manager.AddCharacter(newCharacter);
            }
            else if (choice == "3")
            {
                running = false;
                Console.WriteLine("Application ended.");
            }
            else
            {
                Console.WriteLine("Invalid choice, try again.");
            }
        }
    }
}