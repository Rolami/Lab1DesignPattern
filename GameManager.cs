

namespace Lab_1_implementera;
// Add the public access modifier
public class GameManager
{
    private static GameManager? instance; //Frågetecken för att få bort varning, instancen kommer inte vara null.

    private GameManager() { }

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameManager();
                Console.WriteLine("GameManager instance created");
            }
            return instance;
        }
    }

    public ICharacter CreateCharacter(CharacterFactory factory)
    {
        ICharacter character = factory.CreateCharacter();
        CharacterObserver observer = new CharacterObserver();
        character.RegisterObserver(observer);
        return character;
    }
}

