using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Ucu.Poo.RolePlayGame
{
    public class Dwarves : ICharacter
    {
        public string Name { get; }
        public int AttackValue { get; }
        private int DefenseValue { get; }
        private int InitialHealth { get; }
        public int Health { get; private set; }
        public List<IItem> Equipment { get; private set; }
    

        public Dwarves(string name)
        {
            this.Name = name;
            this.AttackValue = 70;
            this.DefenseValue = 50;
            this.InitialHealth = 400;
            this.Health = this.InitialHealth;
            this.Equipment = new List<IItem>();
            this.Equipment.Add(new Axe("Axe", 30));
            this.Equipment.Add(new Helmet("Helmet", 15));
            this.Equipment.Add(new Shield("Shield", 20));
        }

        public void ReceiveAttack(ICharacter attacker)
        {
            int actualDamage = attacker.GetTotalAttack() - this.GetTotalDefense();
            if (actualDamage > 0)
            {
                this.Health -= actualDamage;
            }
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
            return total;
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
    }
}