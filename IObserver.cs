using System;

namespace Lab_1_implementera;

public interface IObserver
{
    public void Update(ICharacter character);
}

public class CharacterObserver : IObserver
{
    public void Update(ICharacter character)
    {
        Console.WriteLine($"Character state updated: {character.GetType().Name}");
    }
}
