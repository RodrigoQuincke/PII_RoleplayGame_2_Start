using System;
using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    public class Knight
    {
        public string Name { get; }
        public int AttackValue { get; }
        private int DefenseValue { get; }
        private int InitialHealth { get; }
        public int Health { get; private set; }
        public List<IItem> Equipment { get; private set; }


        public Knight(string name)
        {
            this.Name = name;
            this.AttackValue = 150;
            this.DefenseValue = 100;
            this.InitialHealth = 300;
            this.Health = this.InitialHealth;
            this.Equipment = new List<IItem>();
            this.Equipment.Add(new Sword("Sword", 50));
            this.Equipment.Add(new Shield("Shield", 20));
            this.Equipment.Add(new Armor("Armor", 50));
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

        public void Attack(Knight target)
        {
            target.ReceiveAttack(this.GetTotalAttack());
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
            foreach (IOffensiveItem item in this.Equipment)
            {
                total += item.AttackValue;
            }
            return total;
        }

        public int GetTotalDefense()
        {
            int total = this.DefenseValue;
            foreach (IDefensiveItem item in this.Equipment)
            {
                total += item.DefenseValue;
            }
            return total;
        }
    }
}