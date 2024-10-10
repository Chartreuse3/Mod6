using NLog;

class CharacterManager
{
    private string csvFilePath = "mario.csv";
    private static readonly Logger logger = LogManager.GetCurrentClassLogger();

    public void DisplayCharacters()
    {
        try
        {
            if (System.IO.File.Exists(csvFilePath))
            {
                string[] characters = System.IO.File.ReadAllLines(csvFilePath);
                foreach (string character in characters)
                {
                    Console.WriteLine(character);
                }
                logger.Info("Displayed all characters.");
            }
            else
            {
                Console.WriteLine("No characters found.");
                logger.Warn("Character file not found.");
            }
        }
        catch (Exception ex)
        {
            logger.Error(ex, "Error displaying characters.");
        }
    }

    public void AddCharacter(Character character)
    {
        try
        {
            System.IO.File.AppendAllText(csvFilePath, character.ToString() + System.Environment.NewLine);
            Console.WriteLine("Character added!");
            logger.Info($"Character {character.Name} added successfully.");
        }
        catch (Exception ex)
        {
            logger.Error(ex, "Error adding character.");
        }
    }
}
