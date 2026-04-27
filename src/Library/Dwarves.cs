using System;
using System.Collections.Generic;

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
            this.Equipment.Add(new Item("Axe", 30, 0));
            this.Equipment.Add(new Item("Helmet", 0, 15));
            this.Equipment.Add(new Item("Shield", 0, 20));
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
                total += item.AttackValue;
            }
            return total;
        }

        public int GetTotalDefense()
        {
            int total = this.DefenseValue;
            foreach (IItem item in this.Equipment)
            {
                total += item.DefenseValue;
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