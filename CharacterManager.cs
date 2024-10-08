class CharacterManager
{
        if (System.IO.File.Exists(csvFilePath))
        {
            string[] characters = System.IO.File.ReadAllLines(csvFilePath);
            foreach (string character in characters)
            {
                Console.WriteLine(character);
            }
        }
        else
        {
            Console.WriteLine("No characters found.");
        }
}