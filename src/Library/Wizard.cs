using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Ucu.Poo.RolePlayGame
{
    public class Wizard : ICharacter
    {
        public string Name { get; }
        public int AttackValue { get; }
        private int DefenseValue { get; }
        private int InitialHealth { get; }
        public int Health { get; private set; }
        public List<IItem> Equipment { get; private set; }
        public SpellsBook SpellsBook { get; private set; }

        public Wizard(string name)
        {
            this.Name = name;
            this.AttackValue = 50;
            this.DefenseValue = 80;
            this.InitialHealth = 150;
            this.Health = this.InitialHealth;
            this.Equipment = new List<IItem>();
            this.Equipment.Add(new Staff("Staff", 30));
            this.SpellsBook = new SpellsBook("Wizards Book");
        }

        public void ReceiveAttack(ICharacter attacker)
        {
            int actualDamage = attacker.GetTotalAttack() - this.GetTotalDefense();
            if (actualDamage > 0)
            {
                this.Health -= actualDamage;
            }
        }

        public void Cure()
        {
            this.Health = this.InitialHealth;
        }
        public void AddItem(IItem item)
        {
            this.Equipment.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            this.Equipment.Remove(item);
        }
        public int GetTotalAttack()
        {
            int total = this.AttackValue;
            foreach (IItem item in this.Equipment)
            {
                if (item is IOffensiveItem)
                {
                    IOffensiveItem offensiveItem = (IOffensiveItem)item;
                    total += offensiveItem.AttackValue;
                }
            }
            total += this.SpellsBook.GetTotalAttack();
            return total;
        }

        public int GetTotalDefense()
        {
            int total = this.DefenseValue;
            foreach (IItem item in this.Equipment)
            {
                if (item is IDefensiveItem)
                {
                    IDefensiveItem defensiveItem = (IDefensiveItem)item;
                    total += defensiveItem.DefenseValue;
                }
            }
            total += this.SpellsBook.GetTotalDefense();
            return total;
        }
    }
}