class Character
{
    
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Species { get; set; }
    public string FirstAppearance { get; set; }
    public string YearCreated { get; set; }
    
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
