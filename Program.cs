using System;
using System.Reflection.PortableExecutable;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        var characters = new List<Character>
        {
        new("Amanda", new ClayAbility()),
        new("Laura", new CameraAbility()),
        new("Steph", new GamblingAbility()),
        new("Todo", new StorytellingAbility())
        };

        Character activeCharacter = characters[0];

        const int width = 10;
        const int heigth = 5;

        while(true)
        {
            Console.Clear();
            
            for (int y = 0; y < heigth; y++ )
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(activeCharacter.X == x && activeCharacter.Y == y ? '@' : '.');
                }
                Console.WriteLine();
            }
            Console.WriteLine("Move with WASD. Press Q to quit.");

            ConsoleKey Key = Console.ReadKey(true).Key;

            int changeX = 0;
            int changeY = 0;

            switch (Key)
            {
                case ConsoleKey.W: changeY = -1; break;
                case ConsoleKey.S: changeY = 1; break;
                case ConsoleKey.A: changeX = -1; break;
                case ConsoleKey.D: changeX = 1; break;
                case ConsoleKey.Q: return;
            }

            int nextX = activeCharacter.X + changeX;
            int nextY = activeCharacter.Y + changeY;

            if(nextX >= 0 && nextX < width && nextY >= 0 && nextY < heigth)
            {
                activeCharacter.Move(changeX, changeY);
            }
        }
    }

}
