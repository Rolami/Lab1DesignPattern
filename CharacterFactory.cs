using System;
using System.Collections.Generic;


namespace Lab_1_implementera;

// Factory Method
public interface ICharacter
{
    void Attack();
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}
public abstract class Character : ICharacter
{
    private List<IObserver> observers = new List<IObserver>();


    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }
    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(this);
        }
    }
    public abstract void Attack();
}
class Warrior : Character
{
    public override void Attack()
    {
        /* 
        Jag hade kunnat lagt till lite om karaktären dräper en fiende,
        så får observern titta tills det är dags att ge ny level eller något.
        
        Här hade jag kunnat haft en metod som kollar att det är 
        warrior, mage eller archer som attackerar och därmed rullat skada också.
        Men tänker att jag håller ner hur komplicerat det är.      
        */
        Console.WriteLine("Warrior attacks with a sword!");
        NotifyObservers();
    }
}

class Mage : Character
{
    public override void Attack()
    {
        Console.WriteLine("Mage casts a fireball!");
        NotifyObservers();
    }
}

class Archer : Character
{
    public override void Attack()
    {
        Console.WriteLine("Archer shoots an arrow!");
        NotifyObservers();
    }
}

public abstract class CharacterFactory
{
    public abstract ICharacter CreateCharacter();
}

class WarriorFactory : CharacterFactory
{
    public override ICharacter CreateCharacter()
    {
        return new Warrior();
    }
}

class MageFactory : CharacterFactory
{
    public override ICharacter CreateCharacter()
    {
        return new Mage();
    }
}

class ArcherFactory : CharacterFactory
{
    public override ICharacter CreateCharacter()
    {
        return new Archer();
    }
}
