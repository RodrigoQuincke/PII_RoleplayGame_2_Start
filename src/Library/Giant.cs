using System;
using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    public class Giant
    {
        public string Name { get; }
        public int AttackValue { get; }
        private int DefenseValue { get; }
        private int InitialHealth { get; }
        public int Health { get; private set; }
        public List<Item> Equipment { get; private set; }

        public Giant(string name)
        {
            this.Name = name;
            this.AttackValue = 100;
            this.DefenseValue = 0;
            this.InitialHealth = 500;
            this.Health = this.InitialHealth;
            this.Equipment = new List<Item>();
        }

        public void ReceiveAttack(int attackDamage)
        {
            int actualDamage = attackDamage - this.GetTotalDefense();
            if (actualDamage > 0)
            {
                this.Health -= actualDamage;
            }
        }

        public void Cure()
        {
            this.Health = this.InitialHealth;
        }

        public void Attack(Giant target)
        {
            target.ReceiveAttack(this.GetTotalAttack());
        }

        public void AddItem(Item item)
        {
            this.Equipment.Add(item);
        }

        public void RemoveItem(Item item)
        {
            this.Equipment.Remove(item);
        }
        public int GetTotalAttack()
        {
            int total = this.AttackValue;
            foreach (Item item in this.Equipment)
            {
                total += item.AttackValue;
            }
            return total;
        }

        public int GetTotalDefense()
        {
            int total = this.DefenseValue;
            foreach (Item item in this.Equipment)
            {
                total += item.DefenseValue;
            }
            return total;
        }
    }
}

