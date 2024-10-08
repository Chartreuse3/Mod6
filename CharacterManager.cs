class CharacterManager
{
    private string csvFilePath = "mario.csv";

    public void DisplayCharacters()
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

    public void AddCharacter(Character character)
    {
        System.IO.File.AppendAllText(csvFilePath, character.GetInfo() + System.Environment.NewLine);
        Console.WriteLine("Character added!");
    }
}
