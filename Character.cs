class Character
{
    public Character(string id, string name, string description, string species, string firstAppearance, string yearCreated)
    {
        Id = id;
        Name = name;
        Description = description;
        Species = species;
        FirstAppearance = firstAppearance;
        YearCreated = yearCreated;
    }

    public override string ToString()
    {
        return $"{Id},{Name},{Description},{Species},{FirstAppearance},{YearCreated}";
    }
}
