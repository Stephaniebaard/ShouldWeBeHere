using System;

class Program
{
    static void Main(string[] args)
    {
        var characters = new List<Character>();
        characters.Add(new Character("Amanda", new ClayAbility()));
        characters.Add(new Character("Laura", new CameraAbility()));
        characters.Add(new Character("Edd", new GamblingAbility()));
        characters.Add(new Character("Todo", new StorytellingAbility()));

        foreach (Character character in characters)
        {
            Console.WriteLine($"{character.Name} - Ability: {character.Ability.Name}");
        }
    }
}
