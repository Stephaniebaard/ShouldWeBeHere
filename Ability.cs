abstract class Ability
{
    public abstract string Name {get;}

  /*  public bool CanSolve(Challenge challenge)
    {
        // Implementation goes here
    }
*/
}

class ClayAbility : Ability
{
    public override string Name => "Clay";
}

class CameraAbility : Ability
{
    public override string Name => "Camera";
}

class GamblingAbility : Ability
{
    public override string Name => "Gambling";
}

class StorytellingAbility : Ability
{
    public override string Name => "Storytelling";
}