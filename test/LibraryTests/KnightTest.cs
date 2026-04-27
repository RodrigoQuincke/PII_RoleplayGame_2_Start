using System.Security.Cryptography;
using System.IO;
using System;
using NUnit.Framework;

namespace Ucu.Poo.RolePlayGame.Tests
{
    public class KnightTest
    {

        private Giant ogro;
        private Knight knight;
        private Spell shoot;
        [SetUp]
        public void Setup()
        {
            ogro = new Giant("Ogro Gigante");
            knight = new Knight("Caballero");
        }

        [Test]
        public void TestReceiveAttack_ValidAttackDamage()
        {
            int initialHealth = knight.Health + knight.GetTotalDefense();
            knight.ReceiveAttack(knight.GetTotalAttack());
            Assert.That(knight.Health, Is.EqualTo(initialHealth - knight.GetTotalAttack()));
        }

        [Test]
        public void TestCure()
        {
            int initialHealth = knight.Health;
            knight.ReceiveAttack(ogro.GetTotalAttack());
            knight.Cure();
            Assert.That(knight.Health, Is.EqualTo(initialHealth));
        }

        [Test]
        public void TestAddItem_ValidItem()
        {
            knight.AddItem(new Item("Gloves", 0, 20));
            Assert.That(knight.Equipment, Has.Exactly(4).Items);
        }

        [Test]
        public void TestRemoveItem_ValidItem()
        {
            Item item = new Item("Shield", 0, 50);
            knight.AddItem(item);
            knight.RemoveItem(item);
            Assert.That(knight.Equipment, Has.Exactly(3).Items);
        }

        [Test]
        public void TestGetTotalAttack()
        {
            Assert.That(knight.GetTotalAttack(), Is.EqualTo(200));
        }
        [Test]
        public void TestGetTotalDefense()
        {
            Assert.That(knight.GetTotalDefense(), Is.EqualTo(170));

        }
    }
}