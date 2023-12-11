namespace Lab_1_implementera;

class Program
{
    static void Main()
    {

        //Singleton
        GameManager gameManager = GameManager.Instance;

        CharacterFactory warriorFactory = new WarriorFactory();
        ICharacter warrior = gameManager.CreateCharacter(warriorFactory);
        warrior.Attack();

        CharacterFactory mageFactory = new MageFactory();
        ICharacter mage = gameManager.CreateCharacter(mageFactory);
        mage.Attack();

        CharacterFactory archerFactory = new ArcherFactory();
        ICharacter archer = gameManager.CreateCharacter(archerFactory);
        archer.Attack(); //Ligger med bara för att demonstrera att den finns och fungerar.
    }
}
