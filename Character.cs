

class Character
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public string Name {get;}
    public Ability Ability {get;}

    public Character(string name, Ability ability)
    {
        Name = name;
        Ability = ability;
    }
    public void Move(int changeX, int changeY)
    {
        X += changeX;
        Y += changeY;
    }
}