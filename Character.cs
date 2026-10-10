
class Ability
{
    public string Name {get;}

    public bool CanSolve(Challenge challenge)
    {
        // Implementation goes here
    }
}

class ClayAbility : Ability
{
    
}

class CameraAbility : Ability
{
}

class GameAbility : Ability
{
}

class StorytellingAbility : Ability
{
}

class Character
{
    public string Name {get;}
    public Ability Ability {get;}
}