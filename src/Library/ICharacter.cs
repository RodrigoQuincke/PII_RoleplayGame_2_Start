using System;

public interface ICharacter
{
    string Name { get; }
    int Health { get; }
    int GetTotalAttack();
    void ReceiveAttack(ICharacter attacker);
    void Cure();
}